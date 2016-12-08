using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ElasticsearchDao;
using Nest;
<<<<<<< HEAD
using System.Net;
=======
>>>>>>> SimpleSearch

namespace TestElasticsearchDao
{
    [TestClass]
    public class ElasticAccessTest
    {
        [TestMethod]
        public void ElasticConnectionTest()
        {
<<<<<<< HEAD

=======
            Uri node = new Uri("http://localhost:9200");
            ConnectionSettings connectionSettings = new ConnectionSettings(node); ;
            ElasticClient client = new ElasticClient(connectionSettings); ;

            Assert.IsTrue(client.CatMaster().CallDetails.Success);
>>>>>>> SimpleSearch
        }
    }
}
