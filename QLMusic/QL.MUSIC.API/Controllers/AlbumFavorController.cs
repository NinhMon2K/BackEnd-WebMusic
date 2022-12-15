using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QL.MUSIC.BL;
using QL.MUSIC.Common.Entities;
using QL.MUSIC.Common.Entities.Data;

namespace QL.MUSIC.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlbumFavorController : BasesController<albumFavor>
    {
        public AlbumFavorController(IBaseBL<albumFavor> baseBL) : base(baseBL)
        {
        }
    }
}
