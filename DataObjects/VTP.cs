using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects
{
    public class VTP
    {
        public DATAS DATA { get; set; }
        public string TOKEN { get; set; }

        public class DATAS
        {
            public string ORDER_NUMBER { get; set; }
            public string ORDER_REFERENCE { get; set; }
            public string ORDER_STATUSDATE { get; set; }
            public int ORDER_STATUS { get; set; }
            public string STATUS_NAME { get; set; }
            public string LOCALION_CURRENTLY { get; set; }
            public string NOTE { get; set; }
            public int MONEY_COLLECTION { get; set; }
            public int MONEY_FEECOD { get; set; }
            public int MONEY_TOTAL { get; set; }
            public string EXPECTED_DELIVERY { get; set; }
            public int PRODUCT_WEIGHT { get; set; }
            public string ORDER_SERVICE { get; set; }
        }

    }


    public class VTPXML
    {
        public string Company { get; set; }
        public string ORDER_NUMBER { get; set; }
        public string ORDER_REFERENCE { get; set; }
        public string ORDER_STATUSDATE { get; set; }
        public int ORDER_STATUS { get; set; }
        public string STATUS_NAME { get; set; }
        public string LOCALION_CURRENTLY { get; set; }
        public string NOTE { get; set; }
        public int MONEY_COLLECTION { get; set; }
        public int MONEY_FEECOD { get; set; }
        public int MONEY_TOTAL { get; set; }
        public string EXPECTED_DELIVERY { get; set; }
        public int PRODUCT_WEIGHT { get; set; }
        public string ORDER_SERVICE { get; set; }
    }
}
