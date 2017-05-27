using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_cafe_film.Models;
using PagedList;
using PagedList.Mvc;
using System.Data.Entity;

namespace Web_cafe_film.Areas.Admin.Controllers
{
    public class DanhSachController : Controller
    {
        WebsiteFilmEntities db = new WebsiteFilmEntities();
        // GET: Admin/DanhSach
        public ActionResult Index( )
        {
            //int pageNumber = (page ?? 1);
            //int pageSize = 10;

            //return View(db.Movies.ToList().ToPagedList(pageNumber, pageSize));
            return View();
        }

        public PartialViewResult DanhSachPartial()                                  
        {                                                                                   
            var lstDanhSach = db.Movie.Take(1000000).ToList();          
            return PartialView(lstDanhSach);       
                           
        }                                                           
        //public PartialViewResult DanhSachPartial2()
        //{
        //    var lstDanhSach2 = db.DetailMovies.Take(10).ToList();

        //    return PartialView(lstDanhSach2);
        //}

    }
}