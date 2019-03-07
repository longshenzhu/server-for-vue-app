using Common;
using DataServer;
using DataServer.Domains;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Security;

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
            FormsAuthentication.SetAuthCookie(loginName, true);
            return MessageResult.CreateSuccessResult("登录成功",account);
        }

        [HttpGet]
        public MessageResult LoginOut()
        {
            FormsAuthentication.SignOut();
            return MessageResult.CreateSuccessResult("注销成功");
        }

        //[HttpGet]
        //public MessageResult GetAccountInfo()
        //{
        //    var user = HttpContext.Current.User.Identity.Name;
        //    return MessageResult.CreateSuccessResult(data: user);
        //}

        [HttpGet]
        public MessageResult GetAccountInfo(string loginName)
        {
            var user = UserTable.AllAccount.SingleOrDefault(x => x.LoginName == loginName);
            if (user == null)
            {
                return MessageResult.CreateFailResult("用户不存在");
            }
            return MessageResult.CreateSuccessResult(data: user);
        }
    }
}
