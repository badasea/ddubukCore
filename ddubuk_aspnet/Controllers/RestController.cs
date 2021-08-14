using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
namespace ddubuk_aspnet.Controllers
{
    [Route("api/[controller]")]
    public class RestController : Controller
    {
        private readonly ILogger<RestController> _logger;

        public RestController(ILogger<RestController> logger)
        {
             _logger = logger;
        }
        
        
        [HttpGet("{id}", Name = "GetTodo")]
        public IActionResult GetById(string id)
        {            
            return new ObjectResult(id);
        }
    }
}