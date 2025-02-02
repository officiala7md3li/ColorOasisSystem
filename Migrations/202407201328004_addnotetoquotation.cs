namespace ColorOasisSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addnotetoquotation : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Quotations", "Note", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Quotations", "Note");
        }
    }
}
