using System.ComponentModel.DataAnnotations;

namespace ASP03Db.Models
{
    public class Movie
    {
        public int MovieId { get; set; }

        [Required(ErrorMessage = "Title is required")] 
        [MinLength(2, ErrorMessage = "Title must be at least 2 characters long")]
        public required string Title { get; set; }
        
        [Range(1888, 2100, ErrorMessage = "Year must be between 1888 and 2100")]
        public int? Year { get; set; }

        [Required(ErrorMessage = "Length is required")]
        public long Length { get; set; }
    }
}
