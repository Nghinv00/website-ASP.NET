using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_cafe_film.Models;
namespace Web_cafe_film.Areas.Admin.Controllers
{
    public class EmployeeController : Controller
    {
        WebsiteFilmEntities db = new WebsiteFilmEntities();
        // GET: Admin/Employee
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult EmployeePartial()
        {
            var lstemp = db.Employee.Take(10).ToList();
            return PartialView(lstemp);
        }
        /*
         *public PartialViewResult AccountPartial()
        {
            //var lstUser = db.Users.Take(25).ToList();
            var lstaccount = db.Accounts.Take(10).ToList();

            return PartialView(lstaccount);

        } 
         */



    }
}