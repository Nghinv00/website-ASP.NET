namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DoanhThu")]
    public partial class DoanhThu
    {
        public int Id { get; set; }

        [Column(TypeName = "money")]
        public decimal? Domain { get; set; }

        [Column(TypeName = "money")]
        public decimal? Hosting { get; set; }

        [Column(TypeName = "money")]
        public decimal? MuaPhim { get; set; }

        [Column(TypeName = "money")]
        public decimal? BanPhim { get; set; }

        [Column(TypeName = "money")]
        public decimal? BaoTri { get; set; }

        [Column(TypeName = "money")]
        public decimal? TongSoDu { get; set; }

        public int IdEmployee { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
