using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace BookStore.Models
{
    public partial class BookStoreDB : DbContext
    {
        public BookStoreDB()
            : base("name=BookStoreDB")
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<InvoiceDetail> InvoiceDetails { get; set; }
        public virtual DbSet<Promotion> Promotions { get; set; }
        public virtual DbSet<Publisher> Publishers { get; set; }
        public virtual DbSet<PurchaseOrder> PurchaseOrders { get; set; }
        public virtual DbSet<PurchaseOrderDetail> PurchaseOrderDetails { get; set; }
        public virtual DbSet<Receipt> Receipts { get; set; }
        public virtual DbSet<ReceiptDetail> ReceiptDetails { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<VIP> VIPs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.PassWord)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.EmployeeID)
                .IsUnicode(false);

            modelBuilder.Entity<Book>()
                .Property(e => e.BookID)
                .IsUnicode(false);

            modelBuilder.Entity<Book>()
                .Property(e => e.CategoryID)
                .IsUnicode(false);

            modelBuilder.Entity<Book>()
                .Property(e => e.PublisherID)
                .IsUnicode(false);

            modelBuilder.Entity<Book>()
                .Property(e => e.BuyPrice)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Book>()
                .Property(e => e.SellPrice)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Book>()
                .HasMany(e => e.InvoiceDetails)
                .WithRequired(e => e.Book)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Book>()
                .HasMany(e => e.PurchaseOrderDetails)
                .WithRequired(e => e.Book)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Book>()
                .HasMany(e => e.ReceiptDetails)
                .WithRequired(e => e.Book)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Category>()
                .Property(e => e.CategoryID)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .Property(e => e.SupplierID)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .HasMany(e => e.Books)
                .WithRequired(e => e.Category)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.CustomerID)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.PhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.VIPID)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.EmployeeID)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.IDCard)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.PhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Accounts)
                .WithRequired(e => e.Employee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Invoices)
                .WithRequired(e => e.Employee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Invoice>()
                .Property(e => e.InvoiceID)
                .IsUnicode(false);

            modelBuilder.Entity<Invoice>()
                .Property(e => e.EmployeeID)
                .IsUnicode(false);

            modelBuilder.Entity<Invoice>()
                .Property(e => e.PromotionID)
                .IsUnicode(false);

            modelBuilder.Entity<Invoice>()
                .Property(e => e.CustomerID)
                .IsUnicode(false);

            modelBuilder.Entity<Invoice>()
                .Property(e => e.Total)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Invoice>()
                .HasMany(e => e.InvoiceDetails)
                .WithRequired(e => e.Invoice)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<InvoiceDetail>()
                .Property(e => e.InvoiceID)
                .IsUnicode(false);

            modelBuilder.Entity<InvoiceDetail>()
                .Property(e => e.BookID)
                .IsUnicode(false);

            modelBuilder.Entity<InvoiceDetail>()
                .Property(e => e.UnitPrice)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Promotion>()
                .Property(e => e.PromotionID)
                .IsUnicode(false);

            modelBuilder.Entity<Publisher>()
                .Property(e => e.PublisherID)
                .IsUnicode(false);

            modelBuilder.Entity<Publisher>()
                .HasMany(e => e.Books)
                .WithRequired(e => e.Publisher)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PurchaseOrder>()
                .Property(e => e.PurchaseOrderID)
                .IsUnicode(false);

            modelBuilder.Entity<PurchaseOrder>()
                .Property(e => e.SupplierID)
                .IsUnicode(false);

            modelBuilder.Entity<PurchaseOrder>()
                .HasMany(e => e.PurchaseOrderDetails)
                .WithRequired(e => e.PurchaseOrder)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PurchaseOrder>()
                .HasMany(e => e.Receipts)
                .WithRequired(e => e.PurchaseOrder)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PurchaseOrderDetail>()
                .Property(e => e.PurchaseOrderID)
                .IsUnicode(false);

            modelBuilder.Entity<PurchaseOrderDetail>()
                .Property(e => e.BookID)
                .IsUnicode(false);

            modelBuilder.Entity<Receipt>()
                .Property(e => e.ReceiptID)
                .IsUnicode(false);

            modelBuilder.Entity<Receipt>()
                .Property(e => e.PurchaseOrderID)
                .IsUnicode(false);

            modelBuilder.Entity<Receipt>()
                .HasMany(e => e.ReceiptDetails)
                .WithRequired(e => e.Receipt)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ReceiptDetail>()
                .Property(e => e.ReceiptID)
                .IsUnicode(false);

            modelBuilder.Entity<ReceiptDetail>()
                .Property(e => e.BookID)
                .IsUnicode(false);

            modelBuilder.Entity<ReceiptDetail>()
                .Property(e => e.UnitPrice)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.SupplierID)
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.PhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .HasMany(e => e.Categories)
                .WithRequired(e => e.Supplier)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Supplier>()
                .HasMany(e => e.PurchaseOrders)
                .WithRequired(e => e.Supplier)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<VIP>()
                .Property(e => e.VIPID)
                .IsUnicode(false);

            modelBuilder.Entity<VIP>()
                .HasMany(e => e.Customers)
                .WithRequired(e => e.VIP)
                .WillCascadeOnDelete(false);
        }
    }
}
