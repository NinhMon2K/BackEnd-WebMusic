using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QL.MUSIC.API.Interface;
using QL.MUSIC.BL;
using QL.MUSIC.Common.Entities;
using QL.MUSIC.Common.Entities.Data;
using QL.MUSIC.Common.Enums;
using QL.MUSIC.Common.Resources;
using System.Net.Http.Headers;

namespace QL.MUSIC.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class AccountsController : BasesController<account>
    {
        protected IStorageService _storageService;
        #region Field

        private IAccountBL _accountBL;

        #endregion
        public AccountsController(IAccountBL accountBL) : base(accountBL)
        {
            _accountBL = accountBL;
        }

        [HttpPost("Filters")]
        public IActionResult FilterSongs([FromBody] PagingSong pagingSong)
        {
            try
            {
                var filterResponse = _accountBL.FilterAccounts(pagingSong);

                return StatusCode(StatusCodes.Status200OK, filterResponse);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError, new ErrorResult(
                    ErrorCode.Exception,
                    Resource.DevMsg_Exception,
                    Resource.UserMsg_Exception,
                    Resource.MoreInfo_Exception,
                    HttpContext.TraceIdentifier));
            }
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
                    res.Data = "/saveimage/" + fileName;
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
