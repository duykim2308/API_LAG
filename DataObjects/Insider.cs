using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects
{
    public class Insider
    {

        public class XML
        {
            public string email { get; set; }
            public string name { get; set; }
            public string phone_number { get; set; }
            public string last_visit_product { get; set; }
            public string last_add_to_cart_poduct { get; set; }
        }


        public class UserFlow
        { 
            public string email { get; set; }
            public string name { get; set; }
            public string phone_number { get; set; }
            public string last_visit_product { get; set; }
            public string last_add_to_cart_poduct { get; set; }
        }
    }
}
