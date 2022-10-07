using Microsoft.AspNetCore.Mvc;

namespace RoundTheCode.AppSettings.Controllers
{
    [Route("api/my")]
    [ApiController]
    public class MyController : ControllerBase
    {
        private readonly ILogger<MyController> _logger;

        public MyController(ILogger<MyController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            _logger.LogInformation("This is my page");

            return Ok(new { Success = true });
        }
    }
}
