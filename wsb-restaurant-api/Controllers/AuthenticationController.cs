using Microsoft.AspNetCore.Mvc;
using wsb_restaurant_application.Services.Authentication;
using wsb_restaurant_domain.Dtos;

namespace wsb_restaurant_api.Controllers
{
    [Route("api/v1/auth")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthenticationService _authenticationService;

        public AuthenticationController(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> LoginUser([FromBody] LoginRequest loginRequest)
        {
            var authResponse = _authenticationService.Login(loginRequest.email, loginRequest.password);
            var requestResponse = new AuthenticationResult(authResponse.id, authResponse.firstName, authResponse.lastName, authResponse.email, authResponse.token);
            return Ok(requestResponse);
        }

        [HttpPost("register")]
        public async Task<IActionResult> RegisterUser([FromBody] RegisterRequest registerRequest)
        {
            var authResponse = _authenticationService.Register(registerRequest.firstName, registerRequest.lastName, registerRequest.email, registerRequest.password);
            var requestResponse = new AuthenticationResult(authResponse.id, authResponse.firstName, authResponse.lastName, authResponse.email, authResponse.token);
            
            return Ok(requestResponse);
        }

        
    }
}
