using Microsoft.AspNetCore.Mvc;
using wsb_restaurant_application.Common.Services.Account;
using wsb_restaurant_application.Services.Authentication;
using wsb_restaurant_domain.Dtos;

namespace wsb_restaurant_api.Controllers
{
    [Route("api/v1/account")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService accountService;

        public AccountController(IAccountService accountService)
        {
            this.accountService = accountService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> LoginUser([FromBody] LoginRequest loginRequest)
        {
            var authenticationResult = accountService.Login(loginRequest.email, loginRequest.password);
            return Ok(authenticationResult);
        }

        [HttpPost("register")]
        public async Task<IActionResult> RegisterUser([FromBody] RegisterRequest registerRequest)
        {
            accountService.Register(registerRequest.firstName, registerRequest.lastName, registerRequest.email, registerRequest.password);

            return Ok();
        }
    }
}
