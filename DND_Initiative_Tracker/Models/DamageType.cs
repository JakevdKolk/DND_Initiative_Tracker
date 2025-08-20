namespace DND_Initiative_Tracker.Models
{
    public class DamageType
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public ICollection<CreatureDamageType> CreatureDamageTypes { get; set; } = new List<CreatureDamageType>();
    }
}
