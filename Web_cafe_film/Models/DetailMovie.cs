//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Web_cafe_film.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DetailMovie
    {
        public int IdDetail { get; set; }
        public Nullable<int> MovieID { get; set; }
        public string MoviePart { get; set; }
        public string ImagePicture { get; set; }
        public string Note { get; set; }
    
        public virtual Movie Movie { get; set; }
    }
}