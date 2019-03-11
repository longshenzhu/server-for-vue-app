using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Db
{
    public class DbConfigHelper
    {
        public static string ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];
        public static SqlConnection GetCon()
        {
            return new SqlConnection(ConnectionString);
        }

    }
}
