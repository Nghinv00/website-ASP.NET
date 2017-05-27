using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_cafe_film.Models;
namespace Web_cafe_film.Areas.Admin.Controllers
{
    public class UserController : Controller
    {


       
        // GET: Admin/User
        public ActionResult Index()
        {
            return View();
        }
        WebsiteFilmEntities db = new WebsiteFilmEntities();
        // GET: Admin/User
        public PartialViewResult UserPartital()
        {
            //var lstUser = db.Users.Take(25).ToList();
            //var lstUser = db.Users.Take(25).ToList();
            var lstThanhVien = db.ThanhVien.Take(10).ToList();
            return PartialView(lstThanhVien);

        }
    }
}