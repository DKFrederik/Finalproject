using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Nest;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //string uri = "http://localhost:9200/";

            //var req = System.Net.WebRequest.Create(uri);
            //System.Net.WebResponse resp = req.GetResponse();
            //System.IO.StreamReader sr = new System.IO.StreamReader(resp.GetResponseStream());

            //Console.WriteLine(sr.ReadToEnd().Trim());
            //Console.ReadLine();

            Uri node = new Uri("http://localhost:9200");
            ConnectionSettings settings = new ConnectionSettings(node);
            ElasticClient client = new ElasticClient(settings);

            Console.WriteLine(client.CatHealth().CallDetails.Success);
            Console.ReadKey();
        }
    }
}
