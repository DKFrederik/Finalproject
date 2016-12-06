using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ElasticsearchDao;
using Nest;

namespace TestElasticsearchDao
{
    [TestClass]
    public class ElasticAccessTest
    {
        [TestMethod]
        public void ElasticConnectionTest()
        {
            Uri node = new Uri("http://localhost:9200");
            ConnectionSettings connectionSettings = new ConnectionSettings(node); ;
            ElasticClient client = new ElasticClient(connectionSettings); ;

            Assert.IsTrue(client.CatMaster().CallDetails.Success);
        }
    }
}
