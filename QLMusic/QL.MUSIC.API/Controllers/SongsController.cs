using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QL.MUSIC.BL;
using QL.MUSIC.Common.Entities;
using QL.MUSIC.Common.Enums;
using QL.MUSIC.Common.Resources;
using System.Reflection;

namespace QL.MUSIC.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class SongsController : BasesController<song>
    {
        #region Field

        private ISongBL _songBL;

        #endregion

        #region Constructor
        public SongsController(ISongBL songBL) : base(songBL)
        {
            _songBL = songBL;
        }
        #endregion
        [HttpPost("Filters")]
        public IActionResult FilterSongs([FromBody] PagingSong pagingSong)
        {
            try
            {
                var filterResponse = _songBL.FilterSongs(pagingSong);

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
