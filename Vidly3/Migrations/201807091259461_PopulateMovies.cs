namespace Vidly3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies(Name, GenreId, ReleaseDate, DateAdded, NumberInStock) VALUES('Baraka', 1, '1995-12-02', '2018-7-9', 10)");
            Sql("INSERT INTO Movies(Name, GenreId, ReleaseDate, DateAdded, NumberInStock) VALUES('Infinity War', 2, '2016-12-02', '2018-7-9', 5)");
            Sql("INSERT INTO Movies(Name, GenreId, ReleaseDate, DateAdded, NumberInStock) VALUES('Point Break', 4, '1995-12-02', '2018-7-9', 4)");
            Sql("INSERT INTO Movies(Name, GenreId, ReleaseDate, DateAdded, NumberInStock) VALUES('Ice Age 3', 3, '2010-8-02', '2018-7-9', 3)");
        }
        
        public override void Down()
        {
        }
    }
}
