using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects.HRV
{
    public class Customer
    {
        public bool accepts_marketing { get; set; }
        public IList<Address> addresses { get; set; }
        public string created_at { get; set; }
        public DefaultAddress default_address { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string first_name { get; set; }
        public int id { get; set; }
        public object multipass_identifier { get; set; }
        public string last_name { get; set; }
        public int? last_order_id { get; set; }
        public string last_order_name { get; set; }
        public string note { get; set; }
        public int orders_count { get; set; }
        public string state { get; set; }
        public object tags { get; set; }
        public double total_spent { get; set; }
        public double total_paid { get; set; }
        public string updated_at { get; set; }
        public bool verified_email { get; set; }
        public bool send_email_invite { get; set; }
        public bool send_email_welcome { get; set; }
        public object password { get; set; }
        public object password_confirmation { get; set; }
        public object group_name { get; set; }
        public object birthday { get; set; }
        public object gender { get; set; }
        public object last_order_date { get; set; }
    }
}
