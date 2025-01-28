using Microsoft.AspNetCore.Mvc;

namespace OpenSauce.Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Home()
        {
            return Ok("Hello World!");
        }
    }
}