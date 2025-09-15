namespace DND_Initiative_Tracker.Contracts
{
    public class CampaignDTO
    {

        public record CampaignDto(
            int Id,
            string Name,
            string? Description,
            string? VttLink,
            string? DriveLink,
            List<MinimalAppUserDto> Users
        );

        public record CreateCampaignDto(
            string Name,
            string? Description,
            string? VttLink,
            string? DriveLink
        );
    }
}
