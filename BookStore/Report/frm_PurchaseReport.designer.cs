
namespace BookStore.Report
{
    partial class frm_PurchaseReport
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
            this.PurReportviewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txtPurID = new System.Windows.Forms.TextBox();
            this.ESC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PurReportviewer
            // 
            this.PurReportviewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PurReportviewer.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PurReportviewer.Location = new System.Drawing.Point(16, 70);
            this.PurReportviewer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PurReportviewer.Name = "PurReportviewer";
            this.PurReportviewer.ServerReport.BearerToken = null;
            this.PurReportviewer.ShowToolBar = false;
            this.PurReportviewer.Size = new System.Drawing.Size(626, 734);
            this.PurReportviewer.TabIndex = 0;
            // 
            // txtPurID
            // 
            this.txtPurID.Location = new System.Drawing.Point(509, 26);
            this.txtPurID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPurID.Name = "txtPurID";
            this.txtPurID.Size = new System.Drawing.Size(132, 22);
            this.txtPurID.TabIndex = 1;
            // 
            // ESC
            // 
            this.ESC.Font = new System.Drawing.Font("Segoe UI Semibold", 9.2F, System.Drawing.FontStyle.Bold);
            this.ESC.ForeColor = System.Drawing.Color.Indigo;
            this.ESC.Location = new System.Drawing.Point(16, 15);
            this.ESC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ESC.Name = "ESC";
            this.ESC.Size = new System.Drawing.Size(100, 33);
            this.ESC.TabIndex = 2;
            this.ESC.Text = "Đóng";
            this.ESC.UseVisualStyleBackColor = true;
            this.ESC.Click += new System.EventHandler(this.ESC_Click);
            // 
            // frm_PurchaseReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(161)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(659, 820);
            this.Controls.Add(this.ESC);
            this.Controls.Add(this.txtPurID);
            this.Controls.Add(this.PurReportviewer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_PurchaseReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_PurchaseReport";
            this.Load += new System.EventHandler(this.frm_PurchaseReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer PurReportviewer;
        private System.Windows.Forms.TextBox txtPurID;
        private System.Windows.Forms.Button ESC;
    }
}