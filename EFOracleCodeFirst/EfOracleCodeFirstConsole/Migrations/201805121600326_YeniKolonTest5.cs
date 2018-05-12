namespace EfOracleCodeFirstConsole.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class YeniKolonTest5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("TEST.Page", "Test5", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            DropColumn("TEST.Page", "Test5");
        }
    }
}
