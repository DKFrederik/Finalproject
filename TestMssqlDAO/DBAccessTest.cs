using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MssqlDAO;

namespace TestMssqlDAO
{
    [TestClass]

    public class DBAccessTest
    {
        [TestMethod]
        public void ConnectionTest()
        {
            DBAccess dba = new DBAccess();
            Assert.IsTrue(dba.Open());
            dba.Close();
        }
    }
}
