namespace DND_Initiative_Tracker.Controllers
{
    using global::DND_Initiative_Tracker.Contracts;
    using global::DND_Initiative_Tracker.Data;
    using global::DND_Initiative_Tracker.Models;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using System.Linq.Expressions;

    namespace DND_Initiative_Tracker.Controllers
    {
        [ApiController]
        [Route("api/roles")]
        public class RoleController : BaseController<Role, RoleDto, CreateRoleDto, int> 
        {
            public RoleController(DnDDbContext dbContext) : base(dbContext) { }

            protected override Expression<Func<Role, RoleDto>> MapToDto() => u => new(
                u.Id, u.Name
            );

            protected override Role MapToEntity(CreateRoleDto dto) => new()
            {
                Name = dto.Name
            };

            protected override Expression<Func<Role, bool>> ById(int id) => u => u.Id == id;
        }
    }

}
