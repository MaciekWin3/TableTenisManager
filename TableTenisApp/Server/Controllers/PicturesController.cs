using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using TableTenisApp.Shared.Database;
using TableTenisApp.Shared.Models;

namespace TableTenisApp.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PicturesController : ControllerBase
    {
        public IDapperDb _db;
        private readonly IHostEnvironment _environment;

        public PicturesController(IDapperDb db, IHostEnvironment environment)
        {
            _db = db;
            _environment = environment;
        }

        [HttpPost]
        public async Task<IActionResult> PostPicture([FromForm] IFormFile image)
        {

            if (image == null || image.Length == 0)
            {
                return BadRequest("Upload a file");
            }

            string fileName = image.FileName;
            string extension = Path.GetExtension(fileName);

            string[] allowedExtensions = { ".png" };

            if (!allowedExtensions.Contains(extension))
            {
                return BadRequest("File is not a valid image");
            }

            //string newFileName = $"{Guid.NewGuid()}{extension}";
            string filePath = Path.Combine(_environment.ContentRootPath, "wwwroot", "Images", fileName);

            using (var fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                await image.CopyToAsync(fileStream);
            };


            return Ok($"Images/{fileName}");
        }
    }
}
