using Microsoft.AspNetCore.Mvc;
using MoviesAPI.Models;
namespace MoviesAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class MovieController : ControllerBase
{

    private static List<Movie> movies = new()
    {
        new Movie { Id = 1, Title = "Inception", Genre = "Drama", Director = "Christopher Nolan", ReleaseYear = 2010 },
        new Movie { Id = 2, Title = "The Matrix", Genre = "Drama", Director = "The Wachowskis", ReleaseYear = 1999 },
        new Movie { Id = 3, Title = "Interstellar", Genre = "Sci-Fi", Director = "Christopher Nolan", ReleaseYear = 2014 }
    };

    [HttpPost]
    public void AddMovie([FromBody] Movie movie)
    {
        // Implementation for adding a movie
        movies.Add(movie);
    }

    [HttpGet]
    public List<Movie> GetMovies()
    {
        return movies;
    }
}
