namespace ColorOasisSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inspectionedit : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Inspections", "UserId", "dbo.Users");
            DropIndex("dbo.Inspections", new[] { "UserId" });
            DropColumn("dbo.Inspections", "UserId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Inspections", "UserId", c => c.Int(nullable: false));
            CreateIndex("dbo.Inspections", "UserId");
            AddForeignKey("dbo.Inspections", "UserId", "dbo.Users", "Id", cascadeDelete: true);
        }
    }
}
