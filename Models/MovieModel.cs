using Models.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Models
{
    public class MovieModel
    {
        private WebcafefilmDbContext context = null;

        public MovieModel()
        {
            context = new WebcafefilmDbContext();
        }
        public List<Movie> ListAll()
        {
            var list = context.Database.SqlQuery<Movie>("prd_MovieList_All").ToList();
            return list;
        }

        public int Create(int  id, string name, string url, DateTime? release , string link )
        {
            object[] parameters =
            {
                new SqlParameter("@MovieID",id),
               new SqlParameter("@MovieName", name),
                  new SqlParameter("@URLDetail", url),
                  new SqlParameter("@ReleaseDate", release),
                  new SqlParameter("@LinkImage", link)

            };
            int res = context.Database.ExecuteSqlCommand("prd_Movie_Insert @MovieID, @MovieName,@URLDetail, @ReleaseDate,@LinkImage", parameters);
            return res;
        }







    }
}
