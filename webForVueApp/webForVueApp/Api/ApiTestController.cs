using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.WebSockets;
using Common.Db;

namespace webForVueApp.Api
{
    public class ApiTestController : ApiController
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

        [HttpGet]
        public Object GetDataBySql()
        {
            var sqlStr = "SELECT Id,Title,StartTime FROM [dbo].[App_LiveWx_Activity] where Id ='4665a9a4-af6c-45db-9551-00f2d09ac294'";
            var reader = DbHelperSql.ExecuteReader(sqlStr);
            while (reader.Read())
            {
                return new 
                {
                    Id = reader[0],
                    Title = reader[1],
                    StartTime = reader[2]
                };
            }
            return null;
        } 
    }
}
