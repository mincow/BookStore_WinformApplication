namespace BookStore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Book")]
    public partial class Book
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Book()
        {
            InvoiceDetails = new HashSet<InvoiceDetail>();
            PurchaseOrderDetails = new HashSet<PurchaseOrderDetail>();
            ReceiptDetails = new HashSet<ReceiptDetail>();
        }

        [StringLength(20)]
        public string BookID { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        [StringLength(50)]
        public string Author { get; set; }

        public DateTime DatePublished { get; set; }

        [Required]
        [StringLength(20)]
        public string CategoryID { get; set; }

        [Required]
        [StringLength(20)]
        public string PublisherID { get; set; }

        public DateTime ImportDate { get; set; }

        public int Stock { get; set; }

        public decimal? BuyPrice { get; set; }

        public decimal SellPrice { get; set; }

        public byte[] Image { get; set; }

        public virtual Category Category { get; set; }

        public virtual Publisher Publisher { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InvoiceDetail> InvoiceDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PurchaseOrderDetail> PurchaseOrderDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReceiptDetail> ReceiptDetails { get; set; }
    }
}
