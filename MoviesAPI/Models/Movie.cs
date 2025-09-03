using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.Security.Principal;

namespace MoviesAPI.Models;

public class Movie
{
    [Required]
    [Key]    
    public int Id { get; set; }
    [Required(ErrorMessage = "Title is Required.")]
    [MaxLength(50, ErrorMessage = "Title cannot be more than 50 characters")]
    public string? Title { get; set; }
    [Required]
    [MaxLength(30, ErrorMessage = "Genre cannot be more than 30 characters")]
    public string? Genre { get; set; }
    [Required]
    [RegularExpression(@"^[a-zA-Z]+[ a-zA-Z-_]*$", ErrorMessage = "Use Characters only")]
    public string? Director { get; set; }
    [Required]
    //[MaxLength(4, ErrorMessage = "Release year cannot be more than 4 characters")]
    public int ReleaseYear { get; set; }

}
