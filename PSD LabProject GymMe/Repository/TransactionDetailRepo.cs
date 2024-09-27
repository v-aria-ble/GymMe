using PSD_LabProject_GymMe.Factory;
using PSD_LabProject_GymMe.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSD_LabProject_GymMe.Repository
{
    public class TransactionDetailRepo
    {
        static LocalDatabaseEntities db = DatabaseSingleton.getInstance();
        public static void CreateTransactionDetail(int transactionId, List<MsCart> cart)
        {
            foreach (MsCart x in cart)
            {
                TransactionDetail detail = TransactionDetailFactory.CreateTransactionDetail(transactionId, x.SupplementId, x.Quantity);
                db.TransactionDetails.Add(detail);
                db.MsCarts.Remove(x);
                db.SaveChanges();
            }
            
            return;
        }
        public static List<object> GetTransactionDetails(int transactionId)
        {
            var TransactionDetails = (from x in db.TransactionDetails join y in db.TransactionHeaders on x.TransactionId equals y.TransactionId join z in db.MsSupplements on x.SupplementId equals z.SupplementId where x.TransactionId == transactionId select new
            {
                TransactionId = y.TransactionId,
                TransactionDate = y.TransactionDate,
                SupplementId = x.SupplementId,
                SupplementName = z.SupplementName,
                Quantity = x.Quantity,
                Status = y.Status
            }).ToList<object>();
            return TransactionDetails;
        }
        public static List<TransactionDetail> GetTransactionDetailNormal(int transactionId)
        {
            return (from x in db.TransactionDetails where x.TransactionId == transactionId select x).ToList();
        }
    }
}