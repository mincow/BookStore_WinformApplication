namespace BookStore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Customer")]
    public partial class Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            Invoices = new HashSet<Invoice>();
        }

        [StringLength(20)]
        public string CustomerID { get; set; }

        [Required]
        [StringLength(30)]
        public string FullName { get; set; }

        [Required]
        [StringLength(12)]
        public string PhoneNumber { get; set; }

        public string Address { get; set; }

        [Required]
        [StringLength(20)]
        public string VIPID { get; set; }

        public virtual VIP VIP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Invoice> Invoices { get; set; }
    }
}
