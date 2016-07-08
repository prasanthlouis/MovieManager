using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MovieManager.Models;

namespace MovieManager.ViewModels
{
    public class MovieViewModels
    {
        public string Title { get; set; }
        public int Rating { get; set; }
        public string GenreType { get; set; }
        public string DateAdded { get; set; }
        public string TimeAdded { get; set; }
        public IEnumerable<Genre> GenreList { get; set; }
    }
}