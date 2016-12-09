using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MssqlDAO;
using Model;

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

        [TestMethod]
        public void XMLTest()
        {
            DBAccess dba = new DBAccess();
            dba.SelectAllXml();
            Assert.AreEqual(1, 1);
        }
    }
}
