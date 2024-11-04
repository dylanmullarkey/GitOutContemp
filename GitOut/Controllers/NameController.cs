using Microsoft.AspNetCore.Mvc;

namespace GitOut.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NameController : ControllerBase
    {

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
