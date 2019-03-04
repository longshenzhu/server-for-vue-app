using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Common;

namespace webForVueApp.Api
{
    public class AccountController : ApiController
    {
        public MessageResult LoginIn()
        {
            return MessageResult.CreateSuccessResult();
        }

    }
}
