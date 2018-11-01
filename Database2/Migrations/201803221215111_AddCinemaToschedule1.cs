namespace MovieBookingSytem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCinemaToschedule1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.MovieSchedules", "CinemaId", "dbo.Cinemas");
            DropIndex("dbo.MovieSchedules", new[] { "CinemaId" });
            AddColumn("dbo.MovieSchedules", "Cinema", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.MovieSchedules", "Cinema");
            CreateIndex("dbo.MovieSchedules", "CinemaId");
            AddForeignKey("dbo.MovieSchedules", "CinemaId", "dbo.Cinemas", "Id", cascadeDelete: true);
        }
    }
}
