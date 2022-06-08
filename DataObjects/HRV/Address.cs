using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects.HRV
{
    public class Address
    {
        public string address1 { get; set; }
        public object address2 { get; set; }
        public string city { get; set; }
        public string company { get; set; }
        public string country { get; set; }
        public string first_name { get; set; }
        public int id { get; set; }
        public string last_name { get; set; }
        public string phone { get; set; }
        public string province { get; set; }
        public string zip { get; set; }
        public string name { get; set; }
        public string province_code { get; set; }
        public string country_code { get; set; }

        public bool @default { get; set; }
        public string district { get; set; }
        public string district_code { get; set; }
        public string ward { get; set; }
        public string ward_code { get; set; }
    }
}
