
namespace BookStore
{
    partial class frmBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBook));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.cmbOption = new System.Windows.Forms.ComboBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblLine0 = new System.Windows.Forms.Label();
            this.lblLine1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblLine3 = new System.Windows.Forms.Label();
            this.lblLine6 = new System.Windows.Forms.Label();
            this.lblLine7 = new System.Windows.Forms.Label();
            this.lblLine5 = new System.Windows.Forms.Label();
            this.lblLine4 = new System.Windows.Forms.Label();
            this.lbl9 = new System.Windows.Forms.Label();
            this.pbxBookImg = new System.Windows.Forms.PictureBox();
            this.pnlParent = new System.Windows.Forms.Panel();
            this.pnlImgBook = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lblLine12 = new System.Windows.Forms.Label();
            this.lblLine11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblLine10 = new System.Windows.Forms.Label();
            this.txtPulishedDate = new System.Windows.Forms.TextBox();
            this.txtImportDate = new System.Windows.Forms.TextBox();
            this.txtBuyPrice = new System.Windows.Forms.TextBox();
            this.lblBuyPrice = new System.Windows.Forms.Label();
            this.lblImportDate = new System.Windows.Forms.Label();
            this.lblDatePublished = new System.Windows.Forms.Label();
            this.pnlListBook = new System.Windows.Forms.Panel();
            this.dgvBook = new System.Windows.Forms.DataGridView();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.BookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PublisherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBookImg)).BeginInit();
            this.pnlParent.SuspendLayout();
            this.pnlImgBook.SuspendLayout();
            this.pnlListBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtSearch.Location = new System.Drawing.Point(330, 30);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(334, 28);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(12, 170);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(67, 71);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // grpSearch
            // 
            this.grpSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSearch.Controls.Add(this.btnRefresh);
            this.grpSearch.Controls.Add(this.label1);
            this.grpSearch.Controls.Add(this.dtpFrom);
            this.grpSearch.Controls.Add(this.dtpTo);
            this.grpSearch.Controls.Add(this.cmbOption);
            this.grpSearch.Controls.Add(this.lblSearch);
            this.grpSearch.Controls.Add(this.txtSearch);
            this.grpSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.grpSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            this.grpSearch.Location = new System.Drawing.Point(224, 12);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(995, 191);
            this.grpSearch.TabIndex = 6;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Tìm kiếm";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Location = new System.Drawing.Point(784, 47);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(123, 42);
            this.btnRefresh.TabIndex = 9;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 21F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(368, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 47);
            this.label1.TabIndex = 8;
            this.label1.Text = "~";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(456, 128);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(312, 30);
            this.dtpFrom.TabIndex = 6;
            this.dtpFrom.ValueChanged += new System.EventHandler(this.dtpFrom_ValueChanged);
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(10, 128);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(312, 30);
            this.dtpTo.TabIndex = 7;
            this.dtpTo.ValueChanged += new System.EventHandler(this.dtpTo_ValueChanged);
            // 
            // cmbOption
            // 
            this.cmbOption.FormattingEnabled = true;
            this.cmbOption.Items.AddRange(new object[] {
            "Ngày xuất bản",
            "Ngày nhập"});
            this.cmbOption.Location = new System.Drawing.Point(330, 71);
            this.cmbOption.Name = "cmbOption";
            this.cmbOption.Size = new System.Drawing.Size(190, 31);
            this.cmbOption.TabIndex = 4;
            this.cmbOption.Text = "Ngày xuất bản";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(6, 79);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(287, 23);
            this.lblSearch.TabIndex = 3;
            this.lblSearch.Text = "Tìm kiếm ngày nhập, ngày xuất bản";
            // 
            // btnReset
            // 
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.Location = new System.Drawing.Point(85, 170);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(67, 71);
            this.btnReset.TabIndex = 5;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblLine0
            // 
            this.lblLine0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            this.lblLine0.Location = new System.Drawing.Point(64, 21);
            this.lblLine0.Name = "lblLine0";
            this.lblLine0.Size = new System.Drawing.Size(50, 4);
            this.lblLine0.TabIndex = 7;
            // 
            // lblLine1
            // 
            this.lblLine1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            this.lblLine1.Location = new System.Drawing.Point(64, 24);
            this.lblLine1.Name = "lblLine1";
            this.lblLine1.Size = new System.Drawing.Size(4, 40);
            this.lblLine1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(64, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(4, 40);
            this.label2.TabIndex = 8;
            // 
            // lblLine3
            // 
            this.lblLine3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            this.lblLine3.Location = new System.Drawing.Point(64, 326);
            this.lblLine3.Name = "lblLine3";
            this.lblLine3.Size = new System.Drawing.Size(50, 4);
            this.lblLine3.TabIndex = 9;
            // 
            // lblLine6
            // 
            this.lblLine6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            this.lblLine6.Location = new System.Drawing.Point(324, 23);
            this.lblLine6.Name = "lblLine6";
            this.lblLine6.Size = new System.Drawing.Size(4, 40);
            this.lblLine6.TabIndex = 10;
            // 
            // lblLine7
            // 
            this.lblLine7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            this.lblLine7.Location = new System.Drawing.Point(277, 21);
            this.lblLine7.Name = "lblLine7";
            this.lblLine7.Size = new System.Drawing.Size(50, 4);
            this.lblLine7.TabIndex = 11;
            // 
            // lblLine5
            // 
            this.lblLine5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            this.lblLine5.Location = new System.Drawing.Point(324, 287);
            this.lblLine5.Name = "lblLine5";
            this.lblLine5.Size = new System.Drawing.Size(4, 40);
            this.lblLine5.TabIndex = 12;
            // 
            // lblLine4
            // 
            this.lblLine4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            this.lblLine4.Location = new System.Drawing.Point(277, 326);
            this.lblLine4.Name = "lblLine4";
            this.lblLine4.Size = new System.Drawing.Size(50, 4);
            this.lblLine4.TabIndex = 13;
            // 
            // lbl9
            // 
            this.lbl9.BackColor = System.Drawing.Color.DarkTurquoise;
            this.lbl9.Location = new System.Drawing.Point(65, 54);
            this.lbl9.Name = "lbl9";
            this.lbl9.Size = new System.Drawing.Size(1, 250);
            this.lbl9.TabIndex = 14;
            // 
            // pbxBookImg
            // 
            this.pbxBookImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxBookImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxBookImg.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pbxBookImg.ErrorImage")));
            this.pbxBookImg.Image = ((System.Drawing.Image)(resources.GetObject("pbxBookImg.Image")));
            this.pbxBookImg.Location = new System.Drawing.Point(85, 35);
            this.pbxBookImg.Name = "pbxBookImg";
            this.pbxBookImg.Size = new System.Drawing.Size(223, 279);
            this.pbxBookImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxBookImg.TabIndex = 15;
            this.pbxBookImg.TabStop = false;
            // 
            // pnlParent
            // 
            this.pnlParent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlParent.Controls.Add(this.pnlImgBook);
            this.pnlParent.Controls.Add(this.pnlListBook);
            this.pnlParent.Location = new System.Drawing.Point(1, 248);
            this.pnlParent.Name = "pnlParent";
            this.pnlParent.Size = new System.Drawing.Size(1383, 546);
            this.pnlParent.TabIndex = 16;
            // 
            // pnlImgBook
            // 
            this.pnlImgBook.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlImgBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(247)))), ((int)(((byte)(245)))));
            this.pnlImgBook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlImgBook.Controls.Add(this.label5);
            this.pnlImgBook.Controls.Add(this.lblLine12);
            this.pnlImgBook.Controls.Add(this.lblLine11);
            this.pnlImgBook.Controls.Add(this.label4);
            this.pnlImgBook.Controls.Add(this.label3);
            this.pnlImgBook.Controls.Add(this.lblLine10);
            this.pnlImgBook.Controls.Add(this.txtPulishedDate);
            this.pnlImgBook.Controls.Add(this.txtImportDate);
            this.pnlImgBook.Controls.Add(this.txtBuyPrice);
            this.pnlImgBook.Controls.Add(this.lblBuyPrice);
            this.pnlImgBook.Controls.Add(this.lblImportDate);
            this.pnlImgBook.Controls.Add(this.lblDatePublished);
            this.pnlImgBook.Controls.Add(this.lbl9);
            this.pnlImgBook.Controls.Add(this.lblLine3);
            this.pnlImgBook.Controls.Add(this.lblLine5);
            this.pnlImgBook.Controls.Add(this.lblLine0);
            this.pnlImgBook.Controls.Add(this.lblLine4);
            this.pnlImgBook.Controls.Add(this.lblLine1);
            this.pnlImgBook.Controls.Add(this.lblLine6);
            this.pnlImgBook.Controls.Add(this.label2);
            this.pnlImgBook.Controls.Add(this.lblLine7);
            this.pnlImgBook.Controls.Add(this.pbxBookImg);
            this.pnlImgBook.Location = new System.Drawing.Point(991, 0);
            this.pnlImgBook.Name = "pnlImgBook";
            this.pnlImgBook.Size = new System.Drawing.Size(385, 546);
            this.pnlImgBook.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            this.label5.Location = new System.Drawing.Point(156, 527);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 2);
            this.label5.TabIndex = 22;
            // 
            // lblLine12
            // 
            this.lblLine12.BackColor = System.Drawing.Color.DarkTurquoise;
            this.lblLine12.Location = new System.Drawing.Point(96, 327);
            this.lblLine12.Name = "lblLine12";
            this.lblLine12.Size = new System.Drawing.Size(200, 1);
            this.lblLine12.TabIndex = 21;
            // 
            // lblLine11
            // 
            this.lblLine11.BackColor = System.Drawing.Color.DarkTurquoise;
            this.lblLine11.Location = new System.Drawing.Point(96, 22);
            this.lblLine11.Name = "lblLine11";
            this.lblLine11.Size = new System.Drawing.Size(200, 1);
            this.lblLine11.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(171, 467);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 2);
            this.label4.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(186, 408);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 2);
            this.label3.TabIndex = 19;
            // 
            // lblLine10
            // 
            this.lblLine10.BackColor = System.Drawing.Color.DarkTurquoise;
            this.lblLine10.Location = new System.Drawing.Point(325, 54);
            this.lblLine10.Name = "lblLine10";
            this.lblLine10.Size = new System.Drawing.Size(1, 250);
            this.lblLine10.TabIndex = 18;
            // 
            // txtPulishedDate
            // 
            this.txtPulishedDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPulishedDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(247)))), ((int)(((byte)(245)))));
            this.txtPulishedDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPulishedDate.Font = new System.Drawing.Font("Segoe UI Semibold", 11.8F, System.Drawing.FontStyle.Bold);
            this.txtPulishedDate.Location = new System.Drawing.Point(195, 377);
            this.txtPulishedDate.Name = "txtPulishedDate";
            this.txtPulishedDate.ReadOnly = true;
            this.txtPulishedDate.Size = new System.Drawing.Size(168, 27);
            this.txtPulishedDate.TabIndex = 17;
            this.txtPulishedDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtImportDate
            // 
            this.txtImportDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtImportDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(247)))), ((int)(((byte)(245)))));
            this.txtImportDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtImportDate.Font = new System.Drawing.Font("Segoe UI Semibold", 11.8F, System.Drawing.FontStyle.Bold);
            this.txtImportDate.Location = new System.Drawing.Point(195, 436);
            this.txtImportDate.Name = "txtImportDate";
            this.txtImportDate.ReadOnly = true;
            this.txtImportDate.Size = new System.Drawing.Size(168, 27);
            this.txtImportDate.TabIndex = 17;
            this.txtImportDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBuyPrice
            // 
            this.txtBuyPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuyPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(247)))), ((int)(((byte)(245)))));
            this.txtBuyPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuyPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 11.8F, System.Drawing.FontStyle.Bold);
            this.txtBuyPrice.Location = new System.Drawing.Point(195, 496);
            this.txtBuyPrice.Name = "txtBuyPrice";
            this.txtBuyPrice.ReadOnly = true;
            this.txtBuyPrice.Size = new System.Drawing.Size(168, 27);
            this.txtBuyPrice.TabIndex = 17;
            this.txtBuyPrice.Text = "0";
            this.txtBuyPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblBuyPrice
            // 
            this.lblBuyPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBuyPrice.AutoSize = true;
            this.lblBuyPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblBuyPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            this.lblBuyPrice.Location = new System.Drawing.Point(26, 504);
            this.lblBuyPrice.Name = "lblBuyPrice";
            this.lblBuyPrice.Size = new System.Drawing.Size(88, 25);
            this.lblBuyPrice.TabIndex = 16;
            this.lblBuyPrice.Text = "Giá nhập";
            // 
            // lblImportDate
            // 
            this.lblImportDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblImportDate.AutoSize = true;
            this.lblImportDate.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblImportDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            this.lblImportDate.Location = new System.Drawing.Point(26, 444);
            this.lblImportDate.Name = "lblImportDate";
            this.lblImportDate.Size = new System.Drawing.Size(106, 25);
            this.lblImportDate.TabIndex = 16;
            this.lblImportDate.Text = "Ngày nhập";
            // 
            // lblDatePublished
            // 
            this.lblDatePublished.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDatePublished.AutoSize = true;
            this.lblDatePublished.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblDatePublished.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            this.lblDatePublished.Location = new System.Drawing.Point(26, 384);
            this.lblDatePublished.Name = "lblDatePublished";
            this.lblDatePublished.Size = new System.Drawing.Size(138, 25);
            this.lblDatePublished.TabIndex = 16;
            this.lblDatePublished.Text = "Ngày xuất bản";
            // 
            // pnlListBook
            // 
            this.pnlListBook.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlListBook.Controls.Add(this.dgvBook);
            this.pnlListBook.Location = new System.Drawing.Point(0, 0);
            this.pnlListBook.Name = "pnlListBook";
            this.pnlListBook.Size = new System.Drawing.Size(953, 546);
            this.pnlListBook.TabIndex = 2;
            // 
            // dgvBook
            // 
            this.dgvBook.AllowUserToAddRows = false;
            this.dgvBook.AllowUserToDeleteRows = false;
            this.dgvBook.AllowUserToResizeColumns = false;
            this.dgvBook.AllowUserToResizeRows = false;
            this.dgvBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBook.BackgroundColor = System.Drawing.Color.White;
            this.dgvBook.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvBook.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBook.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBook.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBook.ColumnHeadersHeight = 54;
            this.dgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Delete,
            this.Edit,
            this.BookID,
            this.Title,
            this.Author,
            this.CategoryID,
            this.PublisherName,
            this.Stock,
            this.SellPrice});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(151)))), ((int)(((byte)(156)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBook.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBook.EnableHeadersVisualStyles = false;
            this.dgvBook.GridColor = System.Drawing.Color.Gray;
            this.dgvBook.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvBook.Location = new System.Drawing.Point(0, 0);
            this.dgvBook.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBook.Name = "dgvBook";
            this.dgvBook.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(168)))), ((int)(((byte)(212)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBook.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBook.RowHeadersVisible = false;
            this.dgvBook.RowHeadersWidth = 51;
            this.dgvBook.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(151)))), ((int)(((byte)(156)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dgvBook.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvBook.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvBook.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBook.RowTemplate.Height = 42;
            this.dgvBook.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBook.Size = new System.Drawing.Size(953, 546);
            this.dgvBook.TabIndex = 2;
            this.dgvBook.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBook_CellContentClick);
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Delete.FillWeight = 30F;
            this.Delete.HeaderText = "";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Edit
            // 
            this.Edit.FillWeight = 30F;
            this.Edit.HeaderText = "";
            this.Edit.Image = ((System.Drawing.Image)(resources.GetObject("Edit.Image")));
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // BookID
            // 
            this.BookID.HeaderText = "Mã Sách";
            this.BookID.MinimumWidth = 6;
            this.BookID.Name = "BookID";
            this.BookID.ReadOnly = true;
            // 
            // Title
            // 
            this.Title.HeaderText = "Tựa sách";
            this.Title.MinimumWidth = 6;
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // Author
            // 
            this.Author.HeaderText = "Tác giả";
            this.Author.MinimumWidth = 6;
            this.Author.Name = "Author";
            this.Author.ReadOnly = true;
            // 
            // CategoryID
            // 
            this.CategoryID.HeaderText = "Thể loại";
            this.CategoryID.MinimumWidth = 6;
            this.CategoryID.Name = "CategoryID";
            this.CategoryID.ReadOnly = true;
            // 
            // PublisherName
            // 
            this.PublisherName.HeaderText = "Nhà xuất bản";
            this.PublisherName.MinimumWidth = 6;
            this.PublisherName.Name = "PublisherName";
            this.PublisherName.ReadOnly = true;
            // 
            // Stock
            // 
            this.Stock.FillWeight = 50F;
            this.Stock.HeaderText = "Kho";
            this.Stock.MinimumWidth = 6;
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            // 
            // SellPrice
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(236)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(236)))));
            this.SellPrice.DefaultCellStyle = dataGridViewCellStyle2;
            this.SellPrice.HeaderText = "Giá bán";
            this.SellPrice.MinimumWidth = 6;
            this.SellPrice.Name = "SellPrice";
            this.SellPrice.ReadOnly = true;
            // 
            // frmBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(1385, 820);
            this.Controls.Add(this.pnlParent);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnAdd);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmBook_Load);
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBookImg)).EndInit();
            this.pnlParent.ResumeLayout(false);
            this.pnlImgBook.ResumeLayout(false);
            this.pnlImgBook.PerformLayout();
            this.pnlListBook.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.ComboBox cmbOption;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblLine0;
        private System.Windows.Forms.Label lblLine1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblLine3;
        private System.Windows.Forms.Label lblLine6;
        private System.Windows.Forms.Label lblLine7;
        private System.Windows.Forms.Label lblLine5;
        private System.Windows.Forms.Label lblLine4;
        private System.Windows.Forms.Label lbl9;
        private System.Windows.Forms.PictureBox pbxBookImg;
        private System.Windows.Forms.Panel pnlParent;
        private System.Windows.Forms.Panel pnlImgBook;
        private System.Windows.Forms.Panel pnlListBook;
        private System.Windows.Forms.DataGridView dgvBook;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PublisherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellPrice;
        private System.Windows.Forms.Label lblBuyPrice;
        private System.Windows.Forms.Label lblImportDate;
        private System.Windows.Forms.Label lblDatePublished;
        private System.Windows.Forms.TextBox txtBuyPrice;
        private System.Windows.Forms.Label lblLine10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblLine12;
        private System.Windows.Forms.Label lblLine11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPulishedDate;
        private System.Windows.Forms.TextBox txtImportDate;
    }
}