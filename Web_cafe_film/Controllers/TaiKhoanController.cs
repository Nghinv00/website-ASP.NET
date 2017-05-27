using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Web_cafe_film.Models;

namespace Web_cafe_film.Controllers
{
    public class TaiKhoanController : Controller
    {

        WebsiteFilmEntities db = new WebsiteFilmEntities();
        // GET: TaiKhoan
        public ActionResult Index()
        {
            return View();
        }
     
        //Hàm trả về trang view để đăng ký tài khoản

        [HttpGet]
        public ActionResult DangKy()
        {

            return View();
        }

        [HttpPost]
       // [ValidateAntiForgeryToken]
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
            ViewBag.Message = "Chúc mừng bạn" + NguoiDung.HoTen + " đã đăng ký thành công";
            return View();
            
        }

        //Hàm lưu thông tin đăng ký
        // [HttpPost]
        //public ActionResult LuuDangKy([Bind(Include = "Gmail, TenDangNhap, MatKhau")]ThanhVien taikhoan)
        //{
        //    //Kiểm tra hợp lệ dữ liệu
        //    if (ModelState.IsValid)
        //    {
        //        //kiểm tra tên đăng nhập, email có bị đã tồn tại hay chưa?
        //        var checkUserName = db.ThanhViens.Any(s => s.HoTen == taikhoan.HoTen);
        //        var checkEmail = db.ThanhViens.Any(s => s.Gmail == taikhoan.Gmail);

        //        //Các lỗi nếu có trong quá trình đăng ký tài khoản
        //        if (checkUserName)
        //        {
        //            ModelState.AddModelError("", "Tên đăng nhập đã tồn tại!");
        //        }
        //        if (checkEmail)
        //        {
        //            ModelState.AddModelError("", "Email đã có người sử dụng!");
        //        }
        //        if (checkUserName == true || checkEmail == true)
        //        {
        //            //trả về view đăng ký và thông báo các lỗi ở trên
        //            return View("DangKy");
        //        }
        //        else
        //        {
        //            //Lưu thông tin tài khoản vào CSDL
        //            db.ThanhViens.Add(taikhoan);
        //            db.SaveChanges();
        //            //xác thực tài khoản trong ứng dụng
        //            FormsAuthentication.SetAuthCookie(taikhoan.HoTen, false);
        //            //trả về trang chủ đăng ký thành công
        //            return Redirect("/");

        //        }
        //    }
        //    else
        //    {
        //        //Trang báo lỗi nhập liệu không hợp lệ!
        //        return View("Error");
        //    }
        //}

        //public ActionResult DangNhap()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public ActionResult KiemTraDangNhap(DangNhapViewModel taikhoan)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        //cấu trúc linq kiểm tra xem có tài khoản nào khớp hay không
        //        var checkLogin = db.ThanhViens.Any(s => s.HoTen == taikhoan.TenDangNhap && s.Passwords == taikhoan.PassWord);
        //        //nếu có checklogin = true
        //        if (checkLogin)
        //        {
        //            FormsAuthentication.SetAuthCookie(taikhoan.TenDangNhap, false);
        //            return RedirectToAction("Index", "Home");
        //        }
        //        else
        //        {
        //            ModelState.AddModelError("", "Sai tên đăng nhập hoặc mật khẩu, kiểm tra lại nhé!");
        //            //trở lại trang đăng nhập, báo lỗi
        //            return View("DangNhap", taikhoan);
        //        }
        //    }
        //    //Đăng nhập thành công, trở về trang chủ
        //    return Redirect("/");
        //}

        //public ActionResult DangXuat()
        //{
        //    //Đăng xuất khỏi ứng dụng
        //    FormsAuthentication.SignOut();
        //    //Về trang chủ
        //    return Redirect("/");
        //}






    }
}