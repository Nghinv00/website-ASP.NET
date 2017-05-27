using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_cafe_film.Models;


namespace Web_cafe_film.Controllers
{
    public class LayOutController : Controller
    {
        WebsiteFilmEntities db = new WebsiteFilmEntities();
        // GET: LayOut
        public ActionResult Index()
        {
          return View();

        }
        
        public PartialViewResult WebFilm_RecentUploads()
        {
            return PartialView(db.Movie.Where(n => n.New == "1").ToList());
         }
        
        public ActionResult DetailMovie(int MovieID)
        {            
            Movie mv = db.Movie.SingleOrDefault(n => n.MovieID == MovieID);
            if (Session["LISTFILM"] != null)
            {
                string s = (string)Session["LISTFILM"];

                string[] tmp = s.Split(';');
                bool check = false;
                for(int i = 0; i < tmp.Length; i++)
                {
                    if(MovieID.ToString().Equals(tmp[i]))
                    {
                        check = true;
                        break;
                    }
                }
                if(!check)
                {
                    s = s + ";" + MovieID.ToString();
                    Session["LISTFILM"] = s;
                }                                    
            }
            else
                Session["LISTFILM"] = MovieID.ToString();
            if (mv == null)
            {
                Response.StatusCode = 404;
                return null;
            }

            // Hiển thị danh sách phim mà người dùng có thể lựa chọn
            ViewData["FILMDETAIL"] = mv;
            IList<ThuatToan.Entities.Rule> suggest = ThuatToan.GlobalVariables.suggest;
            suggest = suggest.Where(o => o.X == MovieID.ToString()).OrderBy(o => o.Confidence).ToList();
            string strID = "";
            if (suggest.Count >= 1)
                strID = suggest[0].Y;
            for (int i = 1; i < suggest.Count; i++)
            {
                strID = strID + ";" + suggest[i].Y;
            }
            string[] arrMovieID = strID.Split(';');
            List<Movie> suggestMovie = db.Movie.Where(o => arrMovieID.Contains(o.MovieID.ToString())).ToList();
            ViewData["SUGGESTFILM"] = suggestMovie;

            return View();
        }


        
        // Viết 1 hàm để lấy danh sách file text từ dữ liệu .... 



        //public ActionResult DetailMovie(int movieID)
        //{

        //    Movie movie = db.Movies.SingleOrDefault(n => n.MovieID == movieID);
        //    if (movie == null)
        //    {
        //        Response.StatusCode = 404;
        //        return null;
        //    }

        //    // Đưa dữ liệu vào DropDownList
        //    ViewBag.CategoryID = new SelectList(db.Categories.ToList(), "CategoryID", "CategoryName");

        //    return View(movie);
        //}


        // Chỉnh sửa phim
        //public ActionResult DetailMovie(int movieID)
        //{
        //    Movie movie = db.Movies.SingleOrDefault(n => n.MovieID == movieID);
        //    if (movie == null)
        //    {
        //        Response.StatusCode = 404;
        //        return null;
        //    }

        //    // Đưa dữ liệu vào DropDownList
        //    ViewBag.MovieID = new SelectList(db.Movies.ToList(), "MovieID", "MovieName");

        //    return View(movie);
        //}

        //[HttpPost]
        //[ValidateInput(false)]
        //public ActionResult DetailMovie(Movie movie)
        //{
        //    //Movie movie1 = db.Movies.SingleOrDefault(n => n.MovieID == movie.MovieID);
        //    //db.SaveChanges();

        //    // Đưa dữ liệu vào DropDownList
        //    ViewBag.MovieID = new SelectList(db.Movies.ToList(), "MovieID", "MovieName");

        //    if (ModelState.IsValid)
        //    {
        //        // Thực hiện cập nhật trong Model
        //        db.Entry(movie).State = System.Data.Entity.EntityState.Modified;
        //        db.SaveChanges();
        //    }
        //    //db.Movies.Add(movie);
        //    //return View();
        //    return RedirectToAction("Index", "LayOut");


        //}

        //public ViewResult DetailMovie(int movieid = 0)
        //{
        //    Movie movie = db.Movies.SingleOrDefault(n => n.MovieID == movieid);

        //    if (movie == null)
        //    {
        //        // TRả về trang báo lỗi
        //        Response.StatusCode = 404;
        //        return null;
        //    }

        //    // ViewBag.CategoryID= new SelectList( db.Ca)

        //    return View(movie);

        //}




    }
}