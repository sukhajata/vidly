namespace Vidly3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMovieGenre : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies(Name, Genre)  VALUES('Baraka', 'Documentary')");
            Sql("INSERT INTO Movies(Name, Genre)  VALUES('Up', 'Animation')");
            Sql("INSERT INTO Movies(Name, Genre)  VALUES('Infinity War', 'Action')");
            Sql("INSERT INTO Movies(Name, Genre)  VALUES('The Red Shoe', 'Drama')");
        }
        
        public override void Down()
        {
        }
    }
}
