using PSD_LabProject_GymMe.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSD_LabProject_GymMe.Factory
{
    public class CartFactory
    {
        public static MsCart createCart(int userId, int supplementId, int quantity)
        {
            MsCart cart = new MsCart();
            cart.UserId = userId;
            cart.SupplementId = supplementId;
            cart.Quantity = quantity;
            return cart;
        }
    }
}