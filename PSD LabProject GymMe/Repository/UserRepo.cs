using PSD_LabProject_GymMe.Factory;
using PSD_LabProject_GymMe.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSD_LabProject_GymMe.Repository
{
    public class UserRepo
    {
        static LocalDatabaseEntities db = DatabaseSingleton.getInstance();

        public static void CreateCustomer(string username, string userEmail, DateTime userDOB, string userGender, string userPassword)
        {
            MsUser user = UserFactory.CreateCustomer(username, userEmail, userDOB, userGender, userPassword);
            db.MsUsers.Add(user);
            db.SaveChanges();

        }
        public static void UpdateUser(int id, string username, string userEmail, DateTime userDOB, string userGender)
        {
            MsUser user = db.MsUsers.Find(id);
            user.UserName = username;
            user.UserEmail = userEmail;
            user.UserDOB = userDOB;
            user.UserGender = userGender;
            db.SaveChanges();
        }
        public static void UpdateUserPassword(int id, string userPassword)
        {
            MsUser user = db.MsUsers.Find(id);
            user.UserPassword = userPassword;
            db.SaveChanges();
        }
        public static string GetUserPassword(int userId)
        {
            return db.MsUsers.Find(userId).UserPassword;
        }
        public static MsUser FindUserById(int id)
        {
            return (from x in db.MsUsers where x.UserId == id select x).FirstOrDefault();
            //return db.MsUsers.Find(id);
        }
        public static MsUser FindUserByUsername(string username)
        {
            return (from x in db.MsUsers where x.UserName == username select x).FirstOrDefault();
        }
        public static MsUser FindUserByEmail(string userEmail)
        {
            return (from x in db.MsUsers where x.UserEmail == userEmail select x).FirstOrDefault();
        }

        public static List<MsUser> GetUsersList()
        {
            return db.MsUsers.ToList();
        }
    }
}