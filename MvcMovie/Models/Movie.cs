using System;
using System.Data.Entity;

namespace MvcMovie.Models
{
    public class Movie
    {
        // Each property of the Movie class 
        //  will map to a column in the table.
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }

    // With this DbContext class, we can use
    //  entity framework to access database through
    //  DbSet which might contain many Movie entities.
    public class MovieDBContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
    }
}