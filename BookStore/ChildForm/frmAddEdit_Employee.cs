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
    public partial class frmAddEdit_Employee : Form
    {
        BookStoreDB context = new BookStoreDB();
        public frmAddEdit_Employee()
        {
            InitializeComponent();
        }
        string EmployeeID, Name1, IDcard, Sex, Phonenumber, Email, Address; DateTime Birthday = DateTime.Now;

        public frmAddEdit_Employee(string employeeID, string name, string idcard, string sex, string phonenumber, string email, string address, DateTime birthday)
        {
            EmployeeID = employeeID;
            Name1 = name;
            Sex = sex;
            IDcard = idcard;
            Phonenumber = phonenumber;
            Email = email;
            Address = address;
            Birthday = birthday;
            InitializeComponent();
        }
        private void frmAdd_Employee_Load(object sender, EventArgs e)
        {
            txtID.Enabled = false;
            List<Employee> employees = context.Employees.ToList();
            txtID.Text = EmployeeID;
            txtName.Text = Name1;
            txtIDCard.Text = IDcard;
            txtPhone.Text = Phonenumber;
            txtEmail.Text = Email;
            txtAddress.Text = Address;
            dtBirth.Value = Birthday;
            if (Sex == "Nam")
                opt1.Checked = true;
            if (Sex == "Nữ")
                opt2.Checked = true;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (GetSelectedRow(txtID.Text) == -1)
            {
                if (check())
                {
                    DateTime dt = DateTime.Now;
                    Employee employee = new Employee();
                    employee.EmployeeID = "NV" + dt.Day + dt.Month + dt.Year + "_" + dt.Hour + dt.Minute + dt.Second;
                    employee.FullName = txtName.Text;
                    employee.DateOfBirth = dtBirth.Value;
                    employee.Sex = checkSex();
                    employee.IDCard = txtIDCard.Text;
                    employee.PhoneNumber = txtPhone.Text;
                    employee.Email = txtEmail.Text;
                    employee.Address = txtAddress.Text;
                    context.Employees.Add(employee);
                    context.SaveChanges();
                    MessageBox.Show("ADD success!");
                    this.Close();
                }

            }

            if (GetSelectedRow(txtID.Text) != -1)
            {
                if (checkV2(txtID.Text))
                {
                    Employee EUpdate = context.Employees.FirstOrDefault(p => p.EmployeeID == txtID.Text);
                    if (EUpdate != null)
                    {
                        EUpdate.FullName = txtName.Text;
                        EUpdate.DateOfBirth = dtBirth.Value;
                        EUpdate.Sex = checkSex();
                        EUpdate.IDCard = txtIDCard.Text;
                        EUpdate.PhoneNumber = txtPhone.Text;
                        EUpdate.Email = txtEmail.Text;
                        EUpdate.Address = txtAddress.Text;
                        context.SaveChanges();
                        MessageBox.Show("Update success!");
                        this.Close();
                    }
                }
            }
        }

       
        private int GetSelectedRow(string EployeeID)
        {
            List<Employee> listbook = context.Employees.ToList();

            for (int i = 0; i < listbook.Count; i++)
            {
                if (listbook[i].EmployeeID == EployeeID)
                {
                    return i;
                }
            }
            return -1;
        }
        private bool check()
        {
            List<Employee> listCheck = context.Employees.Where(p =>  p.PhoneNumber == txtPhone.Text
                                                                   || p.IDCard == txtIDCard.Text
                                                                   || p.Email == txtEmail.Text).ToList();
            if (txtName.Text == "" || opt1.Checked == false && opt2.Checked == false || txtIDCard.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return false;
            }
            else if (listCheck.Count != 0)
            {
                MessageBox.Show("Một trong các thông tin: Mã NV, CMND/CCCD, SĐT, Email đã tồn tại !!!\nVui lòng kiểm tra lại");
                return false;
            }
            else
                return true;
        }
        private bool checkV2(string id)
        {
            List<Employee> listCheck = context.Employees.Where(p => p.PhoneNumber == txtPhone.Text
                                                                   || p.IDCard == txtIDCard.Text
                                                                   || p.Email == txtEmail.Text).ToList();
           listCheck.Remove(context.Employees.FirstOrDefault(p => p.EmployeeID == id));
            if (txtName.Text == "" || opt1.Checked == false && opt2.Checked == false || txtIDCard.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return false;
            }
            else if (listCheck.Count != 0)
            {
                MessageBox.Show("Một trong các thông tin: Mã NV, CMND/CCCD, SĐT, Email đã tồn tại !!!\nVui lòng kiểm tra lại");
                return false;
            }
            else
                return true;
        }
        private string checkSex()
        {
            Employee e = new Employee();
            if (opt1.Checked)
            {

                return "Nam";

            }
            else if (opt2.Checked)
            {

                return "Nữ";
            }
            else
                return "";

        }
    }
}
