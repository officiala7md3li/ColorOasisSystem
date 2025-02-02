namespace ColorOasisSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserModification : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "UserPermissionId", c => c.Int(nullable: false));
            AddColumn("dbo.Users", "Photo", c => c.Binary());
            CreateIndex("dbo.Users", "UserPermissionId");
            AddForeignKey("dbo.Users", "UserPermissionId", "dbo.UserPermissions", "Id", cascadeDelete: false);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "UserPermissionId", "dbo.UserPermissions");
            DropIndex("dbo.Users", new[] { "UserPermissionId" });
            DropColumn("dbo.Users", "Photo");
            DropColumn("dbo.Users", "UserPermissionId");
        }
    }
}
