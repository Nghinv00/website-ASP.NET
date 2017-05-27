namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Account")]
    public partial class Account
    {
        [Key]
        public int idAcc { get; set; }

        public int idEmp { get; set; }

        [Required]
        [StringLength(2000)]
        public string Username { get; set; }

        [Required]
        [StringLength(2000)]
        public string Password { get; set; }

        public int Permission { get; set; }

        public int State { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
