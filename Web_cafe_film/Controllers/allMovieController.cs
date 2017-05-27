using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_cafe_film.Models;

namespace Web_cafe_film.Controllers
{
    public class allMovieController : Controller
    {
        // GET: allMovie
        WebsiteFilmEntities db = new WebsiteFilmEntities();
        public ActionResult Index()
        {

            return View();
        }

        public PartialViewResult WebFilm_RecentUploads()
        {
            //var lstFilm = db.Movies.Take(16).ToList();
            return PartialView(db.Movie.ToList());
        }
    }
}
