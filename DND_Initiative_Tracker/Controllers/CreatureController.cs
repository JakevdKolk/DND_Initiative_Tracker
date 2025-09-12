using DND_Initiative_Tracker.Contracts;
using DND_Initiative_Tracker.Data;
using DND_Initiative_Tracker.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;

namespace DND_Initiative_Tracker.Controllers
{

    [ApiController]
    [Route("api/creatures")]
    public class CreatureController : BaseController<Creature, CreatureDto, CreateCreatureDto, int>
    {
        public CreatureController(DnDDbContext context) : base(context) { }

        protected override Expression<Func<Creature, CreatureDto>> MapToDto() => u => new(
              u.Id, u.Name, u.Size, u.TypeId, u.Ac, u.Hp, u.HpDiceCount, u.HpDiceSize, u.HpDiceBonus,
              u.LegendaryActionCharges, u.ProficiencyBonus, u.Notes, u.IsNpc, u.LairInitiative, u.InitiativeBonus, u.OwnerUserId
        );

        protected override Creature MapToEntity(CreateCreatureDto dto) => new()
        {
            Name = dto.Name,
            Size = dto.Size,
            TypeId = dto.TypeId,
            Ac = dto.Ac,
            Hp = dto.Hp,
            HpDiceCount = dto.HpDiceCount,
            HpDiceSize = dto.HpDiceSize,
            HpDiceBonus = dto.HpDiceBonus,
            LegendaryActionCharges = dto.LegendaryActionsCharges,
            ProficiencyBonus = dto.ProficienyBonus,
            Notes = dto.Notes,
            IsNpc = dto.IsNpc,
            LairInitiative = dto.LairInitiative,
            InitiativeBonus = dto.InitiativeBonus,
            OwnerUserId = dto.OwnerUserId
        };

        protected override Expression<Func<Creature, bool>> ById(int id) => u => u.Id == id;
    }
}
