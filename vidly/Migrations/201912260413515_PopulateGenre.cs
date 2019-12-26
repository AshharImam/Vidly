namespace vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenre : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id,Name) Values(1,'Comedy')");
            Sql("INSERT INTO Genres (Id,Name) Values(2,'Action')");
            Sql("INSERT INTO Genres (Id,Name) Values(3,'Drama')");
            Sql("INSERT INTO Genres (Id,Name) Values(4,'Romance')");
            Sql("INSERT INTO Genres (Id,Name) Values(5,'Horror')");
        }
        
        public override void Down()
        {
        }
    }
}
