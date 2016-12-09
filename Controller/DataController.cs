using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MssqlDAO;
using Model;

namespace Controller
{
    public class DataController
    {
        ProductDAO pDao;

        public DataController()
        {
            pDao = new ProductDAO();
        }
        public List<Product> GetData()
        {
            return pDao.GetProducts();
        }

        public string SaveData()
        {
            return null;
        }

        public string SearchData()
        {
            return null;
        }

    }
}
