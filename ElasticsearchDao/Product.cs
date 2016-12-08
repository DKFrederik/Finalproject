using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nest;

namespace ElasticsearchDao
{
    [ElasticsearchType(IdProperty = "Id", Name = "product")]
    public class Product
    {
        [Number(NumberType.Integer)]
        public string Id { get; set; }
        [String]
        public string Title { get; set; }
        [String]
        public string Description { get; set; }

        public override string ToString()
        {
            return string.Format("Id: '{0}', Title: '{1}', Body: '{2}'", Id, Title, Description);
        }
    }
}
