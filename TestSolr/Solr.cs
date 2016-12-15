using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using SolrDAO;
using SolrNet;
using Microsoft.Practices.ServiceLocation;

namespace TestSolr
{
    [TestClass]
    public class Solr
    {
        private SolrAccess solr;
        [TestInitialize]
        public void setup()
        {
            solr = new SolrAccess();
        }
        [TestMethod]
        public void TestAccessSolr()
        {
        }

        [TestMethod]
        public void TestFacet()
        {
            var res = solr.FacetSearchGetAll();
        }
    }
}
