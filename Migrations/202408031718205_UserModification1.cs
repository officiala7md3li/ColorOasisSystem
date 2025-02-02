namespace ColorOasisSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserModification1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "NameEn", c => c.String(maxLength: 30));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "NameEn");
        }
    }
}
