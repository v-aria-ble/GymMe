using PSD_LabProject_GymMe.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSD_LabProject_GymMe.Factory
{
    public class SupplementFactory
    {
        public static MsSupplement CreateSupplement(string supplementName, DateTime supplementExpiryDate, int supplementPrice, int supplementTypeId)
        {
            MsSupplement supplement = new MsSupplement();
            supplement.SupplementName = supplementName;
            supplement.SupplementExpiryDate = supplementExpiryDate;
            supplement.SupplementPrice = supplementPrice;
            supplement.SupplementTypeId = supplementTypeId;
            return supplement;
        }
    }
}