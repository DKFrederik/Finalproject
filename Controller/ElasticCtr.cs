using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElasticsearchDao;
using System.Web;
using System.Web.Script.Serialization;
namespace Controller
{
    public class ElasticCtr
    {
        private ElasticAccess elastic;

        public ElasticCtr()
        {
            elastic = new ElasticAccess();
        }

        public int CreateIndex(string name)
        {
            return elastic.CreateIndex(name);
        }

        public int DeleteIndex(string name)
        {
            return elastic.DeleteIndex(name);
        }

        public string AddDocToIndex(string targetIndex, string doc)
        {
            var json = serializeJson(doc);
            return elastic.AddDocToIndex(targetIndex, json);
        }

        public object serializeJson(string jsonString)
        {
            JavaScriptSerializer serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            var json = serializer.Deserialize<Object>(jsonString);
            return json;
        }

        public String SimpleSearch(string term, string field)
        {
            return elastic.SimpleSearch(term, field);
        }
    }
}
