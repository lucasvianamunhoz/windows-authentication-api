using Microsoft.AspNetCore.Mvc;

namespace windows_authentication.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {
        [HttpGet]
        public IActionResult Login()
        {
            if (User.Identity.IsAuthenticated)
            {
                // Usuário autenticado
                return Ok();
            }
            else
            {
                // Usuário não autenticado
                return Unauthorized();
            }
        }

    }

}
