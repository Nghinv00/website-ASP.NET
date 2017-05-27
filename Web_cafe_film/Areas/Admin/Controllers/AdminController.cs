using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_cafe_film.Models;

namespace Web_cafe_film.Areas.Admin.Controllers
{
    //[Authorize]         // thuộc tính kiểm tra khi đủ điều kiện mới được đăng nhập
    //[AllowAnonymous]        // Thuộc tính vào nặc danh : Khong cần tài khoản vẫn vào được
    public class AdminController : Controller
    {

        WebsiteFilmEntities db = new WebsiteFilmEntities();
        // GET: Admin/Home
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult DanhSachPartial()
        {
            var lstDanhSach = db.Movie.Take(1000000).ToList();
            return PartialView(lstDanhSach);

        }
        public ActionResult getDanhSach()
        {
            var lstDanhSach2 = db.Movie.ToList();
            return Json(new { data = lstDanhSach2 }, JsonRequestBehavior.AllowGet);
        }

    }
}