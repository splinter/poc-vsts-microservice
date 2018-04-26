using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
namespace ConsoleApplication
{
    [Route("records")]
    public class PokemonController : Controller
    {
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
             var record = new Record {
             Id = 1,
             EntityId = "Sample",
             Type = "Customer"
             };
             return Ok(record);
        }
    }
}