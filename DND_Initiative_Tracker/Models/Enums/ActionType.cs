namespace DND_Initiative_Tracker.Models.Enums
{
    using NpgsqlTypes;

    public enum ActionType
    {
        [PgName("action")] Action,
        [PgName("bonus_action")] BonusAction,
        [PgName("reaction")] Reaction,
        [PgName("trait")] Trait,
        [PgName("legendary_action")] LegendaryAction,
        [PgName("lair_action")] LairAction,
        [PgName("mythical_action")] MythicalAction
    }
}
