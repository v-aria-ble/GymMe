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
    public partial class UpdateSPPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                load();

            }
        }
        protected void load()
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);
            MsSupplement supplement = SupplementController.GetSupplement(id);
            SupplementNameTb.Text = supplement.SupplementName;
            CurrentExpLbl.Text += Convert.ToString(supplement.SupplementExpiryDate);
            SupplementPriceTb.Text = Convert.ToString(supplement.SupplementPrice);
            TypeIdTb.Text = Convert.ToString(supplement.SupplementTypeId);
            EditLbl.Text += Convert.ToString(id);
        }
        protected void BackBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/ManageSupplementPage.aspx");
        }

        protected void UpdateBtn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);
            string supplementName = SupplementNameTb.Text;
            string supplementExpDate = SupplementExpiryDateTb.Text;
            string price = SupplementPriceTb.Text;
            string typeId = TypeIdTb.Text;
            ErrorLbl.Text=SupplementController.UpdateSupplement(id, supplementName, supplementExpDate, price, typeId).message;
        }
    }
}