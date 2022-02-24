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
    public partial class frmEmployee : Form
    {
        BookStoreDB context = new BookStoreDB();
        public frmEmployee()
        {
            InitializeComponent();
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            try
            {
                List<Employee> listEmployee = context.Employees.ToList();
                BindGrid(listEmployee);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BindGrid(List<Employee> listEmployee)
        {
            dgvEmployee.Rows.Clear();
            foreach (var item in listEmployee)
            {
                int index = dgvEmployee.Rows.Add();
                dgvEmployee.Rows[index].Cells[2].Value = item.EmployeeID;
                dgvEmployee.Rows[index].Cells[3].Value = item.FullName;
                dgvEmployee.Rows[index].Cells[4].Value = item.DateOfBirth.ToShortDateString();
                dgvEmployee.Rows[index].Cells[5].Value = item.Sex;
                dgvEmployee.Rows[index].Cells[6].Value = item.IDCard;
                dgvEmployee.Rows[index].Cells[7].Value = item.PhoneNumber;
                dgvEmployee.Rows[index].Cells[8].Value = item.Email;
                dgvEmployee.Rows[index].Cells[9].Value = item.Address;
            }
        }

        private void Reload()
        {
            try
            {
                BookStoreDB context1 = new BookStoreDB();
                List<Employee> listEmployee = context1.Employees.ToList();
                BindGrid(listEmployee);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEmployee.Columns[e.ColumnIndex].Name == "Delete")
            {
                if (MessageBox.Show("Bạn chắc chắn muốn xóa", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string employeeID;
                    employeeID = dgvEmployee.Rows[e.RowIndex].Cells[2].Value.ToString();
                    Employee bDel = context.Employees.FirstOrDefault(p => p.EmployeeID == employeeID);
                    if (bDel != null)
                    {
                        context.Employees.Remove(bDel);
                        context.SaveChanges();
                        Reload();
                        MessageBox.Show("Xóa thành công!");
                    }
                }
            }
            if (dgvEmployee.Columns[e.ColumnIndex].Name == "Edit")
            {
                string employeeID, fullName, address, sex, idCard, phoneNumber, email; DateTime dateOfBirth;
                employeeID = Convert.ToString(dgvEmployee.Rows[e.RowIndex].Cells[2].Value);
                fullName = Convert.ToString(dgvEmployee.Rows[e.RowIndex].Cells[3].Value);
                dateOfBirth = Convert.ToDateTime(dgvEmployee.Rows[e.RowIndex].Cells[4].Value);
                sex = Convert.ToString(dgvEmployee.Rows[e.RowIndex].Cells[5].Value);
                idCard = Convert.ToString(dgvEmployee.Rows[e.RowIndex].Cells[6].Value);
                phoneNumber = Convert.ToString(dgvEmployee.Rows[e.RowIndex].Cells[7].Value);
                email = Convert.ToString(dgvEmployee.Rows[e.RowIndex].Cells[8].Value);
                address = Convert.ToString(dgvEmployee.Rows[e.RowIndex].Cells[9].Value);
                frmAddEdit_Employee f = new frmAddEdit_Employee(employeeID, fullName, idCard, sex, phoneNumber, email, address, dateOfBirth);
                f.Show();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            List<Employee> listSearch = new List<Employee>();
            List<Employee> listEmployee = context.Employees.ToList();
            if (txtSearch.Text != null)
            {
                foreach (Employee item in listEmployee)
                {
                    if (item.EmployeeID.ToLower().Contains(txtSearch.Text.ToLower()) 
                        || item.FullName.ToLower().Contains(txtSearch.Text.ToLower()) 
                        || item.Sex.ToString().Contains(txtSearch.Text.ToLower())
                        || item.IDCard.ToLower().Contains(txtSearch.Text.ToLower()) 
                        || item.PhoneNumber.ToLower().Contains(txtSearch.Text.ToLower())
                        || item.Email.ToLower().Contains(txtSearch.Text.ToLower())
                        || item.Address.ToLower().Contains(txtSearch.Text.ToLower()))
                    {
                        listSearch.Add(item);
                    }
                    BindGrid(listSearch);

                }
            }
            else
                BindGrid(listEmployee);
        }
        private void SearchDate()
        {
            try
            {
                List<Employee> listSearch = new List<Employee>();
                List<Employee> listEmployee = context.Employees.ToList();
                if (dtpTo.Value > dtpFrom.Value)
                {
                    throw new Exception("Ngày bắt đầu lớn hơn ngày kết thúc !!!");
                }                    
                listSearch = listEmployee.Where(p => p.DateOfBirth >= dtpTo.Value && p.DateOfBirth <= dtpFrom.Value).ToList();
                BindGrid(listSearch);
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
            txtSearch.ResetText();
            dtpTo.Value = dtpFrom.Value = DateTime.Now;
            Reload();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddEdit_Employee f = new frmAddEdit_Employee();
            f.Show();
        }
    }    
}
