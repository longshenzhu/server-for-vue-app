using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.Http;
using Common.Db;
using DataServer.Domains;
using DataServer;

namespace webForVueApp2017
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // 在应用程序启动时运行的代码
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);            
        }

        static void Main()
        {
            //初始化数据
            InitData();
            Console.WriteLine(DbHelperSql.ConnectionString);
            Console.ReadLine();
        }

        /// <summary>
        /// 初始化数据
        /// </summary>
        public static void InitData()
        {
            //初始化用户
            InitAccountData(UserTable.AllAccount);

        }

        public static void InitAccountData(IList<Account> accounts)
        {
            var sqlString = "insert into App_Account"
                + " (Id,LoginName,NickName,Password,Avatar,Roles,CreateTime,Description)"
                + " values  ";
            var valueStr = "";
            foreach (var account in accounts)
            {
                string accountStr = string.Format("('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}'),",
                    account.Id,account.LoginName,account.NickName,account.Password,account.AvatarUrl,account.Roles,account.CreateTime,account.Description);
                valueStr += accountStr;
            }
            valueStr = valueStr.TrimEnd(',');
            sqlString += valueStr;
            DbHelperSql.ExecuteSql(sqlString);

        }
    }
}