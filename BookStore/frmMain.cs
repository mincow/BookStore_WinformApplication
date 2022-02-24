using BookStore.ChildForm;
using BookStore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    public partial class frmMain : Form
    {
        BookStoreDB context = new BookStoreDB();
        internal Account accountSignIn = new Account();
        public frmMain(Account a)
        {
            InitializeComponent();
            timer1.Start();
            accountSignIn = a;
        }
        
        private void frmMain_Load(object sender, EventArgs e)
        {
                
            Employee employeeSignIn = context.Employees.FirstOrDefault(p => p.EmployeeID == accountSignIn.EmployeeID);
            lblUser.Text = "Xin chào, " + employeeSignIn.FullName.ToString();
            //
            if (accountSignIn.Roles == false)
            {
                btnEmployeeManage.Enabled = false;
                btnEmployee.Enabled = false;
                btnAccount.Enabled = false;
                btnReceipt.Enabled = false;
                btnSupplier.Enabled = false;
                btnImport.Enabled = false;
            }    

            //Scroll without scrollbar
            pnlBottom.VerticalScroll.Maximum = 0;
            pnlBottom.VerticalScroll.Visible = false;
            //pnlMenu.HorizontalScroll.Maximum = 0;
            //pnlMenu.HorizontalScroll.Visible = false;            
            pnlBottom.AutoScroll = true;

            //Hide selected tab
            pnlLine0.Location = btnHome.Location;
            lblTitle.Text = "Trang chủ";
            frmHome fHome = new frmHome();
            ChildForm(fHome);

        }

        private bool isCollapsePnlBook = true;
        private bool isCollapsePnlEmployee = true;
        private bool isCollapsePnlCustomer = true;
        private bool isCollapsePnlImport = true;

        //private void 

        private void btnExit_Click(object sender, EventArgs e)
        {
            /*DialogResult confirm = MessageBox.Show("Bạn chắn chắn muốn to");*/
            Application.Exit();
        }


        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (this.pnlMenu.Width > 240) // 340, 892
            {
                lblTime.Size = new Size(110, 52);
                lblTime.Font = new Font("DS-Digital", 30);
                lblSecond.Visible = false;
                lblAmPm.Visible = false;
                lblDate.Font = new Font("Comic Sans MS", 13);
                pnlMenu.Width = 110;
                pbxLogo.Visible = false;
                btnMenu.Dock = DockStyle.Top;
                btnExit.Text = "";
                btnExit.ImageAlign = ContentAlignment.MiddleCenter;
                btnExit.Padding = new Padding(0);

                foreach (Button bt in pnlBottom.Controls.OfType<Button>())
                {
                    bt.Text = "";
                    bt.ImageAlign = ContentAlignment.MiddleCenter;
                    bt.Padding = new Padding(0);
                }

                foreach (Panel pnl in pnlBottom.Controls.OfType<Panel>())
                {
                    if (pnl.Height > 150 && Convert.ToString(pnl.Tag) == "flag")
                    {
                        if (pnl.Controls.Count == 4)
                            pnl.Height -= 166;
                        else
                            pnl.Height -= 111;
                        if (pnl.Name.Contains("Book"))
                            isCollapsePnlBook = true;
                        if (pnl.Name.Contains("Employee"))
                            isCollapsePnlEmployee = true;
                        if (pnl.Name.Contains("Customer"))
                            isCollapsePnlCustomer = true;
                    }
                    foreach (Button bt in pnl.Controls.OfType<Button>())
                    {
                        bt.Text = "";
                        bt.ImageAlign = ContentAlignment.MiddleCenter;
                        bt.Padding = new Padding(0);
                    }
                }
            }
            else
            {
                RefreshFormat();
            }
        }

        private void RefreshFormat()
        {
            lblTime.Size = new Size(142, 56);
            lblTime.Font = new Font("DS-Digital", (float)40.2);
            lblSecond.Visible = true;
            lblAmPm.Visible = true;
            pnlMenu.Width = 255;
            pbxLogo.Visible = true;
            btnMenu.Dock = DockStyle.None;
            btnExit.Text = btnExit.Tag.ToString();
            btnExit.TextAlign = ContentAlignment.MiddleLeft;
            btnExit.ImageAlign = ContentAlignment.MiddleRight;
            btnExit.Padding = new Padding(9, 0, 26, 0);
            foreach (Button bt in pnlBottom.Controls.OfType<Button>())
            {
                bt.Text = bt.Tag.ToString();
                bt.TextAlign = ContentAlignment.MiddleLeft;
                bt.ImageAlign = ContentAlignment.MiddleRight;
                bt.Padding = new Padding(9, 0, 26, 0);
            }
            foreach (Panel pnl in pnlBottom.Controls.OfType<Panel>())
            {
                if (Convert.ToString(pnl.Tag) == "flag")
                    foreach (Button bt in pnl.Controls.OfType<Button>())
                    {
                        bt.Text = bt.Tag.ToString();
                        bt.TextAlign = ContentAlignment.MiddleLeft;
                        bt.ImageAlign = ContentAlignment.MiddleRight;
                        if (bt.ForeColor.Name == "ffc3cbe3") //195, 203, 227
                            bt.Padding = new Padding(18, 0, 26, 0);
                        else
                            bt.Padding = new Padding(9, 0, 26, 0);
                    }
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Trang chủ";
            //Hide selected tab
            pnlLine0.Location = btnHome.Location;
            frmHome fHome = new frmHome();
            ChildForm(fHome);
        }

        private void CollapseOrExpand(Panel pnlOject)
        {
            if ((pnlOject.Name.Contains("Book") && isCollapsePnlBook) || (pnlOject.Name.Contains("Employee") && isCollapsePnlEmployee) || (pnlOject.Name.Contains("Customer") && isCollapsePnlCustomer) || (pnlOject.Name.Contains("Import") && isCollapsePnlImport))
            {
                if (pnlOject.Controls.Count == 4)
                    pnlOject.Height += 166; //3 button 55
                else
                    pnlOject.Height += 111; //2 button 55
                if (pnlOject.Name.Contains("Book"))
                    isCollapsePnlBook = false;
                if (pnlOject.Name.Contains("Employee"))
                    isCollapsePnlEmployee = false;
                if (pnlOject.Name.Contains("Customer"))
                    isCollapsePnlCustomer = false;
                if (pnlOject.Name.Contains("Import"))
                    isCollapsePnlImport = false;
            }
            else
            {
                if (pnlOject.Controls.Count == 4)
                    pnlOject.Height -= 166;
                else
                    pnlOject.Height -= 111;
                if (pnlOject.Name.Contains("Book"))
                    isCollapsePnlBook = true;
                if (pnlOject.Name.Contains("Employee"))
                    isCollapsePnlEmployee = true;
                if (pnlOject.Name.Contains("Customer"))
                    isCollapsePnlCustomer = true;
                if (pnlOject.Name.Contains("Import"))
                    isCollapsePnlImport = true;

            }
        }

        private void btnBookManage_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Quản Lý Sách";
            CollapseOrExpand(pnlBook);
            if (!isCollapsePnlCustomer)
                CollapseOrExpand(pnlCustomer);
            else if (!isCollapsePnlEmployee)
                CollapseOrExpand(pnlEmployee);
            else if (!isCollapsePnlImport)
                CollapseOrExpand(pnlImport);

                RefreshFormat();
            //Hide selected tab
            pnlLine0.Location = pnlBook.Location;
        }

        private void ChildForm(Form f)
        {
            pnlDesktop.Controls.Clear();
            f.MdiParent = this;
            f.Show();
            f.TopLevel = false;
            f.VerticalScroll.Maximum = 0;
            f.VerticalScroll.Visible = false;
            f.AutoScroll = true;
            pnlDesktop.Controls.Add(f);
            f.Dock = DockStyle.Fill;
        }
        private void btnBook_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Quản Lý Sách > Sách";
            frmBook fBook = new frmBook(accountSignIn);
            ChildForm(fBook);
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Quản Lý Sách > Thể Loại";
            frmCategory fCategory = new frmCategory(accountSignIn);
            ChildForm(fCategory);
        }

        private void btnPublisher_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Quản Lý Sách > Nhà Xuất Bản";
            frmPublisher fPublisher = new frmPublisher(accountSignIn);
            ChildForm(fPublisher);
        }

        private void btnEmployeeManage_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Nhân Viên";
            CollapseOrExpand(pnlEmployee);
            if (!isCollapsePnlCustomer)
                CollapseOrExpand(pnlCustomer);
            else if (!isCollapsePnlBook)
                CollapseOrExpand(pnlBook);
            else if (!isCollapsePnlImport)
                CollapseOrExpand(pnlImport);
            RefreshFormat();
            //Hide selected tab
            pnlLine0.Location = pnlEmployee.Location;
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Nhân Viên > Thông Tin Nhân Viên";
            frmEmployee fEmployee = new frmEmployee();
            ChildForm(fEmployee);
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Nhân Viên > Tài Khoản";
            frmAccount fAccount = new frmAccount();
            ChildForm(fAccount);
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Hóa Đơn";
            //Hide selected tab
            pnlLine0.Location = btnInvoice.Location;
            frmInvoice fInvoice = new frmInvoice(accountSignIn);
            ChildForm(fInvoice);
        }

        private void btnPromotion_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Khuyến Mãi";
            pnlLine0.Location = btnPromotion.Location;
            frmPromotion fPromotion = new frmPromotion(accountSignIn);
            ChildForm(fPromotion);
        }

        private void btnCustomerManage_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Khách Hàng";
            CollapseOrExpand(pnlCustomer);
            if (!isCollapsePnlBook)
                CollapseOrExpand(pnlBook);
            else if (!isCollapsePnlEmployee)
                CollapseOrExpand(pnlEmployee);
            else if (!isCollapsePnlImport)
                CollapseOrExpand(pnlImport);
            RefreshFormat();
            pnlEnd.BringToFront();
            pnlEnd.BackColor = Color.Violet;
            //Hide selected tab
            pnlLine0.Location = pnlCustomer.Location;
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Khách Hàng > Thẻ Thành Viên";
            frmCustommer fCustomer = new frmCustommer(accountSignIn);
            ChildForm(fCustomer);
        }

        private void btnVIP_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Khách Hàng > VIP";
            frmVIP fVIP = new frmVIP(accountSignIn);
            ChildForm(fVIP);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            lblTime.Text = time.ToString("hh:mm");
            lblSecond.Text = time.ToString("ss");
            lblAmPm.Text = time.ToString("tt");
            lblDate.Text = time.ToString("dddd, dd-MM-yyyy");
        }

        private void llblLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult di = MessageBox.Show("Bạn chắc chắn muốn đăng xuất ???", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (di == DialogResult.Yes)
            {
                Application.Restart();
                Environment.Exit(0);
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Nhập hàng";
            CollapseOrExpand(pnlImport);
            if (!isCollapsePnlBook)
                CollapseOrExpand(pnlBook);
            else if (!isCollapsePnlEmployee)
                CollapseOrExpand(pnlEmployee);
            else if (!isCollapsePnlCustomer)
                CollapseOrExpand(pnlCustomer);
            RefreshFormat();
            pnlEnd.BringToFront();
            pnlEnd.BackColor = Color.Violet;
            //Hide selected tab
            pnlLine0.Location = pnlImport.Location;
        }

        private void btnPurchaseOrder_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Nhập hàng > Đơn Đặt Hàng";
            frmPurchaseOrder fPurchaseOrder = new frmPurchaseOrder();
            ChildForm(fPurchaseOrder);
        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Nhập Hàng > Biên Lai";
            frmReceipt fReceipt = new frmReceipt();
            ChildForm(fReceipt);
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            
            lblTitle.Text = "Nhà Cung Ứng";
            frmSupplier fSupplier = new frmSupplier(accountSignIn);
            ChildForm(fSupplier);
            //Hide selected tab
            pnlLine0.Location = btnSupplier.Location;
        }
    }
}
