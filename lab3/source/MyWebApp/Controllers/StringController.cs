using Microsoft.AspNetCore.Mvc;
using MyWebApp.Models;

namespace MyWebApp.Controllers
{
    [Route("")]
    [ApiController]
    public class StringController : ControllerBase
    {
        // GET: api/<CommandController>
        [HttpGet]
        public IActionResult Get([FromQuery] string? str)
        {
            if(str is null)
            {
                return BadRequest("No string was supplied");
            }

            if(str == string.Empty)
            {
                return Ok(new StringBreakdown());
            }

            return Ok("Hello World");
        }
    }
}
