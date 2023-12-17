using Microsoft.AspNetCore.Mvc;

namespace DeserializationLatencyInvestigation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LatencyController : ControllerBase
    {
        [HttpPost(Name = "SomeTestEndpoint")]
        public async Task<IActionResult> Post([FromBody] TestModel model)
        {
            return Ok(model);
        }
    }
}
