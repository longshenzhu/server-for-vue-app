using System.Collections.Generic;
using Common;

namespace DataServer.Domains
{
    public class MyCart
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
