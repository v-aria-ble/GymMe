using PSD_LabProject_GymMe.Model;
using PSD_LabProject_GymMe.Modules;
using PSD_LabProject_GymMe.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls.WebParts;

namespace PSD_LabProject_GymMe.Handlers
{
    public class CartHandler
    {
        public static Response<MsCart> AddItemCart(int userId, int supplementId, int quantity)
        {
            MsCart cart = CartsRepo.FindItemCart(userId, supplementId);
            if (cart==null)
            {
                CartsRepo.AddItemCart(userId, supplementId, quantity);
            }
            else
            {
                CartsRepo.UpdateItemCart(cart, CartsRepo.FindItemQuantity(cart.CartId)+quantity);
            }
            return new Response<MsCart>
            {
                message = "Success!",
                status = true,
                payload = cart
            };
        }
        public static Response<MsCart> RemoveAllItems(int userId)
        {
            List<MsCart> Items = CartsRepo.GetAllCarts(userId);
            if (Items == null)
            {
                return new Response<MsCart>
                {
                    message = "There's nothing in the cart!",
                    status = false,
                    payload = null
                };
            }
            else
            {
                CartsRepo.RemoveAllItems(userId);
                return new Response<MsCart>
                {
                    message = "Success!",
                    status = true,
                    payload = null
                };
            }
        }
        public static List<object> GetCartList(int userId)
        {
            return CartsRepo.GetCartList(userId);
        }
    }
}