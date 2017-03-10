namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Edit2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Aliases", "NewProp");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Aliases", "NewProp", c => c.String());
        }
    }
}
