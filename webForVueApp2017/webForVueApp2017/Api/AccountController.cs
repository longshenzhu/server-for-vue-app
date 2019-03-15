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
using webForVueApp2017.Models;

namespace webForVueApp2017.Api
{
    public class AccountController : ApiController
    {
        private List<Account> _accountService = UserTable.AllAccount;
        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="loginName">用户名</param>
        /// <param name="password">密码</param>
        /// <param name="rememberMe">是否记住密码</param>
        /// <returns></returns>
        [HttpGet]
        public MessageResult LoginIn(string loginName,string password,bool rememberMe =false)
        {
            var account = _accountService.SingleOrDefault(x => x.LoginName == loginName && x.Password == password);
            if(account == null)
            {
                return MessageResult.CreateFailResult("用户名或者密码不正确");
            }
            //查询通过，加入缓存 todo...
            FormsAuthentication.SetAuthCookie(loginName, true);
            return MessageResult.CreateSuccessResult("登录成功",account);
        }

        /// <summary>
        /// 注销
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public MessageResult LoginOut()
        {
            FormsAuthentication.SignOut();
            return MessageResult.CreateSuccessResult("注销成功");
        }

        /// <summary>
        /// 获取登录用户信息
        /// </summary>
        /// <param name="loginName">用户名</param>
        /// <returns></returns>
        [HttpGet]
        public MessageResult GetAccountInfo(string loginName)
        {
            var user = _accountService.SingleOrDefault(x => x.LoginName == loginName);
            if (user == null)
            {
                return MessageResult.CreateFailResult("用户不存在");
            }
            return MessageResult.CreateSuccessResult(data: user);
        }

        /// <summary>
        /// 用户注册
        /// </summary>
        /// <param name="registerAccount">用户名、密码、昵称</param>
        /// <returns></returns>
        [HttpPost]
        public MessageResult RegisterAccount(RegisterAccount registerAccount)
        {
            //验证:用户正确性、存在性
            if(_accountService.Any(x=>x.LoginName == registerAccount.LoginName))
            {
                return MessageResult.CreateFailResult("用户名不能重复");
            }
            var account = new Account
            {
                LoginName = registerAccount.LoginName,
                Password = registerAccount.Password,
                NickName = registerAccount.NickName
            };
            _accountService.Add(account);
            return MessageResult.CreateSuccessResult();
        }

        public MessageResult EditPassword()
        {
            return MessageResult.CreateSuccessResult();
        }
    }
}
