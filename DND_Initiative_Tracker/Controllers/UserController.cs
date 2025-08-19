using Microsoft.AspNetCore.Mvc;
using DND_Initiative_Tracker.Models;
using DND_Initiative_Tracker.Data;
using Microsoft.EntityFrameworkCore;

namespace DND_Initiative_Tracker.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UserController(DnDDbContext db) : ControllerBase
    {
      

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetAll()
        {
            var user = await db.Users.Include(u => u.Role).ToListAsync();

            return Ok(user);

        }

    }
}
