using Microsoft.AspNetCore.Mvc;

namespace RoundTheCode.AppSettings.Controllers
{
    [Route("api/home")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly IWebHostEnvironment _environment;

        public HomeController(IConfiguration configuration, IWebHostEnvironment environment)
        {
            _configuration = configuration;
            _environment = environment;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return Ok(new
            {
                Environment = _environment.EnvironmentName,
                ClientId = _configuration.GetValue<string>("Authentication:ClientId"),
                ClientSecret = _configuration.GetValue<string>("Authentication:ClientSecret"),
                AllowedHosts = _configuration.GetSection("Authentication:AllowedHosts").Get<string[]>(),
                Attempts = _configuration.GetValue<int>("Authentication:Attempts"),
                LiveHost = _configuration.GetValue<string>("LiveHost")
            });
        }
    }
}