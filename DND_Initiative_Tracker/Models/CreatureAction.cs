namespace DND_Initiative_Tracker.Models
{
    public class CreatureAction
    {
        public int CreatureId { get; set; }
        public Creature Creature { get; set; } = default!;

        public int ActionId { get; set; }
        public ActionEntity Action { get; set; } = default!;

        public bool? SpellPrepared { get; set; }
    }
}
