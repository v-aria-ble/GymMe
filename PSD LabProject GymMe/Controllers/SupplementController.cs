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
    public class SupplementController
    {
        public static string FieldValidation(string supplementName, string supplementExpiryDate, string supplementPrice, string SupplementTypeId)
        {
            


            if (supplementName.Equals("")) return "Please Fill in the supplement name!";
            if (supplementExpiryDate.Equals("")) return "Please Fill in the supplement expiry date!";
            if (supplementPrice.Equals("")) return "Please Fill in the supplement price!";
            if (SupplementTypeId.Equals("")) return "Please Fill in the supplement type id!";
            if (supplementName.Contains("Supplement")==false) return "Supplement name must contain the word 'Supplement'!";
            DateTime TimeNow = DateTime.Now;
            DateTime ExpiryDate = Convert.ToDateTime(supplementExpiryDate);
            if (ExpiryDate < TimeNow) return "Please enter an expiry date greater than today's date!";
            if (supplementPrice.All(Char.IsDigit))
                {
                int supplementPriceDigit = Convert.ToInt32(supplementPrice);
                if (supplementPriceDigit < 3000) return "Please enter a price greater than 3000!";
                return "";
                }
            return "Please enter a valid input price!";
        }
           
            

        
        public static Response<MsSupplement> CreateSupplement(string supplementName, string supplementExpiryDate, string supplementPrice, string SupplementTypeId)
        {
            Response<MsSupplement> response = new Response<MsSupplement>
            {
                message = FieldValidation( supplementName,  supplementExpiryDate,  supplementPrice,  SupplementTypeId),
                status = false,
                payload = null
            };
            if (response.message.Equals(""))
            {
                return SupplementHandler.CreateSupplement(supplementName, Convert.ToDateTime(supplementExpiryDate), Convert.ToInt32(supplementPrice), Convert.ToInt32(SupplementTypeId));
            }
                
                
            return response;
        }
        public static Response<MsSupplement> UpdateSupplement(int supplementId, string supplementName, string supplementExpiryDate, string supplementPrice, string supplementTypeId)
        {
            Response<MsSupplement> response = new Response<MsSupplement>
            {
                message = FieldValidation(supplementName, supplementExpiryDate, supplementPrice, supplementTypeId),
                status = false,
                payload = null
            };
            if (response.message.Equals(""))
            {
                return SupplementHandler.UpdateSupplement(supplementId, supplementName, Convert.ToDateTime(supplementExpiryDate), Convert.ToInt32(supplementPrice), Convert.ToInt32(supplementTypeId));
            }
            return response;
        }

        public static Response<MsSupplement> RemoveSupplement(int supplementId)
        {
            return SupplementHandler.RemoveSupplement(supplementId);
        }
        public static List<object> GetSupplementList()
        {
            return SupplementHandler.GetSupplementList();
        }
        public static MsSupplement GetSupplement(int supplementId)
        {
            return SupplementHandler.GetSupplement(supplementId);
        }
    }
}