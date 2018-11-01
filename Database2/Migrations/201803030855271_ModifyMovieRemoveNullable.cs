namespace MovieBookingSytem.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class ModifyMovieRemoveNullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "ReleaseDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.MovieSchedules", "DateFrom", c => c.DateTime(nullable: false));
            AlterColumn("dbo.MovieSchedules", "DateTo", c => c.DateTime(nullable: false));
            AlterColumn("dbo.MovieSchedules", "TimeFrom", c => c.DateTime(nullable: false));
            AlterColumn("dbo.MovieSchedules", "TimeTo", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MovieSchedules", "TimeTo", c => c.DateTime());
            AlterColumn("dbo.MovieSchedules", "TimeFrom", c => c.DateTime());
            AlterColumn("dbo.MovieSchedules", "DateTo", c => c.DateTime());
            AlterColumn("dbo.MovieSchedules", "DateFrom", c => c.DateTime());
            AlterColumn("dbo.Movies", "ReleaseDate", c => c.DateTime());
        }
    }
}
