namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Movie")]
    public partial class Movie
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Movie()
        {
            DetailMovies = new HashSet<DetailMovie>();
            RatingOfMovies = new HashSet<RatingOfMovie>();
            MovieUsers = new HashSet<MovieUser>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MovieID { get; set; }

        [StringLength(2000)]
        public string MovieName { get; set; }

        [StringLength(2000)]
        public string URLDetail { get; set; }

        [StringLength(2000)]
        public string LinkImage { get; set; }

        [StringLength(2000)]
        public string Descriptions { get; set; }

        [StringLength(2000)]
        public string Director { get; set; }

        [StringLength(2000)]
        public string Writer { get; set; }

        [StringLength(2000)]
        public string Stars { get; set; }

        public int? YearProduce { get; set; }

        [StringLength(2000)]
        public string AddressProduce { get; set; }

        [StringLength(2000)]
        public string RunningTime { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ReleaseDate { get; set; }

        [StringLength(2000)]
        public string ReleaseAddress { get; set; }

        [Column(TypeName = "image")]
        public byte[] Img { get; set; }

        public int? idEmp { get; set; }

        [StringLength(2000)]
        public string New { get; set; }

        public int? CategoryID { get; set; }

        public virtual Category Category { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetailMovie> DetailMovies { get; set; }

        public virtual Employee Employee { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RatingOfMovie> RatingOfMovies { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MovieUser> MovieUsers { get; set; }
    }
}
