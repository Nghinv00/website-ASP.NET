using Models.Framework;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Web_cafe_film.Models
{
    public class DangNhapModel
    {
        private WebcafefilmDbContext context = null;
        public DangNhapModel()
        {
            context = new WebcafefilmDbContext();
        }

        public bool Login(string HoTen, string PassWords)
        {
            object[] sqlParam =
            {
                new SqlParameter("@HoTen", HoTen),
                    new SqlParameter("@PassWords", PassWords),
            };
            var result = context.Database.SqlQuery<bool>("prd_ThanhVienLogin @HoTen, @PassWords", sqlParam).SingleOrDefault();

            return result;
        }


    }
}