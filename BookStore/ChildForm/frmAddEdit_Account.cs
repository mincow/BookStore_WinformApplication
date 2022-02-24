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
    public partial class frmAddEdit_Account : Form
    {
        BookStoreDB context = new BookStoreDB();
        public frmAddEdit_Account()
        {
            InitializeComponent();
        }
        string empID, uName, pWord; bool role;
        public frmAddEdit_Account( string UName, string PWord, string EmpID, bool Role)
        {
            empID = EmpID;
            uName = UName;
            pWord = PWord;
            role = Role;
            InitializeComponent();
        }
        private void frmAdd_Account_Load(object sender, EventArgs e)
        {
            List<Account> accounts = context.Accounts.ToList();
            List<Employee> employees = context.Employees.ToList();
            if (uName == null && pWord == null)
            {
                //List NV chưa có account
                List<Employee> listNoAcc = new List<Employee>();
                foreach (var item in employees)
                {
                    int flag = 0;
                    foreach (var i in accounts)
                    {
                        if (item.EmployeeID == i.EmployeeID)
                            flag = 1;
                    }
                    if (flag == 0)
                        listNoAcc.Add(item);
                }
                if (listNoAcc == null || listNoAcc.Count() == 0)
                    MessageBox.Show("Tất cả nhân viên đã có tài khoản !!");
                else
                    FillcmbNV(listNoAcc);
            }
            else
            {
                cmbNV.Enabled = false;
                FillcmbNV(employees);
                cmbNV.SelectedValue = empID;
            } 
            
            if (role == true)
                opt1.Checked = true;
            if (role == false)
                opt2.Checked = true;
            txtTaiKhoan.Text = uName;            
            txtMatKhau.Text = pWord;
        }
        private int GetSelectedRow(string UName)
        {
            List<Account> listAccount = context.Accounts.ToList();

            for (int i = 0; i < listAccount.Count; i++)
            {
                if (listAccount[i].UserName == UName)
                {
                    return i;
                }
            }
            return -1;
        }

        private bool checkPass(string pass)
        {
            if (pass.Any(char.IsUpper) && pass.Any(char.IsLower) && pass.Any(char.IsDigit) && pass.Length >= 4)
                return true;
            return false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (check())
            {
                Account checkAccount = context.Accounts.FirstOrDefault(p => p.EmployeeID == cmbNV.Text);
                if (GetSelectedRow(txtTaiKhoan.Text) == -1)
                {
                    if (checkPass(txtMatKhau.Text))
                    {
                        Account A = new Account()
                        {
                            EmployeeID = cmbNV.SelectedValue.ToString(),
                            Roles = checkRole(),
                            UserName = txtTaiKhoan.Text,
                            PassWord = txtMatKhau.Text

                        };
                        context.Accounts.Add(A);
                        context.SaveChanges();
                        MessageBox.Show("ADD success!");
                        this.Close();
                    }
                    else
                        MessageBox.Show("Mật Khẩu phải chứa chữ thường, hoa, số và dài tối thiểu 4 !!!");
                }
                else
                {
                    Account AcUpdate = context.Accounts.FirstOrDefault(p => p.UserName == txtTaiKhoan.Text);
                    cmbNV.Enabled = false;
                    if (AcUpdate != null)
                    {
                        if (checkPass(txtMatKhau.Text))
                        {
                            AcUpdate.EmployeeID = cmbNV.SelectedValue.ToString();
                            AcUpdate.Roles = checkRole();
                            AcUpdate.PassWord = txtMatKhau.Text;
                            context.SaveChanges();
                            MessageBox.Show("Update success!");
                            this.Close();
                        }
                        else
                            MessageBox.Show("Mật Khẩu phải chứa chữ thường, hoa, số và dài tối thiểu 4 !!!");
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private bool check()
        {            
            if (txtTaiKhoan.Text == "" || txtMatKhau.Text == "" || opt1.Checked == false && opt2.Checked == false )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return false;
            }            
            else
                return true;
        }
        private bool checkRole()
        {
            if (opt1.Checked)
            {

                return true;

            }
            else
                return false;
        }
        private void FillcmbNV(List<Employee> listE)
        {
            this.cmbNV.DataSource = listE;
            this.cmbNV.DisplayMember = "EmployeeID";
            this.cmbNV.ValueMember = "EmployeeID";
        }
    }
}
