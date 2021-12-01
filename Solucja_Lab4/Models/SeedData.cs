using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Solucja_Lab4.Data;
using System;
using System.Linq;

namespace Solucja_Lab4.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new Solucja_Lab4Context(
                serviceProvider.GetRequiredService<
                    DbContextOptions<Solucja_Lab4Context>>()))
            {
               
                if (context.Books.Any())
                {
                    return;  
                }

                context.Books.AddRange(
                    new Books
                    {
                        Title = "The Hobbit or There and Back Again",
                        ReleaseDate = DateTime.Parse("1937-06-23"),
                        Author = "J. R. R. Tolkien",
                        Rating = 89
                    },

                    new Books
                    {
                        Title = "The Fellowship of the Ring",
                        ReleaseDate = DateTime.Parse("1954-01-03"),
                        Author = "J. R. R. Tolkien",
                        Rating = 100
                    },

                    new Books
                    {
                        Title = "The Two Towers",
                        ReleaseDate = DateTime.Parse("1954-09-12"),
                        Author = "J. R. R. Tolkien",
                        Rating = 98
                    },

                    new Books
                    {
                        Title = " The Return of the King",
                        ReleaseDate = DateTime.Parse("1955-04-02"),
                        Author = "J. R. R. Tolkien",
                        Rating = 99
                    }
                );
                context.SaveChanges();
            }
        }
    }
}

