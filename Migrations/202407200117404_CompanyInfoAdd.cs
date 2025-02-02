namespace ColorOasisSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CompanyInfoAdd : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CompanyInfoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CompanyTRN = c.String(),
                        Address = c.String(),
                        PhoneNumber = c.String(),
                        ManagerPhoneNumber = c.String(),
                        CompanyAccountIban = c.String(),
                        CompanyAccountHolder = c.String(),
                        BIC = c.String(),
                        BusinessAddress = c.String(),
                        Currency = c.String(),
                        CurrencyAr = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.QuotationDetails", "TotalDiscount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Quotations", "InspectionId", c => c.Int(nullable: false));
            CreateIndex("dbo.Quotations", "InspectionId");
            AddForeignKey("dbo.Quotations", "InspectionId", "dbo.Inspections", "Id", cascadeDelete: false);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Quotations", "InspectionId", "dbo.Inspections");
            DropIndex("dbo.Quotations", new[] { "InspectionId" });
            DropColumn("dbo.Quotations", "InspectionId");
            DropColumn("dbo.QuotationDetails", "TotalDiscount");
            DropTable("dbo.CompanyInfoes");
        }
    }
}
