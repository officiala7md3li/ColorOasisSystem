namespace ColorOasisSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserPermission2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserPermissions", "NameEn", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.UserPermissions", "NameEn");
        }
    }
}
