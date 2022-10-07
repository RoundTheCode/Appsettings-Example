using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RoundTheCode.AppSettings.Entities;

namespace RoundTheCode.AppSettings.Controllers
{
    [ApiController]
    [Route("api/home")]
    public class HomeController : ControllerBase
    {
        private readonly AppSettingsDbContext _context;

        public HomeController(AppSettingsDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<Authentication> Index()
        {
            return await _context.Authentication.FirstAsync(s => s.Id == 1);
        }
    }
}