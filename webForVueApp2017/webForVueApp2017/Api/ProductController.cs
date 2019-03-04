using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace webForVueApp2017.Api
{
    public class ProductController : ApiController
    {
        [HttpGet]
        public IList<string> GetStrings()
        {
            return new List<string>()
            {
                "123",
                "fasdfad"
            };
        }
    }
}
