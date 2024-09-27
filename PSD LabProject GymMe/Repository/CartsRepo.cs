using PSD_LabProject_GymMe.Factory;
using PSD_LabProject_GymMe.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Web;

namespace PSD_LabProject_GymMe.Repository
{
    public class CartsRepo
    {
        static LocalDatabaseEntities db = DatabaseSingleton.getInstance();
        public static void AddItemCart(int userId, int SupplementId, int quantity)
        {
            MsCart cart = CartFactory.createCart(userId, SupplementId, quantity);
            db.MsCarts.Add(cart);
            db.SaveChanges();
        }
        
        public static void RemoveitemCart(int cartId)
        {
            MsCart cart = db.MsCarts.Find(cartId);
            db.MsCarts.Remove(cart);
            db.SaveChanges();
        }
        public static void RemoveAllItems(int userId)
        {
            var allItems = GetAllCarts(userId);
            foreach (var item in allItems)
            {
                db.MsCarts.Remove(item);
                db.SaveChanges();
            }
        }
        public static void UpdateItemCart(MsCart cart, int quantity)
        {
            MsCart tempcart = cart;
            db.MsCarts.Remove(tempcart);
            db.SaveChanges();
            tempcart.Quantity = quantity;
            db.MsCarts.Add(tempcart);
            db.SaveChanges();
        }
        public static MsCart FindItemCart(int userId, int supplementId)
        {
            MsCart cart = (from x in db.MsCarts where x.UserId == userId && x.SupplementId == supplementId select x).FirstOrDefault();
            return cart;
        }
        public static int FindItemQuantity(int cartId)
        {
            MsCart cart = db.MsCarts.Find(cartId);
            return cart.Quantity;
        }
        public static List<MsCart> GetAllCarts(int userId)
        {
            return db.MsCarts.Where(MsCart=>MsCart.UserId == userId).ToList();
        }
        public static List<object> GetCartList(int userId)
        {
            var CartList = (from x in db.MsCarts join z in db.MsSupplements on x.SupplementId equals z.SupplementId where x.UserId == userId
                                  select new
                                  {
                                      SupplementId = x.SupplementId,
                                      SupplementName = z.SupplementName,
                                      SupplementPrice = z.SupplementPrice,
                                      Quantity = x.Quantity

                                  }).ToList<object>();
            return CartList;
        }
    }
}