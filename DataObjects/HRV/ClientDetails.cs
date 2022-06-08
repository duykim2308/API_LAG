using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects.HRV
{
    public class ClientDetails
    {
        public object accept_language { get; set; }
        public string browser_ip { get; set; }
        public object session_hash { get; set; }
        public object user_agent { get; set; }
        public object browser_height { get; set; }
        public object browser_width { get; set; }
    }
}
