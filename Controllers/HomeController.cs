using Microsoft.AspNetCore.Mvc;

namespace EscolaOnline.Api.Controllers
{
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet("")]
        public IActionResult Get()
        {
            return Ok();
        }
    }
}
