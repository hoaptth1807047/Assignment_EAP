namespace Assignment_EAP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddData : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Coins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        BaseAsset = c.String(nullable: false),
                        QuoteAsset = c.String(nullable: false),
                        LastPrice = c.Int(nullable: false),
                        Volumn24h = c.Double(nullable: false),
                        MarketId = c.Int(nullable: false),
                        CreateAt = c.DateTime(),
                        UpdatedAt = c.DateTime(),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Markets", t => t.MarketId, cascadeDelete: true)
                .Index(t => t.MarketId);
            
            CreateTable(
                "dbo.Markets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        CreatedAt = c.DateTime(),
                        UpdatedAt = c.DateTime(),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Coins", "MarketId", "dbo.Markets");
            DropIndex("dbo.Coins", new[] { "MarketId" });
            DropTable("dbo.Markets");
            DropTable("dbo.Coins");
        }
    }
}
