using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using SamuraiApp.Domain;

namespace SamuraiApp.Data
{
    public class SamuraiContext:DbContext
    {
        
        public SamuraiContext(DbContextOptions<SamuraiContext> options)
            : base(options)
        { }

        public DbSet<SamuraiApp.Domain.Samurai> Samurais { get; set; }
        public DbSet<Quote> Quotes { get; set; }
        public DbSet<Battle> Battles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SamuraiBattle>()
                .HasKey(s => new
                {
                    s.BattleId,
                    s.SamuraiId
                });
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Server=ZAYN-PC;Database=SamuraiAppData;User Id=sa;Password=shobuz03;");
        //}
    }
}
