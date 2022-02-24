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
    public partial class frmHome : Form
    {
        BookStoreDB context = new BookStoreDB();// ket noi databases
        public frmHome()
        {
            InitializeComponent();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            //Doanh thu ngày
            DateTime date = DateTime.Now;
            int count = 0; //doanh so
            decimal total = 0; // doanh thu
            foreach (var item in context.Invoices)
            {
                string day = item.Date.ToShortDateString();
                if (day == date.ToShortDateString())
                {
                    count++;
                    total += item.Total.Value;
                }                      
            }
            lbDoanhSo.Text = count.ToString();
            lbDoanhThu.Text = total.ToString();
            //Doanh thu tháng
            lbDST.Text = context.Invoices.Where(p=>p.Date.Month == DateTime.Now.Month).Count().ToString();// doanh so theo thang
            lbDTT.Text = context.Invoices.Where(p => p.Date.Month == DateTime.Now.Month).Sum(p => p.Total).ToString(); //doanh thu theo thang
            // Hiển thị thông tin datagridview Book
            List<Book> lBH = context.Books.ToList();
            BindGridBook(lBH);
            //Hiển thị thông tin datagridview Promotion
            List<Promotion> lProH = context.Promotions.ToList();
            BindGridPro(lProH);
            
        }
        // Hiện thông tin của Book lên datagridview
        private void BindGridBook(List<Book> listBook)
        {
            dgvBookH.Rows.Clear();
            foreach (var item in listBook)
            {
                int index = dgvBookH.Rows.Add();
                dgvBookH.Rows[index].Cells[0].Value = item.BookID;
                dgvBookH.Rows[index].Cells[1].Value = item.Title;
                dgvBookH.Rows[index].Cells[2].Value = item.Author;
                dgvBookH.Rows[index].Cells[3].Value = item.DatePublished.ToShortDateString();
                dgvBookH.Rows[index].Cells[4].Value = item.Category.CategoryName;
                dgvBookH.Rows[index].Cells[5].Value = item.Publisher.PublisherName;
                dgvBookH.Rows[index].Cells[6].Value = item.ImportDate.ToShortDateString();
                dgvBookH.Rows[index].Cells[7].Value = item.Stock;
                dgvBookH.Rows[index].Cells[8].Value = item.SellPrice;
            }
        }
        // Hiện thông tin của Promotion lên datagrivew
        private void BindGridPro(List<Promotion> listPromotion)
        {
            dgvPromotionH.Rows.Clear();
            foreach (var item in listPromotion)
            {
                int index = dgvPromotionH.Rows.Add();
                dgvPromotionH.Rows[index].Cells[0].Value = item.PromotionID;
                dgvPromotionH.Rows[index].Cells[1].Value = item.StartDate.ToShortDateString();
                dgvPromotionH.Rows[index].Cells[2].Value = item.Duration;
                dgvPromotionH.Rows[index].Cells[3].Value = item.Discount;
                dgvPromotionH.Rows[index].Cells[4].Value = item.Note;
            }
        }


    }
}
