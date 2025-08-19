namespace DND_Initiative_Tracker.Models.Enums
{
    using NpgsqlTypes;

    public enum SkillType
    {
        [PgName("skill")] Skill,
        [PgName("tool")] Tool,
        [PgName("instrument")] Instrument
    }

}
