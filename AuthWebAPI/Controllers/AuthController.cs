using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using AuthWebAPI.Entities;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace AuthWebAPI.Controllers
{
    [ApiController]
    [Route("[controller")]
    public class AuthController : ControllerBase
    {
        public AuthController(ILogger<AuthController> logger) { }

        [HttpPost]
        [Route("token")]
        public async Task<IActionResult> Token(Credentials credentials)
        {
            if (!IsAdmin(credentials) && !IsUser(credentials))
            {
                return Unauthorized();
            }

            var secretKey = "MyAnonymousAndSecuredSecretKey";
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey));

            var jwt = new JwtSecurityToken(
                    claims: BuildClaims(credentials),
                    expires: DateTime.Now.AddMinutes(15),
                    signingCredentials: new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha512)
                );

            var token = new JwtSecurityTokenHandler().WriteToken(jwt);

            return Ok(token);
        }

        private Claim[] BuildClaims(Credentials credentials)
        {
            return new[]
            {
                new Claim("userType", IsAdmin(credentials) ? "admin" : "user")
            };
        }

        private bool IsAdmin(Credentials credentials)
        {
            return credentials.UserName == "admin" && credentials.Password == "admin";
        }

        private bool IsUser(Credentials credentials)
        {
            return credentials.UserName == "user" && credentials.Password == "user";
        }
    }
}
