using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataServer;
using DataServer.Domains;

namespace webForVueApp.Api
{
    public class ProductController : ApiController
    {
        [HttpGet]
        public IList<Product> GetProducts()
        {
            return ProductTable.AllProducts;
        }
    }
}
