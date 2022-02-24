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
    public partial class frmAdd_Supplier : Form
    {
        BookStoreDB context = new BookStoreDB();
        public frmAdd_Supplier()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtSupplierName.ResetText();
            txtAddress.ResetText();
            txtPhoneNumber.ResetText();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAddress.Text == "" || txtPhoneNumber.Text == "" || txtSupplierName.Text == "")
                    throw new Exception("Vui lòng nhập đầy đủ thông tin !!!");
                if (txtPhoneNumber.Text.Length > 13)
                    throw new Exception("Không đúng định dạng SĐT");
                List<Supplier> listSupplier = context.Suppliers.Where(p => (p.SupplierName.ToLower() == txtSupplierName.Text.ToLower() && p.PhoneNumber == txtPhoneNumber.Text)
                                                                         || (p.SupplierName.ToLower() == txtSupplierName.Text.ToLower() && p.Address.ToLower() == txtAddress.Text.ToLower())
                                                                         || (p.Address.ToLower() == txtAddress.Text.ToLower() && p.PhoneNumber == txtPhoneNumber.Text)
                                                                         || p.PhoneNumber == txtPhoneNumber.Text).ToList();
                if (listSupplier.Count != 0)
                    throw new Exception("Nhà cung cấp đã tồn tại !!!");
                int count = context.Suppliers.Count();
                DateTime dt = DateTime.Now;
                Supplier sup = new Supplier();
                sup.SupplierID = "NCC" + (count + 1).ToString().PadLeft(3, '0') +"_"+ dt.Day+dt.Month+dt.Hour+dt.Minute+dt.Second;
                sup.SupplierName = txtSupplierName.Text.ToUpper();
                sup.Address = txtAddress.Text;
                sup.PhoneNumber = txtPhoneNumber.Text;
                context.Suppliers.Add(sup);
                context.SaveChanges();
                MessageBox.Show("Thêm thành công");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
