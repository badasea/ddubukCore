using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ddubuk_aspnet.Controllers
{
    public class ItemController : Controller 
    {
        private readonly ILogger<ItemController> _logger;

        public ItemController(ILogger<ItemController> logger)
        {
             _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}