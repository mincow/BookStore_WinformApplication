namespace BookStore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ReceiptDetail
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string ReceiptID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string BookID { get; set; }

        public int Quantity { get; set; }

        public decimal UnitPrice { get; set; }

        public virtual Book Book { get; set; }

        public virtual Receipt Receipt { get; set; }
    }
}
