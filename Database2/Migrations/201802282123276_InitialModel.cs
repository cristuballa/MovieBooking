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
                        Name = c.String(maxLength: 150),
                        Address = c.String(maxLength: 300),
                        Contact = c.String(maxLength: 100),
                        NoOfSeats = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(maxLength: 100),
                        Description = c.String(maxLength: 300),
                        Poster = c.Binary(),
                        ReleaseDate = c.DateTime(),
                        Genre = c.Int(nullable: false),
                        ImdbRating = c.Single(nullable: false),
                        RottenTomatoesRating = c.Single(nullable: false),
                        PgRating = c.String(),
                        Trailer = c.String(),
                        Director = c.String(),
                        Casts = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MovieSchedules",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MovieId = c.Int(nullable: false),
                        CinemaId = c.Int(nullable: false),
                        DateTo = c.DateTime(),
                        TimeFrom = c.DateTime(),
                        TimeTo = c.DateTime(),
                        Price = c.Single(nullable: false),
                        RowLetter = c.String(),
                        SeatPerRow = c.Int(nullable: false),
                        TakenSeats = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MovieSchedules");
            DropTable("dbo.Movies");
            DropTable("dbo.Cinemas");
        }
    }
}
