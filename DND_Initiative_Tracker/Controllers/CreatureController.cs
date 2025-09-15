using DND_Initiative_Tracker.Contracts;
using DND_Initiative_Tracker.Data;
using DND_Initiative_Tracker.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;
using static DND_Initiative_Tracker.Contracts.CreatureTypeDTO;

namespace DND_Initiative_Tracker.Controllers
{

    [ApiController]
    [Route("api/creatures")]
    public class CreatureController : BaseController<Creature, CreatureDto, CreateCreatureDto, int>
    {
        public CreatureController(DnDDbContext context) : base(context) { }

        protected override Expression<Func<Creature, CreatureDto>> MapToDto() => u => new CreatureDto(
              u.Id, u.Name, u.Size,
              u.Type == null ? null : new MinimalCreatureTypeDto(u.Type.Id, u.Type.Name, u.Type.Description),
              u.Ac, u.Hp, u.HpDiceCount, u.HpDiceSize, u.HpDiceBonus,
              u.LegendaryActionCharges, u.ProficiencyBonus, u.Notes, u.IsNpc, u.LairInitiative, u.InitiativeBonus,
              u.OwnerUser == null ? null : new MinimalAppUserDto(u.OwnerUser.Id, u.OwnerUser.Name)
        );

        protected override void ApplyUpdate(Creature e, CreateCreatureDto dto)
        {
            e.Name = dto.Name;
            e.Size = dto.Size;
            e.TypeId = dto.TypeId;
            e.Ac = dto.Ac;
            e.Hp = dto.Hp;
            e.HpDiceCount = dto.HpDiceCount;
            e.HpDiceSize = dto.HpDiceSize;
            e.HpDiceBonus = dto.HpDiceBonus;
            e.LegendaryActionCharges = dto.LegendaryActionsCharges;
            e.ProficiencyBonus = dto.ProficienyBonus;
            e.Notes = dto.Notes;
            e.IsNpc = dto.IsNpc;
            e.LairInitiative = dto.LairInitiative;
            e.InitiativeBonus = dto.InitiativeBonus;
            e.OwnerUserId = dto.OwnerUserId;
        }

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

        protected override int GetKey(Creature entity) => entity.Id;
    }
}
