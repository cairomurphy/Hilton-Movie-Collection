using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hilton_Movie_Collection.Models
{
    public class MovieContext : DbContext
    {
        //Constructor
        public MovieContext (DbContextOptions<MovieContext> options) : base(options)
        {
            //Leave blank for now
        }

        public DbSet<AddedMovie> newmovie { get; set; }
        public DbSet<Category> Categories { get; set; }

        //seed data
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName="Action/Adventure"},
                new Category { CategoryId = 2, CategoryName = "Comedy" },
                new Category { CategoryId = 3, CategoryName = "Drama" },
                new Category { CategoryId = 4, CategoryName = "Family" },
                new Category { CategoryId = 5, CategoryName = "Horror/Suspense" },
                new Category { CategoryId = 6, CategoryName = "Miscellaneous" },
                new Category { CategoryId = 7, CategoryName = "Television" },
                new Category { CategoryId = 8, CategoryName = "VHS" }
                );

            mb.Entity<AddedMovie>().HasData(
                new AddedMovie
                {
                    MovieId = 1,
                    CategoryId = 1,
                    Title = "John Wick",
                    Year = 2022,
                    Director = "Cairo Murphy",
                    Rating = "R",
                    Edited = false,
                    LentTo = "Sarah",
                    Notes = "blank"
                },
                new AddedMovie
                {
                    MovieId = 2,
                    CategoryId = 4,
                    Title = "Madagascar 2",
                    Year = 2005,
                    Director = "Cairo Murphy",
                    Rating = "PG",
                    Edited = true,
                    LentTo = "Sarah's Mom",
                    Notes = "blank"
                },
                new AddedMovie
                {
                    MovieId = 3,
                    CategoryId = 3,
                    Title = "Tombstone",
                    Year = 2005,
                    Director = "Cairo Murphdog",
                    Rating = "R",
                    Edited = false,
                    LentTo = "",
                    Notes = "blank"
                }
                );
        }
    }
}
