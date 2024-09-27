using PSD_LabProject_GymMe.Model;
using PSD_LabProject_GymMe.Modules;
using PSD_LabProject_GymMe.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace PSD_LabProject_GymMe.Handlers
{
    public class UserHandler
    {
        public static Response<MsUser> RegisterUser(string userName, string userEmail, DateTime userDOB, string userGender, string userPassword)
        {
            MsUser user = UserRepo.FindUserByUsername(userName);
            MsUser tempUser = UserRepo.FindUserByEmail(userEmail);
            if (user == null && tempUser == null)
            {
                UserRepo.CreateCustomer(userName, userEmail,userDOB, userGender, userPassword);
                return new Response<MsUser>
                {
                    message = "Register Success!",
                    status = true,
                    payload = null

                };
            }
            else if (user != null)//User already exist, so don't continue.
            {
                return new Response<MsUser>
                {
                    message = "Username already taken.",
                    status = false,
                    payload = null
                };
            }
            else if (tempUser != null)
            {
                return new Response<MsUser>
                {
                    message = "Email already used.",
                    status = false,
                    payload = null
                };
            }
            else
            {
                return new Response<MsUser>
                {
                    message = "Invalid input, Try again.",
                    status = false,
                    payload = null
                };
            }
        }
        public static Response<MsUser> LoginUser(string username, string password)
        {
            MsUser user = UserRepo.FindUserByUsername(username);
            if (user == null)
            {
                return new Response<MsUser>
                {
                    message = "Username Invalid!",
                    status = false,
                    payload = null
                };
            }
            else if (user.UserPassword != password)
            {
                return new Response<MsUser>
                {
                    message = "Password is Invalid!",
                    status = false,
                    payload = null
                };
            }
            else if (user != null)
            {
                return new Response<MsUser>
                {
                    message = "Log-in Success!",
                    status = true,
                    payload = user
                };
            }
            return new Response<MsUser>
            {
                message = "Input Invalid, try again.",
                status = false,
                payload = null
            };
        }
        public static Response<MsUser> UpdateUser(int userId, string userName, string userEmail, DateTime userDOB, string userGender)
        {
            MsUser OriginalUser = UserRepo.FindUserById(userId);
            MsUser user = UserRepo.FindUserByUsername(userName);
            MsUser tempUser = UserRepo.FindUserByEmail(userEmail);
            
            if (user != null && user != OriginalUser)
            {
                return new Response<MsUser>
                {
                    message = "Username already taken.",
                    status = false,
                    payload = null
                };
            }
            else if (tempUser != null && user != OriginalUser)
            {
                return new Response<MsUser>
                {
                    message = "Email already used.",
                    status = false,
                    payload = null
                };
            }
            else
            {
                UserRepo.UpdateUser(userId, userName, userEmail, userDOB, userGender);
                return new Response<MsUser>
                {
                    message = "User update Success!",
                    status = true,
                    payload = null,
                };
            }

        }
        public static Response<MsUser> UpdateUserPassword(int UserId, string oldPassword, string newPassword)
        {
            if (UserRepo.GetUserPassword(UserId).Equals(oldPassword))
            {
                UserRepo.UpdateUserPassword(UserId, newPassword);
                return new Response<MsUser>
                {
                    message = "User update Success!",
                    status = true,
                    payload = null,
                };
            }
            return new Response<MsUser>
            {
                message = "Incorrect current password, Try again.",
                status = false,
                payload = null
            };

        }
        public static List<MsUser> GetUsersList()
        {
            return UserRepo.GetUsersList();
        }
        public static MsUser FindUserById(int id)
        {
            return UserRepo.FindUserById(id);
        }
        public static MsUser FindUserByUsername(string username)
        {
            return UserRepo.FindUserByUsername(username);
        }
        public static MsUser FindUserByEmail(string userEmail)
        {
            return UserRepo.FindUserByEmail(userEmail);
        }

    }
}