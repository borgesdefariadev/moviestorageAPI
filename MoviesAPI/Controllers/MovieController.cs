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

    [HttpGet("{Id}")]
    public IEnumerable<Movie> GetMovies([FromQuery] int skip, [FromQuery] int take)
    {
        return movies.Skip(skip).Take(take);
    }

    public Movie? GetMovieById(int id)
    {
        return movies.FirstOrDefault(m => m.Id == id);
    }   
}
