using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Web_cafe_film.Models
{
    public class LoginThanhVienModel
    {
        [Required]
        public string HoTen { set; get; } 
        public string Passwords { set; get; }

       public  string remember { set; get; }

    }
}