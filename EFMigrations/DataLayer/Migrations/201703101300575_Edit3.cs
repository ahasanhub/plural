namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Edit3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Aliases", "NewProp", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Aliases", "NewProp");
        }
    }
}
