﻿using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Definux.Emeraude.Application.Common.Interfaces.Localization;
using Definux.Emeraude.Domain.Localization;
using Definux.Utilities.Objects;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Definux.Emeraude.Admin.ClientBuilder.Requests.Commands.CreateLanguage
{
    /// <summary>
    /// Command that create a language.
    /// </summary>
    public class CreateLanguageCommand : CreateLanguageRequest, IRequest<CreatedResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateLanguageCommand"/> class.
        /// </summary>
        /// <param name="request"></param>
        public CreateLanguageCommand(CreateLanguageRequest request)
        {
            this.Name = request.Name;
            this.NativeName = request.NativeName;
            this.Code = request.Code;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateLanguageCommand"/> class.
        /// </summary>
        public CreateLanguageCommand()
        {
        }

        /// <inheritdoc/>
        public class CreateLanguageCommandHandler : IRequestHandler<CreateLanguageCommand, CreatedResult>
        {
            private readonly ILocalizationContext context;
            private readonly IMapper mapper;

            /// <summary>
            /// Initializes a new instance of the <see cref="CreateLanguageCommandHandler"/> class.
            /// </summary>
            /// <param name="context"></param>
            /// <param name="mapper"></param>
            public CreateLanguageCommandHandler(ILocalizationContext context, IMapper mapper)
            {
                this.context = context;
                this.mapper = mapper;
            }

            /// <inheritdoc/>
            public async Task<CreatedResult> Handle(CreateLanguageCommand request, CancellationToken cancellationToken)
            {
                var language = this.mapper.Map<Language>(request);
                var keys = await this.context.Keys.AsQueryable().ToListAsync();
                foreach (var key in keys)
                {
                    language.Translations.Add(new TranslationValue
                    {
                        TranslationKeyId = key.Id,
                    });
                }

                this.context.Languages.Add(language);
                await this.context.SaveChangesAsync();

                return new CreatedResult(language.Id);
            }
        }
    }
}
