namespace MovieManager.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class populateGenres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (GenreType) VALUES ('Horror')");
            Sql("INSERT INTO Genres (GenreType) VALUES ('Comedy')");
            Sql("INSERT INTO Genres (GenreType) VALUES ('Romance')");
            Sql("INSERT INTO Genres (GenreType) VALUES ('Action')");
        }

        public override void Down()
        {
            Sql("DELETE FROM GENRES WHERE Id IN (1,2,3,4)");
        }
    }
}
