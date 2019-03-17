using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataServer.Domains
{
    public class Cart : EntityBase
    {
        public string loginName { get; set; }
        public Cart()
        {
            Products = new List<CartProduct>();
        }
        public IList<CartProduct> Products { get; set; }
        public int TotalCount { get; set; }
        public float TotalPrize { get; set; }

        public MessageResult AddToCart(CartProduct product)
        {
            return null;
        }

        public MessageResult RemoveFromCart(Guid productId)
        {
            return null;
        }

        public MessageResult Clear()
        {
            return null;
        }
    }
}
