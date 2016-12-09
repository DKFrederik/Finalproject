using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Product
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public List<string> Categories { get; set; }

        public Product()
        {
            Categories = new List<string>();
        }
    }
}
