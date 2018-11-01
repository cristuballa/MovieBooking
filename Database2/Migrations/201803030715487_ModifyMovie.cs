namespace MovieBookingSytem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyMovie : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "Poster", c => c.Binary());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "Poster", c => c.Binary(nullable: false));
        }
    }
}
