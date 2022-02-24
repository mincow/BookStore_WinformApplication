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
    public partial class frmPromotion : Form
    {
        BookStoreDB context = new BookStoreDB();
        public frmPromotion()
        {
            InitializeComponent();
        }

        Account acc = new Account();
        public frmPromotion(Account acc)
        {
            this.acc = acc;
            InitializeComponent();
        }

        private void frmPromotion_Load(object sender, EventArgs e)
        {
            if (acc.Roles == false)
                btnAdd.Enabled = false;
            try
            {
                List<Promotion> listPromotion = context.Promotions.ToList();
                BindGrid(listPromotion);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BindGrid(List<Promotion> listPromotion)
        {
            dgvPromotion.Rows.Clear();
            foreach (var item in listPromotion)
            {
                int index = dgvPromotion.Rows.Add();
                dgvPromotion.Rows[index].Cells[2].Value = item.PromotionID;
                dgvPromotion.Rows[index].Cells[3].Value = item.StartDate.ToShortDateString();
                dgvPromotion.Rows[index].Cells[4].Value = item.Duration;
                dgvPromotion.Rows[index].Cells[5].Value = item.Discount;
                dgvPromotion.Rows[index].Cells[6].Value = item.Note;
            }
        }

        private void Reload()
        {
            try
            {
                List<Promotion> listPromotion = context.Promotions.ToList();
                BindGrid(listPromotion);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (acc.Roles == true)
            {
                if (dgvPromotion.Columns[e.ColumnIndex].Name == "Delete")
                {
                    if (MessageBox.Show("Bạn chắc chắn muốn xóa", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string promotionID;
                        promotionID = dgvPromotion.Rows[e.RowIndex].Cells[2].Value.ToString();
                        Promotion bDel = context.Promotions.FirstOrDefault(p => p.PromotionID == promotionID);
                        if (bDel != null)
                        {
                            context.Promotions.Remove(bDel);
                            context.SaveChanges();
                            Reload();
                            MessageBox.Show("Xóa thành công!");
                        }
                    }
                }
                if (dgvPromotion.Columns[e.ColumnIndex].Name == "Edit")
                {
                    string promotionID, duration, discount, note; DateTime startDate;
                    promotionID = Convert.ToString(dgvPromotion.Rows[e.RowIndex].Cells[2].Value);
                    startDate = Convert.ToDateTime(dgvPromotion.Rows[e.RowIndex].Cells[3].Value);
                    duration = Convert.ToString(dgvPromotion.Rows[e.RowIndex].Cells[4].Value);
                    discount = Convert.ToString(dgvPromotion.Rows[e.RowIndex].Cells[5].Value);
                    note = Convert.ToString(dgvPromotion.Rows[e.RowIndex].Cells[6].Value);
                    frmAddEdit_Promotion f = new frmAddEdit_Promotion(promotionID, duration, discount, note, startDate);
                    f.Show();
                }
            }    
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            List<Promotion> listSearch = new List<Promotion>();
            List<Promotion> listPromotion = context.Promotions.ToList();
            if (txtSearch.Text != null)
            {
                foreach (Promotion item in listPromotion)
                {
                    if (item.PromotionID.ToLower().Contains(txtSearch.Text.ToLower())
                        || item.StartDate.ToShortTimeString().Contains(txtSearch.Text.ToLower())
                        || item.Duration.ToString().ToLower().Contains(txtSearch.Text.ToLower())
                        || item.Discount.ToString().Contains(txtSearch.Text.ToLower())
                        || item.Note.ToLower().Contains(txtSearch.Text.ToLower()))
                    {
                        listSearch.Add(item);
                    }
                    BindGrid(listSearch);

                }
            }
            else
                BindGrid(listPromotion);
        }

        private void SearchDate()
        {
            try
            {
                List<Promotion> listSearch = new List<Promotion>();
                List<Promotion> listPromotion = context.Promotions.ToList();
                if (dtpTo.Value > dtpFrom.Value)
                {
                    throw new Exception("Ngày bắt đầu lớn hơn ngày kết thúc !!!");
                }
                listSearch = listPromotion.Where(p => p.StartDate >= dtpTo.Value && p.StartDate.AddDays(p.Duration) <= dtpFrom.Value).ToList();
                BindGrid(listSearch);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtpTo_ValueChanged(object sender, EventArgs e)
        {
            SearchDate();
        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            SearchDate();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.ResetText();
            dtpTo.Value = dtpFrom.Value = DateTime.Now;
            Reload();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddEdit_Promotion f = new frmAddEdit_Promotion();
            f.Show();
        }
    }
}
