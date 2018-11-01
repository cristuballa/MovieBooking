namespace MovieBookingSytem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetMoviePropertyToRequired1 : DbMigration
    {
        public override void Up()
        {
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
        }
    }
}
