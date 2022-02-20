namespace Graduated.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class editCat : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Categories", "Cat", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Categories", "Cat", c => c.String(maxLength: 50));
        }
    }
}
