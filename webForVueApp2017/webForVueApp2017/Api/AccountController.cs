using Common;
using DataServer;
using DataServer.Domains;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace webForVueApp2017.Api
{
    public class AccountController : ApiController
    {
        [HttpGet]
        public MessageResult LoginIn(string loginName,string password,bool rememberMe =false)
        {
            var accounts = UserTable.AllAccount;
            var account = accounts.SingleOrDefault(x => x.LoginName == loginName && x.Password == password);
            if(account == null)
            {
                return MessageResult.CreateFailResult("用户名或者密码不正确");
            }
            //查询通过，加入缓存 todo...
            return MessageResult.CreateSuccessResult("登录成功",account);
        }

        public MessageResult LoginOut(string loginName)
        {
            //清楚服务端用户缓存 todo...
            return MessageResult.CreateSuccessResult();
        }
    }
}
