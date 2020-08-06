﻿using Definux.Emeraude.Application.Common.Results.Files;
using Definux.Emeraude.Domain.Logging;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Definux.Emeraude.Application.Common.Interfaces.Files
{
    public interface ISystemFilesService
    {
        string PublicRootDirectory { get; }

        string PrivateRootDirectory { get; }

        string GetPathFromPublicRoot(params string[] paths);

        string GetPathFromPrivateRoot(params string[] paths);

        IEnumerable<SystemFileItem> ScanDirectory(string directory, string baseDirectory = "");

        IEnumerable<SystemFileItem> ScanPublicDirectory();

        IEnumerable<SystemFileItem> ScanPrivateDirectory();

        Task<SystemFileResult> GetFileAsync(string filePath);

        Task<TempFileLog> UploadFileAsync(IFormFile formFile);

        Task<TempFileLog> UploadFileAsync(IFormFile formFile, string saveDirectory, bool publicRoot = false);

        Task<TempFileLog> GetFileByIdAsync(int id);

        TempFileLog GetFileById(int id);

        Task<TempFileLog> MoveFileToPrivateDirectoryAsync(int fileId, string targetDirectory);

        Task<TempFileLog> MoveFileToPublicDirectoryAsync(int fileId, string targetDirectory);

        Task<bool> CreateFolderAsync(string folderName, string folderPath);
    }
}
