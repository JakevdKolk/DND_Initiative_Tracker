namespace DND_Initiative_Tracker.Contracts
{
    public class CreatureTypeDTO
    {
        public record CreatureTypeDto(
             int Id,
             string Name,
             string? Description,
             List<MinimalCreatureDto> Creatures
        );

        public record MinimalCreatureTypeDto(
            int Id,
            string Name,
            string? Description
        );

        public record CreateCreatureTypeDto(
            string Name,
            string? Description
        );
    }
}
