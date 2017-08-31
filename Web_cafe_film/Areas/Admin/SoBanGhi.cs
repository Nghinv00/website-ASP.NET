using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Web_cafe_film.Areas.Admin
{
    public class SoBanGhi
    {


        private static int account;

        public static int user;
        SqlConnection sqlcon = new SqlConnection("Data Source=DESKTOP-O7G3RQO;Initial Catalog=WebsiteFilm;Integrated Security=True");
        string sql = "Select count(*) From User";


        public static int login;
        public static int employee;
        public static int home;


    }
}