namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Occupation")]
    public partial class Occupation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Occupation()
        {
            ThanhViens = new HashSet<ThanhVien>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OccupationID { get; set; }

        [StringLength(2000)]
        public string OccupationName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThanhVien> ThanhViens { get; set; }
    }
}
