using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolrNet;
using SolrNet.Commands;
using SolrNet.Commands.Parameters;
using Model;
using Microsoft.Practices.ServiceLocation;

namespace SolrDAO
{
    public class SolrAccess
    {

        private ISolrOperations<Product> solr;
        public SolrAccess()
        {
            Startup.Init<Product>("http://localhost:8983/solr/newCore");
            solr = ServiceLocator.Current.GetInstance<ISolrOperations<Product>>();
        }

        public string BulkInsert(List<Product> products)
        {
            string res = "Didnt run..";

            try
            {
                res = solr.AddRange(products).Status.ToString();
                Commit();
            }
            catch(Exception e)
            {
                solr.Rollback();
                res = e.ToString();
            }

            return res;
        }

        public string DeleteDoc(string q)
        {
            string res = "Didnt run..";
            try
            {
                SolrQuery query = new SolrQuery(q);
                res = solr.Delete(query).Status.ToString();
                Commit();
            } catch (Exception e)
            {
                solr.Rollback();
                res = e.ToString();
            }
            return res;
        }

        public string Update()
        {
            return null;
        }

        public List<Product> Search(string query)
        {
            try
            {
                SolrQuery q = new SolrQuery(query);
                List<Product> p = solr.Query(q);
                return p;
            }
            catch (Exception e)
            {
                e.ToString();
            }
            return null;
        }

        public void Commit()
        {
            solr.Commit();
        }

        public Dictionary<string, int> FacetSearchGetAll()
        {
            Dictionary<string, int> d = new Dictionary<string, int>();
            var r = solr.FacetFieldQuery(new SolrFacetFieldQuery("_categories_"));

            foreach (var i in r)
            {
                d.Add(i.Key, i.Value);
            }
            return d;
        }

        public List<Product> FacetSearchWithQuery(string term)
        {
            List<Product> r = solr.Query("_categories_:" + term, new QueryOptions()
            {
                Rows = 200
            });

            return r;
        }
    }

}
