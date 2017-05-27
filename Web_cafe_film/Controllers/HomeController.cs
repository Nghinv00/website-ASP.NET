using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_cafe_film.Models;

namespace Web_cafe_film.Controllers
{
    public class HomeController : Controller
    {
        public static int movieid;
        // GET: Home
        
        WebsiteFilmEntities db = new WebsiteFilmEntities();
        public ActionResult Index()
        {           
            return View();            
        }

        //public PartialViewResult WebFilm_RecentUploads()
        //{
        //    //var lstFilm = db.Movies.Take(16).ToList();
        //    String a = Request.QueryString["id"];

        //    return PartialView(db.Movies.Where(n => n.New == "1").ToList());

        //}



        //public ActionResult DetailMovie(int mvid)
        //{
        //    Movie mv = db.Movies.SingleOrDefault(n => n.MovieID == mvid);

        //    if (mv == null)
        //    {
        //        Response.StatusCode = 404;
        //        return null;
        //    }
        //    return View(mv);
        //}

        //public ActionResult DetailMovie(int MovieID)
        //{
        //    Movie mv = db.Movies.SingleOrDefault(n => n.MovieID == MovieID);

        //    if (mv == null)
        //    {
        //        Response.StatusCode = 404;
        //        return null;
        //    }
        //    return View(mv);
        //}

    }
}