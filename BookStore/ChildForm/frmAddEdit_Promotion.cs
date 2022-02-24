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
    public partial class frmAddEdit_Promotion : Form
    {
        BookStoreDB context = new BookStoreDB();
        public frmAddEdit_Promotion()
        {
            InitializeComponent();
        }
        string promotionID, duration, discount, note; DateTime startDate = DateTime.Now;
        public frmAddEdit_Promotion( string proID, string Duration, string Discount, string Note, DateTime StartDate)
        {
            promotionID = proID;
            duration = Duration;
            discount = Discount;
            note = Note;
            startDate = StartDate;
            InitializeComponent();
        }
        private int GetSelectedRow(string proID)
        {
            List<Promotion> listPro = context.Promotions.ToList();

            for (int i = 0; i < listPro.Count; i++)
            {
                if (listPro[i].PromotionID == proID)
                {
                    return i;
                }
            }
            return -1;
        }

        private void frmAdd_Promotion_Load(object sender, EventArgs e)
        {
            List<Promotion> listPro = context.Promotions.ToList();
            txtID.Text = promotionID;
            dtDate.Value = startDate;
            txtTime.Text = duration;
            txtDis.Text = discount;
            rtxtNote.Text = note; 
        }

        private bool check()
        {
            if (txtID.Text == "" || txtDis.Text == "" || txtTime.Text =="" )
            {
                MessageBox.Show("vui lòng nhập đủ thôn tin!");
                return false;
            }
            else
                return true;
        }
        

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (check())
            {
                if (GetSelectedRow(txtID.Text) == -1)
                {
                    Promotion pro = new Promotion()
                    {
                        PromotionID = txtID.Text,
                        StartDate = dtDate.Value,
                        Duration = int.Parse(txtTime.Text),
                        Discount = double.Parse(txtDis.Text),
                        Note = rtxtNote.Text

                    };
                    context.Promotions.Add(pro);
                    context.SaveChanges();
                    MessageBox.Show("ADD success!");
                    this.Close();
                }
                else
                {
                    Promotion proUpdate = context.Promotions.FirstOrDefault(p => p.PromotionID == txtID.Text);
                    if (proUpdate != null)
                    {
                        proUpdate.StartDate = dtDate.Value;
                        proUpdate.Duration = int.Parse(txtTime.Text);
                        proUpdate.Discount = double.Parse(txtDis.Text);
                        proUpdate.Note = rtxtNote.Text;
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
    }
}
