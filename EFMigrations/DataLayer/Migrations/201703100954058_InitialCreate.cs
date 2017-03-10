namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Aliases",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Experience = c.String(maxLength: 10),
                        Rating = c.Int(nullable: false),
                        UserName = c.String(maxLength: 30),
                        Email = c.String(),
                        Bio = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        Avatar = c.Binary(),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tweets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CreateDate = c.DateTime(nullable: false),
                        Content = c.String(),
                        AliasId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Aliases", t => t.AliasId, cascadeDelete: true)
                .Index(t => t.AliasId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tweets", "AliasId", "dbo.Aliases");
            DropIndex("dbo.Tweets", new[] { "AliasId" });
            DropTable("dbo.Tweets");
            DropTable("dbo.Aliases");
        }
    }
}
