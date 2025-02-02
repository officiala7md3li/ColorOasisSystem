namespace ColorOasisSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserPermission1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserPermissions", "Selection", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.UserPermissions", "Selection");
        }
    }
}
