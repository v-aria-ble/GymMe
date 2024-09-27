using PSD_LabProject_GymMe.Handlers;
using PSD_LabProject_GymMe.Model;
using PSD_LabProject_GymMe.Modules;
using PSD_LabProject_GymMe.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSD_LabProject_GymMe.Controllers
{
    public class TransactionController
    {
        public static List<TransactionHeader> GetUserTransaction(int userId)
        {
            return TransactionHandler.GetUserTransaction(userId);
        }
        public static List<TransactionHeader> GetAllTransaction()
        {
            return TransactionHandler.GetAllTransaction();
        }
        public static Response<TransactionHeader> CreateTransaction(int userId)
        {
            return TransactionHandler.CreateTransaction(userId);
        }
        public static List<object> GetTransactionDetails(int transactionId)
        {
            return TransactionHandler.GetTransactionDetails(transactionId);
        }
        public static Response<TransactionHeader> HandleTransactions()
        {
            return TransactionHandler.HandleTransactions();
        }
        public static List<TransactionDetail> GetTransactionDetailsByHeader(TransactionHeader header)
        {
            return TransactionHandler.getTransactionDetailsByHeader(header);

        }
    }
}