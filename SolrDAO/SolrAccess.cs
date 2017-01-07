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

        /**
         * Inserts data in bulk.
         **/
        public string BulkInsert(List<Product> products)
        {
            string res = "Didnt run..";

            try
            {
                res = solr.AddRange(products).Status.ToString();
                Commit();
            }
            catch (Exception e)
            {
                solr.Rollback();
                res = e.ToString();
            }

            return res;
        }
        // Delete a singe document matched by the query
        public string DeleteDoc(string q)
        {
            string res = "Didnt run..";
            try
            {
                SolrQuery query = new SolrQuery(q);

                res = solr.Delete(query).Status.ToString();
                Commit();
            }
            catch (Exception e)
            {
                solr.Rollback();
                res = e.ToString();
            }
            return res;
        }
        //Not implemented. Solr uses Add/AddRange for updats and inserts
        public string Update()
        {
            return null;
        }

        //Performs a query using the lucene/standard parser.
        public List<Product> Search(string query)
        {
            try
            {
                SolrQuery q = new SolrQuery(query);
                var r = solr.Ping();
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
        //Retrieves all the categories facets 
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

        //Dont recall..
        public List<Product> FacetSearchWithQuery(string term)
        {
            List<Product> r = solr.Query("_categories_:" + term, new QueryOptions()
            {
                Rows = 200
            });

            return r;
        }

        public void FacetPivot()
        {
            SolrFacetPivotQuery f = new SolrFacetPivotQuery()
            {
                Fields = new[] { new Pivot().Field = "cat1,cat2,cat3,cat4" },
                MinCount = 1
            };


        FacetParameters fp = new FacetParameters()
        {
            Queries = new[] { f }
        };
            var qo = new QueryOptions();
            qo.Facet = fp;
            qo.Rows = 0;
            var res = solr.Query("*:*", qo);

            double x = 2323;
        }
    }

}
