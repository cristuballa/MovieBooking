namespace MovieBookingSytem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addWAtch3 : DbMigration
    {
        public override void Up()
        {
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
            DropTable("dbo.Watchlists");
        }
    }
}
