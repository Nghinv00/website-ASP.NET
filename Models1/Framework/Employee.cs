namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employee")]
    public partial class Employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee()
        {
            Movies = new HashSet<Movie>();
        }

        [Key]
        public int idEmp { get; set; }

        [Required]
        [StringLength(2000)]
        public string NameEmp { get; set; }

        [Required]
        [StringLength(2000)]
        public string Phone { get; set; }

        [Required]
        [StringLength(2000)]
        public string Address { get; set; }

        public DateTime? Birthday { get; set; }

        public bool? Sex { get; set; }

        [StringLength(2000)]
        public string Note { get; set; }

        public virtual Account Account { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Movie> Movies { get; set; }
    }
}
