using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataServer.Domains
{
    class Cart
    {
        public static IList<Product> Products = new List<Product>()
        {

        };

        public MessageResult AddToCart(Product product)
        {
            return null;
        }
    }
}
