﻿using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace RedStarter.Business.Engines.Song
{
    public class SaveFileEngine
    {
        public string Upload(IFormFile file)
        {
            Account account = new Account(
                "dm7lepkwv",
                "453935962484596",
                "h68wAGIHesHWZKhQB5huALUPdW0");

            Cloudinary cloudinary = new Cloudinary(account);

            var uploadParams = new VideoUploadParams()
            {
                File = new FileDescription("test",file.OpenReadStream()),
            };
            var uploadResult = cloudinary.Upload(uploadParams, "raw");

            return uploadResult.Uri.ToString();
        }

    }
}
