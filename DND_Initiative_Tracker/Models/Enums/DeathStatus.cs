namespace DND_Initiative_Tracker.Models.Enums
{
    using NpgsqlTypes;

    public enum DeathStatus
    {
        [PgName("stable")] Stable,
        [PgName("alive")] Alive,
        [PgName("dying")] Dying,
        [PgName("dead")] Dead
    }
}
