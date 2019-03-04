using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Common;

namespace webForVueApp.Api
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
