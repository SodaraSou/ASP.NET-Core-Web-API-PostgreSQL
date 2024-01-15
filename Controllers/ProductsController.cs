using Microsoft.AspNetCore.Mvc;

namespace ComputerTopiaStoreApi.Controllers
{
    [ApiController]
    [Route("api/computertopia/[controller]")]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetProducts()
        {
            return Ok("Get All Products!");
        }
        [HttpGet("{id}")]
        public IActionResult GetProduct(int id)
        {
            return Ok($"Get Product ID: {id}");
        }
    }
}
