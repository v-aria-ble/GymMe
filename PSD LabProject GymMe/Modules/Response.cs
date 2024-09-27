using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSD_LabProject_GymMe.Modules
{
    public class Response<T>
    {
        public string message;
        public bool status;
        public T payload;
    }
}