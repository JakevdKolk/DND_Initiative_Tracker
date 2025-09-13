using DND_Initiative_Tracker.Contracts;
using DND_Initiative_Tracker.Data;
using DND_Initiative_Tracker.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;
using static DND_Initiative_Tracker.Contracts.CreatureTypeDTO;

namespace DND_Initiative_Tracker.Controllers
{
    [ApiController]
    [Route("/api/creaturetypes")]
    public class CreatureTypeController : BaseController<CreatureType, CreatureTypeDto, CreateCreatureTypeDto, int>
    {

        public CreatureTypeController (DnDDbContext context) : base(context) { }
        protected override void ApplyUpdate(CreatureType entity, CreateCreatureTypeDto dto)
        {
            entity.Name = dto.Name;
            entity.Description = dto.Description;
        }
        protected override Expression<Func<CreatureType, bool>> ById(int id) => u => u.Id == id;

        protected override int GetKey(CreatureType entity) => entity.Id;

        protected override Expression<Func<CreatureType, CreatureTypeDto>> MapToDto() => u => new CreatureTypeDto(
                u.Id, u.Name, u.Description, 
                u.Creatures.Select(c => new MinimalCreatureDto(c.Id, c.Name)).ToList()
        );

        protected override CreatureType MapToEntity(CreateCreatureTypeDto dto) => new()
        {
            Name = dto.Name,
            Description = dto.Description,
        };
    }
}
