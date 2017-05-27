
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Models;
using Web_cafe_film.Models;

namespace Web_cafe_film.Areas.Admin.Controllers
{
    public class ThemPhimController : Controller
    {
        // GET: Admin/ThemPhim
        public ActionResult Index()
        {
            var implementMovie = new MovieModel();
            var model = implementMovie.ListAll();
            //return View(model);
            return View(model);
            //var lstDanhSach = db.Movies.Take(10).ToList();
        }

        // GET: Admin/ThemPhim/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/ThemPhim/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/ThemPhim/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Movie collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var model = new MovieModel();
                    int res = model.Create(collection.MovieID, collection.MovieName, collection.URLDetail, collection.ReleaseDate, collection.LinkImage);

                    if ( res > 0)
                    {
                        return RedirectToAction("Index");
                    }
                    // TODO: Add insert logic here
                else
                    {
                        ModelState.AddModelError("", "Thêm mới không thành công");
                    }    

                }
                return View(collection);

                
            }
            catch
            {
                return View();
            }
        }
  





        // GET: Admin/ThemPhim/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/ThemPhim/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/ThemPhim/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }



        // POST: Admin/ThemPhim/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


    }
}
