using PSD_LabProject_GymMe.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSD_LabProject_GymMe.Repository
{
    public class DatabaseSingleton
    {
        private static LocalDatabaseEntities db = null;
        public static LocalDatabaseEntities getInstance()
        {
            if (db == null)
            {
                db = new LocalDatabaseEntities();
            }
            return db;
        }
    }
}