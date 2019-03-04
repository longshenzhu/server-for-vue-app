using Common;
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
        [HttpPost]
        public MessageResult AddToCart()
        {
            return MessageResult.CreateSuccessResult();
        }
    }
}
