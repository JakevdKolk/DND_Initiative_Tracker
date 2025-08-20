namespace DND_Initiative_Tracker.Controllers
{
    using global::DND_Initiative_Tracker.Contracts;
    using global::DND_Initiative_Tracker.Data;
    using global::DND_Initiative_Tracker.Models;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;

    namespace DND_Initiative_Tracker.Controllers
    {
        [ApiController]
        [Route("api/roles")]
        public class RoleController(DnDDbContext db) : ControllerBase
        {

            [HttpGet]
            [ProducesResponseType(typeof(List<RoleDto>), StatusCodes.Status200OK)]
            public async Task<ActionResult<List<RoleDto>>> GetAll()
            {
                var roles = await db.Roles
                    .AsNoTracking()
                    .Select(u => new RoleDto(
                        u.Id,
                        u.Name
                    ))
                    .ToListAsync();

                return Ok(roles);
            }

            [HttpGet("{id:int}", Name = "GetRolesById")]
            [ProducesResponseType(typeof(RoleDto), StatusCodes.Status200OK)]
            [ProducesResponseType(StatusCodes.Status404NotFound)]
            public async Task<ActionResult<RoleDto>> GetById([FromRoute] int id, CancellationToken ct)
            {
                var roles = await db.Roles
                    .AsNoTracking()
                    .Where(u => u.Id == id)
                    .Select(u => new RoleDto(
                        u.Id,
                        u.Name
                    ))
                    .SingleOrDefaultAsync(ct);

                if (roles is null) return NotFound();
                return Ok(roles);
            }

            [HttpPost]
            [Consumes("application/json")]
            [ProducesResponseType(typeof(RoleDto), StatusCodes.Status201Created)]
            public async Task<ActionResult<RoleDto>> Create([FromBody] CreateRoleDto dto, CancellationToken ct)
            {
                var role = new Role { Name = dto.Name};
                db.Roles.Add(role);
                await db.SaveChangesAsync(ct);

                var result = new RoleDto(role.Id ,role.Name);

                return CreatedAtRoute("GetRolesById", new { id = role.Id }, result);
            }


            [HttpDelete("{id:int}")]
            [ProducesResponseType(StatusCodes.Status204NoContent)]
            [ProducesResponseType(StatusCodes.Status404NotFound)]
            public async Task<ActionResult<RoleDto>> Destroy([FromRoute] int id, CancellationToken ct)
            {
                var role = await db.Roles.FindAsync(new object?[] { id }, ct);


                if (role == null)
                    return NotFound();

                db.Roles.Remove(role);
                await db.SaveChangesAsync(ct);

                return NoContent();
            }

        }
    }

}
