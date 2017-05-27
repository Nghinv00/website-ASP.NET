using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_cafe_film.Models;

namespace Web_cafe_film.Controllers
{
    public class DangKyController : Controller
    {
        WebsiteFilmEntities db = new WebsiteFilmEntities();
        // GET: DangKy
        public ActionResult Index()
        {

            return View();
        }


        [HttpGet]
        public ActionResult DangKy()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DangKy(ThanhVien NguoiDung)
        {
            if (ModelState.IsValid)
            {
                // Chèn dữ liệu vào bảng đăng ký
                db.ThanhVien.Add(NguoiDung);
                // Lưu vào csdl
                db.SaveChanges();
            }
            // ModelState.Clear();
            ViewBag.Message = "Chúc mừng bạn " + NguoiDung.HoTen + " đã đăng ký thành công";
            return View();
        }

    }
}