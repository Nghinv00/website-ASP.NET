using System;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Web_cafe_film.ThuatToan;
using System.Data;
namespace Web_cafe_film
{
    public class MvcApplication : System.Web.HttpApplication
    {
        DBConnection db = new DBConnection();

        Web_cafe_film.Models.MovieSuggest mvg = new Models.MovieSuggest();
        ThuatToan.ReadWriteFile write = new ThuatToan.ReadWriteFile();
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            write.invokeApriori();
        }
        protected void Session_OnEnd(Object sender, EventArgs e)
        {
            string s = (string)Session["LISTFILM"];
            //save to db
           addSession(s);
        }

        protected void addSession(String s)
        {          
            string sql = "prd_MovieSuggest_Insert";
            SqlConnection con = db.getConnection();
            SqlCommand command = new SqlCommand(sql, con);
            con.Open();
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@S", SqlDbType.NVarChar).Value = s ;            
            command.ExecuteNonQuery();
            command.Dispose();
            con.Close();
        }

    }
}
