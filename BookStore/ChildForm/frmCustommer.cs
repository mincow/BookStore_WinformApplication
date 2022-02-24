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
    public partial class frmCustommer : Form
    {
        BookStoreDB context = new BookStoreDB();
        public frmCustommer()
        {
            InitializeComponent();
        }

        Account acc = new Account();
        public frmCustommer(Account acc)
        {
            this.acc = acc;
            InitializeComponent();
        }

        private void frmCustommer_Load(object sender, EventArgs e)
        {
            //Tự cập nhật mức VIP            
            foreach (var item in context.Customers)
            {
                List<Invoice> listInvoiceOfItem = context.Invoices.Where(p => p.CustomerID == item.CustomerID).ToList();
                double total = 0;
                foreach(var i in listInvoiceOfItem)
                {
                    total += Convert.ToDouble(i.Total);
                }
                if (total >= 20000000)
                    item.VIPID = "V03";
                else if (total >= 35000000)
                    item.VIPID = "V02";
                else if (total >= 50000000)
                    item.VIPID = "V01";
                else
                    item.VIPID = "V00";
            }

            try
            {
                List<Customer> listCustomer = context.Customers.ToList();
                List<VIP> listVip = context.VIPs.ToList();
                BindGrid(listCustomer);
                txtMaKH.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BindGrid(List<Customer> listCustomer)
        {
            dgvCustommer.Rows.Clear();
            foreach (var item in listCustomer)
            {
                int index = dgvCustommer.Rows.Add();
                dgvCustommer.Rows[index].Cells[2].Value = item.CustomerID;
                dgvCustommer.Rows[index].Cells[3].Value = item.FullName;
                dgvCustommer.Rows[index].Cells[4].Value = item.PhoneNumber;
                dgvCustommer.Rows[index].Cells[5].Value = item.Address;
                dgvCustommer.Rows[index].Cells[6].Value = item.VIPID;                
            }
        }

        private void dgvCustommer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCustommer.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvCustommer.CurrentRow.Selected = true;
                txtMaKH.Enabled = false;
                txtHoTen.Enabled = false;
                txtSDT.Enabled = false;
                txtDiachi.Enabled = false;
                txtMaKH.Text = dgvCustommer.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtHoTen.Text = dgvCustommer.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtSDT.Text = dgvCustommer.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtDiachi.Text = dgvCustommer.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtVIP.Text = dgvCustommer.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
            if (dgvCustommer.Columns[e.ColumnIndex].Name == "Delete" && acc.Roles == true)
            {
                if (MessageBox.Show("Bạn chắc chắn muốn xóa", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string employeeID;
                    employeeID = dgvCustommer.Rows[e.RowIndex].Cells[2].Value.ToString();
                    Employee bDel = context.Employees.FirstOrDefault(p => p.EmployeeID == employeeID);
                    if (bDel != null)
                    {
                        context.Employees.Remove(bDel);
                        context.SaveChanges();
                        Reload();
                        MessageBox.Show("Xóa thành công!");
                    }
                }
            }
            if(dgvCustommer.Columns[e.ColumnIndex].Name == "Edit")
            {
                txtHoTen.Enabled = true;
                txtSDT.Enabled = true;
                txtDiachi.Enabled = true;
                dgvCustommer.CurrentRow.Selected = true;
                txtMaKH.Text = dgvCustommer.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtHoTen.Text = dgvCustommer.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtSDT.Text = dgvCustommer.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtDiachi.Text = dgvCustommer.Rows[e.RowIndex].Cells[5].Value.ToString();
            }    
        }
        private void Reload()
        {
            try
            {
                List<Customer> listCustomer = context.Customers.ToList();
                BindGrid(listCustomer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void refresh()
        {
            txtMaKH.Text = "";
            txtHoTen.Text = "";
            txtSDT.Text = "";
            txtDiachi.Text = "";
            txtVIP.Text = "";
        }
        private int GetSelectedRow(string MaKH)
        {
            List<Customer> listCus = context.Customers.ToList();
            for (int i = 0; i <listCus.Count; i++)
            {
                if (listCus[i].CustomerID == MaKH)
                {
                    return i;
                }
            }
            return -1;
        }
        private bool check()
        {
            if (txtHoTen.Text == "" || txtSDT.Text == "")
            {
                MessageBox.Show("vui lòng nhập đầy đủ thông tin");
                return false;
            }
            else
                return true;

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //Tạo mã KH tự động
            string customerID = "KH_";
            string[] customerName = txtHoTen.Text.Trim().Split(new char[] { ' ' });
            foreach (string s in customerName)
            {

                if (s.Trim() != "")
                    customerID += s[0];
            }
            int count = context.Customers.Count(); ;
            customerID += (count + 1).ToString().PadLeft(3, '0');
            txtVIP.Text = "V00";
            if (check())
            {

                if (GetSelectedRow(txtMaKH.Text) == -1)
                {
                    Customer cus = new Customer()
                    {
                        CustomerID = customerID,
                        FullName = txtHoTen.Text,
                        PhoneNumber = txtSDT.Text,
                        Address = txtDiachi.Text,
                        VIPID = txtVIP.Text
                    };
                    context.Customers.Add(cus);
                    context.SaveChanges();
                    Reload();
                    refresh();
                    MessageBox.Show("Thêm thành công!");
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtHoTen.Enabled == true)
                {
                    if (txtMaKH.Text == "")
                        throw new Exception("Không tìm thấy mã KH");
                    Customer cusUpdate = context.Customers.FirstOrDefault(p => p.CustomerID == txtMaKH.Text);
                    if (cusUpdate != null)
                    {
                        cusUpdate.FullName = txtHoTen.Text;
                        cusUpdate.PhoneNumber = txtSDT.Text;
                        cusUpdate.Address = txtDiachi.Text;
                        context.SaveChanges();
                        MessageBox.Show("Cập nhật thành công!");
                        Reload();
                        refresh();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }
    }
}
