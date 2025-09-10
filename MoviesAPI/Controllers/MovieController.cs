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
    public IActionResult AddMovie([FromBody] Movie movie)
    {
        // Implementation for adding a movie
        movie.Id = Id++;
        movies.Add(movie);
        return CreatedAtAction(nameof(GetMovieById), new { id = movie.Id }, movie);
    }

    [HttpGet("{Id}")]
    public IEnumerable<Movie> GetMovies([FromQuery] int skip =0, [FromQuery] int take =10)
    {
        return movies.Skip(skip).Take(take);
    }

    public IActionResult GetMovieById(int id)
    {
        var movie = movies.FirstOrDefault(m => m.Id == id);
        if (movie == null) return NotFound();
        return Ok();

    }   
}
