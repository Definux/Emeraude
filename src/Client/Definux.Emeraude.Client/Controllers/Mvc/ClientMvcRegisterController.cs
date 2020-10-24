﻿using System;
using System.Threading.Tasks;
using Definux.Emeraude.Application.Exceptions;
using Definux.Emeraude.Application.Requests.Identity.Commands.Register;
using Definux.Emeraude.Locales.Attributes;
using Definux.Emeraude.Presentation.Controllers;
using Definux.Emeraude.Presentation.Extensions;
using Definux.Emeraude.Resources;
using Microsoft.AspNetCore.Mvc;

namespace Definux.Emeraude.Client.Controllers.Mvc
{
    /// <inheritdoc/>
    public sealed partial class ClientMvcAuthenticationController : PublicController
    {
        private const string RegisterRoute = "/register";

        /// <summary>
        /// Register action for GET request.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route(RegisterRoute)]
        [LanguageRoute(RegisterRoute)]
        public IActionResult Register()
        {
            if (this.User.Identity.IsAuthenticated)
            {
                return this.RedirectToHomeIndex();
            }

            var request = new RegisterRequest();

            return this.RegisterView(request);
        }

        /// <summary>
        /// Register action for POST request.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route(RegisterRoute)]
        [LanguageRoute(RegisterRoute)]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterRequest request)
        {
            if (this.User.Identity.IsAuthenticated)
            {
                return this.RedirectToHomeIndex();
            }

            try
            {
                var requestResult = await this.Mediator.Send(new RegisterCommand(request));

                if (requestResult.Result.Succeeded)
                {
                    return this.View("RegisterSuccess");
                }
                else
                {
                    this.ModelState.AddModelError(string.Empty, Messages.UserCannotBeRegistered);
                }
            }
            catch (ValidationException ex)
            {
                this.ModelState.ApplyValidationException(ex);
            }
            catch (Exception)
            {
                this.ModelState.AddModelError(string.Empty, Messages.UserCannotBeRegistered);
            }

            return this.RegisterView(request);
        }

        private ViewResult RegisterView(object model)
        {
            return this.View("Register", model);
        }
    }
}
