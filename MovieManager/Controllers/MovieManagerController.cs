using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieManager.Controllers
{
    public class MovieManagerController : Controller
    {
        // GET: MovieManager
        public ActionResult Movie()
        {
            return View();
        }
    }
}