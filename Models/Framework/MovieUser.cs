namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MovieUser")]
    public partial class MovieUser
    {
        public int Id { get; set; }

        public int IdUser { get; set; }

        public int IdMovie { get; set; }

        [Required]
        [StringLength(2000)]
        public string ThoiGianXem { get; set; }

        [Required]
        [StringLength(2000)]
        public string Secsion { get; set; }

        public virtual Movie Movie { get; set; }

        public virtual ThanhVien ThanhVien { get; set; }
    }
}
