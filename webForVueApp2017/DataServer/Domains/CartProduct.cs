using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataServer.Domains
{
    public class CartProduct : EntityBase
    {
        public Product Product { get; set; }
        public int Count { get; set; }
    }
}
