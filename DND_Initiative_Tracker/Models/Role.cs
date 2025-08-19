namespace DND_Initiative_Tracker.Models
{

    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public ICollection<AppUser> Users { get; set; } = new List<AppUser>();
    }
}