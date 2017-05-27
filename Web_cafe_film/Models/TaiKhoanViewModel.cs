using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Web_cafe_film.Models
{
    public class DangNhapViewModel
    {
        [Required]
        [Display(Name = "Tên đăng nhập")]
        public string TenDangNhap { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Mật khẩu")]
        public string PassWord { get; set; }
    }
    public class DangKyViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Gmail { get; set; }


     [Required(ErrorMessage ="Mời nhập tên để đăng nhập", AllowEmptyStrings =false)]
        //[Required]
        [Display(Name = "Tên đăng nhập")]
        public string TenDangNhap { get; set; }

        //[Required]
        //[Display(Name = "Tên đầy đủ")]
        //public string TenDayDu { get; set; }

       [Required(ErrorMessage ="Mời nhập mật khẩu", AllowEmptyStrings = false)]
        [DataType(DataType.Password)]
        [Display(Name = "Mật khẩu")]
        public string MatKhau { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Xác nhận mật khẩu")]
        [Compare("MatKhau", ErrorMessage = "Mật khẩu không trùng khớp")]
        public string XacNhanMatKhau { get; set; }
    }
}