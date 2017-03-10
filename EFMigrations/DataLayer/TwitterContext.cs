using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using DomainClasses;


namespace DataLayer
{
  public class TwitterContext : DbContext
  {
    public DbSet<Alias> Aliases { get; set; }
    public DbSet<Tweet> Tweets { get; set; }
  }
}
