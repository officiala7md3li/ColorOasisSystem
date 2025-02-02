namespace ColorOasisSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class QuotationModified : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Quotations", "ClientType", c => c.Int(nullable: false));
            AddColumn("dbo.Quotations", "ClientId", c => c.Int(nullable: false));
            AddColumn("dbo.Quotations", "ClientName", c => c.String());
            AddColumn("dbo.Quotations", "ClientLocation", c => c.String());
            AddColumn("dbo.Quotations", "ClientPhoneNo", c => c.String());
            AddColumn("dbo.Quotations", "ClientTRN", c => c.String());
            AddColumn("dbo.Quotations", "Paid", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Quotations", "Remain", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Quotations", "IsValid", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Quotations", "IsValid");
            DropColumn("dbo.Quotations", "Remain");
            DropColumn("dbo.Quotations", "Paid");
            DropColumn("dbo.Quotations", "ClientTRN");
            DropColumn("dbo.Quotations", "ClientPhoneNo");
            DropColumn("dbo.Quotations", "ClientLocation");
            DropColumn("dbo.Quotations", "ClientName");
            DropColumn("dbo.Quotations", "ClientId");
            DropColumn("dbo.Quotations", "ClientType");
        }
    }
}
