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
    public partial class frmAddEdit_Category : Form
    {
        BookStoreDB context = new BookStoreDB();
        public frmAddEdit_Category()
        {
            InitializeComponent();
        }
        string cateID, cateName, supplierName;
        public frmAddEdit_Category(string CateID, string CateName, string SupplierName)
        {
            cateID = CateID;
            cateName = CateName;
            supplierName = SupplierName;
            InitializeComponent();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAdd_Category_Load(object sender, EventArgs e)
        {
            if (cateID == null)
            {
                txtCategoryID.Hide();
                lblCategoryID.Hide();
                pnlLineCategoryID.Hide();
            }
            else
                txtCategoryID.Enabled = false;
            txtCategoryID.Text = cateID;
            FillCmbSupplierName();
            txtName.Text = cateName;
            cmbSupplierName.Text = supplierName;
        }
        private bool check()
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return false;
            }
            else
                return true;
        }

        private void FillCmbSupplierName()
        {
            cmbSupplierName.DataSource = context.Suppliers.ToList();
            cmbSupplierName.DisplayMember = "SupplierName";
            cmbSupplierName.ValueMember = "SupplierID";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (check())
            {
                if (cateID == null)
                {
                    DateTime dt = DateTime.Now;
                    FillCmbSupplierName();
                    Category Cate = new Category()
                    {
                        CategoryID = "TL" + +dt.Day + dt.Month + dt.Year + "_" + dt.Hour + dt.Minute + dt.Second,
                        CategoryName = txtName.Text,
                        SupplierID = context.Suppliers.FirstOrDefault(p => p.SupplierID == cmbSupplierName.SelectedValue.ToString()).SupplierID
                    };
                    context.Categories.Add(Cate);
                    context.SaveChanges();
                    MessageBox.Show("ADD success!");
                    this.Close();
                }
                else
                {
                    Category CateUpdate = context.Categories.FirstOrDefault(p => p.CategoryID == txtCategoryID.Text);
                    if (CateUpdate != null)
                    {
                        CateUpdate.CategoryName = txtName.Text;
                        CateUpdate.SupplierID = context.Suppliers.FirstOrDefault(p => p.SupplierID == cmbSupplierName.SelectedValue.ToString()).SupplierID;
                        context.SaveChanges();
                        MessageBox.Show("Update success!");
                        this.Close();
                    }
                }
            }
        }
    }
}
