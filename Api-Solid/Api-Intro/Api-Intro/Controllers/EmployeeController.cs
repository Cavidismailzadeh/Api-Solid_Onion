using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Api_Intro.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            string[] names = { "Ali","Jale","Pervin" };
            return Ok(names);
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById([FromRoute]int? id)
        {
            if (id == null) return BadRequest();
            
            return Ok("Ali -" + " " + id);
        }
    }
}
