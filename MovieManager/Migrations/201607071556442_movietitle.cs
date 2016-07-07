namespace MovieManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class movietitle : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.MovieModels", "Title", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MovieModels", "Title", c => c.String(nullable: false));
        }
    }
}
