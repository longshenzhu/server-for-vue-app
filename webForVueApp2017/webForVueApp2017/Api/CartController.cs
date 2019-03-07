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

        [HttpPost]
        public MessageResult AddToCart()
        {
            return MessageResult.CreateSuccessResult();
        }

        [HttpGet]
        public IList<Product> MyCart()
        {
            var product = _productService.Where(x => MyCartTable.AllProducts.Contains(x.Id)).ToList();
            return product;
        }
    }
}
