﻿using System.Threading;
using System.Threading.Tasks;
using Definux.Emeraude.Application.Files;
using Definux.Emeraude.Application.Requests.Files.Commands.Shared;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace Definux.Emeraude.Application.Requests.Files.Commands.UploadVideo
{
    /// <summary>
    /// Command for uploading video files.
    /// </summary>
    public class UploadVideoCommand : IRequest<UploadResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UploadVideoCommand"/> class.
        /// </summary>
        /// <param name="formFile"></param>
        public UploadVideoCommand(IFormFile formFile)
        {
            this.FormFile = formFile;
        }

        /// <inheritdoc cref="IFormFile"/>
        public IFormFile FormFile { get; set; }

        /// <inheritdoc/>
        public class UploadVideoCommandHandler : IRequestHandler<UploadVideoCommand, UploadResult>
        {
            private readonly IFilesValidationProvider validationProvider;
            private readonly ISystemFilesService systemFilesService;

            /// <summary>
            /// Initializes a new instance of the <see cref="UploadVideoCommandHandler"/> class.
            /// </summary>
            /// <param name="validationProvider"></param>
            /// <param name="systemFilesService"></param>
            public UploadVideoCommandHandler(IFilesValidationProvider validationProvider, ISystemFilesService systemFilesService)
            {
                this.validationProvider = validationProvider;
                this.systemFilesService = systemFilesService;
            }

            /// <inheritdoc/>
            public async Task<UploadResult> Handle(UploadVideoCommand request, CancellationToken cancellationToken)
            {
                var validationResult = this.validationProvider.ValidateFormVideoFile(request.FormFile);
                if (validationResult.Successed)
                {
                    var uploadedFile = await this.systemFilesService.UploadFileAsync(request.FormFile);
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
