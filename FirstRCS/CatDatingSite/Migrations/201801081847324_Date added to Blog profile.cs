namespace CatDatingSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DateaddedtoBlogprofile : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Blogs", "Blogemail", c => c.String(nullable: false));
            AddColumn("dbo.Blogs", "BlogCreated", c => c.DateTime(nullable: false));
            AddColumn("dbo.Blogs", "BlogEdited", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Blogs", "BlogEdited");
            DropColumn("dbo.Blogs", "BlogCreated");
            DropColumn("dbo.Blogs", "Blogemail");
        }
    }
}
