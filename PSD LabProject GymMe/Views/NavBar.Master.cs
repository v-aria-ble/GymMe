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
    public partial class Site1 : System.Web.UI.MasterPage
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
            if (Request.Cookies["user"]!=null)
            {
                string username = Request.Cookies["user"].Value;
                Session["user"] = UserController.FindUserByUsername(username);
            }
            if (Session["user"]!=null)
            {
                MsUser user = (MsUser)Session["user"];
                if (user.UserRole.Equals("Admin")) isAdmin();
                else isCustomer();
            }
            else isGuest();
        }
        protected void isAdmin()
        {
            LogoutBtn.Visible = true;
            ProfileBtn.Visible = true;
            HistoryBtn.Visible = true;
            OrderBtn.Visible = false;
            TransactionBtn.Visible = true;
            TransactionQueueBtn.Visible = true;
            ManageSupplementBtn.Visible = true;
            HomeBtn.Visible = true;
            RegisterBtn.Visible = false;
            LoginBtn.Visible = false;
        }
        protected void isGuest()
        {
            LogoutBtn.Visible = false;
            ProfileBtn.Visible = false;
            HistoryBtn.Visible = false;
            OrderBtn.Visible = false;
            TransactionBtn.Visible = false;
            TransactionQueueBtn.Visible = false;
            ManageSupplementBtn.Visible = false;
            HomeBtn.Visible = true;
            RegisterBtn.Visible = true;
            LoginBtn.Visible = true;
        }
        protected void isCustomer()
        {
            LogoutBtn.Visible = true;
            ProfileBtn.Visible = true;
            HistoryBtn.Visible = true;
            OrderBtn.Visible = true;
            TransactionBtn.Visible = true;
            TransactionQueueBtn.Visible = false;
            ManageSupplementBtn.Visible = false;
            HomeBtn.Visible = true;
            RegisterBtn.Visible = false;
            LoginBtn.Visible = false;
        }

        protected void OrderBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/OrderSupplementPage.aspx");
        }

        protected void ManageSupplementBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/ManageSupplementPage.aspx");
        }

        protected void ProfileBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/ProfilePage.aspx");
        }

        protected void LoginBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/LoginPage.aspx");
        }

        protected void RegisterBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/RegisterPage.aspx");
        }

        protected void HomeBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/HomePage.aspx");
        }

        protected void LogoutBtn_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            HttpCookie cookie = Request.Cookies["user"];
            if (cookie != null)
            {
                cookie.Expires = DateTime.Now.AddDays(-1);
                Response.Cookies.Add(cookie);
                Response.Redirect("~/Views/HomePage.aspx");
            }
        }

        protected void HistoryBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/TransactionHistoryPage.aspx");
        }

        protected void TransactionQueueBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/TransactionQueue.aspx");
        }

        protected void TransactionBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/TransactionReportPage.aspx");
        }
    }
}