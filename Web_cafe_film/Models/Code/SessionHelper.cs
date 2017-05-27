using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_cafe_film.Models.Code
{
    public class SessionHelper
    {
        public static void SetSession(UserSesssion session)
        {
            HttpContext.Current.Session["loginSession1"] = session;

        }


        public static UserSesssion GetSession()
        {
            var session = HttpContext.Current.Session["loginSession1"];
            if (session == null)
                return null;
            else
            {
                return session as UserSesssion;
            }
        }


    }
}