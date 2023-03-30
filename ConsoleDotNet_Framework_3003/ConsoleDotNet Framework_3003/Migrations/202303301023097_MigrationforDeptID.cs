namespace ConsoleDotNet_Framework_3003.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrationforDeptID : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "DeptID", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "DeptID");
        }
    }
}
