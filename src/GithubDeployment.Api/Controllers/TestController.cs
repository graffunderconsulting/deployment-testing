using Microsoft.AspNetCore.Mvc;

namespace GithubDeployement.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {        
        private readonly ILogger<TestController> _logger;

        public TestController(ILogger<TestController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "Test")]
        public IActionResult Get([FromQuery] string? testName)
        {
            return Ok($"Hello again {testName}");
        }
    }
}