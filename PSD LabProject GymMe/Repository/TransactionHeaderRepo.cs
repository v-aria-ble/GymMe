using PSD_LabProject_GymMe.Factory;
using PSD_LabProject_GymMe.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSD_LabProject_GymMe.Repository
{
    public class TransactionHeaderRepo
    {
        static LocalDatabaseEntities db = DatabaseSingleton.getInstance();
        public static TransactionHeader CreateTransactionHeader(int userId, DateTime transactionDate, string Status)
        {
            TransactionHeader header = TransactionHeaderFactory.CreateTransactionHeader(userId, transactionDate, Status);
            db.TransactionHeaders.Add(header);
            db.SaveChanges();
            return header;
        }
        public static List<TransactionHeader> GetUserTransaction(int userId)
        {
            List<TransactionHeader> HeaderList = (from x in db.TransactionHeaders where x.UserId == userId select x).ToList();
            return HeaderList;
        }
        public static List<TransactionHeader> GetAllTransaction()
        {
            List<TransactionHeader> HeaderList = db.TransactionHeaders.ToList();
            return HeaderList;
        }
        public static void HandleTransactions()
        {
            List<TransactionHeader> HeaderList = GetUnhandledTransaction();
            foreach (TransactionHeader header in HeaderList)
            {
                header.Status = "Handled";
                db.SaveChanges();
            }
        }
        public static List<TransactionHeader> GetUnhandledTransaction()
        {
            List<TransactionHeader> HeaderList = (from x in db.TransactionHeaders where x.Status == "Unhandled" select x).ToList();
            return HeaderList;
        } 
    }
}