using PSD_LabProject_GymMe.Model;
using PSD_LabProject_GymMe.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSD_LabProject_GymMe.Controllers
{
    public partial class WebForm1 : System.Web.UI.Page
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
            MsUser user = (MsUser)Session["user"];
            GreetingsText.InnerText += user.UserName + "!";
            List<MsUser> users = UserController.GetUsersList();
            UserList.DataSource = users;
            UserList.DataBind();

        }
        protected void isGuest()
        {
            GreetingsText.InnerText += "Guest!";
        }
        protected void isCustomer()
        {
            MsUser user = (MsUser)Session["user"];

            GreetingsText.InnerText += user.UserName + "!";
        }
        
            
            

        
    }
}