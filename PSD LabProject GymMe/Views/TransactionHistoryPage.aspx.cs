using PSD_LabProject_GymMe.Controllers;
using PSD_LabProject_GymMe.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSD_LabProject_GymMe.Views
{
    public partial class TransactionHistoryPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ValidateUser();
            }

        }
        protected void ValidateUser()
        {
            if (Request.Cookies["user"] != null)
            {
                string username = Request.Cookies["user"].Value;
                Session["user"] = UserController.FindUserByUsername(username);
            }
            if (Session["user"] != null)
            {
                MsUser user = (MsUser)Session["user"];
                if (user.UserRole.Equals("Admin")) isAdmin();
                else isCustomer();
            }
            else isGuest();
        }
        protected void isAdmin()
        {
            TransHistoryGV.DataSource = TransactionController.GetAllTransaction();
            TransHistoryGV.DataBind();
        }
        protected void isGuest()
        {
            Response.Redirect("~/Views/HomePage.aspx");
        }
        protected void isCustomer()
        {
            MsUser user = (MsUser)Session["user"];
            TransHistoryGV.DataSource = TransactionController.GetUserTransaction(user.UserId);
            TransHistoryGV.DataBind();
        }
        protected void TransHistoryGV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void TransHistoryGV_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow row = TransHistoryGV.Rows[e.RowIndex];
            int id = Convert.ToInt32(row.Cells[0].Text);
            Response.Redirect("~/Views/TransactionDetailPage.aspx?id=" + id);


        }
    }
}