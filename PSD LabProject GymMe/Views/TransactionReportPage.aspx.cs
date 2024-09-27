using PSD_LabProject_GymMe.Controllers;
using PSD_LabProject_GymMe.Dataset;
using PSD_LabProject_GymMe.Model;
using PSD_LabProject_GymMe.Report;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSD_LabProject_GymMe.Views
{
    public partial class TransactionReportPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TransactionReport report = new TransactionReport();
            CrystalReportViewer1.ReportSource = report;
            TransactionDataset dataset = GetDataset(TransactionController.GetAllTransaction());
            report.SetDataSource(dataset);
        }
        protected TransactionDataset GetDataset(List<TransactionHeader> header)
        {
            TransactionDataset dataset = new TransactionDataset();
            var headerData = dataset.TransactionHeaders;
            var detailData = dataset.TransactionDetails;
            foreach(TransactionHeader x in header)
            {
                var headerRow = headerData.NewRow();
                headerRow["TransactionId"] =x.TransactionId;
                headerRow["UserId"] = x.UserId;
                headerRow["TransactionDate"]=x.TransactionDate;
                headerRow["Status"]=x.Status;
                headerData.Rows.Add(headerRow);
                
                foreach(TransactionDetail y in TransactionController.GetTransactionDetailsByHeader(x))
                {
                    var detailRow = detailData.NewRow();
                    detailRow["TransactionId"]=y.TransactionId;
                    detailRow["SupplementId"]=y.SupplementId;
                    detailRow["Quantity"]=y.Quantity;
                    detailData.Rows.Add(detailRow);
                }
            }
            return dataset;
        }
    }
}