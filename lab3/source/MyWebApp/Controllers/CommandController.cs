using Microsoft.AspNetCore.Mvc;

namespace MyWebApp.Controllers
{
    [Route("")]
    [ApiController]
    public class CommandController : ControllerBase
    {
        // GET: api/<CommandController>
        [HttpGet]
        public IActionResult Get([FromQuery] string? cmd, [FromQuery] string? str)
        {
            if(!string.IsNullOrEmpty(cmd))
            {
                switch (cmd) 
                {
                    case "time":
                        return Ok(DateTime.Now.ToString("HH:mm:ss"));
                    case "rev":
                        if(string.IsNullOrEmpty(str))
                        {
                            return BadRequest("Command rev was supplied but str parameter was null or empty");
                        }
                        return Ok(string.Concat(str.Reverse()));
                }
            }

            return Ok("Hello World");
        }
    }
}
