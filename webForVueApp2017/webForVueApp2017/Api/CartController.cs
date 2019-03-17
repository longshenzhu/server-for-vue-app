using Common;
using DataServer;
using DataServer.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using webForVueApp2017.Models;

namespace webForVueApp2017.Api
{
    public class CartController : ApiController
    {
        private IList<Product> _productService = ProductTable.AllProducts;
        private IList<Cart> _cartProductService = CartTable.AllProducts;

        /// <summary>
        /// 加入购物车，尚未实现
        /// </summary>
        /// <param name="loginName">登录用户名</param>
        /// <param name="productId">商品Id</param>
        /// <param name="count">加入购物车数量</param>
        /// <returns></returns>
        [HttpPost]
        public MessageResult AddToCart(string loginName,Guid productId,int count=1)
        {
            var product = _productService.Single(x => x.Id == productId);
            var cartEntity = _cartProductService.SingleOrDefault(x => x.loginName == loginName);
            if(cartEntity == null)
            {
                var cart = new Cart()
                {
                    loginName = loginName
                };
                cart.Products.Add(new CartProduct()
                {
                    Product = product,
                    Count = count
                });
                _cartProductService.Add(cart);
            }
            else
            {
                var cartProduct = cartEntity.Products.SingleOrDefault(x => x.Id == productId);
                if(cartProduct == null)
                {
                    cartEntity.Products.Add(new CartProduct()
                    {
                        Product = product,
                        Count = count
                    });
                }
                else
                {
                    cartProduct.Count += count;
                }
            }
            return MessageResult.CreateSuccessResult();
        }

        /// <summary>
        /// 查看我的购物车
        /// </summary>
        /// <param name="loginName">登录名</param>
        /// <returns></returns>
        [HttpGet]
        public Cart MyCart(string loginName)
        {
            var cart = _cartProductService.SingleOrDefault(x => x.loginName == loginName);
            return cart;
        }
    }
}
