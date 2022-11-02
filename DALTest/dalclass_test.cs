using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using NUnit.Framework;

namespace DALTest
{
    [TestFixture]
    public class dalclass_test
    {


        operations op = new operations();

        [TestCase("abc@123", "abc", ExpectedResult = true)]
        [TestCase("xyz@123", "xyz", ExpectedResult = true)]
        [TestCase("pqr@678", "pqr", ExpectedResult = true)]
        [TestCase("sweety@gmail","avs", ExpectedResult = true)]
        public bool Validate(string email, string password)
        {
            return op.ValidateUser(email, password);
        }
        [TestCase(1, ExpectedResult = false)]
        [TestCase(2, ExpectedResult = false)]
        public void InsertCkeck(int id)
        {
            custloginfo c = new custloginfo();
            c.userid = id;
             op.insert(c);
        }
    }
}

