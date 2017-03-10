using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using DomainClasses;


namespace DataLayer
{
  public class TwitterContext : DbContext
  {
       public TwitterContext() : base(@"Data Source = SHAPLA-PC\SQLEXPRESS; Initial Catalog = TwitterDB; Integrated Security = true")
       {
       }
      public TwitterContext(string connectionString) : base(connectionString)
      {
      }

    public DbSet<Alias> Aliases { get; set; }
    public DbSet<Tweet> Tweets { get; set; }
    public DbSet<TwitterRevenue> TeRevenues { get; set; }
    }
}
