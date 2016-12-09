using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Model;

namespace MssqlDAO
{
    public class ProductDAO
    {
        private DBAccess dba;

        public ProductDAO()
        {
            dba = new DBAccess();
        }

        public List<Product> GetProducts()
        {

            //SQL string for fetching data from MSSQL database
            string sql = "SELECT * FROM Products";
            //Create a empty list of products
            var products = new List<Product>();

            using (SqlCommand cmd = dba.GetDbCommand(sql))
            {
                //DataReader
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    try
                    {
                        while (reader.Read())
                        {
                            var p = new Product()
                            {
                                id = reader.GetInt32("id"),
                                name = reader.GetString("name"),
                                description = reader.GetString("description"),
                                cat1 = reader.GetString("cat1"),
                                cat2 = reader.GetString("cat2"),
                                cat3 = reader.GetString("cat3"),
                                cat4 = reader.GetString("cat4")
                            };
                            //Add every Product to List
                            products.Add(p);
                        }
                    }

                    catch
                    {
                        Console.WriteLine("An exception occurred!");
                    }
                }
                cmd.Parameters.Clear();
            }
            return products;
        }
    }
}
