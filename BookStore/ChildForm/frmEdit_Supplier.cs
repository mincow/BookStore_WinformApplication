using System;
using BookStore.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore.ChildForm
{
    public partial class frmEdit_Supplier : Form
    {
        BookStoreDB context = new BookStoreDB();
        public frmEdit_Supplier()
        {
            InitializeComponent();
        }

        string supplierID, supplierName, address, phoneNumber;

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Reload();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Supplier supplier = context.Suppliers.FirstOrDefault(p => p.SupplierID == txtSupplierID.Text);
            supplier.SupplierName = txtSupplier.Text;
            supplier.Address = txtAddress.Text;
            supplier.PhoneNumber = txtPhoneNumber.Text;
            MessageBox.Show("Cập nhật thành công");
            this.Close();
        }

        public frmEdit_Supplier(string supplierID, string supplierName, string address, string phoneNumber)
        {
            this.supplierID = supplierID;
            this.supplierName = supplierName;
            this.address = address;
            this.phoneNumber = phoneNumber;
            InitializeComponent();
        }

        private void frmEdit_Supplier_Load(object sender, EventArgs e)
        {
            txtSupplierID.Text = supplierID;
            txtSupplierID.Enabled = false;
            txtSupplier.Text = supplierName;
            txtAddress.Text = address;
            txtPhoneNumber.Text = phoneNumber;
        }

        private void Reload()
        {
            txtSupplierID.Text = supplierID;
            txtSupplierID.Enabled = false;
            txtSupplier.Text = supplierName;
            txtAddress.Text = address;
            txtPhoneNumber.Text = phoneNumber;
        }
    }
}
