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
    public partial class frmAdd_Receipt : Form
    {
        BookStoreDB context = new BookStoreDB();
        List<Cart> listGoods = new List<Cart>();
        public frmAdd_Receipt()
        {
            InitializeComponent();
        }
        

        private void frmAdd_Receipt_Load(object sender, EventArgs e)
        {
            List<PurchaseOrder> listOrder = context.PurchaseOrders.ToList();            
            List<Receipt> listReceipt = context.Receipts.ToList();
            List<PurchaseOrder> listChoose = new List<PurchaseOrder>();
            //list đơn đặt chưa có biên lai hoặc đơn đặt giao chưa đủ
            listChoose = listOrder.Where(p => !listReceipt.Any(s => s.PurchaseOrderID == p.PurchaseOrderID && s.Status == true)).ToList();
            
            if (listChoose.Count != 0)
            {
                cmbChooseOrder.DataSource = listChoose;
                cmbChooseOrder.DisplayMember = "PurchaseOrderID";
                cmbChooseOrder.ValueMember = "PurchaseOrderID";
            }
            else
            {
                cmbChooseOrder.DataSource = context.PurchaseOrders.ToList();
                cmbChooseOrder.DisplayMember = "PurchaseOrderID";
                cmbChooseOrder.ValueMember = "PurchaseOrderID";
            }
        }

        private void BindGrid(List<Cart> listGoods)
        {
            dgvReceiptTemp.Rows.Clear();
            foreach (var item in listGoods)
            {
                int index = dgvReceiptTemp.Rows.Add();
                dgvReceiptTemp.Rows[index].Cells[1].Value = item.Title;
                dgvReceiptTemp.Rows[index].Cells[2].Value = item.Quantity;
                dgvReceiptTemp.Rows[index].Cells[3].Value = item.Unit;            
            }
        }

        private void Reload()
        {
            try
            {
                BindGrid(listGoods);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtBookTitle.ResetText();
            txtOrderQuantity.ResetText();
            txtQuantity.ResetText();
            txtBuyPrice.ResetText();
            cmbChooseOrder.ResetText();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtQuantity.Text == "" || cmbChooseOrder.Text == "" || txtBuyPrice.Text == "")
                    throw new Exception("Vui lòng nhập đầy đủ thông tin");
                //Check exist sp
                List<Cart> listCheck = listGoods.Where(p => p.Title.ToLower() == txtBookTitle.Text.ToLower()).ToList();
                if (listCheck.Count != 0)
                    throw new Exception("Sản phẩm đã tồn tại trong bản ghi!!!");
                
                Cart goods = new Cart();
                goods.Title = txtBookTitle.Text;
                goods.Quantity = Convert.ToInt32(txtQuantity.Text);
                goods.Unit = Convert.ToDecimal(txtBuyPrice.Text);
                listGoods.Add(goods);
                BindGrid(listGoods);
                txtBookTitle.ResetText();
                txtOrderQuantity.ResetText();
                txtQuantity.ResetText();
                txtBuyPrice.ResetText();
                cmbChooseOrder.ResetText();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                List<Cart> listChechExits = listGoods.Where(s => s.Title.ToLower() == txtBookTitle.Text.ToLower()).ToList();
                if (listChechExits.Count == 0)
                    throw new Exception("Sản phẩm không tồn tại trong bản ghi !!!");
                if (txtBookTitle.Text == "" || txtQuantity.Text == "")
                    throw new Exception("Vui lòng nhập đầy đủ thông tin");
                List<Book> listCheckTitle = context.Books.Where(p => p.Title.ToLower() == txtBookTitle.Text.ToLower()).ToList();
                Cart goods = listGoods.FirstOrDefault(p => p.Title.ToLower() == txtBookTitle.Text.ToLower());
                goods.Quantity = Convert.ToInt32(txtQuantity.Text);
                goods.Unit = Convert.ToDecimal(txtBuyPrice.Text);
                Reload();
                txtBookTitle.ResetText();
                txtOrderQuantity.ResetText();
                txtQuantity.ResetText();
                txtBuyPrice.ResetText();
                cmbChooseOrder.ResetText();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelCart_Click(object sender, EventArgs e)
        {
            listGoods.Clear();
            txtBookTitle.ResetText();
            txtOrderQuantity.ResetText();
            txtQuantity.ResetText();
            txtBuyPrice.ResetText();
            cmbChooseOrder.ResetText();
            Reload();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreateReceipt_Click(object sender, EventArgs e)
        {
            try
            {
                //Add receipt
                PurchaseOrder purchaseOrder = context.PurchaseOrders.FirstOrDefault(p => p.PurchaseOrderID == cmbChooseOrder.SelectedValue.ToString());
                DateTime dt = DateTime.Now;
                string receiptID = "BL" + dt.Day + dt.Month + dt.Year + "_" + dt.Hour + dt.Minute + dt.Second;
                Receipt receipt = new Receipt();
                receipt.ReceiptID = receiptID;
                receipt.PurchaseOrderID = cmbChooseOrder.SelectedValue.ToString();
                receipt.ImportDate = dtpImportDate.Value;
                int totalQuantity = listGoods.Sum(p => p.Quantity);
                if (listGoods.Sum(p => p.Quantity) == purchaseOrder.PurchaseOrderDetails.Sum(p => p.Quantity))
                    receipt.Status = true;
                else
                    receipt.Status = false;
                decimal total = listGoods.Sum(p => p.Quantity * p.Unit);
                receipt.Note = txtNote.Text;
                context.Receipts.Add(receipt);

                context.SaveChanges();
                //Add ReceiptDetails
                foreach (var item in listGoods)
                {
                    ReceiptDetail goods = new ReceiptDetail();
                    goods.BookID = context.Books.FirstOrDefault(p => p.Title == item.Title).BookID;
                    goods.UnitPrice = item.Unit;
                    goods.Quantity = item.Quantity;
                    goods.ReceiptID = receiptID;
                    context.ReceiptDetails.Add(goods);
                    context.SaveChanges();
                }

                //Cập nhật SL và ImportDate cho sách cũ               
                foreach(var item in listGoods)
                {
                    Book bookUpdate = context.Books.FirstOrDefault(p => p.Title == item.Title);
                    if (bookUpdate != null)
                    {
                        bookUpdate.Stock += item.Quantity;
                        bookUpdate.ImportDate = dtpImportDate.Value;
                        bookUpdate.BuyPrice = item.Unit;
                        context.SaveChanges();
                    }                        
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }          

        private void dgvCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvReceiptTemp.Columns[e.ColumnIndex].Name == "Delete")
            {
                if (MessageBox.Show("Bạn chắc chắn muốn xóa", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string title;
                    title = dgvReceiptTemp.Rows[e.RowIndex].Cells[1].Value.ToString();
                    Cart bDel = listGoods.FirstOrDefault(p => p.Title == title);
                    if (bDel != null)
                    {
                        listGoods.Remove(bDel);
                        Reload();
                        MessageBox.Show("Xóa thành công!");
                    }
                }
            }
            else
            {
                txtBookTitle.Text = dgvReceiptTemp.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtQuantity.Text = dgvReceiptTemp.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtBuyPrice.Text = dgvReceiptTemp.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }

        private void cmbChooseOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            PurchaseOrderDetail selectedPODetails = context.PurchaseOrderDetails.FirstOrDefault(p => p.PurchaseOrderID == cmbChooseOrder.Text.ToString());
            txtBookTitle.Text = selectedPODetails.Book.Title;
            txtOrderQuantity.Text = selectedPODetails.Quantity.ToString();
        }
    }
}
