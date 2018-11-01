namespace MovieBookingSytem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCinemaToschedule : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.MovieSchedules", "CinemaId");
            AddForeignKey("dbo.MovieSchedules", "CinemaId", "dbo.Cinemas", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MovieSchedules", "CinemaId", "dbo.Cinemas");
            DropIndex("dbo.MovieSchedules", new[] { "CinemaId" });
        }
    }
}
