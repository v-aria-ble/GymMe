using PSD_LabProject_GymMe.Controllers;
using PSD_LabProject_GymMe.Model;
using PSD_LabProject_GymMe.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSD_LabProject_GymMe.Views
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                UsernameTb.Text = Request.QueryString["un"];
                PasswordTb.Text = Request.QueryString["pw"];
            }
        }

        protected void RegisterBtn_Click(object sender, EventArgs e)
        {
            string username = UsernameTb.Text;
            string userPassword = PasswordTb.Text;
            string userEmail = EmailTb.Text;
            string userDOB = DobTb.Text;
            string userGender = GenderList.Text;
            string confirmPassword = ConfirmPwTb.Text;
            Response<MsUser> response = UserController.RegisterUser(username, userEmail, userDOB, userGender, userPassword, confirmPassword);
            ErrorLbl.Text = response.message;
            if (response.status == true)
            {
                //ErrorLbl.Text = response.message+" you will be redirected to the login page.";
                //Thread.Sleep(3000);
                Response.Redirect("~/Views/LoginPage.aspx?" + "un=" + username + "&pw=" + userPassword);
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void LoginBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/LoginPage.aspx");
        }
    }
}