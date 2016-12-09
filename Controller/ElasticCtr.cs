using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElasticsearchDao;
using MssqlDAO;
using System.Web;
using System.Web.Script.Serialization;
using Model;
using Newtonsoft.Json;

namespace Controller
{
    public class ElasticCtr
    {
        private ElasticAccess elastic;
        private DBAccess mssql;

        public ElasticCtr()
        {
            elastic = new ElasticAccess();
            mssql = new DBAccess();
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
            //var json = serializeJson(doc);
            //return elastic.AddDocToIndex(targetIndex, json);
            return "";
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

        public String InsertDataToElastic(string index)
        {
            List<Product> p = mssql.SelectAllXml();

            return elastic.AddDocToIndex(index, p);
        }
    }
}
