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
    public partial class TransactionQueue : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
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
            TransQueueGV.DataSource = TransactionController.GetAllTransaction();
            TransQueueGV.DataBind();
        }
        protected void isGuest()
        {
            Response.Redirect("~/Views/HomePage.aspx");
        }
        protected void isCustomer()
        {
            Response.Redirect("~/Views/HomePage.aspx");
        }
        protected void HandleBtn_Click(object sender, EventArgs e)
        {
            ErrorLbl.Text = TransactionController.HandleTransactions().message;
        }
    }
}