namespace MovieBookingSytem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MovieScheduleDateFromAdded : DbMigration
    {
        public override void Up()
        {
          //  AddColumn("dbo.MovieSchedules", "DateFrom", c => c.DateTime());
        }
        
        public override void Down()
        {
           // DropColumn("dbo.MovieSchedules", "DateFrom");
        }
    }
}
