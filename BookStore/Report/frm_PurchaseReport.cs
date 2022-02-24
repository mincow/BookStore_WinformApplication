using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookStore.Models;
using Microsoft.Reporting.WinForms;

namespace BookStore.Report
{
    public partial class frm_PurchaseReport : Form
    {
        BookStoreDB context = new BookStoreDB();
        string PurID;
        public frm_PurchaseReport(string purID)
        {
            PurID = purID;
            InitializeComponent();
        }
        public frm_PurchaseReport()
        {
            InitializeComponent();
        }

        private void frm_PurchaseReport_Load(object sender, EventArgs e)
        {
            txtPurID.Text = PurID;
            PurchaseOrder PurOrder = context.PurchaseOrders.FirstOrDefault(p => p.PurchaseOrderID == txtPurID.Text);
            List<PurchaseOrderDetail> listPur = context.PurchaseOrderDetails.Where(p => p.PurchaseOrderID == txtPurID.Text).ToList();
            List<PurchaseReport> listReport = new List<PurchaseReport>();
            foreach (PurchaseOrderDetail i in listPur)
            {
                PurchaseReport temp = new PurchaseReport();
                temp.MaSach = i.Book.Title;
                temp.SoLuong = i.Quantity;
                listReport.Add(temp);
            }
            ReportParameter[] param = new ReportParameter[4];
            param[0] = new ReportParameter("PurchaseID", PurOrder.PurchaseOrderID);
            param[1] = new ReportParameter("Supplier", PurOrder.Supplier.SupplierName);
            param[2] = new ReportParameter("OrderDate", PurOrder.OrderDate.ToString());
            param[3] = new ReportParameter("ExDeliverDate", PurOrder.ExDeliverDate.ToString());

            this.PurReportviewer.LocalReport.ReportPath = "Report/PurchaseReport.rdlc";
            this.PurReportviewer.LocalReport.SetParameters(param);
            var reportDataSuorce = new ReportDataSource("DTSPurchase", listReport);
            this.PurReportviewer.LocalReport.DataSources.Clear();
            this.PurReportviewer.LocalReport.DataSources.Add(reportDataSuorce);
            this.PurReportviewer.RefreshReport();
            
        }

        private void ESC_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
