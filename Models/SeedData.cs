using Microsoft.EntityFrameworkCore;
using MvcMovie.Data;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider) 
        {
            using var context = new MvcMovieContext(
                serviceProvider.GetRequiredService
                <DbContextOptions<MvcMovieContext>>());
            // Look for Movies already in the
            // database.
            if (context.Movie.Any())
            {
                return; // DB has already been seeded.
            }
            context.Movie.AddRange
                (
                    new Movie
                    {
                        Title = "17 Miracles",
                        ReleaseDate = DateTime.Parse("2011-6-3"),
                        Genre = "Adventure",
                        Rating = "PG",
                        Price = 9.99M,
                        Image = "https://d2ncbdssutn1hp.cloudfront.net/product-images/000/448/826/detail/17_Miracles-DVD.jpg"
                    },
                    new Movie
                    {
                        Title = "Ephraim's Rescue",
                        ReleaseDate = DateTime.Parse("2013-5-31"),
                        Genre = "Adventure",
                        Rating = "PG",
                        Price = 19.99M,
                        Image = "https://d1hdlz9ljonw49.cloudfront.net/product-images/000/715/548/detail/Ephraims_Rescue_DVD.jpg?1447880052"
                    },                 
                    new Movie
                    {
                        Title = "Meet the Mormons",
                        ReleaseDate = DateTime.Parse("2014-10-10"),
                        Genre = "Documentary",
                        Rating = "PG",
                        Price = 11.99M,
                        Image = "https://d2ncbdssutn1hp.cloudfront.net/product-images/000/711/327/detail/Meet-The-Mormons-Poster.jpg?1425327122"
                    },
                    new Movie
                    {
                        Title = "The Fighting Preacher",
                        ReleaseDate = DateTime.Parse("2019-07-24"),
                        Genre = "Comedy-Drama",
                        Rating = "PG",
                        Price = 14.99M,
                        Image = "https://d26iejr7yj7kfh.cloudfront.net/product-images/000/734/861/detail/The_Fighting_Preacher.png?1563828994"
                    },
                    new Movie
                    {
                        Title = "The Other Side of Heaven",
                        ReleaseDate = DateTime.Parse("2002-04-12"),
                        Genre = "Adventure Drama",
                        Rating = "PG",
                        Price = 16.99M,
                        Image = "https://d2jc79253juilm.cloudfront.net/product-images/000/728/575/detail/Other_Side_of_Heaven-PB_new.jpg?1541527578"
                    }
                );
            // Save the changes to the context.
            context.SaveChanges();
        }
    }
}
