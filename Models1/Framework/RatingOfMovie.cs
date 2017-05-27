namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RatingOfMovie")]
    public partial class RatingOfMovie
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaThanhVien { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MovieID { get; set; }

        public int? Rating { get; set; }

        public int? Data { get; set; }

        public virtual Movie Movie { get; set; }

        public virtual ThanhVien ThanhVien { get; set; }
    }
}
