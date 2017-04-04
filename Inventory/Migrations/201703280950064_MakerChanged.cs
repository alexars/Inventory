namespace Inventory.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MakerChanged : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Makers", "Name", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Makers", "Name", c => c.String(maxLength: 50));
        }
    }
}
