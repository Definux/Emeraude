﻿using System.Threading;
using System.Threading.Tasks;
using Definux.Emeraude.Application.Files;
using Definux.Emeraude.Application.Requests.Files.Commands.Shared;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace Definux.Emeraude.Application.Requests.Files.Commands.UploadImage
{
    /// <summary>
    /// Command for uploading images.
    /// </summary>
    public class UploadImageCommand : IRequest<UploadResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UploadImageCommand"/> class.
        /// </summary>
        /// <param name="formFile"></param>
        public UploadImageCommand(IFormFile formFile)
        {
            this.FormFile = formFile;
        }

        /// <inheritdoc cref="IFormFile"/>
        public IFormFile FormFile { get; set; }

        /// <inheritdoc/>
        public class UploadImageCommandHandler : IRequestHandler<UploadImageCommand, UploadResult>
        {
            private readonly IFilesValidationProvider validationProvider;
            private readonly ISystemFilesService systemFilesService;
            private readonly IUploadService uploadService;

            /// <summary>
            /// Initializes a new instance of the <see cref="UploadImageCommandHandler"/> class.
            /// </summary>
            /// <param name="validationProvider"></param>
            /// <param name="systemFilesService"></param>
            /// <param name="uploadService"></param>
            public UploadImageCommandHandler(
                IFilesValidationProvider validationProvider,
                ISystemFilesService systemFilesService,
                IUploadService uploadService)
            {
                this.validationProvider = validationProvider;
                this.systemFilesService = systemFilesService;
                this.uploadService = uploadService;
            }

            /// <inheritdoc/>
            public async Task<UploadResult> Handle(UploadImageCommand request, CancellationToken cancellationToken)
            {
                var validationResult = this.validationProvider.ValidateFormImageFile(request.FormFile);
                if (validationResult.Successed)
                {
                    var uploadedFile = await this.uploadService.UploadFileAsync(request.FormFile);
                    if (uploadedFile != null)
                    {
                        return UploadResult.SuccessResult(uploadedFile.Id);
                    }
                    else
                    {
                        return UploadResult.ErrorResult("File has not been uploaded.");
                    }
                }

                return UploadResult.ValidationErrorResult(validationResult.Message);
            }
        }
    }
}
