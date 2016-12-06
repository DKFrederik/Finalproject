using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElasticsearchDao;

namespace Controller
{
    public class ElasticCtr
    {
        private ElasticAccess elastic;

        public ElasticCtr(string uri)
        {
            elastic = new ElasticAccess(uri);
        }

        public int CreateIndex(string name)
        {
            return elastic.CreateIndex(name);
        }

        public int DeleteIndex(string name)
        {
            return elastic.DeleteIndex(name);
        }
    }
}
