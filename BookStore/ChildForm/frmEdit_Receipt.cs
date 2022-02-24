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
    public partial class frmEdit_Receipt : Form
    {
        BookStoreDB context = new BookStoreDB();
        public frmEdit_Receipt()
        {
            InitializeComponent();
        }

        string recceiptID, supplierID;
        int totalQuantity;
        DateTime importDate;
        decimal total;
        public frmEdit_Receipt(string recceiptID, string supplierID, int totalQuantity, DateTime importDate, decimal total)
        {
            this.recceiptID = recceiptID;
            this.supplierID = supplierID;
            this.totalQuantity = totalQuantity;
            this.importDate = importDate;
            this.total = total;
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Reload();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Receipt receipt = context.Receipts.FirstOrDefault(p => p.ReceiptID == txtReceiptID.Text);
            receipt.ImportDate = dtpImportDate.Value;
            MessageBox.Show("Cập nhật thành công");
            this.Close();            
        }

        private void frmEdit_Receipt_Load(object sender, EventArgs e)
        {
            txtReceiptID.Text = recceiptID;
            txtReceiptID.Enabled = false;
            txtSupplier.Text = supplierID;
            txtTotalQuantity.Text = Convert.ToString(totalQuantity);
            txtTotalQuantity.Enabled = false;
            dtpImportDate.Value = importDate;
            txtTotal.Text = Convert.ToString(total);
            txtTotal.Enabled = false;
        }
        private void Reload()
        {
            txtReceiptID.Text = recceiptID;
            txtReceiptID.Enabled = false;
            txtSupplier.Text = supplierID;
            txtTotalQuantity.Text = Convert.ToString(totalQuantity);
            txtTotalQuantity.Enabled = false;
            dtpImportDate.Value = importDate;
            txtTotal.Text = Convert.ToString(total);
            txtTotal.Enabled = false;
        }
    }
}
