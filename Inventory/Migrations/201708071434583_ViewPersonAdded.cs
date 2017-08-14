namespace Inventory.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ViewPersonAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.View_PeopleDepartments",
                c => new
                    {
                        PersonID = c.Guid(nullable: false),
                        Name = c.String(),
                        Expr1 = c.String(),
                    })
                .PrimaryKey(t => t.PersonID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.View_PeopleDepartments");
        }
    }
}
