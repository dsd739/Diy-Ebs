using Diy_B.Helpers;
using Diy_B.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Diy_B.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
		private readonly AuthService _authService;
		private readonly IConfiguration _configuration;

		public AuthController(AuthService authService, IConfiguration configuration)
		{
			_authService = authService;
			_configuration = configuration;
		}

		[HttpPost("login")]
		public async Task<IActionResult> Login([FromBody] LoginRequest request)
		{
			var user = await _authService.AuthenticateAsync(request.Username, request.Password);
			if (user == null)
				return Unauthorized("Invalid username or password.");

			var token = JwtHelper.GenerateJwtToken(
				request.Username,
				_configuration["Jwt:Key"],
				_configuration["Jwt:Issuer"],
				_configuration["Jwt:Audience"]
			);

			return Ok(new { Token = token });
		}
	}
	public class LoginRequest
	{
		public string Username { get; set; }
		public string Password { get; set; }
	}
}
