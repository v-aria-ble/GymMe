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
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                load();
            }
            

        }

        protected void load()
        {
            MsUser user = (MsUser)Session["user"];
            if (user == null)
            {
                Response.Redirect("~/Views/HomePage.aspx");
            }
            List<object> SupplementList = SupplementController.GetSupplementList();
            SupplementOrderList.DataSource = SupplementList;
            SupplementOrderList.DataBind();
            List<object> CartList = CartController.GetCartList(user.UserId);
            MyCartList.DataSource = CartList;
            MyCartList.DataBind();
        }
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        protected void SupplementOrderList_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            MsUser user = (MsUser)Session["user"];
            int row = Convert.ToInt32(e.RowIndex);
            int id = Convert.ToInt32(SupplementOrderList.Rows[row].Cells[0].Text);
            TextBox tb = SupplementOrderList.Rows[row].FindControl("QuantityTb") as TextBox;
            string quantity = tb.Text;
            ErrorLbl.Text = CartController.AddItemCart(user.UserId, id, quantity).message;
            load();
        }

        protected void ClearCartBtn_Click(object sender, EventArgs e)
        {
            MsUser user = (MsUser)Session["user"];
            ErrorLbl2.Text = CartController.RemoveAllItems(user.UserId).message;
            load();

        }

        protected void CheckoutBtn_Click(object sender, EventArgs e)
        {
            MsUser user = (MsUser)Session["user"];
            ErrorLbl2.Text = TransactionController.CreateTransaction(user.UserId).message;
            load();
        }
    }
}