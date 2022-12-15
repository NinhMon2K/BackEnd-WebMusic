using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QL.MUSIC.BL;
using QL.MUSIC.Common.Entities;
using QL.MUSIC.Common.Entities.Data;
using QL.MUSIC.Common.Enums;
using QL.MUSIC.Common.Resources;

namespace QL.MUSIC.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class AccountsController : BasesController<account>
    {
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
    }
}
