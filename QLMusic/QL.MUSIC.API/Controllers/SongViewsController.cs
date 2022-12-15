using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QL.MUSIC.BL;
using QL.MUSIC.Common.Entities;

namespace QL.MUSIC.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SongViewsController : BasesController<songview>
    {
        public SongViewsController(IBaseBL<songview> baseBL) : base(baseBL)
        {
        }
    }
}
