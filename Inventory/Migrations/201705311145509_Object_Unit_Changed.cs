namespace Inventory.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Object_Unit_Changed : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Units", "SerialNumber", c => c.String());
            AddColumn("dbo.Units", "Description", c => c.String());
            DropColumn("dbo.Units", "MyProperty");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Units", "MyProperty", c => c.Int(nullable: false));
            DropColumn("dbo.Units", "Description");
            DropColumn("dbo.Units", "SerialNumber");
        }
    }
}
