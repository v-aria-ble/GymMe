using PSD_LabProject_GymMe.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;

namespace PSD_LabProject_GymMe.Factory
{
    public class UserFactory
    {
        public static MsUser CreateCustomer(string username, string userEmail, DateTime userDOB, string userGender, string userPassword)
        {
            MsUser customer = new MsUser();
            customer.UserName = username;
            customer.UserEmail = userEmail;
            customer.UserGender = userGender;
            customer.UserRole = "Customer";
            customer.UserDOB = userDOB;
            customer.UserPassword = userPassword;
            return customer;
        }
        
    }
}