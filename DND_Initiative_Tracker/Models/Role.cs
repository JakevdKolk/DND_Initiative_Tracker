using System.Text.Json.Serialization;

namespace DND_Initiative_Tracker.Models
{

    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        [JsonIgnore]
        public ICollection<AppUser> AppUsers { get; set; } = new List<AppUser>();
    }
}