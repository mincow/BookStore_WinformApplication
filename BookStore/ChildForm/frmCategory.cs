using BookStore.Models;
using System;
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
    public partial class frmCategory : Form
    {
        BookStoreDB context = new BookStoreDB();
        public frmCategory()
        {
            InitializeComponent();
        }

        Account acc = new Account();
        public frmCategory(Account acc)
        {
            this.acc = acc;
            InitializeComponent();
        }

        private void frmCategory_Load(object sender, EventArgs e)
        {
            if (acc.Roles == false)
                btnAdd.Enabled = false;
            try
            {
                List<Category> listCategory = context.Categories.ToList();
                BindGrid(listCategory);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BindGrid(List<Category> listCategory)
        {
            dgvCategory.Rows.Clear();
            foreach (var item in listCategory)
            {
                int index = dgvCategory.Rows.Add();
                dgvCategory.Rows[index].Cells[2].Value = item.CategoryID;
                dgvCategory.Rows[index].Cells[3].Value = item.CategoryName;
                dgvCategory.Rows[index].Cells[4].Value = item.Supplier.SupplierName;
            }
        }

        private void Reload()
        {
            try
            {
                List<Category> listCategory = context.Categories.ToList();
                BindGrid(listCategory);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (acc.Roles == true)
            {
                if (dgvCategory.Columns[e.ColumnIndex].Name == "Delete")
                {
                    if (MessageBox.Show("Bạn chắc chắn muốn xóa", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string categoryID;
                        categoryID = dgvCategory.Rows[e.RowIndex].Cells[2].Value.ToString();
                        Category bDel = context.Categories.FirstOrDefault(p => p.CategoryID == categoryID);
                        if (bDel != null)
                        {
                            context.Categories.Remove(bDel);
                            context.SaveChanges();
                            Reload();
                            MessageBox.Show("Xóa thành công!");
                        }
                    }
                }
                if (dgvCategory.Columns[e.ColumnIndex].Name == "Edit")
                {
                    string categoryID, categoryName, supplierName;
                    categoryID = Convert.ToString(dgvCategory.Rows[e.RowIndex].Cells[2].Value);
                    categoryName = Convert.ToString(dgvCategory.Rows[e.RowIndex].Cells[3].Value);
                    supplierName = Convert.ToString(dgvCategory.Rows[e.RowIndex].Cells[4].Value);
                    frmAddEdit_Category f = new frmAddEdit_Category(categoryID, categoryName, supplierName);
                    f.Show();
                }
            }    
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            List<Category> listSearch = new List<Category>();
            List<Category> listCategory = context.Categories.ToList();
            if (txtSearch.Text != null)
            {
                foreach (Category item in listCategory)
                {
                    if (item.CategoryID.ToLower().Contains(txtSearch.Text.ToLower()) 
                        || item.CategoryName.ToLower().Contains(txtSearch.Text.ToLower())
                        || item.Supplier.SupplierName.ToLower().Contains(txtSearch.Text.ToLower()))
                    {
                        listSearch.Add(item);
                    }
                    BindGrid(listSearch);

                }
            }
            else
                BindGrid(listCategory);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddEdit_Category fAdd_Category = new frmAddEdit_Category();
            fAdd_Category.Show();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSearch.ResetText();
            Reload();
        }
    }
}
