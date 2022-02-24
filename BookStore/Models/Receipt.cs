namespace BookStore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Receipt")]
    public partial class Receipt
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Receipt()
        {
            ReceiptDetails = new HashSet<ReceiptDetail>();
        }

        [StringLength(20)]
        public string ReceiptID { get; set; }

        [Required]
        [StringLength(20)]
        public string PurchaseOrderID { get; set; }

        public DateTime ImportDate { get; set; }

        public bool? Status { get; set; }

        public string Note { get; set; }

        public virtual PurchaseOrder PurchaseOrder { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReceiptDetail> ReceiptDetails { get; set; }
    }
}
