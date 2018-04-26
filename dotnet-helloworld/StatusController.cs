using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
namespace ConsoleApplication
{
    [Route("status")]
    public class StatusController : Controller
    {
        [HttpGet]
        public IActionResult Get(int id)
        {
             var status = new Status {
                 Version = "1.0.0"
             };
             return Ok(status);
        }
    }
}