using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Http;
using System.Web.Http.Hosting;
using System.Web.Security;
using Common;
using DataServer;
using DataServer.Domains;

namespace webForVueApp.Api
{
    public class AccountController : ApiController
    {
        [HttpGet]
        public MessageResult LoginIn(string loginName,string password)
        {
            //string cookieValue = "";
            //HttpCookie cookieGet = HttpContext.Current.Request.Cookies["userName"];
            //HttpCookie cookieSet = new HttpCookie("username")
            //{
            //    Value = HttpUtility.UrlDecode(loginName, Encoding.GetEncoding("GB2312")),
            //    Expires = DateTime.Now.AddMinutes(10)
            //};
            //HttpContext.Current.Response.Cookies.Add(cookieSet);
            FormsAuthentication.SetAuthCookie(loginName,true);
            return MessageResult.CreateSuccessResult("登录成功",new { loginName,password});
        }

        [HttpGet]
        public MessageResult LoginOut()
        {
            FormsAuthentication.SignOut();
            return MessageResult.CreateSuccessResult("注销成功");
        }

        [HttpGet]
        public MessageResult GetAccountInfo()
        {
            var user = HttpContext.Current.User.Identity.Name;
            //HttpCookie cookieGet = HttpContext.Current.Request.Cookies["userName"];
            return MessageResult.CreateSuccessResult(data: user);
        }

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
