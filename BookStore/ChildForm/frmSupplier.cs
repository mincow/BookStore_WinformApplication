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
    public partial class frmSupplier : Form
    {
        BookStoreDB context = new BookStoreDB();
        public frmSupplier()
        {
            InitializeComponent();
        }

        Account acc = new Account();
        public frmSupplier(Account acc)
        {
            this.acc = acc;
            InitializeComponent();
        }

        private void frmSupplier_Load(object sender, EventArgs e)
        {
            try
            {
                List<Supplier> listSupplier = context.Suppliers.ToList();
                BindGrid(listSupplier);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BindGrid(List<Supplier> listSupplier)
        {

            dgvSupplier.Rows.Clear();
            foreach (var item in listSupplier)
            {
                int index = dgvSupplier.Rows.Add();
                dgvSupplier.Rows[index].Cells[2].Value = item.SupplierID;
                dgvSupplier.Rows[index].Cells[3].Value = item.SupplierName;
                dgvSupplier.Rows[index].Cells[4].Value = item.Address;
                dgvSupplier.Rows[index].Cells[5].Value = item.PhoneNumber;
            }
        }

        private void Reload()
        {
            try
            {
                BookStoreDB context1 = new BookStoreDB();
                List<Supplier> listSupplier = context1.Suppliers.ToList();
                BindGrid(listSupplier);               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvSupplier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string supplierID;
            supplierID = dgvSupplier.Rows[e.RowIndex].Cells[2].Value.ToString();
            if (dgvSupplier.Columns[e.ColumnIndex].Name == "Delete" && acc.Roles == true)
            {
                if (MessageBox.Show("Bạn chắc chắn muốn xóa", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Supplier bDel = context.Suppliers.FirstOrDefault(p => p.SupplierID == supplierID);
                    if (bDel != null)
                    {
                        context.Suppliers.Remove(bDel);
                        context.SaveChanges();
                        Reload();
                        MessageBox.Show("Xóa thành công!");
                    }
                }
            }
            if (dgvSupplier.Columns[e.ColumnIndex].Name == "Edit" && acc.Roles == true)
            {
                string suplierID, supplierName, address, phoneNumber;
                suplierID = Convert.ToString(dgvSupplier.Rows[e.RowIndex].Cells[2].Value);
                supplierName = Convert.ToString(dgvSupplier.Rows[e.RowIndex].Cells[3].Value);
                address = Convert.ToString(dgvSupplier.Rows[e.RowIndex].Cells[4].Value);
                phoneNumber = Convert.ToString(dgvSupplier.Rows[e.RowIndex].Cells[5].Value);
                frmEdit_Supplier f = new frmEdit_Supplier(supplierID, supplierName, address, phoneNumber);
                f.Show();
            }
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            frmAdd_Supplier f = new frmAdd_Supplier();
            f.Show();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSearch.ResetText();
            Reload();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            List<Supplier> listSearch = new List<Supplier>();
            List<Supplier> listSupplier = context.Suppliers.ToList();
            if (txtSearch.Text != null)
            {
                foreach (var item in listSupplier)
                {
                    if (item.SupplierName.ToLower().Contains(txtSearch.Text.ToLower())
                        || item.PhoneNumber.Contains(txtSearch.Text.ToLower())
                        || item.SupplierID.ToLower().Contains(txtSearch.Text.ToLower())
                        || item.Address.ToString().Contains(txtSearch.Text.ToLower()))
                    {
                        listSearch.Add(item);
                    }
                    BindGrid(listSearch);

                }
            }
            else
                BindGrid(listSupplier);
        }
    }
}
