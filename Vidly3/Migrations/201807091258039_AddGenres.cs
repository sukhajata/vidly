namespace Vidly3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGenres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Name) VALUES ('Documentary')");
            Sql("INSERT INTO Genres (Name) VALUES ('Action')");
            Sql("INSERT INTO Genres (Name) VALUES ('Animation')");
            Sql("INSERT INTO Genres (Name) VALUES ('Drama')");
            Sql("INSERT INTO Genres (Name) VALUES ('Comedy')");
            Sql("INSERT INTO Genres (Name) VALUES ('Fantasy')");
            Sql("INSERT INTO Genres (Name) VALUES ('Sci-Fi')");
        }
        
        public override void Down()
        {
        }
    }
}
