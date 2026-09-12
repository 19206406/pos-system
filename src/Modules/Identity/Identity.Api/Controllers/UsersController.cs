using Microsoft.AspNetCore.Mvc;
using User.Api.Users.RegisterUser;

namespace Identity.Api.Controllers
{
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpPost]
        public Task<IActionResult> UserRegister(RegisterUserRequest request)
        {

        }
    }
}
