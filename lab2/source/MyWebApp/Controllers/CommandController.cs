using Microsoft.AspNetCore.Mvc;

namespace MyWebApp.Controllers
{
    [Route("")]
    [ApiController]
    public class CommandController : ControllerBase
    {
        // GET: api/<CommandController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
    }
}
