using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ElasticsearchDao;
using Nest;
using System.Net;

namespace TestElasticsearchDao
{
    [TestClass]
    public class ElasticAccessTest
    {
        private ElasticAccess e;

        [TestInitialize]
        public void Setup()
        {
            e = new ElasticAccess();
        }
        [TestMethod]
        public void ElasticConnectionTest()
        {
            Uri node = new Uri("http://localhost:9200");
            ConnectionSettings connectionSettings = new ConnectionSettings(node); ;
            ElasticClient client = new ElasticClient(connectionSettings); ;

            Assert.IsTrue(client.CatMaster().CallDetails.Success);
        }

        [TestMethod]
        public void TestTermAggregateNested()
        {
            e.TermAggregateNested();
        }
        [TestMethod]
        public void TestTermAggregate()
        {
            e.TermAggregate();
        }
    }
}
