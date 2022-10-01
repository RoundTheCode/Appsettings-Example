using Microsoft.AspNetCore.Mvc;

namespace RoundTheCode.AppSettings.Controllers
{
    [Route("api/home")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public HomeController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return Ok(new
            {
                ClientId = _configuration.GetValue<string>("Authentication:ClientId"),
                ClientSecret = _configuration.GetValue<string>("Authentication:ClientSecret"),
                AllowedHosts = _configuration.GetSection("Authentication:AllowedHosts").Get<string[]>(),
                Attempts = _configuration.GetValue<int>("Authentication:Attempts")
            });
        }
    }
}