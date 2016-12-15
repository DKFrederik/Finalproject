using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolrDAO;
using MssqlDAO;
using Model;

namespace Controller
{
    public class SolrCtr
    {
        private SolrAccess solr;
        private ProductDAO sql;

        public SolrCtr()
        {
            solr = new SolrAccess();
            sql = new ProductDAO();
        }

        public string BulkInsert()
        {
            return solr.BulkInsert(sql.GetProducts());
        }

        public string DeleteAllDocuments()
        {
            string q = "*:*"; //Catch all wild card
            return solr.DeleteDoc(q);
        }

        public string DeleteDocByQuery(string q)
        {
            return solr.DeleteDoc(q);
        }

        public List<Product> Search(String query)
        {
            return solr.Search(query);
        }
    }
}
