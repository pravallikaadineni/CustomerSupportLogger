using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DAL;

namespace DAL
{
    public class operations
    {
        customerdbEntities context = new customerdbEntities();
        custloginfo d = new custloginfo();
        userinfo c = new userinfo();
        /* public bool ValidateUser( string email, string password)
         {
             bool result = false;


                 if (  c.email == "abc@123" && c.password == "abc" )
                 {
                     result = true;
                 }

             return result;
         }*/

        public bool ValidateUser(string email, string password)
        {
            bool ans = false;
            var found1 = context.userinfoes.ToList();
            var found = found1.Find(x => x.email == email);
            if (found != null)
            {
                if (found.password == password)
                {
                    ans = true;
                }
            }
            return ans;
        }

        public void insert(custloginfo d)
        {
            context.custloginfoes.Add(d);
            context.SaveChanges();
        }




    }

}






