namespace ConsoleDotNet_Framework_3003.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrationforRoles : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "roles", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "roles");
        }
    }
}
