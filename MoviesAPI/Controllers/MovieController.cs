using Microsoft.AspNetCore.Mvc;
using MoviesAPI.Data;
using MoviesAPI.Models;
namespace MoviesAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class MovieController : ControllerBase
{

    private MovieContext _context;

    public MovieController(MovieContext context)
    {
        _context = context;
    }

    [HttpPost]
    public IActionResult AddMovie([FromBody] Movie movie)
    {
        // Implementation for adding a movie
        _context.Movies.Add(movie);
        _context.SaveChanges();
        return CreatedAtAction(nameof(GetMovieById), new { id = movie.Id }, movie);
    }

    [HttpGet("{Id}")]
    public IEnumerable<Movie> GetMovies([FromQuery] int skip =0, [FromQuery] int take =10)
    {
        return _context.Movies.Skip(skip).Take(take);
    }

    public IActionResult GetMovieById(int id)
    {
        var movie = _context.Movies.
            FirstOrDefault(m => m.Id == id);
        if (movie == null) return NotFound();
        return Ok();

    }   
}
