using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataServer.Domains
{
    public class CartProduct : EntityBase
    {
        public Guid ProductId { get; set; }
        public int Count { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
