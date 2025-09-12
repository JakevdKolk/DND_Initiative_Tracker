using DND_Initiative_Tracker.Contracts;
using DND_Initiative_Tracker.Data;
using DND_Initiative_Tracker.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DND_Initiative_Tracker.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UserController : BaseController<AppUser, AppUserDto, CreateAppUserDto, UpdateAppUserDto, int>
    {

        public UserController(DnDDbContext dbContext) : base(dbContext) { }

        protected override Expression<Func<AppUser, AppUserDto>> MapToDto() => u => new AppUserDto(
           u.Id, u.Name, u.Role == null ? null : new RoleDto(u.Role.Id, u.Role.Name)
         );

        protected override void ApplyUpdate(AppUser entity, UpdateAppUserDto dto)
        {
            entity.Name = dto.Name;
            entity.RoleId = dto.RoleId;
        }

        protected override AppUser MapToEntity(CreateAppUserDto dto) => new()
        {
            Name = dto.Name,
            RoleId = dto.RoleId,
        };

        protected override Expression<Func<AppUser, bool>> ById(int id) => u => u.Id == id;

        protected override int GetKey(AppUser entity) => entity.Id;

    }
}
