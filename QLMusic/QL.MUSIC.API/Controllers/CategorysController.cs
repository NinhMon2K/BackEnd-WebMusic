using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QL.MUSIC.BL;
using QL.MUSIC.Common.Entities;

namespace QL.MUSIC.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CategorysController : BasesController<category>
    {
        public CategorysController(IBaseBL<category> baseBL) : base(baseBL)
        {
        }
    }
}
