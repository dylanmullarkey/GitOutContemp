using Microsoft.AspNetCore.Mvc;

namespace GitOut.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NameController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<NameController> _logger;

        public NameController(ILogger<NameController> logger)
        {
            _logger = logger;
        }

        [HttpGet]

        public IActionResult Get()
        {
            var personName = new Name { PersonName = "Dylan Mullarkey" };
            return Ok(personName);
        }
    }
}
