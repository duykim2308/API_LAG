using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects
{
    public class Insider_Email
    {

        public class XML
        {
            public int timestamp { get; set; }
            public string @event { get; set; }
            public string email { get; set; }
            public string campaign_name { get; set; }
            public int variation_id { get; set; }
            public string subject { get; set; }
            public string link_clicked { get; set; }
            public string iid { get; set; }
        }


        public class Processed
        {
            public int timestamp { get; set; }
            public string @event { get; set; }
            public string email { get; set; }
            public string campaign_name { get; set; }
            public int variation_id { get; set; }
            public string subject { get; set; }
            public string iid { get; set; }
        }


        public class Delivered
        {
            public int timestamp { get; set; }
            public string @event { get; set; }
            public string email { get; set; }
            public string campaign_name { get; set; }
            public int variation_id { get; set; }
            public string subject { get; set; }
            public string iid { get; set; }
            public string ip { get; set; }
        }

        public class Blocked
        {
            public string email { get; set; }
            public string @event { get; set; }
            public string event_type { get; set; }
            public string reason { get; set; }
            public string campaign_name { get; set; }
            public int timestamp { get; set; }
            public string iid { get; set; }
            public int variation_id { get; set; }
            public string subject { get; set; }
        }


        public class Bounced
        {
            public string email { get; set; }
            public string @event { get; set; }
            public string reason { get; set; }
            public string campaign_name { get; set; }
            public int timestamp { get; set; }
            public string iid { get; set; }
            public int variation_id { get; set; }
            public string subject { get; set; }
        }


        public class Open
        {
            public int timestamp { get; set; }
            public string @event { get; set; }
            public string email { get; set; }
            public string campaign_name { get; set; }
            public int variation_id { get; set; }
            public string subject { get; set; }
            public string iid { get; set; }
            public string ip { get; set; }
            public string user_agent { get; set; }
        }

        public class Click
        {
            public int timestamp { get; set; }
            public string @event { get; set; }
            public string email { get; set; }
            public string link_clicked { get; set; }
            public string campaign_name { get; set; }
            public int variation_id { get; set; }
            public string subject { get; set; }
            public string iid { get; set; }
            public string ip { get; set; }
            public string user_agent { get; set; }
            public UrlOffset url_offset { get; set; }

            public class UrlOffset
            {
                public int index { get; set; }
                public string type { get; set; }
            }

        }

        public class Unsubscribe
        {
            public int timestamp { get; set; }
            public string @event { get; set; }
            public string email { get; set; }
            public string campaign_name { get; set; }
            public int variation_id { get; set; }
            public string subject { get; set; }
            public string iid { get; set; }
        }
          

        public class Deferred
        {
            public int timestamp { get; set; }
            public string @event { get; set; }
            public string email { get; set; }
            public string campaign_name { get; set; }
            public int variation_id { get; set; }
            public string subject { get; set; }
            public string iid { get; set; }
        }


    }
}
