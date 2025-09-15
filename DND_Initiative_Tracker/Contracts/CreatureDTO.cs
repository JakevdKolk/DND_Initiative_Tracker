

using DND_Initiative_Tracker.Models.Enums;
using static DND_Initiative_Tracker.Contracts.CreatureTypeDTO;

namespace DND_Initiative_Tracker.Contracts
{
    public record CreatureDto(
        int Id,
        string Name,
        Size? Size,
        MinimalCreatureTypeDto? Type,
        int? Ac,
        int? Hp,
        int? HpDiceCount,
        int? HpDiceSize,
        int? HpDiceBonus,
        int? LegendaryActionsCharges,
        int? ProficienyBonus,
        string? Notes,
        bool? IsNpc,
        int? LairInitiative,
        int? InitiativeBonus,
        MinimalAppUserDto? OwnerUser
    );

    public record MinimalCreatureDto(
        int Id,
        string Name
     );

    public record CreateCreatureDto(
        string Name,
        Size? Size,
        int? TypeId,
        int? Ac,
        int? Hp,
        int? HpDiceCount,
        int? HpDiceSize,
        int? HpDiceBonus,
        int? LegendaryActionsCharges,
        int? ProficienyBonus,
        string? Notes,
        bool? IsNpc,
        int? LairInitiative,
        int? InitiativeBonus,
        int? OwnerUserId
    );
}
