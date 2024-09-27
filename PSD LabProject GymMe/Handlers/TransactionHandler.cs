using PSD_LabProject_GymMe.Model;
using PSD_LabProject_GymMe.Modules;
using PSD_LabProject_GymMe.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSD_LabProject_GymMe.Handlers
{
    public class TransactionHandler
    {
        public static int CreateTransactionHeader(int userId)
        {
            TransactionHeader header = TransactionHeaderRepo.CreateTransactionHeader(userId, DateTime.Now, "Unhandled");
            return header.TransactionId;
        }
        public static List<TransactionHeader> GetUserTransaction(int userId)
        {
            return TransactionHeaderRepo.GetUserTransaction(userId);
        }
        public static List<TransactionHeader> GetAllTransaction()
        {
            return TransactionHeaderRepo.GetAllTransaction();
        }
        public static Response<TransactionHeader> CreateTransaction(int userId)
        {

            List<MsCart> cart = CartsRepo.GetAllCarts(userId);
            if (cart != null)
            {
                TransactionHeader header = TransactionHeaderRepo.CreateTransactionHeader(userId, DateTime.Now, "Unhandled");
                int TransactionId = header.TransactionId;
                TransactionDetailRepo.CreateTransactionDetail(TransactionId, cart);
                return new Response<TransactionHeader>
                {
                    message = "Success!",
                    status = true,
                    payload = null
                };
            }
            return new Response<TransactionHeader>
            {
                message = "Cart Empty!",
                status = false,
                payload = null
            };


        }
        public static List<object> GetTransactionDetails(int transactionId)
        {
            return TransactionDetailRepo.GetTransactionDetails(transactionId);
        }
        public static Response<TransactionHeader> HandleTransactions()
        {
            if (TransactionHeaderRepo.GetUnhandledTransaction() != null)
            {
                TransactionHeaderRepo.HandleTransactions();
                return new Response<TransactionHeader>
                {
                    message = "Success!",
                    status = true,
                    payload = null
                };
            }
            return new Response<TransactionHeader>
            {
                message = "All transactions are already handled!",
                status = false,
                payload = null
            };
        }
        public static List<TransactionDetail> getTransactionDetailsByHeader(TransactionHeader header)
        {
            int transactionId = header.TransactionId;
            return TransactionDetailRepo.GetTransactionDetailNormal(transactionId);
        }
       
    }
}