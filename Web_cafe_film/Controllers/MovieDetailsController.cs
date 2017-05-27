using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_cafe_film.Models;

namespace Web_cafe_film.Controllers
{
    public class MovieDetailsController : Controller
      {

          WebsiteFilmEntities db = new WebsiteFilmEntities();
  
        // GET: MovieDetails
        public ActionResult Index()
        {           
            return View();
        }

        public ActionResult Index(int MovieID)
        {
            Movie mv = db.Movie.SingleOrDefault(n => n.MovieID == MovieID);

            if (mv == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(mv);
        }



























        public PartialViewResult ChiTietPhimPartial(int movieid)
        {

            int id = Convert.ToInt32(Request.QueryString["id"]); 
            
            Movie movie = db.Movie.SingleOrDefault(n => n.MovieID == id);
            if ( movie == null)
            {

                Response.StatusCode = 404;
                return null;
            }
            return PartialView(movie);
        }



    }
}