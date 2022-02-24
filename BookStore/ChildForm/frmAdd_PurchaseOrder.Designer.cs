
namespace BookStore.ChildForm
{
    partial class frmAdd_PurchaseOrder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdd_PurchaseOrder));
            this.txtNote = new System.Windows.Forms.TextBox();
            this.btnCancelCart = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCreateCart = new System.Windows.Forms.Button();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.grpCart = new System.Windows.Forms.GroupBox();
            this.cmbBook = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblLine1 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblLine0 = new System.Windows.Forms.Label();
            this.lblBookID = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.grpAddProduct = new System.Windows.Forms.GroupBox();
            this.dtpExDate = new System.Windows.Forms.DateTimePicker();
            this.lblExDate = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.BookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbSupplier = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.grpCart.SuspendLayout();
            this.grpAddProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNote
            // 
            this.txtNote.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNote.Location = new System.Drawing.Point(78, 663);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(562, 74);
            this.txtNote.TabIndex = 26;
            // 
            // btnCancelCart
            // 
            this.btnCancelCart.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnCancelCart.ForeColor = System.Drawing.Color.Indigo;
            this.btnCancelCart.Location = new System.Drawing.Point(66, 758);
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
            this.btnExit.Location = new System.Drawing.Point(458, 758);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(164, 51);
            this.btnExit.TabIndex = 19;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCreateCart
            // 
            this.btnCreateCart.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnCreateCart.ForeColor = System.Drawing.Color.Indigo;
            this.btnCreateCart.Location = new System.Drawing.Point(261, 758);
            this.btnCreateCart.Name = "btnCreateCart";
            this.btnCreateCart.Size = new System.Drawing.Size(164, 51);
            this.btnCreateCart.TabIndex = 20;
            this.btnCreateCart.Text = "Tạo Đơn Hàng";
            this.btnCreateCart.UseVisualStyleBackColor = true;
            this.btnCreateCart.Click += new System.EventHandler(this.btnCreateCart_Click);
            // 
            // dgvCart
            // 
            this.dgvCart.AllowUserToAddRows = false;
            this.dgvCart.AllowUserToDeleteRows = false;
            this.dgvCart.AllowUserToOrderColumns = true;
            this.dgvCart.AllowUserToResizeColumns = false;
            this.dgvCart.AllowUserToResizeRows = false;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvCart.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvCart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCart.BackgroundColor = System.Drawing.Color.White;
            this.dgvCart.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dgvCart.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvCart.ColumnHeadersHeight = 40;
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Delete,
            this.BookID,
            this.Title,
            this.quantity});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCart.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgvCart.EnableHeadersVisualStyles = false;
            this.dgvCart.Location = new System.Drawing.Point(6, 46);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.ReadOnly = true;
            this.dgvCart.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvCart.RowHeadersVisible = false;
            this.dgvCart.RowHeadersWidth = 51;
            this.dgvCart.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCart.RowTemplate.Height = 38;
            this.dgvCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCart.Size = new System.Drawing.Size(675, 214);
            this.dgvCart.TabIndex = 0;
            this.dgvCart.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCart_CellContentClick);
            // 
            // grpCart
            // 
            this.grpCart.Controls.Add(this.dgvCart);
            this.grpCart.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.grpCart.ForeColor = System.Drawing.Color.Indigo;
            this.grpCart.Location = new System.Drawing.Point(11, 309);
            this.grpCart.Name = "grpCart";
            this.grpCart.Size = new System.Drawing.Size(687, 269);
            this.grpCart.TabIndex = 17;
            this.grpCart.TabStop = false;
            this.grpCart.Text = "Đơn đặt";
            // 
            // cmbBook
            // 
            this.cmbBook.BackColor = System.Drawing.Color.White;
            this.cmbBook.FormattingEnabled = true;
            this.cmbBook.Location = new System.Drawing.Point(123, 30);
            this.cmbBook.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBook.Name = "cmbBook";
            this.cmbBook.Size = new System.Drawing.Size(350, 31);
            this.cmbBook.TabIndex = 17;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(47, 166);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(116, 39);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(335, 166);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(116, 39);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Cập Nhật SL";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(190, 166);
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
            this.lblLine1.Location = new System.Drawing.Point(117, 122);
            this.lblLine1.Name = "lblLine1";
            this.lblLine1.Size = new System.Drawing.Size(230, 2);
            this.lblLine1.TabIndex = 5;
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(161)))), ((int)(((byte)(240)))));
            this.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuantity.ForeColor = System.Drawing.Color.Black;
            this.txtQuantity.Location = new System.Drawing.Point(134, 94);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(188, 23);
            this.txtQuantity.TabIndex = 4;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(15, 96);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(94, 28);
            this.lblQuantity.TabIndex = 3;
            this.lblQuantity.Text = "Số lượng";
            // 
            // lblLine0
            // 
            this.lblLine0.BackColor = System.Drawing.Color.Indigo;
            this.lblLine0.Location = new System.Drawing.Point(117, 68);
            this.lblLine0.Name = "lblLine0";
            this.lblLine0.Size = new System.Drawing.Size(360, 2);
            this.lblLine0.TabIndex = 2;
            // 
            // lblBookID
            // 
            this.lblBookID.AutoSize = true;
            this.lblBookID.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookID.Location = new System.Drawing.Point(15, 42);
            this.lblBookID.Name = "lblBookID";
            this.lblBookID.Size = new System.Drawing.Size(90, 28);
            this.lblBookID.TabIndex = 0;
            this.lblBookID.Text = "Tên sách";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblNote.ForeColor = System.Drawing.Color.Indigo;
            this.lblNote.Location = new System.Drawing.Point(24, 661);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(48, 23);
            this.lblNote.TabIndex = 25;
            this.lblNote.Text = "Note";
            // 
            // grpAddProduct
            // 
            this.grpAddProduct.Controls.Add(this.cmbBook);
            this.grpAddProduct.Controls.Add(this.btnCancel);
            this.grpAddProduct.Controls.Add(this.btnUpdate);
            this.grpAddProduct.Controls.Add(this.btnAdd);
            this.grpAddProduct.Controls.Add(this.lblLine1);
            this.grpAddProduct.Controls.Add(this.txtQuantity);
            this.grpAddProduct.Controls.Add(this.lblQuantity);
            this.grpAddProduct.Controls.Add(this.lblLine0);
            this.grpAddProduct.Controls.Add(this.lblBookID);
            this.grpAddProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.grpAddProduct.ForeColor = System.Drawing.Color.Indigo;
            this.grpAddProduct.Location = new System.Drawing.Point(110, 76);
            this.grpAddProduct.Name = "grpAddProduct";
            this.grpAddProduct.Size = new System.Drawing.Size(497, 227);
            this.grpAddProduct.TabIndex = 16;
            this.grpAddProduct.TabStop = false;
            this.grpAddProduct.Text = "Thêm sản phẩm";
            // 
            // dtpExDate
            // 
            this.dtpExDate.CalendarFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpExDate.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            this.dtpExDate.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            this.dtpExDate.CalendarTrailingForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dtpExDate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpExDate.Location = new System.Drawing.Point(252, 601);
            this.dtpExDate.Name = "dtpExDate";
            this.dtpExDate.Size = new System.Drawing.Size(343, 30);
            this.dtpExDate.TabIndex = 31;
            this.dtpExDate.Value = new System.DateTime(2022, 1, 7, 0, 0, 0, 0);
            // 
            // lblExDate
            // 
            this.lblExDate.AutoSize = true;
            this.lblExDate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExDate.ForeColor = System.Drawing.Color.Indigo;
            this.lblExDate.Location = new System.Drawing.Point(56, 603);
            this.lblExDate.Name = "lblExDate";
            this.lblExDate.Size = new System.Drawing.Size(179, 28);
            this.lblExDate.TabIndex = 30;
            this.lblExDate.Text = "Ngày giao dự kiến";
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
            // BookID
            // 
            this.BookID.FillWeight = 103.2368F;
            this.BookID.HeaderText = "Mã sách";
            this.BookID.MinimumWidth = 6;
            this.BookID.Name = "BookID";
            this.BookID.ReadOnly = true;
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
            // cmbSupplier
            // 
            this.cmbSupplier.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.cmbSupplier.FormattingEnabled = true;
            this.cmbSupplier.Location = new System.Drawing.Point(276, 22);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Size = new System.Drawing.Size(302, 36);
            this.cmbSupplier.TabIndex = 35;
            this.cmbSupplier.SelectedIndexChanged += new System.EventHandler(this.cmbSupplier_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(250, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 2);
            this.label1.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Indigo;
            this.label3.Location = new System.Drawing.Point(93, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 28);
            this.label3.TabIndex = 33;
            this.label3.Text = "Nhà cung cấp";
            // 
            // frmAdd_PurchaseOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(161)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(705, 836);
            this.Controls.Add(this.cmbSupplier);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpExDate);
            this.Controls.Add(this.lblExDate);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.btnCancelCart);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCreateCart);
            this.Controls.Add(this.grpCart);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.grpAddProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdd_PurchaseOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdd_PurchaseOrder";
            this.Load += new System.EventHandler(this.frmAdd_PurchaseOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.grpCart.ResumeLayout(false);
            this.grpAddProduct.ResumeLayout(false);
            this.grpAddProduct.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Button btnCancelCart;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCreateCart;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.GroupBox grpCart;
        private System.Windows.Forms.ComboBox cmbBook;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblLine1;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblLine0;
        private System.Windows.Forms.Label lblBookID;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.GroupBox grpAddProduct;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DateTimePicker dtpExDate;
        private System.Windows.Forms.Label lblExDate;
        private System.Windows.Forms.ComboBox cmbSupplier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}