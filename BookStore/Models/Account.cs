namespace BookStore.Models
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
        [StringLength(30)]
        public string UserName { get; set; }

        [Required]
        [StringLength(30)]
        public string PassWord { get; set; }

        [Required]
        [StringLength(20)]
        public string EmployeeID { get; set; }

        public bool Roles { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
