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
    public partial class frmAdd_PurchaseOrder : Form
    {
        BookStoreDB context = new BookStoreDB();
        List<Cart> listCart = new List<Cart>();
        public frmAdd_PurchaseOrder()
        {
            InitializeComponent();
        }

        private void frmAdd_PurchaseOrder_Load(object sender, EventArgs e)
        {            
            cmbSupplier.DataSource = context.Suppliers.ToList();
            cmbSupplier.DisplayMember = "SupplierName";
            cmbSupplier.ValueMember = "SupplierName";
            cmbBook.DataSource = context.Books.ToList();
            cmbBook.DisplayMember = "Title";
            cmbBook.ValueMember = "BookID";
        }

        private void cmbSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            Category category = context.Categories.FirstOrDefault(p => p.Supplier.SupplierName == cmbSupplier.Text);
            //Lấy ra ds books do nhà cung ứng đã chọn cung cấp
            cmbBook.DataSource = context.Books.Where(p => p.CategoryID == category.CategoryID).ToList();
            cmbBook.DisplayMember = "Title";
            cmbBook.ValueMember = "BookID";
        }

        private void BindGrid(List<Cart> listProduct)
        {
            dgvCart.Rows.Clear();
            foreach (var item in listProduct)
            {
                int index = dgvCart.Rows.Add();
                dgvCart.Rows[index].Cells[1].Value = item.BookID;
                dgvCart.Rows[index].Cells[2].Value = item.Title;
                dgvCart.Rows[index].Cells[3].Value = item.Quantity;
            }
        }

        private void Reload()
        {
            try
            {
                BindGrid(listCart);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbBook.Text == "" || txtQuantity.Text == "")
                    throw new Exception("Vui lòng nhập đầy đủ thông tin");
                //Check exist sp
                List<Cart> listCheck = listCart.Where(p => p.Title.ToLower() == cmbBook.Text.ToLower()).ToList();
                if (listCheck.Count != 0)
                    throw new Exception("Sản phẩm đã tồn tại trong giỏ hàng !!!");
                //Check Book
                List<Book> listCheckTitle = context.Books.Where(p => p.Title.ToLower() == cmbBook.Text.ToLower()).ToList();
                if (listCheckTitle.Count == 0)
                {
                    MessageBox.Show("Vui Lòng kiểm tra tên sách !!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Cart product = new Cart();
                    product.Title = cmbBook.Text;
                    product.Quantity = Convert.ToInt32(txtQuantity.Text);
                    Book book = context.Books.FirstOrDefault(p => p.Title.ToLower() == cmbBook.Text.ToLower());
                    product.BookID = book.BookID;
                    listCart.Add(product);
                    BindGrid(listCart);
                    cmbBook.ResetText();
                    txtQuantity.ResetText();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cmbBook.ResetText();
            txtQuantity.ResetText();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbBook.Text == "" || txtQuantity.Text == "")
                    throw new Exception("Vui lòng nhập đầy đủ thông tin");
                if (dgvCart.Rows.Count == 0)
                    throw new Exception("Không tồn tại sản phẩm !!!");
                List<Book> listCheckTitle = context.Books.Where(p => p.Title.ToLower() == cmbBook.Text.ToLower()).ToList();
                if (listCheckTitle.Count == 0)
                {
                    MessageBox.Show("Vui Lòng kiểm tra tên sách !!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Cart product = listCart.FirstOrDefault(p => p.Title.ToLower() == cmbBook.Text.ToLower());
                    product.Quantity = Convert.ToInt32(txtQuantity.Text);
                    Reload();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCart.Columns[e.ColumnIndex].Name == "Delete")
            {
                if (MessageBox.Show("Bạn chắc chắn muốn xóa", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string bookID;
                    bookID = dgvCart.Rows[e.RowIndex].Cells[1].Value.ToString();
                    Cart bDel = listCart.FirstOrDefault(p => p.BookID == bookID);
                    if (bDel != null)
                    {
                        listCart.Remove(bDel);
                        Reload();
                        MessageBox.Show("Xóa thành công!");
                    }
                }
            }
            else
            {
                cmbBook.Text = dgvCart.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtQuantity.Text = dgvCart.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }

        private void btnCreateCart_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime dTime = DateTime.Now;
                string purchaseOrderID = "DDH" + dTime.Day+dTime.Month+dTime.Year+ "_" + dTime.Hour + dTime.Minute + dTime.Second;
                PurchaseOrder purchaseOrder = new PurchaseOrder();
                purchaseOrder.PurchaseOrderID = purchaseOrderID;
                purchaseOrder.OrderDate = DateTime.Now;
                if (cmbSupplier.Text == "")
                {
                    throw new Exception("Vui lòng nhập tên nhà cung ứng");
                }
                else
                    purchaseOrder.SupplierID = context.Suppliers.FirstOrDefault(p => p.SupplierName == cmbSupplier.Text).SupplierID;
                purchaseOrder.ExDeliverDate = dtpExDate.Value;
                purchaseOrder.Note = txtNote.Text;
                context.PurchaseOrders.Add(purchaseOrder);
                context.SaveChanges();
                foreach (var item in listCart)
                {
                    PurchaseOrderDetail product = new PurchaseOrderDetail();
                    product.BookID = item.BookID;
                    product.Quantity = item.Quantity;
                    product.PurchaseOrderID = purchaseOrderID;
                    context.PurchaseOrderDetails.Add(product);
                    context.SaveChanges();
                    MessageBox.Show("Tạo thành công !!");
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelCart_Click(object sender, EventArgs e)
        {
            listCart.Clear();
            cmbBook.ResetText();
            cmbSupplier.ResetText();
            txtQuantity.ResetText();
            Reload();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
