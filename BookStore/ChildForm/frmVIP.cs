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
    public partial class frmVIP : Form
    {
        BookStoreDB context = new BookStoreDB();
        public frmVIP()
        {
            InitializeComponent();
        }

        Account acc = new Account();
        public frmVIP(Account acc)
        {
            this.acc = acc;
            InitializeComponent();
        }

        private void frmVIP_Load(object sender, EventArgs e)
        {
            txtVIPID.Enabled = false;
            txtDiscount.Enabled = false;
            try
            {
                List<VIP> listVIP = context.VIPs.ToList();
                BindGrid(listVIP);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BindGrid(List<VIP> listVIP)
        {
            dgvVIP.Rows.Clear();
            foreach (var item in listVIP)
            {
                int index = dgvVIP.Rows.Add();
                dgvVIP.Rows[index].Cells[2].Value = item.VIPID;
                dgvVIP.Rows[index].Cells[3].Value = item.Discount;
            }
        }

        private void Reload()
        {
            try
            {
                List<VIP> listVIP = context.VIPs.ToList();
                BindGrid(listVIP);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvPublisher_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvVIP.Columns[e.ColumnIndex].Name == "Delete" && acc.Roles == true)
            {
                if (MessageBox.Show("Bạn chắc chắn muốn xóa", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string vipID;
                    vipID = dgvVIP.Rows[e.RowIndex].Cells[2].Value.ToString();
                    VIP bDel = context.VIPs.FirstOrDefault(p => p.VIPID == vipID);
                    if (bDel != null)
                    {
                        context.VIPs.Remove(bDel);
                        context.SaveChanges();
                        Reload();
                        MessageBox.Show("Xóa thành công!");
                    }
                }
            }
            else if (dgvVIP.Columns[e.ColumnIndex].Name == "Edit" && acc.Roles == true)
            {
                txtVIPID.Text = dgvVIP.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtDiscount.Enabled = true;
                txtDiscount.Text = dgvVIP.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            else
            {                
                txtVIPID.Text = dgvVIP.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtDiscount.Text = dgvVIP.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            List<VIP> listSearch = new List<VIP>();
            List<VIP> listVIP = context.VIPs.ToList();
            if (txtSearch.Text != null)
            {
                foreach (VIP item in listVIP)
                {
                    if (item.VIPID.ToLower().Contains(txtSearch.Text.ToLower())
                        || item.Discount.ToString().ToLower().Contains(txtSearch.Text.ToLower()))
                    {
                        listSearch.Add(item);
                    }
                    BindGrid(listSearch);

                }
            }
            else
                BindGrid(listVIP);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtDiscount.Enabled == true && acc.Roles == true)
            {
                VIP vip = context.VIPs.FirstOrDefault(p => p.VIPID == txtVIPID.Text);
                vip.Discount = Convert.ToDouble(txtDiscount.Text);
                MessageBox.Show("Cập nhật thành công");
                txtVIPID.ResetText();
                txtDiscount.ResetText();
                context.SaveChanges();
                txtDiscount.Enabled = false;
            }            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtVIPID.Enabled == true && txtDiscount.Enabled == true && acc.Roles == true)
            {
                VIP vip = new VIP();
                List<VIP> listCheck = context.VIPs.Where(p => p.VIPID == txtVIPID.Text).ToList();
                if (listCheck.Count == 0)
                    vip.VIPID = txtVIPID.Text;
                else
                    MessageBox.Show("Mã VIP đã tồn tại");
                vip.Discount = Convert.ToDouble(txtDiscount.Text);
                MessageBox.Show("Tạo mới thành công");
                txtVIPID.ResetText();
                txtDiscount.ResetText();
                txtVIPID.Enabled = false;
                txtDiscount.Enabled = false;
            }            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSearch.ResetText();
            txtDiscount.ResetText();
            txtDiscount.Enabled = false;
            txtVIPID.ResetText();
            txtVIPID.Enabled = false;
            Reload();
        }
    }
}
