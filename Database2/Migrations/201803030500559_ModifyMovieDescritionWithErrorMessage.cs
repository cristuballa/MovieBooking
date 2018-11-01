namespace MovieBookingSytem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyMovieDescritionWithErrorMessage : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.MovieSchedules", "RowLetter", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MovieSchedules", "RowLetter", c => c.String());
        }
    }
}
