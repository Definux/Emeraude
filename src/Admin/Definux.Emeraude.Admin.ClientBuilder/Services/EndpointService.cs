﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Definux.Emeraude.Admin.ClientBuilder.DataAnnotations;
using Definux.Emeraude.Admin.ClientBuilder.Models;
using Definux.Emeraude.Admin.ClientBuilder.Options;
using Definux.Emeraude.Application.Common.Interfaces.Logging;
using Definux.Utilities.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace Definux.Emeraude.Admin.ClientBuilder.Services
{
    /// <inheritdoc cref="IEndpointService"/>
    public class EndpointService : IEndpointService
    {
        private readonly ILogger logger;
        private readonly ClientBuilderOptions clientBuilderOptions;

        /// <summary>
        /// Initializes a new instance of the <see cref="EndpointService"/> class.
        /// </summary>
        /// <param name="clientBuilderOptions"></param>
        /// <param name="logger"></param>
        public EndpointService(IOptions<ClientBuilderOptions> clientBuilderOptions, ILogger logger)
        {
            this.clientBuilderOptions = clientBuilderOptions.Value;
            this.logger = logger;
        }

        /// <inheritdoc/>
        public List<Endpoint> GetAllEndpoints()
        {
            List<Type> apiControllersTypes = new List<Type>();
            foreach (var assembly in this.clientBuilderOptions.Assemblies)
            {
                var assemblyTypes = assembly.GetTypes().Where(x => x.HasAttribute<ApiEndpointsControllerAttribute>()).ToList();
                apiControllersTypes.AddRange(assemblyTypes);
            }

            List<Endpoint> resultEndpoints = new List<Endpoint>();
            foreach (var controllerType in apiControllersTypes)
            {
                var currentControllerEndpoints = controllerType.GetMethods().Where(x => x.HasAttribute<EndpointAttribute>()).ToList();
                foreach (var endpoint in currentControllerEndpoints)
                {
                    var currentEntpoint = this.BuildEndpoint(endpoint, controllerType);

                    if (resultEndpoints.FirstOrDefault(x => x.Id == currentEntpoint.Id) == null)
                    {
                        resultEndpoints.Add(currentEntpoint);
                    }
                }
            }

            return resultEndpoints.OrderBy(x => x.ControllerName).ToList();
        }

        /// <inheritdoc/>
        public List<ClassDescription> GetAllEndpointsClasses()
        {
            var endpoints = this.GetAllEndpoints();
            var classes = new List<ClassDescription>();
            foreach (var endpoint in endpoints)
            {
                if (!endpoint.Response.Void && endpoint.Response.Class.IsComplex)
                {
                    classes.Add(endpoint.Response.Class);
                }

                classes.AddRange(endpoint.Arguments.Where(x => x.Class.IsComplex).Select(x => x.Class).ToList());
            }

            return DescriptionExtractor.ExtractUniqueClassesFromClasses(classes);
        }

        private Endpoint BuildEndpoint(MethodInfo endpointMethodInfo, Type controllerType)
        {
            try
            {
                var endpointAttribute = endpointMethodInfo.GetAttribute<EndpointAttribute>();
                string controllerRoute = controllerType.GetAttribute<RouteAttribute>().Template;
                string actionRoute = endpointMethodInfo.GetAttribute<RouteAttribute>().Template;

                Endpoint currentEntpoint = new Endpoint
                {
                    Id = $"{controllerType.FullName.ToString().ToLower().Replace('.', '-')}-{endpointMethodInfo.Name.ToString().ToLower().Replace('.', '-')}",
                    ControllerName = controllerType.Name,
                    ActionName = endpointMethodInfo.Name,
                    Route = actionRoute.StartsWith("/", StringComparison.OrdinalIgnoreCase) ? actionRoute : $"{controllerRoute}{actionRoute}",
                    Method = endpointMethodInfo.GetControllerActionHttpMethod(),
                    Authorized = endpointMethodInfo.HasAttribute<AuthorizeAttribute>() || controllerType.HasAttribute<AuthorizeAttribute>(),
                    Response = DescriptionExtractor.ExtractResponseDescription(endpointAttribute.ResponseType),
                    Arguments = endpointMethodInfo.GetParameters().Select(x => DescriptionExtractor.ExtractArgumentDescription(x.Name, x.ParameterType)).ToList(),
                };

                return currentEntpoint;
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex);
                return null;
            }
        }
    }
}
