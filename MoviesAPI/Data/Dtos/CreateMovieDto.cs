using System.ComponentModel.DataAnnotations;

namespace MoviesAPI.Data.Dtos;

public class CreateMovieDto
{

    [Required(ErrorMessage = "Title is Required.")]
    [MaxLength(50, ErrorMessage = "Title cannot be more than 50 characters")]
    public string? Title { get; set; }
    [Required]
    [StringLength(30, ErrorMessage = "Genre cannot be more than 30 characters")]
    public string? Genre { get; set; }
    [Required]
    [RegularExpression(@"^[a-zA-Z]+[ a-zA-Z-_]*$", ErrorMessage = "Use Characters only")]
    public string? Director { get; set; }
    [Required]
    [Range(1900, 2100, ErrorMessage = "Release Year must be a valid Year.")]
    public int ReleaseYear { get; set; }
}
