using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcMovieContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcMovieContext>>()))
        {
            // Look for any movies.
            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }
            context.Movie.AddRange(
                new Movie
                {
                    Title = "When Harry Met Sally",
                    ReleaseDate = DateTime.Parse("1989-2-12"),
                    Genre = "Romantic Comedy",
                    Rating = "R",
                    Price = 7.99M
                },
                new Movie
                {
                    Title = "Ghostbusters ",
                    ReleaseDate = DateTime.Parse("1984-3-13"),
                    Genre = "Comedy",
                    Rating = "R",
                    Price = 8.99M
                },
                new Movie
                {
                    Title = "Ghostbusters 2",
                    ReleaseDate = DateTime.Parse("1986-2-23"),
                    Genre = "Comedy",
                    Rating = "R+",
                    Price = 9.99M
                },
                new Movie
                {
                    Title = "Rio Bravo",
                    ReleaseDate = DateTime.Parse("1959-4-15"),
                    Genre = "Western",
                    Rating = "R+++",
                    Price = 3.99M
                },
                new Movie
                {
                    Title = "20 Days in Mariupol",
                    ReleaseDate = DateTime.Parse("2023-11-21"),
                    Genre = "Documentary",
                    Rating = "R+++",
                    Price = 0.75M
                },
                new Movie
                {
                    Title = "Oppenheimer",
                    ReleaseDate = DateTime.Parse("2023-07-11"),
                    Genre = "Thriller",
                    Rating = "R",
                    Price = 100M
                },
                new Movie
                {
                    Title = "Venom: The Last Dance",
                    ReleaseDate = DateTime.Parse("2023-1-21"),
                    Genre = "Thriller",
                    Rating = "R",
                    Price = 120M
                }
                
            );
            context.SaveChanges();
        }
    }
}
