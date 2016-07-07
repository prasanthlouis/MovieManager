namespace MovieManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedConventions : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.MovieModels", "GenreType_Id", "dbo.Genres");
            DropIndex("dbo.MovieModels", new[] { "GenreType_Id" });
            AddColumn("dbo.MovieModels", "MovieUser_Id", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Genres", "GenreType", c => c.String(maxLength: 255));
            AlterColumn("dbo.MovieModels", "Title", c => c.String(nullable: false));
            AlterColumn("dbo.MovieModels", "GenreType_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.MovieModels", "GenreType_Id");
            CreateIndex("dbo.MovieModels", "MovieUser_Id");
            AddForeignKey("dbo.MovieModels", "MovieUser_Id", "dbo.AspNetUsers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.MovieModels", "GenreType_Id", "dbo.Genres", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MovieModels", "GenreType_Id", "dbo.Genres");
            DropForeignKey("dbo.MovieModels", "MovieUser_Id", "dbo.AspNetUsers");
            DropIndex("dbo.MovieModels", new[] { "MovieUser_Id" });
            DropIndex("dbo.MovieModels", new[] { "GenreType_Id" });
            AlterColumn("dbo.MovieModels", "GenreType_Id", c => c.Int());
            AlterColumn("dbo.MovieModels", "Title", c => c.String());
            AlterColumn("dbo.Genres", "GenreType", c => c.String());
            DropColumn("dbo.MovieModels", "MovieUser_Id");
            CreateIndex("dbo.MovieModels", "GenreType_Id");
            AddForeignKey("dbo.MovieModels", "GenreType_Id", "dbo.Genres", "Id");
        }
    }
}
