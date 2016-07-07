using System.ComponentModel.DataAnnotations;

namespace MovieManager.Models
{
    public class MovieModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Title { get; set; }

        public int Rating { get; set; }

        [Required]
        public Genre GenreType { get; set; }

        [Required]
        [StringLength(255)]
        public ApplicationUser MovieUser { get; set; }
    }
}