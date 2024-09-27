using PSD_LabProject_GymMe.Handlers;
using PSD_LabProject_GymMe.Model;
using PSD_LabProject_GymMe.Modules;
using PSD_LabProject_GymMe.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace PSD_LabProject_GymMe.Controllers
{
    public class UserController
    {
        public static string FieldValidation(string userName, string userEmail, string userDOB, string userGender)
        {
            if (userName.Equals("")) return "Please fill in your username!";
            if (userEmail.Equals("")) return "Please fill in your email!";
            if (userDOB.Equals("")) return "Please fill in your date of birth!";
            if (userGender.Equals("Choose...")) return "Please choose your gender!";
            string emailPattern = @"^.+\.com$";
            string usernamePattern = @"^[a-zA-Z\s]{5,15}$";
            if (!Regex.IsMatch(userEmail, emailPattern)) return "Please enter a valid Email!";
            if (!Regex.IsMatch(userName, usernamePattern)) return "Username must be 5-15 in length with spaces only!";
            return "";
        }
        public static string PasswordValidation(string userPassword, string confirmPassword)
        {
            string alphanumeric = @"^[a-zA-Z0-9]+$";
            if (userPassword.Equals("")) return "Please fill in your password!";
            if (!Regex.IsMatch(userPassword, alphanumeric)) return "Password must be can only contain letters and numbers!";
            if (!userPassword.Equals(confirmPassword)) return "Confirmation password does not match!";
            return "";
        }

        public static Response<MsUser> LoginUser(string username, string password)
        {
            Response<MsUser> response = new Response<MsUser>();
            response.message = null;
            response.status = false;
            response.payload = null;
            if (username == null || password == null)
            {
                response.message = "Fill in all the fields!";
                return response;
            }
            return UserHandler.LoginUser(username, password);

        }
        public static Response<MsUser> RegisterUser(string userName, string userEmail, string userDOB, string userGender, string userPassword, string confirmPassword)
        {
            Response<MsUser> response = new Response<MsUser>();
            response.message = FieldValidation(userName, userEmail, userDOB, userGender);
            
            if (response.message.Equals(""))
            {
                response.message = PasswordValidation(userPassword, confirmPassword);
                if (response.message.Equals(""))
                {
                    return UserHandler.RegisterUser(userName, userEmail, Convert.ToDateTime(userDOB), userGender, userPassword);
                }
            }
            response.status = false;
            response.payload = null;
            return response;
        }
        public static Response<MsUser> UpdateUser(int userId, string userName, string userEmail, string userDOB, string userGender)
        {
            Response<MsUser> response = new Response<MsUser>();
            response.message = FieldValidation(userName, userEmail, userDOB, userGender);
            if (response.message.Equals(""))
            {
                return UserHandler.UpdateUser(userId, userName, userEmail, Convert.ToDateTime(userDOB), userGender);
            }
            response.status = false;
            response.payload = null;
            return response;
        }
        public static Response<MsUser> UpdateUserPassword(int userId, string oldPassword, string newPassword)
        {
            Response<MsUser> response = new Response<MsUser>();
            response.message = PasswordValidation(newPassword,newPassword);
            if (response.message.Equals(""))
            {
                return UserHandler.UpdateUserPassword(userId, oldPassword, newPassword);
            }
            return response;
        }
        public static List<MsUser> GetUsersList()
        {
            return UserHandler.GetUsersList();
        }
        public static MsUser FindUserById(int id)
        {
            return UserHandler.FindUserById(id);
        }
        public static MsUser FindUserByUsername(string username)
        {
            return UserHandler.FindUserByUsername(username);
        }
        public static MsUser FindUserByEmail(string userEmail)
        {
            return UserHandler.FindUserByEmail(userEmail);
        }
    }
}