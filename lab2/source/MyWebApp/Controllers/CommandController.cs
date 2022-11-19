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
                        break;
                    case "rev":
                        break;
                }
            }

            return Ok(DateTime.Now.ToString("HH:mm:ss"));
        }
    }
}
