using PSD_LabProject_GymMe.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSD_LabProject_GymMe.Factory
{
    public class TransactionHeaderFactory
    {
        public static TransactionHeader CreateTransactionHeader(int userId, DateTime transactionDate, string status)
        {
            TransactionHeader transactionHeader = new TransactionHeader();
            transactionHeader.UserId = userId;
            transactionHeader.TransactionDate = transactionDate;
            transactionHeader.Status = status;
            return transactionHeader;
        }
    }
}