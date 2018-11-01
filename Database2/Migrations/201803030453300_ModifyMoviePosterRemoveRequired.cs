namespace MovieBookingSytem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyMoviePosterRemoveRequired : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cinemas", "Name", c => c.String(nullable: false, maxLength: 150));
            AlterColumn("dbo.Cinemas", "Address", c => c.String(nullable: false, maxLength: 300));
            AlterColumn("dbo.Cinemas", "Contact", c => c.String(nullable: false, maxLength: 10));
            AlterColumn("dbo.Movies", "Poster", c => c.Binary());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "Poster", c => c.Binary(nullable: false));
            AlterColumn("dbo.Cinemas", "Contact", c => c.String(maxLength: 100));
            AlterColumn("dbo.Cinemas", "Address", c => c.String(maxLength: 300));
            AlterColumn("dbo.Cinemas", "Name", c => c.String(maxLength: 150));
        }
    }
}
