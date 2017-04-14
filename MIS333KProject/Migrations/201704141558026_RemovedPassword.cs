namespace MIS333KProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedPassword : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Phone", c => c.String(nullable: false));
            AddColumn("dbo.Employees", "Phone", c => c.String(nullable: false));
            DropColumn("dbo.Customers", "phoneNumber");
            DropColumn("dbo.Customers", "UserId");
            DropColumn("dbo.Employees", "EmpType");
            DropColumn("dbo.Employees", "phoneNumber");
            DropColumn("dbo.Employees", "UserId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "UserId", c => c.String());
            AddColumn("dbo.Employees", "phoneNumber", c => c.String(nullable: false));
            AddColumn("dbo.Employees", "EmpType", c => c.Int(nullable: false));
            AddColumn("dbo.Customers", "UserId", c => c.String());
            AddColumn("dbo.Customers", "phoneNumber", c => c.String(nullable: false));
            DropColumn("dbo.Employees", "Phone");
            DropColumn("dbo.Customers", "Phone");
        }
    }
}
