using PSD_LabProject_GymMe.Controllers;
using PSD_LabProject_GymMe.Model;
using PSD_LabProject_GymMe.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Caching;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSD_LabProject_GymMe.Views
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                UsernameTb.Text = Request.QueryString["un"];
                PasswordTb.Text = Request.QueryString["pw"];
            }
        }

        protected void LoginBtn_Click(object sender, EventArgs e)
        {
            string username = UsernameTb.Text;
            string password = PasswordTb.Text;
            Response<MsUser> response = UserController.LoginUser(username, password);
            ErrorLbl.Text = response.message;
            if(response.status == true)
            {
                Session["user"] = response.payload;
                if (RememberCheck.Checked)
                {
                    HttpCookie cookie = new HttpCookie("user");
                    cookie.Expires = DateTime.Now.AddHours(3);
                    Response.Cookies.Add(cookie);
                    cookie.Value = username;
                    
                }
                Response.Redirect("~/Views/HomePage.aspx");
            }
        }

        protected void RegisterBtn_Click(object sender, EventArgs e)
        {
            string username = UsernameTb.Text;
            string password = PasswordTb.Text;
            Response.Redirect("~/Views/RegisterPage.aspx?"+"un="+username+"&pw="+password);
        }
    }
}