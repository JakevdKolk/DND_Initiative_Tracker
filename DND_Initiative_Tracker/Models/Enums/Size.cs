namespace DND_Initiative_Tracker.Models.Enums
{
    using NpgsqlTypes;

    public enum Size
    {
        // Your SQL had capitalized labels here; keep that mapping.
        [PgName("Tiny")] Tiny,
        [PgName("Small")] Small,
        [PgName("Medium")] Medium,
        [PgName("Large")] Large,
        [PgName("Huge")] Huge,
        [PgName("Gargantuan")] Gargantuan
    }
}
