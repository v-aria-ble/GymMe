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
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        protected void BackBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/ManageSupplementPage.aspx");
        }

        protected void InsertBtn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);
            string supplementName = SupplementNameTb.Text;
            string supplementExpDate = SupplementExpiryDateTb.Text;
            string price = SupplementPriceTb.Text;
            string typeId = TypeIdTb.Text;
            ErrorLbl.Text = SupplementController.CreateSupplement(supplementName, supplementExpDate, price, typeId).message;
           
        }
    }
}