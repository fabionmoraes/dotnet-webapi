using dotnet.src.Application.Services;
using dotnet.src.Domain.Model.EmployeeAggregate;
using Microsoft.AspNetCore.Mvc;

namespace dotnet.src.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/auth")]
    [ApiVersion("1.0")]
    public class AuthController : ControllerBase
    {
        [HttpPost]
        public IActionResult Auth(string username, string password)
        {
            if (username == "fabio" && password == "123")
            {
                var token = TokenService.GenerateToken(new Employee("Fabio", 32, ""));
                return Ok(token);
            }

            return BadRequest("Username or Password invalid");
        }
    }
}