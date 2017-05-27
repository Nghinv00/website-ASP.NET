using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Framework;
using System.Data.SqlClient;
using Models;

namespace Models
{
    public class AccountModel
    {
        private WebcafefilmDbContext context = null;

        public AccountModel()
        {
            context = new WebcafefilmDbContext();
        } 

        public bool Login(string userName, string passWord)
        {
            object[] sqlParam =
            {
                new SqlParameter("@Username", userName),
                    new SqlParameter("@Password", passWord),
            };
            var result = context.Database.SqlQuery<bool>("prd_AccountLogin @Username, @Password", sqlParam).SingleOrDefault();

            return result;
        }

    }
}
