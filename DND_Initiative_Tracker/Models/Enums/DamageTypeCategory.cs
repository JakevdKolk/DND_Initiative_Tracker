namespace DND_Initiative_Tracker.Models.Enums
{
    using NpgsqlTypes;

    public enum DamageTypeCategory
    {
        [PgName("resistant")] Resistant,
        [PgName("vulnerable")] Vulnerable,
        [PgName("immune")] Immune,
        [PgName("none")] None
    }
}
