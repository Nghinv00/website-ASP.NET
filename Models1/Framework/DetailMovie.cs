namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DetailMovie")]
    public partial class DetailMovie
    {
        [Key]
        public int IdDetail { get; set; }

        public int? MovieID { get; set; }

        [Required]
        [StringLength(2000)]
        public string MoviePart { get; set; }

        [StringLength(2000)]
        public string ImagePicture { get; set; }

        [StringLength(2000)]
        public string Note { get; set; }

        public virtual Movie Movie { get; set; }
    }
}
