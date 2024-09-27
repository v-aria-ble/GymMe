using PSD_LabProject_GymMe.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSD_LabProject_GymMe.Factory
{
    public class TransactionDetailFactory
    {
        public static TransactionDetail CreateTransactionDetail(int transactionId, int supplementId, int quantity)
        {
            TransactionDetail transactionDetail = new TransactionDetail();
            transactionDetail.TransactionId = transactionId;
            transactionDetail.SupplementId = supplementId;
            transactionDetail.Quantity = quantity;
            return transactionDetail;
        }
    }
}