namespace ColorOasisSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ColorOasisDB1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ServiceCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Photo = c.Binary(storeType: "image"),
                        Name = c.String(),
                        MinimumPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MaximumPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Barcode = c.String(),
                        Dicount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ServiceTypeId = c.Int(nullable: false),
                        ServiceCategoryId = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ServiceCategories", t => t.ServiceCategoryId, cascadeDelete: true)
                .ForeignKey("dbo.ServiceTypes", t => t.ServiceTypeId, cascadeDelete: true)
                .Index(t => t.ServiceTypeId)
                .Index(t => t.ServiceCategoryId);
            
            CreateTable(
                "dbo.ServiceTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Services", "ServiceTypeId", "dbo.ServiceTypes");
            DropForeignKey("dbo.Services", "ServiceCategoryId", "dbo.ServiceCategories");
            DropIndex("dbo.Services", new[] { "ServiceCategoryId" });
            DropIndex("dbo.Services", new[] { "ServiceTypeId" });
            DropTable("dbo.ServiceTypes");
            DropTable("dbo.Services");
            DropTable("dbo.ServiceCategories");
        }
    }
}
