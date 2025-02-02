namespace ColorOasisSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addEnglishNameproperties : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clients", "NameEn", c => c.String());
            AddColumn("dbo.Companies", "NameEn", c => c.String());
            AddColumn("dbo.Companies", "CompanyTRN", c => c.String());
            AddColumn("dbo.ServiceCategories", "NameEn", c => c.String());
            AddColumn("dbo.ServiceTypes", "NameEn", c => c.String());
            AddColumn("dbo.Services", "NameEn", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Services", "NameEn");
            DropColumn("dbo.ServiceTypes", "NameEn");
            DropColumn("dbo.ServiceCategories", "NameEn");
            DropColumn("dbo.Companies", "CompanyTRN");
            DropColumn("dbo.Companies", "NameEn");
            DropColumn("dbo.Clients", "NameEn");
        }
    }
}
