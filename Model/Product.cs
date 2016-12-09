using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nest;

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
            return string.Format("Id: '{0}', Name: '{1}', Description: '{2}'", id, name, description);
        }
    }
}