using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Common;
using DataServer;
using DataServer.Domains;

namespace webForVueApp.Api
{
    public class CartController : ApiController
    {
        [HttpPost]
        public MessageResult AddToCart()
        {
            return MessageResult.CreateSuccessResult();
        }

        [HttpGet]
        public IList<Product> MyCart()
        {
            var product = ProductTable.AllProducts.Where(x => MyCartTable.AllProducts.Contains(x.Id)).ToList();
            return product;
        }
    }
}
