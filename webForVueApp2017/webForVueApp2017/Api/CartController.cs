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
    public class CartController : ApiController
    {
        private IList<Product> _productService = ProductTable.AllProducts;

        /// <summary>
        /// 加入购物车，尚未实现
        /// </summary>
        /// <param name="productId">商品Id</param>
        /// <returns></returns>
        [HttpPost]
        public MessageResult AddToCart(Guid productId)
        {
            return MessageResult.CreateSuccessResult();
        }

        /// <summary>
        /// 查看我的购物车
        /// </summary>
        /// <param name="loginName">登录名</param>
        /// <returns></returns>
        [HttpGet]
        public IList<Product> MyCart(string loginName)
        {
            var product = _productService.Where(x => MyCartTable.AllProducts.Contains(x.Id)).ToList();
            return product;
        }
    }
}
