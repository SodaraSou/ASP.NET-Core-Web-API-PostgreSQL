using ComputerTopiaStoreApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace ComputerTopiaStoreApi.Controllers
{
    [ApiController]
    [Route("api/computertopia/[controller]")]
    public class LaptopsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetLaptops()
        {
            return Ok("Get All Laptops!");
        }
        [HttpPost]
        public IActionResult AddLaptop([FromBody] Laptop newLaptop)
        {
            return Ok("Laptop Added!");
        }
        [HttpPut("{id}")]
        public IActionResult UpdateLaptop(string id)
        {
            return Ok("Laptop Updated!");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteLaptop(string id)
        {
            return Ok("Laptop Deleted!");
        }
    }
}
