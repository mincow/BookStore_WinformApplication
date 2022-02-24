using BookStore.Models;
using BookStore.Report;
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
    public partial class frmInvoice : Form
    {
        BookStoreDB context = new BookStoreDB();
        Account accountSignIn = new Account();
        public frmInvoice(Account acc)
        {
            InitializeComponent();
            accountSignIn = acc;            
        }

        private void frmInvoice_Load(object sender, EventArgs e)
        {
            try
            {
                List<Invoice> listInvoice = context.Invoices.ToList();
                BindGrid(listInvoice);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BindGrid(List<Invoice> listInvoice)
        {
            
            dgvInvoice.Rows.Clear();
            foreach (var item in listInvoice)
            {
                int index = dgvInvoice.Rows.Add();
                dgvInvoice.Rows[index].Cells[2].Value = item.InvoiceID;
                dgvInvoice.Rows[index].Cells[3].Value = item.Date.ToShortDateString();
                dgvInvoice.Rows[index].Cells[4].Value = item.Employee.FullName;
                if (item.PromotionID == null)
                    dgvInvoice.Rows[index].Cells[5].Value = "";
                else
                    dgvInvoice.Rows[index].Cells[5].Value = item.PromotionID.ToString();
                if (item.CustomerID == null)
                    dgvInvoice.Rows[index].Cells[6].Value = "";
                else
                    dgvInvoice.Rows[index].Cells[6].Value = item.Customer.FullName;
                dgvInvoice.Rows[index].Cells[7].Value = item.Total;
                dgvInvoice.Rows[index].Cells[8].Value = item.Note;
            }
        }

        private void Reload()
        {
            try
            {
                List<Invoice> listInvoice = context.Invoices.ToList();
                BindGrid(listInvoice);
                dgvDetails.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvInvoice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string invoiceID;
            invoiceID = dgvInvoice.Rows[e.RowIndex].Cells[2].Value.ToString();
            try
            {
                
                if (dgvInvoice.Columns[e.ColumnIndex].Name == "Delete" && accountSignIn.Roles == true)
                {
                    if (MessageBox.Show("Bạn chắc chắn muốn xóa", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Invoice bDel = context.Invoices.FirstOrDefault(p => p.InvoiceID == invoiceID);
                        if (bDel != null)
                        {
                            foreach (var item in context.InvoiceDetails)
                            {
                                if (item.InvoiceID == bDel.InvoiceID)
                                    context.InvoiceDetails.Remove(item);
                            }
                            context.Invoices.Remove(bDel);
                            context.SaveChanges();
                            Reload();
                            MessageBox.Show("Xóa thành công!");
                        }
                    }
                }
                else if (dgvInvoice.Columns[e.ColumnIndex].Name == "Report")
                {
                    if (MessageBox.Show("Bạn có muốn in", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        invoiceID = dgvInvoice.Rows[e.RowIndex].Cells[2].Value.ToString();
                        frm_InvoiceReport f = new frm_InvoiceReport(invoiceID);
                        f.Show();
                    }
                }
                else
                {
                    List<InvoiceDetail> details = context.InvoiceDetails.Where(p => p.InvoiceID == invoiceID).ToList();
                    dgvDetails.Rows.Clear();
                    decimal total = 0;
                    foreach (var item in details)
                    {
                        int index = dgvDetails.Rows.Add();
                        dgvDetails.Rows[index].Cells[0].Value = item.InvoiceID;
                        dgvDetails.Rows[index].Cells[1].Value = item.BookID;
                        dgvDetails.Rows[index].Cells[2].Value = item.Quantity;
                        dgvDetails.Rows[index].Cells[3].Value = item.UnitPrice;
                        total += item.Quantity * item.UnitPrice;
                    }
                    string promotionID = dgvInvoice.Rows[e.RowIndex].Cells[5].Value.ToString();
                    if (promotionID != "")
                    {
                        Promotion prom = context.Promotions.FirstOrDefault(p => p.PromotionID == promotionID);
                        txtDiscountProm.Text = prom.Discount.ToString();
                    }
                    string customerName = dgvInvoice.Rows[e.RowIndex].Cells[6].Value.ToString();
                    if (customerName != "")
                    {
                        Customer cus = context.Customers.FirstOrDefault(p => p.FullName == customerName);
                        txtDiscountVIP.Text = context.VIPs.FirstOrDefault(p => p.VIPID == cus.VIPID).Discount.ToString();
                    }
                    txtTotalDiscount.Text = (Convert.ToDouble(txtDiscountVIP.Text) + Convert.ToDouble(txtDiscountProm.Text)).ToString();
                    txtTotal.Text = total.ToString();
                    txtPay.Text = dgvInvoice.Rows[e.RowIndex].Cells[7].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            List<Invoice> listSearch = new List<Invoice>();
            List<Invoice> listInvoice = context.Invoices.ToList();
            if (txtSearch.Text != null)
            {
                foreach (Invoice item in listInvoice)
                {
                    if (item.InvoiceID.ToLower().Contains(txtSearch.Text.ToLower())
                        || item.Employee.FullName.ToLower().Contains(txtSearch.Text.ToLower())
                        || item.Total.ToString().ToLower().Contains(txtSearch.Text.ToLower())
                        || item.Note.ToLower().Contains(txtSearch.Text.ToLower()))
                    {
                        listSearch.Add(item);
                    }
                    BindGrid(listSearch);

                }
            }
            else
                BindGrid(listInvoice);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAdd_Invoices fAdd_invoices = new frmAdd_Invoices(accountSignIn);
            fAdd_invoices.Show();
        }

        private void SearchDate()
        {
            try
            {
                List<Invoice> listSearch = new List<Invoice>();
                List<Invoice> listInvoice = context.Invoices.ToList();
                if (dtpTo.Value > dtpFrom.Value)
                {
                    throw new Exception("Ngày bắt đầu lớn hơn ngày kết thúc !!!");
                }
                listSearch = listInvoice.Where(p => p.Date >= dtpTo.Value && p.Date <= dtpFrom.Value).ToList();
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
    }
}
