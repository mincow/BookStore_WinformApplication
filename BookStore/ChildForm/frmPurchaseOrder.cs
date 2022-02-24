using System;
using System.Collections.Generic;
using BookStore.Models;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookStore.Report;

namespace BookStore.ChildForm
{
    public partial class frmPurchaseOrder : Form
    {
        BookStoreDB context = new BookStoreDB();
        Account accountSignIn = new Account();
        public frmPurchaseOrder()
        {
            InitializeComponent();
        }
        public frmPurchaseOrder(Account acc)
        {
            InitializeComponent();
            accountSignIn = acc;
        }

        private void frmPurchaseOrder_Load(object sender, EventArgs e)
        {
            try
            {
                List<PurchaseOrder> listPO = context.PurchaseOrders.ToList();
                BindGrid(listPO);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BindGrid(List<PurchaseOrder> listPO)
        {

            dgvPurchaseOrder.Rows.Clear();
            foreach (var item in listPO)
            {
                int index = dgvPurchaseOrder.Rows.Add();
                dgvPurchaseOrder.Rows[index].Cells[2].Value = item.PurchaseOrderID;
                dgvPurchaseOrder.Rows[index].Cells[3].Value = item.OrderDate.ToShortDateString();
                if (item.ExDeliverDate == null)
                    dgvPurchaseOrder.Rows[index].Cells[4].Value = "";
                else
                    dgvPurchaseOrder.Rows[index].Cells[4].Value = Convert.ToDateTime(item.ExDeliverDate).ToShortDateString();
                dgvPurchaseOrder.Rows[index].Cells[5].Value = item.PurchaseOrderDetails.Sum(p => p.Quantity); ;
                dgvPurchaseOrder.Rows[index].Cells[6].Value = item.Supplier.SupplierName;
                dgvPurchaseOrder.Rows[index].Cells[7].Value = item.Note;
            }
        }

        private void Reload()
        {
            try
            {
                List<PurchaseOrder> listPO = context.PurchaseOrders.ToList();
                BindGrid(listPO);
                dgvDetails.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvPurchaseOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string purchaseOrderID;
            purchaseOrderID = dgvPurchaseOrder.Rows[e.RowIndex].Cells[2].Value.ToString();
            try
            {

                if (dgvPurchaseOrder.Columns[e.ColumnIndex].Name == "Delete" && accountSignIn.Roles == true)
                {
                    if (MessageBox.Show("Bạn chắc chắn muốn xóa", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        PurchaseOrder bDel = context.PurchaseOrders.FirstOrDefault(p => p.PurchaseOrderID == purchaseOrderID);
                        if (bDel != null)
                        {
                            foreach (var item in context.PurchaseOrderDetails)
                            {
                                if (item.PurchaseOrderID == bDel.PurchaseOrderID)
                                    context.PurchaseOrderDetails.Remove(item);
                            }
                            context.PurchaseOrders.Remove(bDel);
                            context.SaveChanges();
                            Reload();
                            MessageBox.Show("Xóa thành công!");
                        }
                    }
                }
                if (dgvPurchaseOrder.Columns[e.ColumnIndex].Name == "Report")
                {
                    if (MessageBox.Show("Bạn có muốn in", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        purchaseOrderID = dgvPurchaseOrder.Rows[e.RowIndex].Cells[2].Value.ToString();
                        frm_PurchaseReport f = new frm_PurchaseReport(purchaseOrderID);
                        f.Show();
                    }
                }
                else
                {
                    List<PurchaseOrderDetail> details = context.PurchaseOrderDetails.Where(p => p.PurchaseOrderID == purchaseOrderID).ToList();
                    dgvDetails.Rows.Clear();
                    foreach (var item in details)
                    {
                        int index = dgvDetails.Rows.Add();
                        dgvDetails.Rows[index].Cells[0].Value = item.PurchaseOrderID;
                        dgvDetails.Rows[index].Cells[1].Value = item.BookID;
                        dgvDetails.Rows[index].Cells[2].Value = item.Quantity;
                    }                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAdd_PurchaseOrder fAdd_PurchaseOrder = new frmAdd_PurchaseOrder();
            fAdd_PurchaseOrder.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.ResetText();
            dtpTo.Value = dtpFrom.Value = DateTime.Now;
            Reload();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            List<PurchaseOrder> listSearch = new List<PurchaseOrder>();
            List<PurchaseOrder> listPO = context.PurchaseOrders.ToList();
            if (txtSearch.Text != null)
            {
                foreach (var item in listPO)
                {
                    if (item.PurchaseOrderID.ToLower().Contains(txtSearch.Text.ToLower())
                        || item.Supplier.SupplierName.ToLower().Contains(txtSearch.Text.ToLower())
                        || item.Note.ToLower().Contains(txtSearch.Text.ToLower()))
                    {
                        listSearch.Add(item);
                    }
                    BindGrid(listSearch);

                }
            }
            else
                BindGrid(listPO);
        }

        private void SearchDate()
        {
            try
            {
                List<PurchaseOrder> listSearch = new List<PurchaseOrder>();
                List<PurchaseOrder> listPO = context.PurchaseOrders.ToList();
                if (dtpTo.Value > dtpFrom.Value)
                    throw new Exception("Ngày bắt đầu lớn hơn ngày kết thúc !!!");
                if (cmbOption.Text == "Ngày đặt đơn")
                {
                    listSearch = listPO.Where(p => p.OrderDate >= dtpTo.Value && p.OrderDate <= dtpFrom.Value).ToList();
                    BindGrid(listSearch);
                }
                if (cmbOption.Text == "Ngày giao dự kiến")
                {
                    listSearch = listPO.Where(p => p.ExDeliverDate >= dtpTo.Value && p.ExDeliverDate <= dtpFrom.Value).ToList();
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


    }
}
