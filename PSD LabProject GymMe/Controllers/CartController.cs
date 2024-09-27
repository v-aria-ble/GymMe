using PSD_LabProject_GymMe.Handlers;
using PSD_LabProject_GymMe.Model;
using PSD_LabProject_GymMe.Modules;
using PSD_LabProject_GymMe.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;

namespace PSD_LabProject_GymMe.Controllers
{
    public class CartController
    {
        public static List<object> GetCartList(int userId)
        {
            return CartsRepo.GetCartList(userId);
        }
        public static Response<MsCart> AddItemCart(int userId, int supplementId, string quantity)
        {
            if (quantity == null || quantity.Equals(""))
            {
                return new Response<MsCart>
                {
                    message = "Invalid input, try again.",
                    status = false,
                    payload = null
                };
            }
            if (quantity.All(Char.IsDigit))
            {
                int numQuantity = Convert.ToInt32(quantity);
                if(numQuantity > 0)
                {
                    CartHandler.AddItemCart(userId, supplementId, numQuantity);
                    return new Response<MsCart>
                    {
                        message = "Success!",
                        status = true,
                        payload = null
                    };
                }
            }
            return new Response<MsCart>
            {
                message = "Invalid input, try again.",
                status = false,
                payload = null
            };
        }
        public static Response<MsCart> RemoveAllItems(int userId)
        {
            return CartHandler.RemoveAllItems(userId);
        }
    }

}