namespace MovieBookingSytem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLisfOfMovieSchedule : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.MovieSchedules", "MovieId");
            AddForeignKey("dbo.MovieSchedules", "MovieId", "dbo.Movies", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MovieSchedules", "MovieId", "dbo.Movies");
            DropIndex("dbo.MovieSchedules", new[] { "MovieId" });
        }
    }
}
