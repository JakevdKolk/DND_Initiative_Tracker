using DND_Initiative_Tracker.Models;

namespace DND_Initiative_Tracker.Models
{
    public class AppUser
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public int? RoleId { get; set; }
        public Role? Role { get; set; }

        public ICollection<CampaignUser> CampaignUsers { get; set; } = new List<CampaignUser>();
        public ICollection<Creature> OwnedCreatures { get; set; } = new List<Creature>();
    }

}