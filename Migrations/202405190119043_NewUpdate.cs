namespace ColorOasisSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewUpdate : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Users", "UserPermissionId", "dbo.UserPermissions");
            DropIndex("dbo.Users", new[] { "UserPermissionId" });
            DropColumn("dbo.Users", "Position");
            DropColumn("dbo.Users", "BranchID");
            DropColumn("dbo.Users", "UserPermissionId");
            DropColumn("dbo.Users", "Photo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "Photo", c => c.Binary(storeType: "image"));
            AddColumn("dbo.Users", "UserPermissionId", c => c.Int(nullable: false));
            AddColumn("dbo.Users", "BranchID", c => c.Int(nullable: false));
            AddColumn("dbo.Users", "Position", c => c.String());
            CreateIndex("dbo.Users", "UserPermissionId");
            AddForeignKey("dbo.Users", "UserPermissionId", "dbo.UserPermissions", "Id", cascadeDelete: true);
        }
    }
}
