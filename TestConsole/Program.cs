using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Nest;
using System.IO;
using System.Data.SqlClient;
using MssqlDAO;

namespace TestConsole
{
    class Program
    {

        static void Main(string[] args)
        {
            DBAccess dba = new DBAccess();

            //Create new ElasticClient on uri localhost:9200
            Uri node = new Uri("http://localhost:9200");
            ConnectionSettings settings = new ConnectionSettings(node);
            var client = new ElasticClient(settings);

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

            var descriptor = new BulkDescriptor();
            descriptor.Index(new IndexName() { Name = "test" });

            foreach (var product in products)
            {
                //For each Product in Product-list, index it to the given index
                descriptor.Index<Product>(i => i.Document(product));
            }

            var response = client.Bulk(descriptor);

        }
    }

    class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string cat1 { get; set; }
        public string cat2 { get; set; }
        public string cat3 { get; set; }
        public string cat4 { get; set; }
    }
}
