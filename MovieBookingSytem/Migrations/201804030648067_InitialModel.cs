namespace MovieBookingSytem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cinemas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 150),
                        Address = c.String(nullable: false, maxLength: 300),
                        Contact = c.String(nullable: false, maxLength: 10),
                        NoOfSeats = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 100),
                        Description = c.String(nullable: false, maxLength: 300),
                        Poster = c.Binary(),
                        ReleaseDate = c.DateTime(nullable: false),
                        Genre = c.Int(nullable: false),
                        ImdbRating = c.Single(nullable: false),
                        RottenTomatoesRating = c.Single(nullable: false),
                        PgRating = c.String(nullable: false),
                        Trailer = c.String(nullable: false),
                        Director = c.String(nullable: false),
                        Casts = c.String(nullable: false),
                        Duration = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MovieSchedules",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MovieId = c.Int(nullable: false),
                        CinemaId = c.Int(nullable: false),
                        DateFrom = c.DateTime(nullable: false),
                        DateTo = c.DateTime(nullable: false),
                        TimeFrom = c.DateTime(nullable: false),
                        TimeTo = c.DateTime(nullable: false),
                        Price = c.Single(nullable: false),
                        RowLetter = c.String(nullable: false),
                        SeatPerRow = c.Int(nullable: false),
                        TakenSeats = c.String(),
                        Cinema = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Movies", t => t.MovieId, cascadeDelete: true)
                .Index(t => t.MovieId);
            
            CreateTable(
                "dbo.Watchlists",
                c => new
                    {
                        WatchlistId = c.Int(nullable: false, identity: true),
                        MovieId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.WatchlistId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MovieSchedules", "MovieId", "dbo.Movies");
            DropIndex("dbo.MovieSchedules", new[] { "MovieId" });
            DropTable("dbo.Watchlists");
            DropTable("dbo.MovieSchedules");
            DropTable("dbo.Movies");
            DropTable("dbo.Cinemas");
        }
    }
}
