using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_cafe_film.Models;

namespace Web_cafe_film.Controllers
{
    public class LoginController : Controller
    {
        WebsiteFilmEntities db = new WebsiteFilmEntities();
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
            ModelState.Clear();
            ViewBag.Message = NguoiDung.HoTen + " đăng ký thành công";
            return View();
        }

        [HttpGet]
        public ActionResult DangNhap()
        {

            return View();

        }
        [HttpPost]   // gửi thẻ đến sever
        [ValidateAntiForgeryToken]
        public ActionResult DangNhap(ThanhVien f)
        {

            if (ModelState.IsValid)
            {
                var v = db.ThanhVien.FirstOrDefault(x => x.HoTen == f.HoTen.Trim() && x.Passwords == f.Passwords.Trim());
                // var v = db.ThanhViens.Single(a => a.HoTen.Equals(f.HoTen) && a.Passwords.Equals(f.Passwords));
                // var v = db.ThanhViens.Where(a => a.HoTen.Equals(f.HoTen) && a.Passwords.Equals(f.Passwords)).FirstOrDefault();
                if (v != null)
                {
                    Session["TaiKhoan"] = v.HoTen.ToString();
                    Session["PassWords"] = v.Passwords.ToString();

                    return RedirectToAction("DangNhap", "Index");
                }
            }
            else
            {
                ModelState.AddModelError("", " Tên tài khoản hoặc mật khẩu không đúng");
            }

            return View(f);

            //string sTaiKhoan = f["txtTaiKhoan"].ToString();
            //string sMatKhau = f.Get("txtMatKhau").ToString();
            //ThanhVien tv = db.ThanhViens.SingleOrDefault(n => n.HoTen == sTaiKhoan && n.Passwords == sMatKhau);
            //if (tv != null)
            //{
            //    ViewBag.ThongBao = "Chúc mừng bạn đăng nhập thành công !";
            //    Session["TaiKhoan"] = tv;

            //    return View(tv);
            //}
            //ViewBag.ThongBao = "Tên tài khoản hoặc mật khẩu không đúng";
            //return View(f);

        }

        //public ActionResult LoginedIn()
        //{

        //    if(Session["HoTen"] != null)
        //    {
        //        return View();
        //    }
        //    else
        //    {
        //        return RedirectToAction("Login");
        //    }

        //}

    }
}