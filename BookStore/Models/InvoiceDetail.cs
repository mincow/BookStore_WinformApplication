namespace BookStore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class InvoiceDetail
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string InvoiceID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string BookID { get; set; }

        public int Quantity { get; set; }

        public decimal UnitPrice { get; set; }

        public virtual Book Book { get; set; }

        public virtual Invoice Invoice { get; set; }
    }
}
