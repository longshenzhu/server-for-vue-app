using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataServer.Domains
{
    public class Account : EntityBase
    {
        public string LoginName { get; set; }
        public string NickName { get; set; }
        public string Description { get; set; }
    }
}
