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
    public partial class frmAddEdit_Publisher : Form
    {
        BookStoreDB context = new BookStoreDB();
        public frmAddEdit_Publisher()
        {
            InitializeComponent();
        }
        string pubID, pubName;
        public frmAddEdit_Publisher(string PubID, string PubName)
        {
            pubID = PubID;
            pubName = PubName;
            InitializeComponent();
        }
        private void frmAdd_Publisher_Load(object sender, EventArgs e)
        {
            if (pubID == null)
            {
                txtID.Hide();
                lblPublisherID.Hide();
                pnlLinePublisherID.Hide();
            }
            else
                txtID.Enabled = false;
            txtID.Text = pubID;
            txtName.Text = pubName;
        }

        private bool check()
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("vui lòng nhập đủ thông tin!");
                return false;
            }
            else
                return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (check())
            {
                if (pubID == null)
                {
                    DateTime dt = DateTime.Now;
                    Publisher Pub = new Publisher()
                    {
                        PublisherID = "NXB" + dt.Day + dt.Month + dt.Year + "_" + dt.Hour + dt.Minute + dt.Second,
                        PublisherName = txtName.Text

                    };
                    context.Publishers.Add(Pub);
                    context.SaveChanges();
                    MessageBox.Show("ADD success!");
                    this.Close();
                }
                else
                {
                    Publisher PubUpdate = context.Publishers.FirstOrDefault(p => p.PublisherID == txtID.Text);
                    if (PubUpdate != null)
                    {
                        PubUpdate.PublisherName = txtName.Text;
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
