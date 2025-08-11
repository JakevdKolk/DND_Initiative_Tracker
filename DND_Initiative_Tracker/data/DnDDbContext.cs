using Microsoft.EntityFrameworkCore;

namespace DND_Initiative_Tracker.data
{
    public class DnDDbContext : DbContext
    {
        public DnDDbContext(DbContextOptions<DnDDbContext> options) : base(options) { }


    }
}
