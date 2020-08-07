﻿using Definux.Emeraude.Application.Common.Interfaces.Logging;
using Definux.Emeraude.Domain.Logging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Definux.Emeraude.Logger
{
    public class Logger : ILogger
    {
        private const string TraceIdCookieName = "trcid";

        private readonly LoggerContext context;

        public Logger(LoggerContext context)
        {
            this.context = context;
        }

        public async Task<bool> ClearAllErrorLogsAsync()
        {
            try
            {
                this.context.ErrorLogs.RemoveRange(await this.context.ErrorLogs.AsQueryable().ToListAsync());
                await this.context.SaveChangesAsync();

                return true;
            }
            catch (Exception ex)
            {
                await LogErrorAsync(ex);
                return false;
            }
        }

        public void LogActivity(ActionExecutingContext context, bool hideParameters = false)
        {
            try
            {
                string traceId;

                if (!context.HttpContext.Request.Cookies.ContainsKey(TraceIdCookieName))
                {
                    traceId = Guid.NewGuid().ToString();

                    CookieOptions options = new CookieOptions();
                    options.Expires = DateTime.Now.AddYears(10);
                    options.HttpOnly = true;
                    options.IsEssential = true;
                    options.Secure = true;
                    context.HttpContext.Response.Cookies.Append(TraceIdCookieName, traceId, options);
                }
                else
                {
                    traceId = context.HttpContext.Request.Cookies[TraceIdCookieName];
                }

                ActivityLog activityLog = new ActivityLog
                {
                    Area = context.RouteData.Values.ContainsKey("area") ? context.RouteData.Values["area"].ToString() : null,
                    Controller = context.RouteData.Values.ContainsKey("controller") ? context.RouteData.Values["controller"].ToString() : null,
                    Action = context.RouteData.Values.ContainsKey("action") ? context.RouteData.Values["action"].ToString() : null,
                    TraceId = traceId,
                    Route = context.HttpContext.Request.Path.Value,
                    Method = context.HttpContext.Request.Method,
                    UserAgent = context.HttpContext.Request.Headers["User-Agent"],
                    Parameters = !hideParameters ? JsonConvert.SerializeObject(context.ActionArguments.ToDictionary(k => k.Key, v => v.Value)) : null,
                    Headers = JsonConvert.SerializeObject(context.HttpContext.Request.Headers.ToDictionary(k => k.Key, v => v.Value)),
                };

                this.context.ActivityLogs.Add(activityLog);
                this.context.SaveChanges();
            }
            catch (Exception ex)
            {
                LogError(ex);
            }
        }

        public async Task LogErrorAsync(Exception exception, [CallerMemberName]string method = "")
        {
            try
            {
                string serviceClass = this.GetType().Name;
                ErrorLog log = new ErrorLog
                {
                    StackTrace = exception.StackTrace,
                    Source = exception.Source,
                    Message = exception.Message,
                    Method = method,
                    Class = serviceClass
                };

                this.context.ErrorLogs.Add(log);
                await this.context.SaveChangesAsync();
            }
            catch (Exception) { }
        }

        public void LogError(Exception exception, [CallerMemberName]string method = "")
        {
            try
            {
                string serviceClass = this.GetType().Name;
                ErrorLog log = new ErrorLog
                {
                    StackTrace = exception.StackTrace,
                    Source = exception.Source,
                    Message = exception.Message,
                    Method = method,
                    Class = serviceClass
                };

                this.context.ErrorLogs.Add(log);
                this.context.SaveChanges();
            }
            catch (Exception) { }
        }

        public async Task LogEmailAsync(string receiver, string subject, string body, bool sent)
        {
            try
            {
                var emailEntity = new EmailLog
                {
                    Receiver = receiver,
                    Subject = subject,
                    Body = body,
                    Sent = sent,
                };

                this.context.EmailLogs.Add(emailEntity);
                await this.context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                await LogErrorAsync(ex);
            }
        }
    }
}
