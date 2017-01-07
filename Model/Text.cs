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
    public class Text
    {
            [Number]
            [SolrUniqueKey("id")]
            public int id { get; set; }
            [String]
            [SolrField("name")]
            public string text { get; set; }
        
    }
}
