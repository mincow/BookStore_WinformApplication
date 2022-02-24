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
    public partial class frmAdd_Invoices : Form
    {
        BookStoreDB context = new BookStoreDB();
        List<Cart> listCart = new List<Cart>();
        Account accountSignIn = new Account();
        public frmAdd_Invoices(Account acc)
        {
            InitializeComponent();
            accountSignIn = acc;
        }

        private void frmAdd_Invoices_Load(object sender, EventArgs e)
        {
            List<Book> lBook = context.Books.ToList();
            FillCmb(lBook);
        }

        private void FillCmb(List<Book> listBook)
        {
            this.cmbBook.DataSource = listBook;
            this.cmbBook.DisplayMember = "Title";
            this.cmbBook.ValueMember = "BookID";
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
                dgvCart.Rows[index].Cells[4].Value = item.Unit;
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
                //Check Stock
                Book bookCheck = context.Books.FirstOrDefault(p => p.Title == cmbBook.Text);
                if (bookCheck != null)
                {
                    if (bookCheck.Stock < Convert.ToInt32(txtQuantity.Text))
                        throw new Exception("Số lượng còn lại không đủ !!!");
                }
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
                    product.Unit = book.SellPrice;
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelCart_Click(object sender, EventArgs e)
        {
            listCart.Clear();
            cmbBook.ResetText();
            txtQuantity.ResetText();
            Reload();
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

        private void btnCreateCart_Click(object sender, EventArgs e)
        {
            try
            {                
                List<Customer> cus = context.Customers.Where(p => p.PhoneNumber == txtCustomer.Text).ToList();
                if (cus.Count == 0 && txtCustomer.Text != "")
                    throw new Exception("Không tìm thấy khách hàng");
                int count = context.Invoices.Count();
                DateTime dTime = DateTime.Now;
                string invoiceID = "HD" + (count + 1).ToString().PadLeft(2, '0') + "_" + dTime.Day+dTime.Month+dTime.Hour+dTime.Minute+dTime.Second;
                Invoice invoice = new Invoice();
                invoice.InvoiceID = invoiceID;
                invoice.Date = DateTime.Now;
                invoice.EmployeeID = accountSignIn.EmployeeID;
                if (txtCustomer.Text != "")
                {
                    Customer c = context.Customers.FirstOrDefault(p => p.PhoneNumber == txtCustomer.Text);
                    invoice.CustomerID = c.CustomerID;
                }
                //tìm mã KM có hiệu lực trong ngày hiện hành // nếu có thì các đơn hàng tạo trong ngày hiện hành đều tự động áp mã
                double promotion = 0;
                double discountVIP = 0;
                DateTime date = DateTime.Now;
                Promotion prom = new Promotion();
                foreach (var i in context.Promotions)
                {
                    DateTime endDate = i.StartDate.AddDays(i.Duration);
                    if (i.StartDate <= date && endDate >= date)
                        prom = i;
                }
                if (prom != null)
                {
                    invoice.PromotionID = prom.PromotionID;
                    promotion = prom.Discount;
                }                    
                //Check KH thuộc VIP nào
                if (txtCustomer.Text != "")
                {
                    Customer customer = context.Customers.FirstOrDefault(p => p.PhoneNumber == txtCustomer.Text);          
                    discountVIP = customer.VIP.Discount;                    
                }
                double totalTemp = Convert.ToDouble(listCart.Sum(p => p.Quantity * p.Unit));
                decimal total = Convert.ToDecimal(totalTemp - totalTemp * (promotion + discountVIP));
                invoice.Total = total;
                invoice.Note = txtNote.Text;
                txtCustomer.Text = invoice.InvoiceID + " " + invoice.Date.ToString() + " " + invoice.EmployeeID + " " + invoice.PromotionID + " " + invoice.CustomerID + " " + invoice.Total.ToString() + " " + invoice.Note;
                context.Invoices.Add(invoice);
                context.SaveChanges();
                foreach (var item in listCart)
                {
                    InvoiceDetail product = new InvoiceDetail();
                    product.BookID = item.BookID;
                    product.Quantity = item.Quantity;
                    //tru sl trong stock
                    Book book = context.Books.FirstOrDefault(p => p.BookID == item.BookID);
                    if (book != null)
                        book.Stock -= item.Quantity;
                    product.UnitPrice = item.Unit;
                    product.InvoiceID = invoiceID;
                    context.InvoiceDetails.Add(product);
                    context.SaveChanges();
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }
    }
}
