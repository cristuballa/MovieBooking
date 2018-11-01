namespace MovieBookingSytem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyMoviePropertyPosterRequired : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "Poster", c => c.Binary(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "Poster", c => c.Binary());
        }
    }
}
