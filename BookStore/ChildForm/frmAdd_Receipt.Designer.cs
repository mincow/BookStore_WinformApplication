
namespace BookStore.ChildForm
{
    partial class frmAdd_Receipt
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdd_Receipt));
            this.btnCancelCart = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCreateReceipt = new System.Windows.Forms.Button();
            this.dgvReceiptTemp = new System.Windows.Forms.DataGridView();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpReceiptTemp = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblLine1 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblLine0 = new System.Windows.Forms.Label();
            this.txtBookTitle = new System.Windows.Forms.TextBox();
            this.lblBookID = new System.Windows.Forms.Label();
            this.grpAddGoods = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOrderQuantity = new System.Windows.Forms.TextBox();
            this.lblOrderQuantity = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuyPrice = new System.Windows.Forms.TextBox();
            this.lblBuyPrice = new System.Windows.Forms.Label();
            this.lblImportDate = new System.Windows.Forms.Label();
            this.dtpImportDate = new System.Windows.Forms.DateTimePicker();
            this.lblChooseOrder = new System.Windows.Forms.Label();
            this.cmbChooseOrder = new System.Windows.Forms.ComboBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceiptTemp)).BeginInit();
            this.grpReceiptTemp.SuspendLayout();
            this.grpAddGoods.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelCart
            // 
            this.btnCancelCart.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnCancelCart.ForeColor = System.Drawing.Color.Indigo;
            this.btnCancelCart.Location = new System.Drawing.Point(62, 812);
            this.btnCancelCart.Name = "btnCancelCart";
            this.btnCancelCart.Size = new System.Drawing.Size(164, 51);
            this.btnCancelCart.TabIndex = 18;
            this.btnCancelCart.Text = "Hủy Bỏ";
            this.btnCancelCart.UseVisualStyleBackColor = true;
            this.btnCancelCart.Click += new System.EventHandler(this.btnCancelCart_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.Indigo;
            this.btnExit.Location = new System.Drawing.Point(454, 812);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(164, 51);
            this.btnExit.TabIndex = 19;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCreateReceipt
            // 
            this.btnCreateReceipt.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnCreateReceipt.ForeColor = System.Drawing.Color.Indigo;
            this.btnCreateReceipt.Location = new System.Drawing.Point(257, 812);
            this.btnCreateReceipt.Name = "btnCreateReceipt";
            this.btnCreateReceipt.Size = new System.Drawing.Size(164, 51);
            this.btnCreateReceipt.TabIndex = 20;
            this.btnCreateReceipt.Text = "Tạo Biên lai";
            this.btnCreateReceipt.UseVisualStyleBackColor = true;
            this.btnCreateReceipt.Click += new System.EventHandler(this.btnCreateReceipt_Click);
            // 
            // dgvReceiptTemp
            // 
            this.dgvReceiptTemp.AllowUserToAddRows = false;
            this.dgvReceiptTemp.AllowUserToDeleteRows = false;
            this.dgvReceiptTemp.AllowUserToOrderColumns = true;
            this.dgvReceiptTemp.AllowUserToResizeColumns = false;
            this.dgvReceiptTemp.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvReceiptTemp.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvReceiptTemp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReceiptTemp.BackgroundColor = System.Drawing.Color.White;
            this.dgvReceiptTemp.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dgvReceiptTemp.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReceiptTemp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvReceiptTemp.ColumnHeadersHeight = 40;
            this.dgvReceiptTemp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvReceiptTemp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Delete,
            this.Title,
            this.quantity,
            this.Unit,
            this.Status});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReceiptTemp.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvReceiptTemp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReceiptTemp.EnableHeadersVisualStyles = false;
            this.dgvReceiptTemp.Location = new System.Drawing.Point(3, 26);
            this.dgvReceiptTemp.Name = "dgvReceiptTemp";
            this.dgvReceiptTemp.ReadOnly = true;
            this.dgvReceiptTemp.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvReceiptTemp.RowHeadersVisible = false;
            this.dgvReceiptTemp.RowHeadersWidth = 51;
            this.dgvReceiptTemp.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvReceiptTemp.RowTemplate.Height = 38;
            this.dgvReceiptTemp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReceiptTemp.Size = new System.Drawing.Size(681, 223);
            this.dgvReceiptTemp.TabIndex = 0;
            this.dgvReceiptTemp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCart_CellContentClick);
            // 
            // Delete
            // 
            this.Delete.FillWeight = 38.63299F;
            this.Delete.HeaderText = "";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            // 
            // Title
            // 
            this.Title.FillWeight = 159.7365F;
            this.Title.HeaderText = "Tên sách";
            this.Title.MinimumWidth = 6;
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.FillWeight = 101.7365F;
            this.quantity.HeaderText = "Số lượng";
            this.quantity.MinimumWidth = 6;
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // Unit
            // 
            this.Unit.FillWeight = 96.65717F;
            this.Unit.HeaderText = "Đơn giá";
            this.Unit.MinimumWidth = 6;
            this.Unit.Name = "Unit";
            this.Unit.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "Trạng thái ĐH";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // grpReceiptTemp
            // 
            this.grpReceiptTemp.Controls.Add(this.dgvReceiptTemp);
            this.grpReceiptTemp.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.grpReceiptTemp.ForeColor = System.Drawing.Color.Indigo;
            this.grpReceiptTemp.Location = new System.Drawing.Point(12, 380);
            this.grpReceiptTemp.Name = "grpReceiptTemp";
            this.grpReceiptTemp.Size = new System.Drawing.Size(687, 252);
            this.grpReceiptTemp.TabIndex = 17;
            this.grpReceiptTemp.TabStop = false;
            this.grpReceiptTemp.Text = "Bản Ghi";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(47, 229);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(116, 39);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(335, 229);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(116, 39);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Cập Nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(190, 229);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(116, 39);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblLine1
            // 
            this.lblLine1.BackColor = System.Drawing.Color.Indigo;
            this.lblLine1.Location = new System.Drawing.Point(162, 151);
            this.lblLine1.Name = "lblLine1";
            this.lblLine1.Size = new System.Drawing.Size(230, 2);
            this.lblLine1.TabIndex = 5;
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(161)))), ((int)(((byte)(240)))));
            this.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuantity.ForeColor = System.Drawing.Color.Black;
            this.txtQuantity.Location = new System.Drawing.Point(179, 123);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(188, 23);
            this.txtQuantity.TabIndex = 4;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(15, 125);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(139, 28);
            this.lblQuantity.TabIndex = 3;
            this.lblQuantity.Text = "Số lượng giao";
            // 
            // lblLine0
            // 
            this.lblLine0.BackColor = System.Drawing.Color.Indigo;
            this.lblLine0.Location = new System.Drawing.Point(162, 58);
            this.lblLine0.Name = "lblLine0";
            this.lblLine0.Size = new System.Drawing.Size(360, 2);
            this.lblLine0.TabIndex = 2;
            // 
            // txtBookTitle
            // 
            this.txtBookTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(161)))), ((int)(((byte)(240)))));
            this.txtBookTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBookTitle.ForeColor = System.Drawing.Color.Black;
            this.txtBookTitle.Location = new System.Drawing.Point(179, 30);
            this.txtBookTitle.Name = "txtBookTitle";
            this.txtBookTitle.ReadOnly = true;
            this.txtBookTitle.Size = new System.Drawing.Size(332, 23);
            this.txtBookTitle.TabIndex = 1;
            // 
            // lblBookID
            // 
            this.lblBookID.AutoSize = true;
            this.lblBookID.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookID.Location = new System.Drawing.Point(15, 32);
            this.lblBookID.Name = "lblBookID";
            this.lblBookID.Size = new System.Drawing.Size(90, 28);
            this.lblBookID.TabIndex = 0;
            this.lblBookID.Text = "Tên sách";
            // 
            // grpAddGoods
            // 
            this.grpAddGoods.Controls.Add(this.label3);
            this.grpAddGoods.Controls.Add(this.txtOrderQuantity);
            this.grpAddGoods.Controls.Add(this.lblOrderQuantity);
            this.grpAddGoods.Controls.Add(this.label1);
            this.grpAddGoods.Controls.Add(this.txtBuyPrice);
            this.grpAddGoods.Controls.Add(this.lblBuyPrice);
            this.grpAddGoods.Controls.Add(this.btnCancel);
            this.grpAddGoods.Controls.Add(this.btnUpdate);
            this.grpAddGoods.Controls.Add(this.btnAdd);
            this.grpAddGoods.Controls.Add(this.lblLine1);
            this.grpAddGoods.Controls.Add(this.txtQuantity);
            this.grpAddGoods.Controls.Add(this.lblQuantity);
            this.grpAddGoods.Controls.Add(this.lblLine0);
            this.grpAddGoods.Controls.Add(this.txtBookTitle);
            this.grpAddGoods.Controls.Add(this.lblBookID);
            this.grpAddGoods.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.grpAddGoods.ForeColor = System.Drawing.Color.Indigo;
            this.grpAddGoods.Location = new System.Drawing.Point(82, 77);
            this.grpAddGoods.Name = "grpAddGoods";
            this.grpAddGoods.Size = new System.Drawing.Size(536, 297);
            this.grpAddGoods.TabIndex = 16;
            this.grpAddGoods.TabStop = false;
            this.grpAddGoods.Text = "Sản phẩm";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Indigo;
            this.label3.Location = new System.Drawing.Point(162, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 2);
            this.label3.TabIndex = 12;
            // 
            // txtOrderQuantity
            // 
            this.txtOrderQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(161)))), ((int)(((byte)(240)))));
            this.txtOrderQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOrderQuantity.ForeColor = System.Drawing.Color.Black;
            this.txtOrderQuantity.Location = new System.Drawing.Point(179, 76);
            this.txtOrderQuantity.Name = "txtOrderQuantity";
            this.txtOrderQuantity.ReadOnly = true;
            this.txtOrderQuantity.Size = new System.Drawing.Size(188, 23);
            this.txtOrderQuantity.TabIndex = 11;
            // 
            // lblOrderQuantity
            // 
            this.lblOrderQuantity.AutoSize = true;
            this.lblOrderQuantity.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderQuantity.Location = new System.Drawing.Point(15, 78);
            this.lblOrderQuantity.Name = "lblOrderQuantity";
            this.lblOrderQuantity.Size = new System.Drawing.Size(129, 28);
            this.lblOrderQuantity.TabIndex = 10;
            this.lblOrderQuantity.Text = "Số lượng đặt";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(162, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 2);
            this.label1.TabIndex = 9;
            // 
            // txtBuyPrice
            // 
            this.txtBuyPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(161)))), ((int)(((byte)(240)))));
            this.txtBuyPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuyPrice.ForeColor = System.Drawing.Color.Black;
            this.txtBuyPrice.Location = new System.Drawing.Point(179, 170);
            this.txtBuyPrice.Name = "txtBuyPrice";
            this.txtBuyPrice.Size = new System.Drawing.Size(188, 23);
            this.txtBuyPrice.TabIndex = 8;
            // 
            // lblBuyPrice
            // 
            this.lblBuyPrice.AutoSize = true;
            this.lblBuyPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuyPrice.Location = new System.Drawing.Point(15, 172);
            this.lblBuyPrice.Name = "lblBuyPrice";
            this.lblBuyPrice.Size = new System.Drawing.Size(83, 28);
            this.lblBuyPrice.TabIndex = 7;
            this.lblBuyPrice.Text = "Đơn giá";
            // 
            // lblImportDate
            // 
            this.lblImportDate.AutoSize = true;
            this.lblImportDate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImportDate.ForeColor = System.Drawing.Color.Indigo;
            this.lblImportDate.Location = new System.Drawing.Point(52, 674);
            this.lblImportDate.Name = "lblImportDate";
            this.lblImportDate.Size = new System.Drawing.Size(163, 28);
            this.lblImportDate.TabIndex = 24;
            this.lblImportDate.Text = "Ngày nhập hàng";
            // 
            // dtpImportDate
            // 
            this.dtpImportDate.CalendarFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpImportDate.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            this.dtpImportDate.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            this.dtpImportDate.CalendarTrailingForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dtpImportDate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpImportDate.Location = new System.Drawing.Point(231, 674);
            this.dtpImportDate.Name = "dtpImportDate";
            this.dtpImportDate.Size = new System.Drawing.Size(373, 30);
            this.dtpImportDate.TabIndex = 25;
            this.dtpImportDate.Value = new System.DateTime(2021, 11, 5, 21, 33, 56, 0);
            // 
            // lblChooseOrder
            // 
            this.lblChooseOrder.AutoSize = true;
            this.lblChooseOrder.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChooseOrder.Location = new System.Drawing.Point(30, 23);
            this.lblChooseOrder.Name = "lblChooseOrder";
            this.lblChooseOrder.Size = new System.Drawing.Size(196, 28);
            this.lblChooseOrder.TabIndex = 26;
            this.lblChooseOrder.Text = "Chọn Đơn Đặt Hàng";
            // 
            // cmbChooseOrder
            // 
            this.cmbChooseOrder.FormattingEnabled = true;
            this.cmbChooseOrder.Location = new System.Drawing.Point(257, 27);
            this.cmbChooseOrder.Name = "cmbChooseOrder";
            this.cmbChooseOrder.Size = new System.Drawing.Size(361, 24);
            this.cmbChooseOrder.TabIndex = 27;
            this.cmbChooseOrder.SelectedIndexChanged += new System.EventHandler(this.cmbChooseOrder_SelectedIndexChanged);
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.ForeColor = System.Drawing.Color.Indigo;
            this.lblNote.Location = new System.Drawing.Point(52, 738);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(82, 28);
            this.lblNote.TabIndex = 28;
            this.lblNote.Text = "Ghi chú";
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(231, 722);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(373, 68);
            this.txtNote.TabIndex = 29;
            // 
            // frmAdd_Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(161)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(705, 928);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.cmbChooseOrder);
            this.Controls.Add(this.lblChooseOrder);
            this.Controls.Add(this.dtpImportDate);
            this.Controls.Add(this.lblImportDate);
            this.Controls.Add(this.btnCancelCart);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCreateReceipt);
            this.Controls.Add(this.grpReceiptTemp);
            this.Controls.Add(this.grpAddGoods);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdd_Receipt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdd_Receipt";
            this.Load += new System.EventHandler(this.frmAdd_Receipt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceiptTemp)).EndInit();
            this.grpReceiptTemp.ResumeLayout(false);
            this.grpAddGoods.ResumeLayout(false);
            this.grpAddGoods.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancelCart;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCreateReceipt;
        private System.Windows.Forms.DataGridView dgvReceiptTemp;
        private System.Windows.Forms.GroupBox grpReceiptTemp;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblLine1;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblLine0;
        private System.Windows.Forms.TextBox txtBookTitle;
        private System.Windows.Forms.Label lblBookID;
        private System.Windows.Forms.GroupBox grpAddGoods;
        private System.Windows.Forms.Label lblImportDate;
        private System.Windows.Forms.DateTimePicker dtpImportDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuyPrice;
        private System.Windows.Forms.Label lblBuyPrice;
        private System.Windows.Forms.Label lblChooseOrder;
        private System.Windows.Forms.ComboBox cmbChooseOrder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOrderQuantity;
        private System.Windows.Forms.Label lblOrderQuantity;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.TextBox txtNote;
    }
}