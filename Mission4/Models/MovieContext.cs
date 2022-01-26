using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission4.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base(options)
        {
            //Blank
        }

        public DbSet<MovieResponse> Responses { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<MovieResponse>().HasData(
                new MovieResponse
                {
                    MovieID = 1,
                    Category = "Action/Adventure",
                    Title = "Lord of The Rings Return of the King",
                    Year = 2003,
                    Director = "Peter Jackson",
                    Rating = "PG-13",
                    Edited = false,
                    Lent = "",
                    Notes = "",
                },

            
            new MovieResponse
            {
                MovieID = 2,
                Category = "Action/Adventure",
                Title = "Prince of Persia: The Sands of Time",
                Year = 2010,
                Director = "Mike Newell",
                Rating = "PG-13",
                Edited = false,
                Lent = "",
                Notes = "",
            },

            new MovieResponse
            {
                MovieID = 3,
                Category = "Commedy",
                Title = "Shrek",
                Year = 2001,
                Director = "Vicky Jenson",
                Rating = "PG",
                Edited = false,
                Lent = "",
                Notes = "",
            }

            );
        }
    }
}
