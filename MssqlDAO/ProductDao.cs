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

        public void createFullTextIndex(string catalogName)
        {
            //Rowcount to be returned from executed sql command.
            int rc = -1;

            //SQL string for creating Full text catalog and index MSSQL database
            string sql = " CREATE FULLTEXT INDEX ON Products(description) KEY INDEX " + getIndexId();


            using (SqlCommand cmd = dba.GetDbCommand(sql))
            {
                try
                {
                    rc = cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

        }

        private string getIndexId()
        {
            //Rowcount to be returned from executed sql command.
            int rc = -1;
            string sql = "SELECT name from sysindexes where object_id('Products') = id";
            string result = "";
            using (SqlCommand cmd = dba.GetDbCommand(sql))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    try
                    {
                        while (reader.Read())
                        {
                            result = reader.GetString("name");
                        }
                    }
                    catch (Exception e)
                    {
                        throw e;
                    }
                }
            }
            return result;
        }

        public List<Product> Search(List<string> words)
        {
            //Instantiate a list to be returned
            List<Product> products = new List<Product>();

            string sql = "SELECT * FROM Products WHERE CONTAINS(*, '";
            int sizeOfList = words.Count();
            //Build the sql string
            for (int i = 0; i < sizeOfList; i++)
            {
                sql += words[i];
                if (i != (sizeOfList-1))
                {
                    sql += " AND ";
                }
            }

            sql += "')";

            using (SqlCommand cmd = dba.GetDbCommand(sql))
            {
                try
                {
                    //DataReader
                    using (SqlDataReader reader = cmd.ExecuteReader())
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
                }
                catch
                {
                    Console.WriteLine("An exception occurred!");
                }
                
                cmd.Parameters.Clear();
            }
            return products;
        }
    }
}
