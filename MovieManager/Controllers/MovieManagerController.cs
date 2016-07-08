using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieManager.Models;
using MovieManager.ViewModels;

namespace MovieManager.Controllers
{
    public class MovieManagerController : Controller
    {
        private ApplicationDbContext _applicationDbContext;

        public MovieManagerController()
        {
            _applicationDbContext = new ApplicationDbContext();
        }
        // GET: MovieManager
        public ActionResult Movie()
        {
            var ViewModel = new MovieViewModels
            {
                GenreList = _applicationDbContext.Genres.ToList()
            };
            return View(ViewModel);
        }
    }
}