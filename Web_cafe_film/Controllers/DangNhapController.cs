using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_cafe_film.Models;
using Web_cafe_film.Models.Code;
using Web_cafe_film.Models;

namespace Web_cafe_film.Controllers
{
    public class DangNhapController : Controller
    {
        // GET: DangNhap
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(LoginThanhVienModel model)
        {
            //var result = new AccountModel().Login(model.username, model.password);

            var result = new DangNhapModel().Login(model.HoTen, model.Passwords);
            if (result && ModelState.IsValid)
            {
                SessionHelper.SetSession(new UserSesssion() { HoTen = model.HoTen });
                return RedirectToAction("Index", "Home");   
            }
            else
            {
                ModelState.AddModelError("", "Tên đăng nhập hoặc mật khẩu không đúng");
            }
            return View(model);
        }


    }
}