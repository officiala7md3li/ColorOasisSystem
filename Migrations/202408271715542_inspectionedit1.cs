namespace ColorOasisSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inspectionedit1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Quotations", "UserId", "dbo.Users");
            DropIndex("dbo.Quotations", new[] { "UserId" });
            DropColumn("dbo.Quotations", "UserId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Quotations", "UserId", c => c.Int(nullable: false));
            CreateIndex("dbo.Quotations", "UserId");
            AddForeignKey("dbo.Quotations", "UserId", "dbo.Users", "Id", cascadeDelete: true);
        }
    }
}
