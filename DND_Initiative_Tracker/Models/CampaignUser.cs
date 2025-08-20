namespace DND_Initiative_Tracker.Models
{

    public class CampaignUser
    {
        public int CampaignId { get; set; }
        public Campaign Campaign { get; set; } = default!;

        public int UserId { get; set; }
        public AppUser User { get; set; } = default!;
    }

}