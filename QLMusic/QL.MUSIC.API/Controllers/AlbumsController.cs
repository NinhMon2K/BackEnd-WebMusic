using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QL.MUSIC.API.Interface;
using QL.MUSIC.BL;
using QL.MUSIC.Common.Entities;
using System.Net.Http.Headers;

namespace QL.MUSIC.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class AlbumsController : BasesController<album>
    {
        protected IStorageService _storageService;

        public AlbumsController(IBaseBL<album> baseBL, IStorageService storageService) : base(baseBL)
        {
            _storageService = storageService;
        }


        [HttpPost("SaveImage")]
        public async Task<ServiceResult> SaveImageDish(IFormFile file)
        {
            var res = new ServiceResult();

            try
            {
                var formData = HttpContext.Request.Form;
                var oldFile = formData["oldFile"];

                if (file != null)
                {
                    var originalFileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                    string fileName = Guid.NewGuid().ToString() + Path.GetExtension(originalFileName);
                    await _storageService.SaveFileAsync(file.OpenReadStream(), fileName);
                    res.Data = "https://mmusic31072001.000webhostapp.com/API/Image/" + fileName;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return res;
        }
    }
}
