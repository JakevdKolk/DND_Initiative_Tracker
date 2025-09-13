using static DND_Initiative_Tracker.Contracts.CampaignDTO;

namespace DND_Initiative_Tracker.Contracts
{
    public class CampaignUserDTO
    {
        public record CampaignUserDto(
            int UserId,
            int CampaignId,
            AppUserDto User,
            CampaignDto Campaign
        );
    }
}
