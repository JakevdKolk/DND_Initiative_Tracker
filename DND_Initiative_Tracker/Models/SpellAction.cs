namespace DND_Initiative_Tracker.Models
{

    public class SpellAction
    {
        public int SpellId { get; set; }
        public Spell Spell { get; set; } = default!;

        public int ActionId { get; set; }
        public ActionEntity Action { get; set; } = default!;
    }

}
