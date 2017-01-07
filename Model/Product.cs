using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nest;
using SolrNet;
using SolrNet.Attributes;

namespace Model
{
    public class Product
    {
        [Number]
        public int id { get; set; }
        [String]
        public string name { get; set; }
        [String]
        public string description { get; set; }
        [String]
        public string cat1 { get; set; }
        [String]
        public string cat2 { get; set; }
        [String]
        public string cat3 { get; set; }
        [String]
        public string cat4 { get; set; }

        public Product()
        {

        }

        public override string ToString()
        {
            return string.Format("Id: '{0}', Name: '{1}'\n"
                + "Description: '{2}'"
                + "Categories: '{3}', '{4}', '{5}', '{6}'", 
                id, name, description, cat1, cat2, cat3, cat4);
        }
    }
}