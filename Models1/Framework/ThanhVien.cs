namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThanhVien")]
    public partial class ThanhVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ThanhVien()
        {
            RatingOfMovies = new HashSet<RatingOfMovie>();
        }

        [Key]
        public int MaThanhVien { get; set; }

        [StringLength(200)]
        public string HoTen { get; set; }

        public bool? GioiTinh { get; set; }

        [StringLength(200)]
        public string Passwords { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgaySinh { get; set; }

        [StringLength(200)]
        public string Gmail { get; set; }

        public int? SoDienThoai { get; set; }

        public int? OccupationID { get; set; }

        public virtual Occupation Occupation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RatingOfMovie> RatingOfMovies { get; set; }
    }
}
