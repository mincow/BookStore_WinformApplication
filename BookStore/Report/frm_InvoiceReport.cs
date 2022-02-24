using BookStore.Models;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore.Report
{
    public partial class frm_InvoiceReport : Form
    {
        BookStoreDB context = new BookStoreDB();

        string invoiceNO;
        public frm_InvoiceReport(string InvoiceNo)
        {
            invoiceNO = InvoiceNo;
            InitializeComponent();
        }
        public frm_InvoiceReport()
        {
            InitializeComponent();
        }

        private void FormtestRP_Load(object sender, EventArgs e)
        {
            txtInvoice.Text = invoiceNO;
            Invoice invoice = context.Invoices.FirstOrDefault(p=>p.InvoiceID == txtInvoice.Text);
            List<InvoiceDetail> listInvoice = context.InvoiceDetails.Where(p=>p.InvoiceID == txtInvoice.Text).ToList();
            List<InvoiceReport> listReport = new List<InvoiceReport>();
            foreach (InvoiceDetail i in listInvoice)
            {
                InvoiceReport temp = new InvoiceReport();
                temp.BookName = i.Book.Title;
                temp.Stock = i.Quantity;
                temp.UnitPrice = i.Book.SellPrice;
                listReport.Add(temp);
            }
            ReportParameter[] param = new ReportParameter[9];
            param[0] = new ReportParameter("InvoiceID", invoice.InvoiceID);
            param[1] = new ReportParameter("Day", invoice.Date.ToString());
            if(invoice.Customer == null)
            {
                param[2] = new ReportParameter("Customer", "");
                param[3] = new ReportParameter("VIP", "0");
                param[8] = new ReportParameter("Discount", (0 + invoice.Promotion.Discount).ToString());
            }
            else
            {
                param[2] = new ReportParameter("Customer", invoice.Customer.FullName);
                param[3] = new ReportParameter("VIP", invoice.Customer.VIP.Discount.ToString());
                param[8] = new ReportParameter("Discount", (invoice.Customer.VIP.Discount + invoice.Promotion.Discount).ToString());
            }
            
                      
            param[4] = new ReportParameter("Promotion", invoice.Promotion.PromotionID.ToString());
            param[5] = new ReportParameter("Employ", invoice.Employee.FullName);
            param[6] = new ReportParameter("Total", invoice.Total.ToString());
            if (invoice.Note == null)
            {
                param[7] = new ReportParameter("Note","");
            }
            else
            {
                param[7] = new ReportParameter("Note", invoice.Note);
            }    
            
            

            this.reportViewer1.LocalReport.ReportPath = "Report/InvoiceReport.rdlc";
            this.reportViewer1.LocalReport.SetParameters(param);
            var reportDataSource = new ReportDataSource("DataSet1", listReport);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
                
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ESC_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
