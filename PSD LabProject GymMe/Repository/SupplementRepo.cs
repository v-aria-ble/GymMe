using PSD_LabProject_GymMe.Factory;
using PSD_LabProject_GymMe.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSD_LabProject_GymMe.Repository
{
    public class SupplementRepo
    {
        static LocalDatabaseEntities db = DatabaseSingleton.getInstance();
        public static void CreateSupplement(string  supplementName, DateTime supplementExpiryDate, int supplementPrice, int SupplementTypeId)
        {
            MsSupplement supplement = SupplementFactory.CreateSupplement(supplementName, supplementExpiryDate, supplementPrice, SupplementTypeId);
            db.MsSupplements.Add(supplement);
            db.SaveChanges();
        }
        public static void RemoveSupplement(int supplementId)
        {
            MsSupplement supplement = db.MsSupplements.Find(supplementId);
            db.MsSupplements.Remove(supplement);
            db.SaveChanges();
        }
        public static void UpdateSupplement(int supplementId, string supplementName, DateTime supplementExpiryDate, int supplementPrice, int supplementTypeId)
        {
            MsSupplement supplement = db.MsSupplements.Find(supplementId);
            supplement.SupplementName = supplementName;
            supplement.SupplementExpiryDate = supplementExpiryDate;
            supplement.SupplementPrice = supplementPrice;
            supplement.SupplementTypeId = supplementTypeId;
            db.SaveChanges();
        }
        public static List<object> GetSupplementList()
        {
            var SupplementList = (from x in db.MsSupplements join y in db.MsSupplementTypes on x.SupplementTypeId equals y.SupplementTypeId select new
            {
                SupplementId = x.SupplementId,
                SupplementName = x.SupplementName,
                SupplementExpiryDate = x.SupplementExpiryDate,
                SupplementPrice = x.SupplementPrice,
                SupplementTypeId = x.SupplementTypeId,
                SupplementTypeName = y.SupplementTypeName
            }).ToList<object>();
            return SupplementList;
        }
        public static MsSupplement GetSupplement(int supplementId)
        {
            return db.MsSupplements.Find(supplementId);
        }
    }
}