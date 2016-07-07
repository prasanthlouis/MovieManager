using System.ComponentModel.DataAnnotations;

namespace MovieManager.Models
{
    public class Genre
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string GenreType { get; set; }
    }
}