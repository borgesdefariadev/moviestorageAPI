using Microsoft.AspNetCore.Mvc;
using MoviesAPI.Models;
namespace MoviesAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class MovieController : ControllerBase
{

    private static List<Movie> movies = new();
    public static int Id = 1;

    [HttpPost]
    public void AddMovie([FromBody] Movie movie)
    {
        // Implementation for adding a movie
        movie.Id = Id++;
        movies.Add(movie);
    }

    [HttpGet]
    public List<Movie> GetMovies()
    {
        return movies;
    }
}
