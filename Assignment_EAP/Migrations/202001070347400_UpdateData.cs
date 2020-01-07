namespace Assignment_EAP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateData : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Coins", "CreatedAt", c => c.DateTime());
            DropColumn("dbo.Coins", "CreateAt");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Coins", "CreateAt", c => c.DateTime());
            DropColumn("dbo.Coins", "CreatedAt");
        }
    }
}
