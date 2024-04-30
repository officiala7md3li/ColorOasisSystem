namespace ColorOasisSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ColorOasisDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserPermissions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        PermissionOfUser_Lock = c.Boolean(nullable: false),
                        PermissionOfUser_AddNew = c.Boolean(nullable: false),
                        PermissionOfUser_Edit = c.Boolean(nullable: false),
                        PermissionOfUser_Delete = c.Boolean(nullable: false),
                        PermissionOfUser_Retrive = c.Boolean(nullable: false),
                        PermissionOfPermission_Lock = c.Boolean(nullable: false),
                        PermissionOfPermission_AddNew = c.Boolean(nullable: false),
                        PermissionOfPermission_Edit = c.Boolean(nullable: false),
                        PermissionOfPermission_Delete = c.Boolean(nullable: false),
                        PermissionOfPermission_Retrive = c.Boolean(nullable: false),
                        IsAdmin = c.Boolean(nullable: false),
                        IsLocked = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(maxLength: 20),
                        Name = c.String(maxLength: 30),
                        RecoverWord = c.String(),
                        Position = c.String(),
                        Phone = c.String(maxLength: 11),
                        BranchID = c.Int(nullable: false),
                        UserPermissionId = c.Int(nullable: false),
                        Password = c.String(),
                        Photo = c.Binary(storeType: "image"),
                        IsActive = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UserPermissions", t => t.UserPermissionId, cascadeDelete: true)
                .Index(t => t.UserName, unique: true)
                .Index(t => t.UserPermissionId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "UserPermissionId", "dbo.UserPermissions");
            DropIndex("dbo.Users", new[] { "UserPermissionId" });
            DropIndex("dbo.Users", new[] { "UserName" });
            DropTable("dbo.Users");
            DropTable("dbo.UserPermissions");
        }
    }
}
