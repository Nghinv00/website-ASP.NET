using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_cafe_film.Models;
using PagedList;
using PagedList.Mvc;
using System.IO;

namespace Web_cafe_film.Areas.Admin.Controllers
{
    public class QuanLyPhimController : Controller
    {
        WebsiteFilmEntities db = new WebsiteFilmEntities();
        // GET: Admin/QuanLyPhim
        public ActionResult Index()
        {           
            return View(db.Movie.ToList().OrderBy(n => n.MovieID));
        }
        // Action Thêm mới
        [HttpGet]
        public ActionResult ThemMoi()
        {
            // Đưa dữ liệu vào DropDownList
            //ViewBag.CategoryID = db.Movies.ToList();
            ViewBag.CategoryID = new SelectList(db.Category.ToList(), "CategoryID", "CategoryName");
            return View();
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult ThemMoi(Movie movie, HttpPostedFileBase fileUpload)
        {  
            if ( ModelState.IsValid)
            {

                // Lưu tên của file
                var fileName = Path.GetFileName(fileUpload.FileName);
                // Lưu đường dẫn của file 
                var path = Path.Combine(Server.MapPath("~/LinkImage"), fileName);

                // Kiểm tra đường dẫn LinkImage
                if ( fileUpload == null)
                {
                    ViewBag.ThongBao = "Chọn hình ảnh";
                    return View();
                }

                if (System.IO.File.Exists(path))
                {
                    //  Kiểm tra hình ảnh đã tồn tại chưa
                    ViewBag.ThongBao = "Hình Ảnh đã tồn tại";
                }
                else
                {
                    fileUpload.SaveAs(path);
                }
                    movie.LinkImage = fileUpload.FileName;
                    db.Movie.Add(movie);
                    db.SaveChanges();
             }
            return RedirectToAction("Index", "QuanLyPhim");
        }
        
        // Chỉnh sửa phim
        public ActionResult ChinhSua( int movieID)
        {
          
            Movie movie = db.Movie.SingleOrDefault( n => n.MovieID == movieID );
            if(movie == null )
            {
                Response.StatusCode = 404;
                return null;
            }

            // Đưa dữ liệu vào DropDownList
            ViewBag.CategoryID = new SelectList(db.Category.ToList(), "CategoryID", "CategoryName");

            return View(movie);
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult ChinhSua(Movie movie)
        {
            //Movie movie1 = db.Movies.SingleOrDefault(n => n.MovieID == movie.MovieID);
            //db.SaveChanges();

            // Đưa dữ liệu vào DropDownList
            ViewBag.CategoryID = new SelectList(db.Category.ToList(), "CategoryID", "CategoryName");

            if (ModelState.IsValid)
            {
                // Thực hiện cập nhật trong Model
                db.Entry(movie).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            //db.Movies.Add(movie);
            //return View();
            return RedirectToAction("Index", "QuanLyPhim");
            

        }

        // Hiển thi Phim
        public ActionResult HienThi( int movieID)
        {
            // Lấy ra đối tượng của Phim theo id 
            Movie movie = db.Movie.SingleOrDefault(n => n.MovieID == movieID);
            if ( movie ==null )
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(movie);
        }
        //Xóa phim
        [HttpGet]
        public ActionResult Xoa( int movieID)
        {
            // Lấy ra đối tượng của Phim theo id 
            Movie movie = db.Movie.SingleOrDefault(n => n.MovieID == movieID);
            if (movie == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(movie);
        }

        [HttpPost,ActionName("Xoa")]
        public ActionResult XacNhanXoa(int movieID)
        {
            Movie movie = db.Movie.SingleOrDefault(n => n.MovieID == movieID);
            if( movie==null)
                {
                Response.StatusCode = 404;
                return null;
            }
            db.Movie.Remove(movie);
            db.SaveChanges();
            return RedirectToAction("Index", "QuanLyPhim");
        }


    }
}