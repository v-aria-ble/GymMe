using PSD_LabProject_GymMe.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSD_LabProject_GymMe.Repository
{
    public class SupplementTypeRepo
    {
        static LocalDatabaseEntities db = DatabaseSingleton.getInstance();
        public static MsSupplementType FindSupplementTypeById(int supplementTypeId)
        {
            return db.MsSupplementTypes.Find(supplementTypeId);

        }
    }
}