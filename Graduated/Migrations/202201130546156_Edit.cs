namespace Graduated.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Edit : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.menu_item", "CatID", "dbo.Categories");
            DropPrimaryKey("dbo.Categories");
            DropColumn("dbo.Categories", "CatID");
            AddColumn("dbo.Categories", "ID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Categories", "ID");
            AddForeignKey("dbo.menu_item", "CatID", "dbo.Categories", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            AddColumn("dbo.Categories", "CatID", c => c.Int(nullable: false, identity: true));
            DropForeignKey("dbo.menu_item", "CatID", "dbo.Categories");
            DropPrimaryKey("dbo.Categories");
            DropColumn("dbo.Categories", "ID");
            AddPrimaryKey("dbo.Categories", "CatID");
            AddForeignKey("dbo.menu_item", "CatID", "dbo.Categories", "CatID", cascadeDelete: true);
        }
    }
}
