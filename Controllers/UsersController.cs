using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ComputerTopiaStoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MembersController : ControllerBase
    {
        private readonly AppDbContext context;
        public MembersController(AppDbContext context)
        {
            this.context = context;
        }

        [HttpGet(Name = "AllMembers")]
        public async Task<ActionResult> GetAll()
        {
            var users = await context.Users.ToListAsync();
            return Ok(users);
        }
    }
}