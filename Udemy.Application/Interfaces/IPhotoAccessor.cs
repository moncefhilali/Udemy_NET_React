﻿using Microsoft.AspNetCore.Http;
using Udemy.Application.Photos;
using System.Threading.Tasks;

namespace Udemy.Application.Interfaces
{
    public interface IPhotoAccessor
    {
        Task<PhotoUploadResult> AddPhoto(IFormFile file);
        Task<string> DeletePhoto(string publicId);
    }
}
