using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;


namespace Web_cafe_film.Models
{
    [MetadataTypeAttribute(typeof(MovieMetadata))]
	public partial class Movie
	{
		internal sealed class MovieMetadata
        {           
            [Required(ErrorMessage = "Vui lòng nhập dữ liệu cho trường này")]
            [Display(Name = "Số thứ tự")]
            public int MovieID { get; set; }

            [Required(ErrorMessage = "Vui lòng nhập dữ liệu cho trường này")]
            [Display(Name = "Tên Phim")]
            public string MovieName { get; set; }

            [Required(ErrorMessage = "Vui lòng nhập dữ liệu cho trường này")]
            [Display(Name = "Link Nhúng")]
            public string URLDetail { get; set; }

            //[Required(ErrorMessage = "Vui lòng nhập dữ liệu cho trường này")]
            [Display(Name = "Ảnh Poster")]
            public string LinkImage { get; set; }

            [Required(ErrorMessage = "Vui lòng nhập dữ liệu cho trường này")]
            [Display(Name = "Mô Tả Về Phim")]
            public string Descriptions { get; set; }

            [Required(ErrorMessage = "Vui lòng nhập dữ liệu cho trường này")]
            [Display(Name = "Đạo Diễn")]
            public string Director { get; set; }

            [Required(ErrorMessage = "Vui lòng nhập dữ liệu cho trường này")]
            [Display(Name = "Biên Kịch")]
            public string Writer { get; set; }

            [Required(ErrorMessage = "Vui lòng nhập dữ liệu cho trường này")]
            [Display(Name = "Diễn Viên Chính")]
            public string Stars { get; set; }


            public Nullable<int> YearProduce { get; set; }


            public string AddressProduce { get; set; }

            [Required(ErrorMessage = "Vui lòng nhập dữ liệu cho trường này")]
            [Display(Name = "Thời Lượng")]
            public string RunningTime { get; set; }

            [DataType(DataType.Date)]
            [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")/*, ApplyFormatInEditMode = true;*/]
            [Required(ErrorMessage = "Vui lòng nhập dữ liệu cho trường này")]
            [Display(Name = "Thời Gian SX")]
            public Nullable<System.DateTime> ReleaseDate { get; set; }

        
            public string ReleaseAddress { get; set; }

            public byte[] Img { get; set; }

            public Nullable<int> idEmp { get; set; }



            [Required(ErrorMessage = "Vui lòng nhập dữ liệu vào trường này")]
            [Display(Name = "Views")]
            public string New { get; set; }


            [Required(ErrorMessage = "Vui lòng nhập dữ liệu vào trường này")]
            [Display(Name = "Thể Loại")]
            public Nullable<int> CategoryID { get; set; }

        }
    }
}