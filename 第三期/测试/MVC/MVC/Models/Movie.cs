using System;
using System.Data.Entity;


using System.ComponentModel.DataAnnotations;namespace MVC.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [StringLength(60,MinimumLength = 3)]
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [Required]
        [StringLength(30)]
        public string Genre { get; set; }

        [Range(1,100)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
    }

    public class MovieDBContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
    }
}