using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_cafe_film.Models;

namespace Web_cafe_film.Areas.Admin.Controllers
{
    public class AccountController : Controller
    {

        // GET: Admin/Account
        public ActionResult Index()
        {
            return View();
        }

        WebsiteFilmEntities db = new WebsiteFilmEntities();
        // GET: Admin/User
        public PartialViewResult AccountPartial()
        {
            //var lstUser = db.Users.Take(25).ToList();
            var lstaccount = db.Account.Take(10).ToList();

            return PartialView(lstaccount);

        }


    }
}