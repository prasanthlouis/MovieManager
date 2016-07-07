using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieManager.Models
{
    public class MovieModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Rating { get; set; }

        public Genre GenreType { get; set; }
    }
}