using Microsoft.AspNetCore.Mvc;

namespace DeserializationLatencyInvestigation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LatencyController : ControllerBase
    {
        [HttpPost("SomeTestEndpoint")]
        public async Task<IActionResult> SomeTestEndpoint([FromBody] TestModel model)
        {
            return Ok();
        }

        [HttpPost("AnotherTestEndpoint")]
        public async Task<IActionResult> AnotherTestEndpoint([FromBody] ShortModel model)
        {
            return Ok();
        }
    }
}
