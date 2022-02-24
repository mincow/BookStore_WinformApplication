
namespace BookStore.ChildForm
{
    partial class frmAddEdit_Publisher
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
            this.label2 = new System.Windows.Forms.Label();
            this.lblPublisherID = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pnlLinePublisherID = new System.Windows.Forms.Panel();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(35, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên NXB";
            // 
            // lblPublisherID
            // 
            this.lblPublisherID.AutoSize = true;
            this.lblPublisherID.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblPublisherID.ForeColor = System.Drawing.Color.Indigo;
            this.lblPublisherID.Location = new System.Drawing.Point(35, 58);
            this.lblPublisherID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPublisherID.Name = "lblPublisherID";
            this.lblPublisherID.Size = new System.Drawing.Size(85, 28);
            this.lblPublisherID.TabIndex = 4;
            this.lblPublisherID.Text = "Mã NXB";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Indigo;
            this.panel6.ForeColor = System.Drawing.Color.Indigo;
            this.panel6.Location = new System.Drawing.Point(156, 155);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(250, 2);
            this.panel6.TabIndex = 5;
            // 
            // pnlLinePublisherID
            // 
            this.pnlLinePublisherID.BackColor = System.Drawing.Color.Indigo;
            this.pnlLinePublisherID.ForeColor = System.Drawing.Color.Indigo;
            this.pnlLinePublisherID.Location = new System.Drawing.Point(156, 84);
            this.pnlLinePublisherID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlLinePublisherID.Name = "pnlLinePublisherID";
            this.pnlLinePublisherID.Size = new System.Drawing.Size(250, 2);
            this.pnlLinePublisherID.TabIndex = 4;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.Window;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.Indigo;
            this.btnThem.Location = new System.Drawing.Point(237, 182);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(128, 54);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Lưu";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(161)))), ((int)(((byte)(240)))));
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtID.Font = new System.Drawing.Font("Segoe UI Semibold", 11.2F, System.Drawing.FontStyle.Bold);
            this.txtID.Location = new System.Drawing.Point(165, 54);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(200, 25);
            this.txtID.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.Indigo;
            this.btnClose.Location = new System.Drawing.Point(487, 3);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(113, 41);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(161)))), ((int)(((byte)(240)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Segoe UI Semibold", 11.2F, System.Drawing.FontStyle.Bold);
            this.txtName.Location = new System.Drawing.Point(165, 124);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 25);
            this.txtName.TabIndex = 2;
            // 
            // frmAdd_Publisher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(161)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(602, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.lblPublisherID);
            this.Controls.Add(this.pnlLinePublisherID);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnThem);
            this.ForeColor = System.Drawing.Color.Indigo;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmAdd_Publisher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdd_Publisher";
            this.Load += new System.EventHandler(this.frmAdd_Publisher_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPublisherID;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel pnlLinePublisherID;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtName;
    }
}