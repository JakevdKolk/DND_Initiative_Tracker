using DND_Initiative_Tracker.Models;

namespace DND_Initiative_Tracker.Models
{
    public class Campaign
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public string? VttLink { get; set; }
        public string? DriveLink { get; set; }

        public ICollection<CampaignUser> CampaignUsers { get; set; } = new List<CampaignUser>();
        public ICollection<Encounter> Encounters { get; set; } = new List<Encounter>();
    }

}