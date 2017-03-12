using NinjaDomain.Classes;
using System.Data.Entity;

namespace NinjaDomain.DataModel
{
    public class NinjaContext:DbContext
    {
        public NinjaContext() : base(@"Server = (localdb)\v11.0; Integrated Security = true; Initial Catalog =NinjaDataModel;")
        {

        }
        public NinjaContext(string connectionString) : base(connectionString)
        {

        }
        public DbSet<Ninja> Ninjas { get; set; }
        public DbSet<Clan> Clans { get; set; }
        public DbSet<NinjaEquipment> Equipment { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Types().Configure(c=>c.Ignore("IsDirty"));
            base.OnModelCreating(modelBuilder);
        }
    }
}
