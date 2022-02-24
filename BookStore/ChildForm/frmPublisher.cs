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
    public partial class frmPublisher : Form
    {
        BookStoreDB context = new BookStoreDB();
        public frmPublisher()
        {
            InitializeComponent();
        }

        Account acc = new Account();
        public frmPublisher(Account acc)
        {
            this.acc = acc;
            InitializeComponent();
        }
        private void frmPublisher_Load(object sender, EventArgs e)
        {
            if (acc.Roles == false)
                btnAdd.Enabled = false;
            try
            {
                List<Publisher> listPublisher = context.Publishers.ToList();
                BindGrid(listPublisher);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BindGrid(List<Publisher> listPublisher)
        {
            dgvPublisher.Rows.Clear();
            foreach (var item in listPublisher)
            {
                int index = dgvPublisher.Rows.Add();
                dgvPublisher.Rows[index].Cells[2].Value = item.PublisherID;
                dgvPublisher.Rows[index].Cells[3].Value = item.PublisherName;
            }
        }

        private void Reload()
        {
            try
            {
                List<Publisher> listPublisher = context.Publishers.ToList();
                BindGrid(listPublisher);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvPublisher_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (acc.Roles == true)
            {
                if (dgvPublisher.Columns[e.ColumnIndex].Name == "Delete")
                {
                    if (MessageBox.Show("Bạn chắc chắn muốn xóa", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string publisherID;
                        publisherID = dgvPublisher.Rows[e.RowIndex].Cells[2].Value.ToString();
                        Publisher bDel = context.Publishers.FirstOrDefault(p => p.PublisherID == publisherID);
                        if (bDel != null)
                        {
                            context.Publishers.Remove(bDel);
                            context.SaveChanges();
                            Reload();
                            MessageBox.Show("Xóa thành công!");
                        }
                    }
                }
                if (dgvPublisher.Columns[e.ColumnIndex].Name == "Edit")
                {
                    string publisherID, publisherName;
                    publisherID = Convert.ToString(dgvPublisher.Rows[e.RowIndex].Cells[2].Value);
                    publisherName = Convert.ToString(dgvPublisher.Rows[e.RowIndex].Cells[3].Value);
                    frmAddEdit_Publisher f = new frmAddEdit_Publisher(publisherID, publisherName);
                    f.Show();
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            List<Publisher> listSearch = new List<Publisher>();
            List<Publisher> listPublisher = context.Publishers.ToList();
            if (txtSearch.Text != null)
            {
                foreach (Publisher item in listPublisher)
                {
                    if (item.PublisherID.ToLower().Contains(txtSearch.Text.ToLower()) 
                        || item.PublisherName.ToLower().Contains(txtSearch.Text.ToLower()))
                    {
                        listSearch.Add(item);
                    }
                    BindGrid(listSearch);

                }
            }
            else
                BindGrid(listPublisher);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddEdit_Publisher f = new frmAddEdit_Publisher();
            f.Show();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSearch.ResetText();
            Reload();
        }
    }
}
