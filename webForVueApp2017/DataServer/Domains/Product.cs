using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataServer.Domains
{
    public class Product : EntityBase
    {
        public string Name { get; set; }
        public IList<string> ImageUrls { get; set; }
        public float Prize { get; set; }
        public string Description { get; set; }
    }
}
