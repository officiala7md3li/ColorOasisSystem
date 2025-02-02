namespace ColorOasisSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class QuotationModified1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Quotations", "IsPaid", c => c.Boolean(nullable: false));
            AddColumn("dbo.Quotations", "IsConverted", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Quotations", "IsConverted");
            DropColumn("dbo.Quotations", "IsPaid");
        }
    }
}
