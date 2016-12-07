using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nest;

namespace ElasticsearchDao
{
    public class ElasticAccess
    {
        private readonly Uri node;
        private readonly ConnectionSettings connectionSettings;
        private readonly ElasticClient client;

        public ElasticAccess()
        {
            node = new Uri("localhost:9200");
            connectionSettings = new ConnectionSettings(node);
            client = new ElasticClient(connectionSettings);
        }

        public int CreateIndex(string name)
        {
            int rc = -1;

            if(!client.IndexExists(name).Exists)
            {
                var createIndex = client.CreateIndex(name);
                rc = 0;
            }

            return rc;
        }

        public int DeleteIndex(string name)
        {
            int rc = -1;

            if (client.IndexExists(name).Exists)
            {
                var deleteIndex = client.DeleteIndex(name);
                rc = 0;
            }

            return rc;
        }
    }
}
