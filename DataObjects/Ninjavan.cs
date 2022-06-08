using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects
{
    public class Ninjavan
    {
        public string company { get; set; }
        public int shipper_id { get; set; }
        public string status { get; set; }
        public string previous_status { get; set; }
        public string shipper_order_ref_no { get; set; }
        public DateTime timestamp { get; set; }
        public string order_id { get; set; }
        public string tracking_id { get; set; }
        public Pod pod { get; set; }

        public class Pod
        {
            public string type { get; set; }
            public string name { get; set; }
            public string identity_number { get; set; }
            public string contact { get; set; }
            public string uri { get; set; }
            public bool left_in_safe_place { get; set; }
        }




    }
}
