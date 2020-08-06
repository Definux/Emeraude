﻿using Definux.Emeraude.Application.Common.Interfaces.Identity.Services;
using Definux.Emeraude.Configuration.Options;
using Definux.Emeraude.Domain.Entities;
using Definux.Emeraude.Identity.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace Definux.Emeraude.Identity.Services
{
    public class TwoFactorAuthenticationService : ITwoFactorAuthenticationService
    {
        private const string AuthenticatorUriFormat = "otpauth://totp/{0}:{1}?secret={2}&issuer={0}&digits=6";
        private readonly UserManager<User> userManager;
        private readonly UrlEncoder urlEncoder;
        private readonly EmOptions options;

        public TwoFactorAuthenticationService(UserManager<User> userManager, UrlEncoder urlEncoder, IOptions<EmOptions> optionsAccessor)
        {
            this.userManager = userManager;
            this.urlEncoder = urlEncoder;
            this.options = optionsAccessor.Value;
        }

        public async Task<string> GetFormattedKeyAsync(IUser user)
        {
            string unformattedKey = await GetUnformattedKeyAsync(user);

            var result = new StringBuilder();
            int currentPosition = 0;
            while (currentPosition + 4 < unformattedKey.Length)
            {
                result.Append(unformattedKey.Substring(currentPosition, 4)).Append(" ");
                currentPosition += 4;
            }
            if (currentPosition < unformattedKey.Length)
            {
                result.Append(unformattedKey.Substring(currentPosition));
            }

            return result.ToString().ToLowerInvariant();
        }

        public async Task<string> GenerateQrCodeUriAsync(IUser user)
        {
            string unformattedKey = await GetUnformattedKeyAsync(user);

            return string.Format(
                AuthenticatorUriFormat,
                this.urlEncoder.Encode(this.options.ProjectName),
                this.urlEncoder.Encode(user.Email),
                unformattedKey);
        }

        public bool IsTwoFactorEnabled(IUser user)
        {
            return ((User)user).TwoFactorEnabled;
        }

        private async Task<string> GetUnformattedKeyAsync(IUser user)
        {
            var identityUser = (User)user;
            var unformattedKey = await this.userManager.GetAuthenticatorKeyAsync(identityUser);
            if (string.IsNullOrEmpty(unformattedKey))
            {
                await this.userManager.ResetAuthenticatorKeyAsync(identityUser);
                unformattedKey = await this.userManager.GetAuthenticatorKeyAsync(identityUser);
            }

            return unformattedKey;
        }
    }
}
