using Microsoft.AspNetCore.Mvc;

namespace RoundTheCode.AppSettings.Controllers
{
    [ApiController]
    [Route("api/home")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Index()
        {
            return Ok(new { Success = true });
        }
    }
}