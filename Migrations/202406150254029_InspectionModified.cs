namespace ColorOasisSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InspectionModified : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.InspectionDetails", "MinimumPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.InspectionDetails", "MaximumPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.InspectionDetails", "Discount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.InspectionDetails", "UnitPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.InspectionDetails", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.InspectionDetails", "CategoryId", c => c.Int(nullable: false));
            AddColumn("dbo.InspectionDetails", "TypeId", c => c.Int(nullable: false));
            AddColumn("dbo.Inspections", "ClientType", c => c.Int(nullable: false));
            AddColumn("dbo.Inspections", "ClientId", c => c.Int(nullable: false));
            AddColumn("dbo.Inspections", "ClientName", c => c.String());
            AddColumn("dbo.Inspections", "ClientLocation", c => c.String());
            AddColumn("dbo.Inspections", "ClientPhoneNo", c => c.String());
            AddColumn("dbo.Inspections", "ClientTRN", c => c.String());
            AddColumn("dbo.Inspections", "IsValid", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Inspections", "TypeofUnit", c => c.Int(nullable: false));
            AlterColumn("dbo.Inspections", "RoomsNo", c => c.Int(nullable: false));
            CreateIndex("dbo.InspectionDetails", "CategoryId");
            CreateIndex("dbo.InspectionDetails", "TypeId");
            AddForeignKey("dbo.InspectionDetails", "CategoryId", "dbo.ServiceCategories", "Id", cascadeDelete: true);
            AddForeignKey("dbo.InspectionDetails", "TypeId", "dbo.ServiceTypes", "Id", cascadeDelete: true);
            DropColumn("dbo.Inspections", "IsComapany");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Inspections", "IsComapany", c => c.Boolean(nullable: false));
            DropForeignKey("dbo.InspectionDetails", "TypeId", "dbo.ServiceTypes");
            DropForeignKey("dbo.InspectionDetails", "CategoryId", "dbo.ServiceCategories");
            DropIndex("dbo.InspectionDetails", new[] { "TypeId" });
            DropIndex("dbo.InspectionDetails", new[] { "CategoryId" });
            AlterColumn("dbo.Inspections", "RoomsNo", c => c.String());
            AlterColumn("dbo.Inspections", "TypeofUnit", c => c.String());
            DropColumn("dbo.Inspections", "IsValid");
            DropColumn("dbo.Inspections", "ClientTRN");
            DropColumn("dbo.Inspections", "ClientPhoneNo");
            DropColumn("dbo.Inspections", "ClientLocation");
            DropColumn("dbo.Inspections", "ClientName");
            DropColumn("dbo.Inspections", "ClientId");
            DropColumn("dbo.Inspections", "ClientType");
            DropColumn("dbo.InspectionDetails", "TypeId");
            DropColumn("dbo.InspectionDetails", "CategoryId");
            DropColumn("dbo.InspectionDetails", "Price");
            DropColumn("dbo.InspectionDetails", "UnitPrice");
            DropColumn("dbo.InspectionDetails", "Discount");
            DropColumn("dbo.InspectionDetails", "MaximumPrice");
            DropColumn("dbo.InspectionDetails", "MinimumPrice");
        }
    }
}
