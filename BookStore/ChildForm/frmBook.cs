using BookStore.ChildForm;
using BookStore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    public partial class frmBook : Form
    {
        BookStoreDB context = new BookStoreDB();
        public frmBook()
        {
            InitializeComponent();
        }

        Account acc = new Account();
        public frmBook(Account acc)
        {
            this.acc = acc;
            InitializeComponent();
        }

        private void frmBook_Load(object sender, EventArgs e)
        {            
            if (acc.Roles == false)
                btnAdd.Enabled = false;
            try
            {
                List<Book> listBook = context.Books.ToList();
                BindGrid(listBook);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BindGrid (List<Book> listBook)
        {
            dgvBook.Rows.Clear();
            foreach(var item in listBook)
            {
                int index = dgvBook.Rows.Add();
                dgvBook.Rows[index].Cells[2].Value = item.BookID;
                dgvBook.Rows[index].Cells[3].Value = item.Title;
                dgvBook.Rows[index].Cells[4].Value = item.Author;                
                dgvBook.Rows[index].Cells[5].Value = item.Category.CategoryName;
                dgvBook.Rows[index].Cells[6].Value = item.Publisher.PublisherName;                
                dgvBook.Rows[index].Cells[7].Value = item.Stock;                
                dgvBook.Rows[index].Cells[8].Value = item.SellPrice;
            }
        }
        private void Reload()
        {
            try
            {
                BookStoreDB context1 = new BookStoreDB();
                List<Book> listBook = context1.Books.ToList();
                BindGrid(listBook);               
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (acc.Roles == true)
            {
                if (dgvBook.Columns[e.ColumnIndex].Name == "Delete")
                {
                    if (MessageBox.Show("Bạn chắc chắn muốn xóa", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string bookID;
                        bookID = dgvBook.Rows[e.RowIndex].Cells[2].Value.ToString();
                        Book bDel = context.Books.FirstOrDefault(p => p.BookID == bookID);
                        if (bDel != null)
                        {
                            context.Books.Remove(bDel);
                            context.SaveChanges();
                            Reload();
                            MessageBox.Show("Xóa thành công!");
                        }
                    }
                }
                else if (dgvBook.Columns[e.ColumnIndex].Name == "Edit")
                {
                    string bookId, title, author, category, publisher; int stock; decimal buyPrice, sellPrice; DateTime importDate, publishedDate; Image img;
                    bookId = Convert.ToString(dgvBook.Rows[e.RowIndex].Cells[2].Value);
                    title = Convert.ToString(dgvBook.Rows[e.RowIndex].Cells[3].Value);
                    author = Convert.ToString(dgvBook.Rows[e.RowIndex].Cells[4].Value);
                    category = Convert.ToString(dgvBook.Rows[e.RowIndex].Cells[5].Value);
                    publisher = Convert.ToString(dgvBook.Rows[e.RowIndex].Cells[6].Value);
                    stock = Convert.ToInt32(dgvBook.Rows[e.RowIndex].Cells[7].Value);
                    sellPrice = Convert.ToDecimal(dgvBook.Rows[e.RowIndex].Cells[8].Value);
                    publishedDate = context.Books.FirstOrDefault(p => p.BookID == bookId).DatePublished;
                    importDate = context.Books.FirstOrDefault(p => p.BookID == bookId).ImportDate;
                    buyPrice = Convert.ToDecimal(txtBuyPrice.Text);
                    img = pbxBookImg.Image;
                    frmAddEdit_Book f = new frmAddEdit_Book(bookId, title, author, publisher, publishedDate, category, importDate, stock, buyPrice, sellPrice, img);
                    f.Show();
                }
                if (e.RowIndex != 0)
                {
                    BookStoreDB context1 = new BookStoreDB();
                    string id = dgvBook.Rows[e.RowIndex].Cells[2].Value.ToString();
                    Book bookSelected = context1.Books.FirstOrDefault(p => p.BookID == id);
                    if (bookSelected.Image != null)
                    {
                        pbxBookImg.SizeMode = PictureBoxSizeMode.StretchImage;
                        using (var ms = new MemoryStream(bookSelected.Image))
                        {
                            var img = Image.FromStream(ms);
                            pbxBookImg.Image = img;
                        }

                    }
                    else
                        pbxBookImg.Image = pbxBookImg.ErrorImage;
                    txtPulishedDate.Text = bookSelected.DatePublished.ToShortDateString();
                    txtImportDate.Text = bookSelected.ImportDate.ToShortDateString();
                    if (bookSelected.BuyPrice == null)
                        txtBuyPrice.Text = "0";
                    else
                        txtBuyPrice.Text = bookSelected.BuyPrice.ToString();
                }
            }            
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            List<Book> listSearch = new List<Book>();
            List<Book> listBook = context.Books.ToList();
            if (txtSearch.Text != null)
            {
                foreach (Book item in listBook)
                {
                    if (item.BookID.ToLower().Contains(txtSearch.Text.ToLower()) 
                        || item.Title.ToLower().Contains(txtSearch.Text.ToLower()) 
                        || item.Author.ToLower().Contains(txtSearch.Text.ToLower()) 
                        || item.SellPrice.ToString().Contains(txtSearch.Text.ToLower())
                        || item.Publisher.PublisherName.ToLower().Contains(txtSearch.Text.ToLower()) 
                        || item.Category.CategoryName.ToLower().Contains(txtSearch.Text.ToLower()))
                    {
                        listSearch.Add(item);
                    }
                    BindGrid(listSearch);
                   
                }
            }
            else
                BindGrid(listBook);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddEdit_Book fAdd_Book = new frmAddEdit_Book();
            fAdd_Book.Show();
        }

        private void SearchDate()
        {
            try
            {
                List<Book> listSearch = new List<Book>();
                List<Book> listBook = context.Books.ToList();               
                if (dtpTo.Value > dtpFrom.Value)
                    throw new Exception("Ngày bắt đầu lớn hơn ngày kết thúc !!!");                
                if (cmbOption.Text == "Ngày xuất bản")
                {
                    listSearch = listBook.Where(p => p.DatePublished >= dtpTo.Value && p.DatePublished <= dtpFrom.Value).ToList();
                    BindGrid(listSearch);
                }
                if (cmbOption.Text == "Ngày nhập")
                {
                    listSearch = listBook.Where(p => p.ImportDate >= dtpTo.Value && p.ImportDate <= dtpFrom.Value).ToList();
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
            dtpTo.Value = dtpFrom.Value = DateTime.Now;
            txtSearch.ResetText();
            cmbOption.Text = "Ngày xuất bản";
            Reload();
        }
    }
}
