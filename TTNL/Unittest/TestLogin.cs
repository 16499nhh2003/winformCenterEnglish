using BUS;
using DAL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Unittest
{
    [TestClass]
    public class TestLogin
    {
        [TestMethod]
        public void TestMethod1()
        {
            BUS_ACCOUNT bUS_ACCOUNT = new BUS_ACCOUNT();
            string username = "admin";
            string password = "1234567";
            int expect = 1;
            Assert.AreEqual(bUS_ACCOUNT.checkLogin(username,password).Count,expect);
        }
        [TestMethod]
        public void TestMethod2()
        {
            BUS_ACCOUNT bUS_ACCOUNT = new BUS_ACCOUNT();
            string username = "admin";
            string password = "admin";
            int expect = 0;
            Assert.AreEqual(bUS_ACCOUNT.checkLogin(username, password).Count, expect);
        }
    }
}
