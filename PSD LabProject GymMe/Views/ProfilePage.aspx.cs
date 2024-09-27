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
    public partial class WebForm4 : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            MsUser user = (MsUser)Session["user"];
            if (user == null)
            {
                Response.Redirect("~/Views/HomePage.aspx");
            }
            if (!IsPostBack)
            {
                UsernameTb.Text = user.UserName;
                EmailTb.Text = user.UserEmail;
                
                DobTb.Text = Convert.ToString(user.UserDOB);
                CurrDobLbl.Text += user.UserDOB;
                CurrentGenderLbl.Text += user.UserGender;

            }
        }

        protected void UpdateProfileBtn_Click(object sender, EventArgs e)
        {
            MsUser user = (MsUser)Session["user"];
            string username = UsernameTb.Text;
            string email = EmailTb.Text;
            string userdob = DobTb.Text;
            string usergender = GenderList.Text;
            ErrorLbl.Text = UserController.UpdateUser(user.UserId, username, email, userdob, usergender).message;
        }

        protected void ChangePasswordBtn_Click(object sender, EventArgs e)
        {
            MsUser user = (MsUser)Session["user"];
            string oldpassword = OldPasswordTb.Text;
            string newpassword = NewPwTb.Text;
            ErrorLbl2.Text = UserController.UpdateUserPassword(user.UserId, oldpassword, newpassword).message;
        }
    }
}