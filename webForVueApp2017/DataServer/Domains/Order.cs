
using System;
using System.Collections.Generic;

namespace DataServer.Domains
{
    /// <summary>
    /// 订单
    /// </summary>
    public class Order : EntityBase
    {
        public string LoginName { get; set; }
        public Order()
        {
            OrderProducts = new List<OrderProduct>();
        }
        public IList<OrderProduct> OrderProducts { get; set; }
        public DateTime CreateTime { get; set; }
    }

    public class OrderProduct
    {
        public Guid OrderId { get; set; }
        public Guid ProductId { get; set; }
        /// <summary>
        /// 购买数量
        /// </summary>
        public int Count { get; set; }
        /// <summary>
        /// 购买价
        /// </summary>
        public decimal BuyInPrice { get; set; }
    }


}