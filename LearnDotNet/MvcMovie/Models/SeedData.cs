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
						Rating = "PG-13",
						Price = 8.99M
					},
					new Movie
					{
						Title = "Ghostbusters 2",
						ReleaseDate = DateTime.Parse("1986-2-23"),
						Genre = "Comedy",
						Rating = "PG-13",
						Price = 9.99M
					},
					new Movie
					{
						Title = "Avengers",
						ReleaseDate = DateTime.Parse("2012-4-30"),
						Genre = "Action",
						Rating = "PG-13",
						Price = 9.99M
					},
					new Movie
					{
						Title = "Brother Bear",
						ReleaseDate = DateTime.Parse("2008-11-22"),
						Genre = "Family",
						Rating = "PG",
						Price = 7.99M
					},
					new Movie
					{
						Title = "Dr. Horrible's Musical Sing-Along Blog",
						ReleaseDate = DateTime.Parse("2014-6-5"),
						Genre = "Comedy",
						Rating = "PG",
						Price = 2.99M
					},
					new Movie
					{
						Title = "Scooby-Doo! and Krypto Too!",
						ReleaseDate = DateTime.Parse("2024-4-30"),
						Genre = "Comedy",
						Rating = "PG",
						Price = 8.99M
					},
					new Movie
					{
						Title = "Rio Bravo",
						ReleaseDate = DateTime.Parse("1959-4-15"),
						Genre = "Western",
						Rating = "PG-13",
						Price = 3.99M
					}
			);
			context.SaveChanges();
		}
	}
}