using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace MyWebApp.Models
{
    public class StringRequest
    {
        [FromQuery]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public string? Str { get; set; }
    }
}
