namespace MovieManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GenreMod : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Genres", "GenreType", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Genres", "GenreType", c => c.String(maxLength: 255));
        }
    }
}
