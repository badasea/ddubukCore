using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ddubuk_aspnet.Controllers
{
    public class CommunityController : Controller 
    {
        private readonly ILogger<CommunityController> _logger;

        public CommunityController(ILogger<CommunityController> logger)
        {
             _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}