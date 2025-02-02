namespace ColorOasisSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class QuotationModified2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.QuotationDetails", "ServiceName", c => c.String());
            AddColumn("dbo.QuotationDetails", "MinimumPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.QuotationDetails", "MaximumPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.QuotationDetails", "CategoryId", c => c.Int(nullable: false));
            AddColumn("dbo.QuotationDetails", "TypeId", c => c.Int(nullable: false));
            AlterColumn("dbo.Quotations", "TypeofUnit", c => c.Int(nullable: false));
            AlterColumn("dbo.Quotations", "RoomsNo", c => c.Int(nullable: false));
            CreateIndex("dbo.QuotationDetails", "CategoryId");
            CreateIndex("dbo.QuotationDetails", "TypeId");
            AddForeignKey("dbo.QuotationDetails", "CategoryId", "dbo.ServiceCategories", "Id", cascadeDelete: true);
            AddForeignKey("dbo.QuotationDetails", "TypeId", "dbo.ServiceTypes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.QuotationDetails", "TypeId", "dbo.ServiceTypes");
            DropForeignKey("dbo.QuotationDetails", "CategoryId", "dbo.ServiceCategories");
            DropIndex("dbo.QuotationDetails", new[] { "TypeId" });
            DropIndex("dbo.QuotationDetails", new[] { "CategoryId" });
            AlterColumn("dbo.Quotations", "RoomsNo", c => c.String());
            AlterColumn("dbo.Quotations", "TypeofUnit", c => c.String());
            DropColumn("dbo.QuotationDetails", "TypeId");
            DropColumn("dbo.QuotationDetails", "CategoryId");
            DropColumn("dbo.QuotationDetails", "MaximumPrice");
            DropColumn("dbo.QuotationDetails", "MinimumPrice");
            DropColumn("dbo.QuotationDetails", "ServiceName");
        }
    }
}
