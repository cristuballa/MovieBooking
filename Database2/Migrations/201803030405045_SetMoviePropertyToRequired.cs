namespace MovieBookingSytem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetMoviePropertyToRequired : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "Title", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Movies", "Description", c => c.String(nullable: false, maxLength: 300));
            AlterColumn("dbo.Movies", "Poster", c => c.Binary(nullable: false));
            AlterColumn("dbo.Movies", "PgRating", c => c.String(nullable: false));
            AlterColumn("dbo.Movies", "Trailer", c => c.String(nullable: false));
            AlterColumn("dbo.Movies", "Director", c => c.String(nullable: false));
            AlterColumn("dbo.Movies", "Casts", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "Casts", c => c.String());
            AlterColumn("dbo.Movies", "Director", c => c.String());
            AlterColumn("dbo.Movies", "Trailer", c => c.String());
            AlterColumn("dbo.Movies", "PgRating", c => c.String());
            AlterColumn("dbo.Movies", "Poster", c => c.Binary());
            AlterColumn("dbo.Movies", "Description", c => c.String(maxLength: 300));
            AlterColumn("dbo.Movies", "Title", c => c.String(maxLength: 100));
        }
    }
}
