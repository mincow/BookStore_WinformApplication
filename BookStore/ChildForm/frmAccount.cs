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
    public partial class frmAccount : Form
    {
        BookStoreDB context = new BookStoreDB();
        public frmAccount()
        {
            InitializeComponent();
        }

        private void frmAccount_Load(object sender, EventArgs e)
        {
            try
            {
                List<Account> listAccount = context.Accounts.ToList();
                BindGrid(listAccount);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BindGrid(List<Account> listAccount)
        {
            dgvAccount.Rows.Clear();
            foreach (var item in listAccount)
            {
                int index = dgvAccount.Rows.Add();
                dgvAccount.Rows[index].Cells[2].Value = item.UserName;
                dgvAccount.Rows[index].Cells[3].Value = item.PassWord;
                dgvAccount.Rows[index].Cells[4].Value = item.EmployeeID;
                dgvAccount.Rows[index].Cells[5].Value = item.Roles;
            }
        }

        private void Reload()
        {
            try
            {
                BookStoreDB context1 = new BookStoreDB();
                List<Account> listAccount = context1.Accounts.ToList();
                BindGrid(listAccount);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAccount.Columns[e.ColumnIndex].Name == "Delete")
            {
                if (MessageBox.Show("Bạn chắc chắn muốn xóa", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string userName;
                    userName = dgvAccount.Rows[e.RowIndex].Cells[2].Value.ToString();
                    Account bDel = context.Accounts.FirstOrDefault(p => p.UserName == userName);
                    if (bDel != null)
                    {
                        context.Accounts.Remove(bDel);
                        context.SaveChanges();
                        Reload();
                        MessageBox.Show("Xóa thành công!");
                    }
                }
            }
            if (dgvAccount.Columns[e.ColumnIndex].Name == "Edit")
            {
                string userName, passWord, employeeID; bool roles;
                userName = Convert.ToString(dgvAccount.Rows[e.RowIndex].Cells[2].Value);
                passWord = Convert.ToString(dgvAccount.Rows[e.RowIndex].Cells[3].Value);
                employeeID = Convert.ToString(dgvAccount.Rows[e.RowIndex].Cells[4].Value);
                roles = Convert.ToBoolean(dgvAccount.Rows[e.RowIndex].Cells[5].Value);
                frmAddEdit_Account f = new frmAddEdit_Account(userName, passWord, employeeID, roles);
                f.Show();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            List<Account> listSearch = new List<Account>();
            List<Account> listAccount = context.Accounts.ToList();
            if (txtSearch.Text != null)
            {
                foreach (Account item in listAccount)
                {
                    if (item.UserName.ToLower().Contains(txtSearch.Text.ToLower())
                        || item.PassWord.ToLower().Contains(txtSearch.Text.ToLower())
                        || item.EmployeeID.ToLower().Contains(txtSearch.Text.ToLower())
                        || item.Roles.ToString().Contains(txtSearch.Text.ToLower()))
                    {
                        listSearch.Add(item);
                    }
                    BindGrid(listSearch);

                }
            }
            else
                BindGrid(listAccount);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSearch.ResetText();
            Reload();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddEdit_Account f = new frmAddEdit_Account();
            f.Show();
        }
    }
}
