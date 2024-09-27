using PSD_LabProject_GymMe.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSD_LabProject_GymMe.Views
{
    public partial class ManageSupplementPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<object> SupplementList = SupplementController.GetSupplementList();
            SupplementManageList.DataSource = SupplementList;
            SupplementManageList.DataBind();
        }

        protected void SupplementOrderList_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(SupplementManageList.Rows[e.RowIndex].Cells[0].Text);
            SupplementController.RemoveSupplement(id);
        }

        protected void SupplementOrderList_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int id = Convert.ToInt32(SupplementManageList.Rows[e.RowIndex].Cells[0].Text);
            Response.Redirect("~/Views/UpdateSPPage.aspx?id="+id);
            //Response.Redirect("~/Views/UpdateSPPage.aspx");
        }

        protected void InsertBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/InsertSPPage.aspx");
        }
    }
}