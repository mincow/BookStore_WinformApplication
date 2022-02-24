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

namespace BookStore.ChildForm
{
    
    public partial class frmAddEdit_Book : Form
    {
        BookStoreDB context = new BookStoreDB();
        public frmAddEdit_Book()
        {
            InitializeComponent();
        }
        string bookId, tit, author, category, publisher; int stock; decimal buyPrice, sellPrice; DateTime importDate = DateTime.Now, published = DateTime.Now; Image img;
        public frmAddEdit_Book(string Bookid, string Title, string Author, string Publisher, DateTime Published, string Category, DateTime ImportDate, int Stock, decimal buyPrice, decimal sellPrice, Image bookIMG)
        {
            bookId = Bookid;
            tit = Title;
            author = Author;            
            publisher = Publisher;
            published = Published;
            category = Category;
            importDate = ImportDate;
            stock = Stock;
            this.buyPrice = buyPrice;
            this.sellPrice = sellPrice;
            img = bookIMG;
            InitializeComponent();
        }


        private void frmAdd_Book_Load(object sender, EventArgs e)
        {
            txtStock.Enabled = false;
            if (bookId == null)
            {
                txtBookID.Hide();
                lblBookID.Hide();
                pnlLineBookID.Hide();
                txtStock.Text = "0";
            }
            else 
                txtBookID.Enabled = false;
            List<Book> listBook = context.Books.ToList();
            List<Category> listCategory = context.Categories.ToList();
            List<Publisher> listPbl = context.Publishers.ToList();
            txtBookID.Text = bookId;
            txtTitle.Text = tit;
            txtAuthor.Text = author;
            txtStock.Text = stock.ToString();
            cmbCategoryID.SelectedValue = category;
            cmbPublisherID.SelectedValue = publisher;
            txtSellPrice.Text = sellPrice.ToString();
            txtBuyPrice.Text = buyPrice.ToString();
            dtpPublished.Text = published.ToShortDateString();
            dtpImport.Text = importDate.ToShortDateString();
            pbxBookImage.Image = img;
            pbxBookImage.SizeMode = PictureBoxSizeMode.StretchImage;
            FillcmbCategory(listCategory);
            FillcmbPublisher(listPbl);
        }

        private void btnOpenIMG_Click(object sender, EventArgs e)
        {           
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "Jpg Files|*.jpg|Png Files|*.png|Jpeg Files|*.jpeg|BMP Files|*.bmp|All Files|*.*";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    //  pictureBox1.Image = new Bitmap(dlg.FileName);
                        pbxBookImage.ImageLocation = dlg.FileName;
                }
            }
        }


        private void btnCancelIMG_Click(object sender, EventArgs e)
        {
            pbxBookImage.Image = null;
        }

        public byte[] ConvertIMGToByte(Image imageInput)
        {
            Bitmap bt = new Bitmap(imageInput);
            using (var ms = new MemoryStream())
            {
                bt.Save(ms, imageInput.RawFormat);
                return ms.ToArray();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (check())
            {
                if (bookId == null) //ADD new book
                {
                    Book b = new Book();
                    DateTime dt = DateTime.Now;
                    string bookID = "B" + dt.Day + dt.Month + dt.Year + "_" + dt.Hour + dt.Minute + dt.Second;                    
                    b.BookID = bookID;
                    b.Title = txtTitle.Text;
                    b.Author = txtAuthor.Text;
                    b.DatePublished = dtpPublished.Value;
                    b.Stock = int.Parse(txtStock.Text);
                    b.ImportDate = dtpImport.Value;
                    b.CategoryID = cmbCategoryID.SelectedValue.ToString();
                    b.PublisherID = cmbPublisherID.SelectedValue.ToString();
                    b.SellPrice = decimal.Parse(txtSellPrice.Text);
                    b.BuyPrice = Decimal.Parse(txtBuyPrice.Text);
                    if (pbxBookImage.Image == null)
                        b.Image = null;
                    else
                        b.Image = ConvertIMGToByte(pbxBookImage.Image);
                    context.Books.Add(b);
                    context.SaveChanges();
                    MessageBox.Show("ADD success!");
                    this.Close();
                }
                else // UPDATE BOOK
                {
                    Book bUpdate = context.Books.FirstOrDefault(p => p.BookID == txtBookID.Text);
                    if (bUpdate != null)
                    {
                        bUpdate.Title = txtTitle.Text;
                        bUpdate.Author = txtAuthor.Text;
                        bUpdate.DatePublished = dtpPublished.Value;
                        bUpdate.Stock = int.Parse(txtStock.Text);
                        bUpdate.ImportDate = dtpImport.Value;
                        bUpdate.CategoryID = cmbCategoryID.SelectedValue.ToString();
                        bUpdate.PublisherID = cmbPublisherID.SelectedValue.ToString();
                        bUpdate.SellPrice = decimal.Parse(txtSellPrice.Text);
                        bUpdate.BuyPrice = decimal.Parse(txtBuyPrice.Text);
                        //Save IMG
                        /*byte[] ImageData;
                        FileStream fs = new FileStream(pbxBookImage.ImageLocation, FileMode.Open, FileAccess.Read);
                        BinaryReader br = new BinaryReader(fs);
                        ImageData = br.ReadBytes((int)fs.Length);
                        br.Close();
                        fs.Close();*/
                        if (pbxBookImage.Image == null)
                            bUpdate.Image = null;
                        else
                            bUpdate.Image = ConvertIMGToByte(pbxBookImage.Image);
                        context.SaveChanges();
                        MessageBox.Show("Update success!");                        
                        this.Close();
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void FillcmbCategory(List<Category> listCategory)
        {
            this.cmbCategoryID.DataSource = listCategory;
            this.cmbCategoryID.DisplayMember = "CategoryName";
            this.cmbCategoryID.ValueMember = "CategoryID";
        }
        private void FillcmbPublisher(List<Publisher> listPbl)
        {
            this.cmbPublisherID.DataSource = listPbl;
            this.cmbPublisherID.DisplayMember = "PublisherName";
            this.cmbPublisherID.ValueMember = "PublisherID";
        }
        private bool check()
        {
            if (txtAuthor.Text == "" || txtStock.Text == "" || txtTitle.Text == "" || txtSellPrice.Text == "" || txtBuyPrice.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return false;
            }
            else if (dtpPublished.Value.Date > dtpImport.Value.Date)
            {
                MessageBox.Show("Ngày xuất bản phải trước ngày nhập sách");
                return false;
            }
            else
                return true;
        }
        
    }
}
