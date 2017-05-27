using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_cafe_film.Areas.Admin.Models;

using Web_cafe_film.Models;
using Web_cafe_film.Areas.Admin.Code;
using Models;

namespace Web_cafe_film.Areas.Admin.Controllers
{
    public class LoginAdminController : Controller
    {
        // GET: Admin/Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(LoginModel model )
        {
            //var result = new AccountModel().Login(model.username, model.password);

            var result = new AccountModel().Login(model.username, model.password);
            if( result && ModelState.IsValid)
            {
                SessionHelper.SetSession(new UserSesssion() { Username = model.username });
                return RedirectToAction("Index", "Admin");

            }
            else
            {
                ModelState.AddModelError("", "Tên đăng nhập hoặc mật khẩu không đúng");
            }
            return View(model);
        }
    }
}