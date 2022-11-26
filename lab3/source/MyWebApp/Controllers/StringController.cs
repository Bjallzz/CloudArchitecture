using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Writers;
using MyWebApp.Models;

namespace MyWebApp.Controllers
{
    [Route("")]
    [ApiController]
    public class StringController : ControllerBase
    {

        [HttpGet]
        public IActionResult Get([FromQuery] string? str)
        {
            if (str is null)
            {
                return BadRequest("No string was supplied");
            }

            return Ok(DisassembleString(str));
        }

        private static StringBreakdown DisassembleString(string str)
        {
            var result = new StringBreakdown();

            if (str == string.Empty)
            {
                return result;
            }

            var characters = str.ToCharArray();

            foreach (var character in characters)
            {
                if (char.IsUpper(character))
                {
                    result.Uppercase++;
                    continue;
                }

                if (char.IsLower(character))
                {
                    result.Lowercase++;
                    continue;
                }

                if (char.IsDigit(character))
                {
                    result.Digits++;
                    continue;
                }

                result.Special++;
            }

            return result;
        }
    }
}
