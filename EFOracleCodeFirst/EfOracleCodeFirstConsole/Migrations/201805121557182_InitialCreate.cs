namespace EfOracleCodeFirstConsole.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "TEST.Page",
                c => new
                    {
                        Id = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true),
                        Title = c.String(maxLength: 100),
                        Description = c.String(maxLength: 500),
                        Deneme = c.String(maxLength: 100),
                        test = c.String(maxLength: 100),
                        test4 = c.String(maxLength: 100),
                        UserId = c.Decimal(precision: 10, scale: 0),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("TEST.User", t => t.UserId)
                .Index(t => t.UserId);
            
            CreateTable(
                "TEST.User",
                c => new
                    {
                        Id = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true),
                        Name = c.String(maxLength: 100),
                        UserGroupId = c.Decimal(precision: 10, scale: 0),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("TEST.UserGroup", t => t.UserGroupId)
                .Index(t => t.UserGroupId);
            
            CreateTable(
                "TEST.UserGroup",
                c => new
                    {
                        Id = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true),
                        Name = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("TEST.User", "UserGroupId", "TEST.UserGroup");
            DropForeignKey("TEST.Page", "UserId", "TEST.User");
            DropIndex("TEST.User", new[] { "UserGroupId" });
            DropIndex("TEST.Page", new[] { "UserId" });
            DropTable("TEST.UserGroup");
            DropTable("TEST.User");
            DropTable("TEST.Page");
        }
    }
}
