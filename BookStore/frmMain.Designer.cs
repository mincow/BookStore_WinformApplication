
namespace BookStore
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.pnlImport = new System.Windows.Forms.Panel();
            this.btnReceipt = new System.Windows.Forms.Button();
            this.btnPurchaseOrder = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.pnlLine0 = new System.Windows.Forms.Panel();
            this.btnPromotion = new System.Windows.Forms.Button();
            this.btnInvoice = new System.Windows.Forms.Button();
            this.pnlEmployee = new System.Windows.Forms.Panel();
            this.btnAccount = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnEmployeeManage = new System.Windows.Forms.Button();
            this.pnlBook = new System.Windows.Forms.Panel();
            this.btnPublisher = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.btnBook = new System.Windows.Forms.Button();
            this.btnBookManage = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlWall = new System.Windows.Forms.Panel();
            this.lblAmPm = new System.Windows.Forms.Label();
            this.lblSecond = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.pnlIcon = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.Button();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.pnlEnd = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.llblLogout = new System.Windows.Forms.LinkLabel();
            this.lblUser = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlDesktop = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnSupplier = new System.Windows.Forms.Button();
            this.pnlCustomer = new System.Windows.Forms.Panel();
            this.btnVIP = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnCustomerManage = new System.Windows.Forms.Button();
            this.pnlMenu.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.pnlImport.SuspendLayout();
            this.pnlEmployee.SuspendLayout();
            this.pnlBook.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.pnlWall.SuspendLayout();
            this.pnlIcon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.pnlTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.pnlMenu.Controls.Add(this.pnlBottom);
            this.pnlMenu.Controls.Add(this.pnlTop);
            this.pnlMenu.Controls.Add(this.pnlEnd);
            this.pnlMenu.Controls.Add(this.btnExit);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(340, 1000);
            this.pnlMenu.TabIndex = 0;
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.pnlLine0);
            this.pnlBottom.Controls.Add(this.btnSupplier);
            this.pnlBottom.Controls.Add(this.pnlCustomer);
            this.pnlBottom.Controls.Add(this.pnlImport);
            this.pnlBottom.Controls.Add(this.btnPromotion);
            this.pnlBottom.Controls.Add(this.btnInvoice);
            this.pnlBottom.Controls.Add(this.pnlEmployee);
            this.pnlBottom.Controls.Add(this.pnlBook);
            this.pnlBottom.Controls.Add(this.btnHome);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBottom.Location = new System.Drawing.Point(0, 243);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(340, 676);
            this.pnlBottom.TabIndex = 9;
            // 
            // pnlImport
            // 
            this.pnlImport.Controls.Add(this.btnReceipt);
            this.pnlImport.Controls.Add(this.btnPurchaseOrder);
            this.pnlImport.Controls.Add(this.btnImport);
            this.pnlImport.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlImport.Location = new System.Drawing.Point(0, 400);
            this.pnlImport.Name = "pnlImport";
            this.pnlImport.Size = new System.Drawing.Size(340, 80);
            this.pnlImport.TabIndex = 107;
            this.pnlImport.Tag = "flag";
            // 
            // btnReceipt
            // 
            this.btnReceipt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(41)))), ((int)(((byte)(64)))));
            this.btnReceipt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReceipt.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReceipt.FlatAppearance.BorderSize = 0;
            this.btnReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceipt.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceipt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(203)))), ((int)(((byte)(227)))));
            this.btnReceipt.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReceipt.Location = new System.Drawing.Point(0, 148);
            this.btnReceipt.Name = "btnReceipt";
            this.btnReceipt.Padding = new System.Windows.Forms.Padding(24, 0, 15, 0);
            this.btnReceipt.Size = new System.Drawing.Size(340, 68);
            this.btnReceipt.TabIndex = 6;
            this.btnReceipt.Tag = "Biên Lai";
            this.btnReceipt.Text = "Biên Lai";
            this.btnReceipt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReceipt.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnReceipt.UseVisualStyleBackColor = false;
            this.btnReceipt.Click += new System.EventHandler(this.btnReceipt_Click);
            // 
            // btnPurchaseOrder
            // 
            this.btnPurchaseOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(41)))), ((int)(((byte)(64)))));
            this.btnPurchaseOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPurchaseOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPurchaseOrder.FlatAppearance.BorderSize = 0;
            this.btnPurchaseOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPurchaseOrder.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchaseOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(203)))), ((int)(((byte)(227)))));
            this.btnPurchaseOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPurchaseOrder.Location = new System.Drawing.Point(0, 80);
            this.btnPurchaseOrder.Name = "btnPurchaseOrder";
            this.btnPurchaseOrder.Padding = new System.Windows.Forms.Padding(24, 0, 15, 0);
            this.btnPurchaseOrder.Size = new System.Drawing.Size(340, 68);
            this.btnPurchaseOrder.TabIndex = 5;
            this.btnPurchaseOrder.Tag = "Đơn Đặt Hàng";
            this.btnPurchaseOrder.Text = "Đơn Đặt Hàng";
            this.btnPurchaseOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPurchaseOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnPurchaseOrder.UseVisualStyleBackColor = false;
            this.btnPurchaseOrder.Click += new System.EventHandler(this.btnPurchaseOrder_Click);
            // 
            // btnImport
            // 
            this.btnImport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnImport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnImport.FlatAppearance.BorderSize = 0;
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImport.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnImport.Image = ((System.Drawing.Image)(resources.GetObject("btnImport.Image")));
            this.btnImport.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImport.Location = new System.Drawing.Point(0, 0);
            this.btnImport.Name = "btnImport";
            this.btnImport.Padding = new System.Windows.Forms.Padding(12, 0, 35, 0);
            this.btnImport.Size = new System.Drawing.Size(340, 80);
            this.btnImport.TabIndex = 4;
            this.btnImport.Tag = "Nhập Hàng";
            this.btnImport.Text = "Nhập Hàng";
            this.btnImport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImport.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // pnlLine0
            // 
            this.pnlLine0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(219)))), ((int)(((byte)(144)))));
            this.pnlLine0.Location = new System.Drawing.Point(3, 1);
            this.pnlLine0.Name = "pnlLine0";
            this.pnlLine0.Size = new System.Drawing.Size(6, 76);
            this.pnlLine0.TabIndex = 7;
            // 
            // btnPromotion
            // 
            this.btnPromotion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnPromotion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPromotion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPromotion.FlatAppearance.BorderSize = 0;
            this.btnPromotion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPromotion.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPromotion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnPromotion.Image = ((System.Drawing.Image)(resources.GetObject("btnPromotion.Image")));
            this.btnPromotion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPromotion.Location = new System.Drawing.Point(0, 320);
            this.btnPromotion.Name = "btnPromotion";
            this.btnPromotion.Padding = new System.Windows.Forms.Padding(12, 0, 35, 0);
            this.btnPromotion.Size = new System.Drawing.Size(340, 80);
            this.btnPromotion.TabIndex = 102;
            this.btnPromotion.Tag = "Khuyến Mãi";
            this.btnPromotion.Text = "Khuyến Mãi";
            this.btnPromotion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPromotion.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnPromotion.UseVisualStyleBackColor = false;
            this.btnPromotion.Click += new System.EventHandler(this.btnPromotion_Click);
            // 
            // btnInvoice
            // 
            this.btnInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnInvoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInvoice.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInvoice.FlatAppearance.BorderSize = 0;
            this.btnInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvoice.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvoice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnInvoice.Image = ((System.Drawing.Image)(resources.GetObject("btnInvoice.Image")));
            this.btnInvoice.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInvoice.Location = new System.Drawing.Point(0, 240);
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.Padding = new System.Windows.Forms.Padding(12, 0, 35, 0);
            this.btnInvoice.Size = new System.Drawing.Size(340, 80);
            this.btnInvoice.TabIndex = 101;
            this.btnInvoice.Tag = "Hóa Đơn";
            this.btnInvoice.Text = "Hóa Đơn";
            this.btnInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInvoice.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnInvoice.UseVisualStyleBackColor = false;
            this.btnInvoice.Click += new System.EventHandler(this.btnInvoice_Click);
            // 
            // pnlEmployee
            // 
            this.pnlEmployee.Controls.Add(this.btnAccount);
            this.pnlEmployee.Controls.Add(this.btnEmployee);
            this.pnlEmployee.Controls.Add(this.btnEmployeeManage);
            this.pnlEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEmployee.Location = new System.Drawing.Point(0, 160);
            this.pnlEmployee.Name = "pnlEmployee";
            this.pnlEmployee.Size = new System.Drawing.Size(340, 80);
            this.pnlEmployee.TabIndex = 100;
            this.pnlEmployee.Tag = "flag";
            // 
            // btnAccount
            // 
            this.btnAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(41)))), ((int)(((byte)(64)))));
            this.btnAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAccount.FlatAppearance.BorderSize = 0;
            this.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccount.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(203)))), ((int)(((byte)(227)))));
            this.btnAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAccount.Location = new System.Drawing.Point(0, 148);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Padding = new System.Windows.Forms.Padding(24, 0, 15, 0);
            this.btnAccount.Size = new System.Drawing.Size(340, 68);
            this.btnAccount.TabIndex = 6;
            this.btnAccount.Tag = "Tài Khoản";
            this.btnAccount.Text = "Tài Khoản";
            this.btnAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAccount.UseVisualStyleBackColor = false;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(41)))), ((int)(((byte)(64)))));
            this.btnEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmployee.FlatAppearance.BorderSize = 0;
            this.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployee.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(203)))), ((int)(((byte)(227)))));
            this.btnEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEmployee.Location = new System.Drawing.Point(0, 80);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Padding = new System.Windows.Forms.Padding(24, 0, 15, 0);
            this.btnEmployee.Size = new System.Drawing.Size(340, 68);
            this.btnEmployee.TabIndex = 5;
            this.btnEmployee.Tag = "Thông Tin Nhân Viên";
            this.btnEmployee.Text = "Thông Tin Nhân Viên";
            this.btnEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEmployee.UseVisualStyleBackColor = false;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnEmployeeManage
            // 
            this.btnEmployeeManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnEmployeeManage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmployeeManage.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmployeeManage.FlatAppearance.BorderSize = 0;
            this.btnEmployeeManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployeeManage.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeManage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnEmployeeManage.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployeeManage.Image")));
            this.btnEmployeeManage.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEmployeeManage.Location = new System.Drawing.Point(0, 0);
            this.btnEmployeeManage.Name = "btnEmployeeManage";
            this.btnEmployeeManage.Padding = new System.Windows.Forms.Padding(12, 0, 35, 0);
            this.btnEmployeeManage.Size = new System.Drawing.Size(340, 80);
            this.btnEmployeeManage.TabIndex = 4;
            this.btnEmployeeManage.Tag = "Nhân Viên";
            this.btnEmployeeManage.Text = "Nhân Viên";
            this.btnEmployeeManage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployeeManage.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEmployeeManage.UseVisualStyleBackColor = false;
            this.btnEmployeeManage.Click += new System.EventHandler(this.btnEmployeeManage_Click);
            // 
            // pnlBook
            // 
            this.pnlBook.Controls.Add(this.btnPublisher);
            this.pnlBook.Controls.Add(this.btnCategory);
            this.pnlBook.Controls.Add(this.btnBook);
            this.pnlBook.Controls.Add(this.btnBookManage);
            this.pnlBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBook.Location = new System.Drawing.Point(0, 80);
            this.pnlBook.Name = "pnlBook";
            this.pnlBook.Size = new System.Drawing.Size(340, 80);
            this.pnlBook.TabIndex = 99;
            this.pnlBook.Tag = "flag";
            // 
            // btnPublisher
            // 
            this.btnPublisher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(41)))), ((int)(((byte)(64)))));
            this.btnPublisher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPublisher.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPublisher.FlatAppearance.BorderSize = 0;
            this.btnPublisher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPublisher.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPublisher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(203)))), ((int)(((byte)(227)))));
            this.btnPublisher.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPublisher.Location = new System.Drawing.Point(0, 216);
            this.btnPublisher.Name = "btnPublisher";
            this.btnPublisher.Padding = new System.Windows.Forms.Padding(24, 0, 15, 0);
            this.btnPublisher.Size = new System.Drawing.Size(340, 68);
            this.btnPublisher.TabIndex = 7;
            this.btnPublisher.Tag = "Nhà Xuất Bản";
            this.btnPublisher.Text = "Nhà Xuất Bản";
            this.btnPublisher.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPublisher.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnPublisher.UseVisualStyleBackColor = false;
            this.btnPublisher.Click += new System.EventHandler(this.btnPublisher_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(41)))), ((int)(((byte)(64)))));
            this.btnCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCategory.FlatAppearance.BorderSize = 0;
            this.btnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategory.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(203)))), ((int)(((byte)(227)))));
            this.btnCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCategory.Location = new System.Drawing.Point(0, 148);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Padding = new System.Windows.Forms.Padding(24, 0, 15, 0);
            this.btnCategory.Size = new System.Drawing.Size(340, 68);
            this.btnCategory.TabIndex = 6;
            this.btnCategory.Tag = "Thể Loại";
            this.btnCategory.Text = "Thể Loại";
            this.btnCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCategory.UseVisualStyleBackColor = false;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnBook
            // 
            this.btnBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(41)))), ((int)(((byte)(64)))));
            this.btnBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBook.FlatAppearance.BorderSize = 0;
            this.btnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBook.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(203)))), ((int)(((byte)(227)))));
            this.btnBook.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBook.Location = new System.Drawing.Point(0, 80);
            this.btnBook.Name = "btnBook";
            this.btnBook.Padding = new System.Windows.Forms.Padding(24, 0, 15, 0);
            this.btnBook.Size = new System.Drawing.Size(340, 68);
            this.btnBook.TabIndex = 5;
            this.btnBook.Tag = "Sách";
            this.btnBook.Text = "Sách";
            this.btnBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBook.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBook.UseVisualStyleBackColor = false;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // btnBookManage
            // 
            this.btnBookManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnBookManage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBookManage.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBookManage.FlatAppearance.BorderSize = 0;
            this.btnBookManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookManage.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookManage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnBookManage.Image = ((System.Drawing.Image)(resources.GetObject("btnBookManage.Image")));
            this.btnBookManage.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBookManage.Location = new System.Drawing.Point(0, 0);
            this.btnBookManage.Name = "btnBookManage";
            this.btnBookManage.Padding = new System.Windows.Forms.Padding(12, 0, 35, 0);
            this.btnBookManage.Size = new System.Drawing.Size(340, 80);
            this.btnBookManage.TabIndex = 4;
            this.btnBookManage.Tag = "Quản Lý Sách";
            this.btnBookManage.Text = "Quản Lý Sách";
            this.btnBookManage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBookManage.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBookManage.UseVisualStyleBackColor = false;
            this.btnBookManage.Click += new System.EventHandler(this.btnBookManage_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Verdana", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(15, 0, 35, 0);
            this.btnHome.Size = new System.Drawing.Size(340, 80);
            this.btnHome.TabIndex = 98;
            this.btnHome.Tag = "Trang Chủ";
            this.btnHome.Text = "Trang Chủ";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.pnlWall);
            this.pnlTop.Controls.Add(this.pnlIcon);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(340, 243);
            this.pnlTop.TabIndex = 8;
            // 
            // pnlWall
            // 
            this.pnlWall.Controls.Add(this.lblAmPm);
            this.pnlWall.Controls.Add(this.lblSecond);
            this.pnlWall.Controls.Add(this.lblTime);
            this.pnlWall.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlWall.Location = new System.Drawing.Point(0, 135);
            this.pnlWall.Name = "pnlWall";
            this.pnlWall.Size = new System.Drawing.Size(340, 108);
            this.pnlWall.TabIndex = 7;
            // 
            // lblAmPm
            // 
            this.lblAmPm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAmPm.Font = new System.Drawing.Font("DS-Digital", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmPm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(237)))), ((int)(((byte)(170)))));
            this.lblAmPm.Location = new System.Drawing.Point(183, 63);
            this.lblAmPm.Name = "lblAmPm";
            this.lblAmPm.Size = new System.Drawing.Size(74, 42);
            this.lblAmPm.TabIndex = 1;
            this.lblAmPm.Text = "PM";
            this.lblAmPm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSecond
            // 
            this.lblSecond.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSecond.Font = new System.Drawing.Font("DS-Digital", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecond.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(237)))), ((int)(((byte)(170)))));
            this.lblSecond.Location = new System.Drawing.Point(183, 3);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Size = new System.Drawing.Size(74, 42);
            this.lblSecond.TabIndex = 1;
            this.lblSecond.Text = "00";
            this.lblSecond.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTime.Font = new System.Drawing.Font("DS-Digital", 40.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(237)))), ((int)(((byte)(170)))));
            this.lblTime.Location = new System.Drawing.Point(0, 16);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(188, 68);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "00:00";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlIcon
            // 
            this.pnlIcon.Controls.Add(this.btnMenu);
            this.pnlIcon.Controls.Add(this.pbxLogo);
            this.pnlIcon.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlIcon.Location = new System.Drawing.Point(0, 0);
            this.pnlIcon.Name = "pnlIcon";
            this.pnlIcon.Size = new System.Drawing.Size(340, 135);
            this.pnlIcon.TabIndex = 6;
            // 
            // btnMenu
            // 
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.Location = new System.Drawing.Point(243, 12);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(74, 45);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // pbxLogo
            // 
            this.pbxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbxLogo.Image")));
            this.pbxLogo.Location = new System.Drawing.Point(3, 3);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(196, 157);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogo.TabIndex = 0;
            this.pbxLogo.TabStop = false;
            // 
            // pnlEnd
            // 
            this.pnlEnd.BackColor = System.Drawing.Color.White;
            this.pnlEnd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlEnd.Location = new System.Drawing.Point(0, 919);
            this.pnlEnd.Name = "pnlEnd";
            this.pnlEnd.Size = new System.Drawing.Size(340, 1);
            this.pnlEnd.TabIndex = 5;
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Verdana", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.Location = new System.Drawing.Point(0, 920);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(12, 0, 35, 0);
            this.btnExit.Size = new System.Drawing.Size(340, 80);
            this.btnExit.TabIndex = 2;
            this.btnExit.Tag = "Thoát";
            this.btnExit.Text = "Thoát";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(237)))), ((int)(((byte)(170)))));
            this.lblDate.Location = new System.Drawing.Point(2, 18);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(242, 28);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Wednesday, 00-00-0000";
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.pnlTitleBar.Controls.Add(this.lblTitle);
            this.pnlTitleBar.Controls.Add(this.llblLogout);
            this.pnlTitleBar.Controls.Add(this.lblUser);
            this.pnlTitleBar.Controls.Add(this.pictureBox1);
            this.pnlTitleBar.Controls.Add(this.lblDate);
            this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleBar.Location = new System.Drawing.Point(340, 0);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(1145, 74);
            this.pnlTitleBar.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(195)))), ((int)(((byte)(245)))));
            this.lblTitle.Location = new System.Drawing.Point(374, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(295, 41);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // llblLogout
            // 
            this.llblLogout.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(151)))), ((int)(((byte)(156)))));
            this.llblLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.llblLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.llblLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(195)))), ((int)(((byte)(245)))));
            this.llblLogout.Image = ((System.Drawing.Image)(resources.GetObject("llblLogout.Image")));
            this.llblLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.llblLogout.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(195)))), ((int)(((byte)(245)))));
            this.llblLogout.Location = new System.Drawing.Point(854, 40);
            this.llblLogout.Name = "llblLogout";
            this.llblLogout.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.llblLogout.Size = new System.Drawing.Size(146, 25);
            this.llblLogout.TabIndex = 8;
            this.llblLogout.TabStop = true;
            this.llblLogout.Text = "Đăng Xuất";
            this.llblLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.llblLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblLogout_LinkClicked);
            // 
            // lblUser
            // 
            this.lblUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUser.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(195)))), ((int)(((byte)(245)))));
            this.lblUser.Location = new System.Drawing.Point(858, 3);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(287, 37);
            this.lblUser.TabIndex = 7;
            this.lblUser.Text = "Xin chào,";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(806, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 46);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pnlDesktop
            // 
            this.pnlDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.pnlDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDesktop.Location = new System.Drawing.Point(340, 74);
            this.pnlDesktop.Name = "pnlDesktop";
            this.pnlDesktop.Size = new System.Drawing.Size(1145, 926);
            this.pnlDesktop.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnSupplier
            // 
            this.btnSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnSupplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSupplier.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSupplier.FlatAppearance.BorderSize = 0;
            this.btnSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupplier.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnSupplier.Image = ((System.Drawing.Image)(resources.GetObject("btnSupplier.Image")));
            this.btnSupplier.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSupplier.Location = new System.Drawing.Point(0, 560);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Padding = new System.Windows.Forms.Padding(12, 0, 35, 0);
            this.btnSupplier.Size = new System.Drawing.Size(340, 80);
            this.btnSupplier.TabIndex = 109;
            this.btnSupplier.Tag = "Nhà Cung Ứng";
            this.btnSupplier.Text = "Nhà Cung Ứng";
            this.btnSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupplier.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSupplier.UseVisualStyleBackColor = false;
            this.btnSupplier.Click += new System.EventHandler(this.btnSupplier_Click);
            // 
            // pnlCustomer
            // 
            this.pnlCustomer.Controls.Add(this.btnVIP);
            this.pnlCustomer.Controls.Add(this.btnCustomer);
            this.pnlCustomer.Controls.Add(this.btnCustomerManage);
            this.pnlCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCustomer.Location = new System.Drawing.Point(0, 480);
            this.pnlCustomer.Name = "pnlCustomer";
            this.pnlCustomer.Size = new System.Drawing.Size(340, 80);
            this.pnlCustomer.TabIndex = 108;
            this.pnlCustomer.Tag = "flag";
            // 
            // btnVIP
            // 
            this.btnVIP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(41)))), ((int)(((byte)(64)))));
            this.btnVIP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVIP.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVIP.FlatAppearance.BorderSize = 0;
            this.btnVIP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVIP.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVIP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(203)))), ((int)(((byte)(227)))));
            this.btnVIP.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVIP.Location = new System.Drawing.Point(0, 148);
            this.btnVIP.Name = "btnVIP";
            this.btnVIP.Padding = new System.Windows.Forms.Padding(24, 0, 15, 0);
            this.btnVIP.Size = new System.Drawing.Size(340, 68);
            this.btnVIP.TabIndex = 6;
            this.btnVIP.Tag = "VIP Discount";
            this.btnVIP.Text = "VIP Discount";
            this.btnVIP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVIP.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnVIP.UseVisualStyleBackColor = false;
            this.btnVIP.Click += new System.EventHandler(this.btnVIP_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(41)))), ((int)(((byte)(64)))));
            this.btnCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCustomer.FlatAppearance.BorderSize = 0;
            this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomer.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(203)))), ((int)(((byte)(227)))));
            this.btnCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCustomer.Location = new System.Drawing.Point(0, 80);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Padding = new System.Windows.Forms.Padding(24, 0, 15, 0);
            this.btnCustomer.Size = new System.Drawing.Size(340, 68);
            this.btnCustomer.TabIndex = 5;
            this.btnCustomer.Tag = "Thẻ Thành Viên";
            this.btnCustomer.Text = "Thẻ Thành Viên";
            this.btnCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCustomer.UseVisualStyleBackColor = false;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnCustomerManage
            // 
            this.btnCustomerManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnCustomerManage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomerManage.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCustomerManage.FlatAppearance.BorderSize = 0;
            this.btnCustomerManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerManage.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerManage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnCustomerManage.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomerManage.Image")));
            this.btnCustomerManage.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCustomerManage.Location = new System.Drawing.Point(0, 0);
            this.btnCustomerManage.Name = "btnCustomerManage";
            this.btnCustomerManage.Padding = new System.Windows.Forms.Padding(12, 0, 35, 0);
            this.btnCustomerManage.Size = new System.Drawing.Size(340, 80);
            this.btnCustomerManage.TabIndex = 4;
            this.btnCustomerManage.Tag = "Khách hàng";
            this.btnCustomerManage.Text = "Khách Hàng";
            this.btnCustomerManage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomerManage.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCustomerManage.UseVisualStyleBackColor = false;
            this.btnCustomerManage.Click += new System.EventHandler(this.btnCustomerManage_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1485, 1000);
            this.Controls.Add(this.pnlDesktop);
            this.Controls.Add(this.pnlTitleBar);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign In";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlBottom.ResumeLayout(false);
            this.pnlImport.ResumeLayout(false);
            this.pnlEmployee.ResumeLayout(false);
            this.pnlBook.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlWall.ResumeLayout(false);
            this.pnlIcon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlCustomer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlEnd;
        private System.Windows.Forms.Panel pnlDesktop;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button btnPromotion;
        private System.Windows.Forms.Button btnInvoice;
        private System.Windows.Forms.Panel pnlEmployee;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnEmployeeManage;
        private System.Windows.Forms.Panel pnlBook;
        private System.Windows.Forms.Button btnPublisher;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button btnBookManage;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlWall;
        private System.Windows.Forms.Label lblAmPm;
        private System.Windows.Forms.Label lblSecond;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Panel pnlIcon;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Panel pnlLine0;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.LinkLabel llblLogout;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlImport;
        private System.Windows.Forms.Button btnReceipt;
        private System.Windows.Forms.Button btnPurchaseOrder;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnSupplier;
        private System.Windows.Forms.Panel pnlCustomer;
        private System.Windows.Forms.Button btnVIP;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnCustomerManage;
    }
}

