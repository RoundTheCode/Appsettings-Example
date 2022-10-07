using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RoundTheCode.AppSettings.Controllers.Home
{
    [Route("api/home")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            _logger.LogInformation("This is the index page");

            return Ok(new { Success = true });
        }
    }
}
