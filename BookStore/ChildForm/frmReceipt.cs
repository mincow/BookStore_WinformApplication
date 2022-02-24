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
    public partial class frmReceipt : Form
    {
        BookStoreDB context = new BookStoreDB();
        public frmReceipt()
        {
            InitializeComponent();
        }

        private void frmReceipt_Load(object sender, EventArgs e)
        {
            try
            {
                List<Receipt> listReceipt = context.Receipts.ToList();
                BindGrid(listReceipt);
                dgvDetails.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void BindGrid(List<Receipt> listResceipt)
        {

            dgvReceipt.Rows.Clear();
            foreach (var item in listResceipt)
            {
                int index = dgvReceipt.Rows.Add();
                dgvReceipt.Rows[index].Cells[2].Value = item.ReceiptID;
                dgvReceipt.Rows[index].Cells[3].Value = item.PurchaseOrderID;
                dgvReceipt.Rows[index].Cells[4].Value = item.ReceiptDetails.Sum(p => p.Quantity);
                dgvReceipt.Rows[index].Cells[5].Value = item.ImportDate.ToShortDateString();
                dgvReceipt.Rows[index].Cells[6].Value = item.ReceiptDetails.Sum(p => p.Quantity * p.UnitPrice);
                if (item.Status == false)
                {
                    dgvReceipt.Rows[index].Cells[7].Value = "Chưa đủ";
                }
                else
                    dgvReceipt.Rows[index].Cells[7].Value = "Đủ";
            }
        }

        

        private void Reload()
        {
            try
            {
                List<Receipt> listReceipt = context.Receipts.ToList();
                BindGrid(listReceipt);
                dgvDetails.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAdd_Receipt fAdd_Receipt = new frmAdd_Receipt();
            fAdd_Receipt.Show();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            List<Receipt> listSearch = new List<Receipt>();
            List<Receipt> listReceipt = context.Receipts.ToList();
            
            if (txtSearch.Text != null)
            {
                foreach (Receipt item in listReceipt)
                {
                    if (item.ReceiptID.ToLower().Contains(txtSearch.Text.ToLower())
                        || item.PurchaseOrderID.ToLower().Contains(txtSearch.Text.ToLower()))
                    {
                        listSearch.Add(item);
                    }
                    BindGrid(listSearch);

                }
            }
            else
                BindGrid(listReceipt);
        }

        private void dgvReceipt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string receiptID;
            receiptID = dgvReceipt.Rows[e.RowIndex].Cells[2].Value.ToString();
            if (dgvReceipt.Columns[e.ColumnIndex].Name == "Delete")
            {
                if (MessageBox.Show("Bạn chắc chắn muốn xóa", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Receipt bDel = context.Receipts.FirstOrDefault(p => p.ReceiptID == receiptID);
                    List<ReceiptDetail> listCheck = context.ReceiptDetails.Where(p => p.ReceiptID == bDel.ReceiptID).ToList();
                    if (bDel != null)
                    {
                        foreach(var item in listCheck)
                        {
                            context.ReceiptDetails.Remove(item);
                            context.SaveChanges();
                        }
                        context.Receipts.Remove(bDel);
                        context.SaveChanges();
                        Reload();
                        MessageBox.Show("Xóa thành công!");
                    }
                }
            }
            else if (dgvReceipt.Columns[e.ColumnIndex].Name == "Edit")
            {
                string recceiptID, supplierID;
                int totalQuantity;
                DateTime importDate;
                decimal total;
                recceiptID = Convert.ToString(dgvReceipt.Rows[e.RowIndex].Cells[2].Value);
                supplierID = Convert.ToString(dgvReceipt.Rows[e.RowIndex].Cells[3].Value);
                totalQuantity = Convert.ToInt32(dgvReceipt.Rows[e.RowIndex].Cells[4].Value);
                importDate = Convert.ToDateTime(dgvReceipt.Rows[e.RowIndex].Cells[5].Value);
                total = Convert.ToDecimal(dgvReceipt.Rows[e.RowIndex].Cells[6].Value);
                frmEdit_Receipt f = new frmEdit_Receipt(recceiptID, supplierID, totalQuantity, importDate, total);           
                f.Show();
            }
            else
            {
                List<ReceiptDetail> details = context.ReceiptDetails.Where(p => p.ReceiptID == receiptID).ToList();
                dgvDetails.Rows.Clear();
                foreach (var item in details)
                {
                    //Get Book Title
                    Book book = context.Books.FirstOrDefault(p => p.BookID == item.BookID);
                    int index = dgvDetails.Rows.Add();
                    dgvDetails.Rows[index].Cells[0].Value = item.ReceiptID;
                    dgvDetails.Rows[index].Cells[1].Value = book.Title;
                    dgvDetails.Rows[index].Cells[2].Value = item.Quantity;
                    dgvDetails.Rows[index].Cells[3].Value = item.UnitPrice;
                }              

            }
        }

        private void SearchDate()
        {
            try
            {
                List<Receipt> listSearch = new List<Receipt>();
                List<Receipt> listReceipt = context.Receipts.ToList();
                if (dtpTo.Value > dtpFrom.Value)
                {
                    throw new Exception("Ngày bắt đầu lớn hơn ngày kết thúc !!!");
                }
                else
                {
                    listSearch = listReceipt.Where(p => p.ImportDate >= dtpTo.Value && p.ImportDate <= dtpFrom.Value).ToList();
                    BindGrid(listSearch);
                }              
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
            dtpFrom.Enabled = true;
            dtpTo.Enabled = true;
            dtpTo.Value = dtpFrom.Value = DateTime.Now;
            Reload();
        }

    }
}
