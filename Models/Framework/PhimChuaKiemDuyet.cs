namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhimChuaKiemDuyet")]
    public partial class PhimChuaKiemDuyet
    {
        public int id { get; set; }

        public int? MovieID { get; set; }

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

        [Column("new")]
        [StringLength(2000)]
        public string _new { get; set; }

        public int? CategoryID { get; set; }
    }
}
