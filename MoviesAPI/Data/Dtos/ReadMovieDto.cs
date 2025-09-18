using System.ComponentModel.DataAnnotations;

namespace MoviesAPI.Data.Dtos;

public class ReadMovieDto
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Genre { get; set; }
    public string? Director { get; set; }
    public int ReleaseYear { get; set; }

    public DateTime OperationTime { get; set; } = DateTime.Now;
}
