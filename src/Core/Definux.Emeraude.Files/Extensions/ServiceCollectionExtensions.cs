﻿using Definux.Emeraude.Application.Files;
using Definux.Emeraude.Files.Services;
using Definux.Emeraude.Files.Validation;
using Microsoft.Extensions.DependencyInjection;

namespace Definux.Emeraude.Files.Extensions
{
    /// <summary>
    /// Extensions for <see cref="IServiceCollection"/>.
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Registers system file management services.
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection RegisterEmeraudeSystemFilesManagement(this IServiceCollection services)
        {
            services.AddScoped<ISystemFilesService, SystemFilesService>();
            services.AddScoped<IFilesValidationProvider, FilesValidationProvider>();

            return services;
        }
    }
}
