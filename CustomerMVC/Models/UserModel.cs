using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerMVC.Models
{
    public class UserModel
    {
        public int userid { get; set; }
        public string email { get; set; }
        public string password { get; set; }
    }
}