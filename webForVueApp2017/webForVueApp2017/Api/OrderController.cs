using Common;
using DataServer;
using DataServer.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace webForVueApp2017.Api
{
    /// <summary>
    /// 订单api
    /// </summary>
    public class OrderController : ApiController
    {
        private List<Order> _orderService = OrderTable.AllOrders;

        /// <summary>
        /// 结算或者立即购买
        /// </summary>
        /// <param name="order">OrderProducts</param>
        /// <returns></returns>
        [HttpPost]
        public MessageResult CreateOrder(Order order)
        {
            if(order.OrderProducts == null || order.OrderProducts.Count == 0)
            {
                return MessageResult.CreateFailResult("结算失败！");
            }
            order.Id = Guid.NewGuid();
            order.CreateTime = DateTime.Now;
            _orderService.Add(order);
            return MessageResult.CreateSuccessResult();

        }
    }
}
