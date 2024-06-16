namespace ColorOasisSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DBUpdate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClientPayments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClientId = c.Int(nullable: false),
                        IsCompany = c.Boolean(nullable: false),
                        Credit = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Debit = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Statement = c.String(),
                        TransactionDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Name = c.String(),
                        Phone = c.String(),
                        Address = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Name = c.String(),
                        Phone = c.String(),
                        Address = c.String(),
                        DealerId = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clients", t => t.DealerId, cascadeDelete: true)
                .Index(t => t.DealerId);
            
            CreateTable(
                "dbo.InspectionDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        InspectionId = c.Int(nullable: false),
                        ServiceId = c.Int(nullable: false),
                        ServiceName = c.String(),
                        Qty = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Inspections",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        UserId = c.Int(nullable: false),
                        DateTime = c.DateTime(nullable: false),
                        IsComapany = c.Boolean(nullable: false),
                        TypeofUnit = c.String(),
                        RoomsNo = c.String(),
                        UnitCode = c.String(),
                        POBox = c.String(),
                        AddedBy = c.String(),
                        EditedBy = c.String(),
                        DeletedBy = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Payments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClientId = c.Int(nullable: false),
                        IsCompany = c.Boolean(nullable: false),
                        Credit = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Debit = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Statement = c.String(),
                        TransactionDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.QuotationDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        QuoteId = c.Int(nullable: false),
                        ServiceId = c.Int(nullable: false),
                        Qty = c.Decimal(nullable: false, precision: 18, scale: 2),
                        UnitPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Discount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Quotations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        UserId = c.Int(nullable: false),
                        DateTime = c.DateTime(nullable: false),
                        IsComapany = c.Boolean(nullable: false),
                        TypeofUnit = c.String(),
                        RoomsNo = c.String(),
                        UnitCode = c.String(),
                        POBox = c.String(),
                        VAT = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SubTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Discount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                        AddedBy = c.String(),
                        EditedBy = c.String(),
                        DeletedBy = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Quotations", "UserId", "dbo.Users");
            DropForeignKey("dbo.Inspections", "UserId", "dbo.Users");
            DropForeignKey("dbo.Companies", "DealerId", "dbo.Clients");
            DropIndex("dbo.Quotations", new[] { "UserId" });
            DropIndex("dbo.Inspections", new[] { "UserId" });
            DropIndex("dbo.Companies", new[] { "DealerId" });
            DropTable("dbo.Quotations");
            DropTable("dbo.QuotationDetails");
            DropTable("dbo.Payments");
            DropTable("dbo.Inspections");
            DropTable("dbo.InspectionDetails");
            DropTable("dbo.Companies");
            DropTable("dbo.Clients");
            DropTable("dbo.ClientPayments");
        }
    }
}
