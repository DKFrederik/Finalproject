using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
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
            node = new Uri("http://localhost:9200/");
            connectionSettings = new ConnectionSettings(node);
            client = new ElasticClient(connectionSettings);
        }

        public int CreateIndex(string name)
        {
            int rc = -1;

            if(!client.IndexExists(name).Exists)
            {
                var createIndex = client.CreateIndex(name, c => c.Mappings(m => m.Map<Product>(p => p.AutoMap())));
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

        public string AddDocToIndex(string targetIndex, List<Product> doc)
        {
            var result = client.Bulk(b => b.Index<List<Product>>(i => i.Document(doc)));
            //var res = client.LowLevel.Index<String>(targetIndex, "type-name", doc);
            return result.CallDetails.ToString();
        }

        public string SimpleSearch(string searchTerm, string searchField)
        {
            Field field = new Field();
            field = searchField;

            var res = client.Search<Product>(s => s.From(0).Size(5).Query(q => q.Match(m => m.Field(searchField).Query(searchTerm))));
            string result = "";
            foreach(var hit in res.Hits)
            {
                result += hit.Id;
            }

            return result;
        }
    }
}
