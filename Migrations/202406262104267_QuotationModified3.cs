namespace ColorOasisSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class QuotationModified3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Services", "Discount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.Services", "Dicount");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Services", "Dicount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.Services", "Discount");
        }
    }
}
