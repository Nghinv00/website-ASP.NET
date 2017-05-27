using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web_cafe_film.Areas.Admin.Code;

namespace Web_cafe_film.Areas.Admin.Code
{
    public class SessionHelper
    {
        public static void SetSession( UserSesssion session)
        {
            HttpContext.Current.Session["loginSession"]
            = session;
            
        }
        public static UserSesssion GetSession()
        {
            var session = HttpContext.Current.Session["loginSession"];
            if (session == null)
                return null;
            else
            {
                return session as UserSesssion;
            }
        }
        
    }
}