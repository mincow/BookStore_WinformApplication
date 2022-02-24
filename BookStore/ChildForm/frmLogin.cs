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

namespace BookStore
{
    public partial class frmLogin : Form
    {
        BookStoreDB context = new BookStoreDB();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            List<Account> userName = context.Accounts.Where(p => p.UserName == txtUserName.Text).ToList();
            List<Account> passWord = context.Accounts.Where(p => p.PassWord == txtPassWord.Text).ToList();
            try
            {
                if (txtUserName.Text == "" || txtPassWord.Text == "")
                    throw new Exception("Vui lòng nhập đầy đủ thông tin đăng nhập !");
                if (userName.Count == 0 || passWord.Count == 0)
                {
                    MessageBox.Show("Vui lòng kiểm tra lại tên đăng nhập hoặc mật khẩu !", "Thông Báo" ,MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    frmMain fMain = new frmMain(userName.FirstOrDefault());
                    fMain.ShowDialog();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }

        private void pbxShowPass_Click(object sender, EventArgs e)
        {
            pbxShowPass.Hide();
            pbxHidePass.Show();
            txtPassWord.PasswordChar = '\0';
        }

        private void pbxHidePass_Click(object sender, EventArgs e)
        {
            pbxHidePass.Hide();
            pbxShowPass.Show();
            txtPassWord.PasswordChar = '*';
        }
    }
}
