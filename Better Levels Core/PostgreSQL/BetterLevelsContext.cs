using Better_Levels_Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Better_Levels_Core.PostgreSQL
{
    public class BetterLevelsContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Reward> Rewards { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("CONNECTION_STRING");
    }
}
