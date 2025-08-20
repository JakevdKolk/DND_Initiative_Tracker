using DND_Initiative_Tracker.Contracts;
using DND_Initiative_Tracker.Data;
using DND_Initiative_Tracker.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DND_Initiative_Tracker.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UserController(DnDDbContext db) : ControllerBase
    {

        [HttpGet]
        [ProducesResponseType(typeof(List<AppUserDto>), StatusCodes.Status200OK)]
        public async Task<ActionResult<List<AppUserDto>>> GetAll()
        {
            var users = await db.AppUser
                .AsNoTracking()
                .Select(u => new AppUserDto(
                    u.Id,
                    u.Name,
                    u.Role == null ? null : new RoleDto(u.Role.Id, u.Role.Name)
                ))
                .ToListAsync();

            return Ok(users);
        }

        [HttpGet("{id:int}", Name = "GetUserById")]
        [ProducesResponseType(typeof(AppUserDto), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<AppUserDto>> GetById([FromRoute] int id, CancellationToken ct)
        {
            var user = await db.AppUser
                .AsNoTracking()
                .Where(u => u.Id == id)
                .Select(u => new AppUserDto(
                    u.Id,
                    u.Name,
                    u.Role == null ? null : new RoleDto(u.Role.Id, u.Role.Name)
                ))
                .SingleOrDefaultAsync(ct);

            if (user is null) return NotFound();
            return Ok(user);
        }

        [HttpPost]
        [Consumes("application/json")]
        [ProducesResponseType(typeof(AppUserDto), StatusCodes.Status201Created)]
        public async Task<ActionResult<AppUserDto>> Create([FromBody] CreateAppUserDto dto, CancellationToken ct)
        {
            var user = new AppUser { Name = dto.Name, RoleId = dto.RoleId };
            db.AppUser.Add(user);
            await db.SaveChangesAsync(ct);

            RoleDto? roleDto = null;
            if (user.RoleId is int rid)
            {
                var role = await db.Roles.AsNoTracking().FirstOrDefaultAsync(r => r.Id == rid, ct);
                if (role != null) roleDto = new RoleDto(role.Id, role.Name);
            }

            var result = new AppUserDto(user.Id, user.Name, roleDto);

            return CreatedAtRoute("GetUserById", new { id = user.Id }, result);
        }

        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<AppUserDto>> Destroy([FromRoute] int id, CancellationToken ct)
        {
            var user = await db.AppUser.FindAsync(new object?[] { id }, ct);


            if (user == null)
                return NotFound();

            db.AppUser.Remove(user);
            await db.SaveChangesAsync(ct );

            return NoContent();
        }

        [HttpPut("{id:int}")]
        [Consumes("application/json")]
        [ProducesResponseType(typeof(AppUserDto), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<AppUserDto>> Update(
            [FromRoute] int id, [FromBody] UpdateAppUserDto dto, CancellationToken ct)
        {
            var user = await db.AppUser.FirstOrDefaultAsync(u => u.Id == id, ct);

            if (user == null)
                return NotFound();

            user.Name = dto.Name;
            user.RoleId = dto.RoleId;

            await db.SaveChangesAsync(ct);

            RoleDto? roleDto = null;
            if (user.RoleId is int rid)
            {
                var role = await db.Roles.AsNoTracking()
                    .FirstOrDefaultAsync(r => r.Id == rid, ct);

                if (role != null)
                    roleDto = new RoleDto(role.Id, role.Name);
            }

            var result = new AppUserDto(user.Id, user.Name, roleDto);
            return Ok(result);
        }


    }
}
