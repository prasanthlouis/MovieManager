namespace MovieManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class datenetered : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MovieModels", "DateEntered", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.MovieModels", "DateEntered");
        }
    }
}
