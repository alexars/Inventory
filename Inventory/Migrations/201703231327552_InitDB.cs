namespace Inventory.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Name = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Name = c.String(maxLength: 50),
                        Departments_ID = c.Guid(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Departments", t => t.Departments_ID)
                .Index(t => t.Departments_ID);
            
            CreateTable(
                "dbo.EqTypes",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Name = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Models",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Name = c.String(maxLength: 50),
                        Eqtypes_ID = c.Guid(),
                        Makers_ID = c.Guid(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.EqTypes", t => t.Eqtypes_ID)
                .ForeignKey("dbo.Makers", t => t.Makers_ID)
                .Index(t => t.Eqtypes_ID)
                .Index(t => t.Makers_ID);
            
            CreateTable(
                "dbo.Makers",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Name = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Units",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        MyProperty = c.Int(nullable: false),
                        Model_ID = c.Guid(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Models", t => t.Model_ID)
                .Index(t => t.Model_ID);
            
            CreateTable(
                "dbo.Licences",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Name = c.String(maxLength: 50),
                        Description = c.String(maxLength: 150),
                        KeyValue = c.String(),
                        Units_ID = c.Guid(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Units", t => t.Units_ID)
                .Index(t => t.Units_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Units", "Model_ID", "dbo.Models");
            DropForeignKey("dbo.Licences", "Units_ID", "dbo.Units");
            DropForeignKey("dbo.Models", "Makers_ID", "dbo.Makers");
            DropForeignKey("dbo.Models", "Eqtypes_ID", "dbo.EqTypes");
            DropForeignKey("dbo.People", "Departments_ID", "dbo.Departments");
            DropIndex("dbo.Licences", new[] { "Units_ID" });
            DropIndex("dbo.Units", new[] { "Model_ID" });
            DropIndex("dbo.Models", new[] { "Makers_ID" });
            DropIndex("dbo.Models", new[] { "Eqtypes_ID" });
            DropIndex("dbo.People", new[] { "Departments_ID" });
            DropTable("dbo.Licences");
            DropTable("dbo.Units");
            DropTable("dbo.Makers");
            DropTable("dbo.Models");
            DropTable("dbo.EqTypes");
            DropTable("dbo.People");
            DropTable("dbo.Departments");
        }
    }
}
