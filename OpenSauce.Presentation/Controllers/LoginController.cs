using Microsoft.AspNetCore.Mvc;
using Application.DTO;

namespace OpenSauce.Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {
        [HttpPost]
        public IActionResult Login([FromBody] LoginRequest request)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (request.Email == "test@example.com" && request.Password == "password123")
            {
                return Ok();
            }


            return Unauthorized();
        }
    }
    
}