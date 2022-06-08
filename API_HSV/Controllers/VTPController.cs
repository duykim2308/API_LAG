using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class VTPController : ApiController
    {
        // GET: api/VTP
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/VTP/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/VTP
        [HttpPost]
        [Route("api/VTP")]
        public HttpStatusCode Post(DataObjects.VTP value)
        {
            int result = 0;
            DataObjects.VTPXML obj = new DataObjects.VTPXML();
            if (value != null)
            {
                obj.Company = "VSTYLE";
                obj.ORDER_NUMBER = value.DATA.ORDER_NUMBER;
                obj.ORDER_REFERENCE = value.DATA.ORDER_REFERENCE;
                obj.ORDER_STATUSDATE = value.DATA.ORDER_STATUSDATE;
                obj.ORDER_STATUS = value.DATA.ORDER_STATUS;
                obj.STATUS_NAME = value.DATA.STATUS_NAME;
                obj.LOCALION_CURRENTLY = value.DATA.LOCALION_CURRENTLY;
                obj.NOTE = value.DATA.NOTE;
                obj.MONEY_COLLECTION = value.DATA.MONEY_COLLECTION;
                obj.MONEY_FEECOD = value.DATA.MONEY_FEECOD;
                obj.MONEY_TOTAL = value.DATA.MONEY_TOTAL;
                obj.EXPECTED_DELIVERY = value.DATA.EXPECTED_DELIVERY;
                obj.PRODUCT_WEIGHT = value.DATA.PRODUCT_WEIGHT;
                obj.ORDER_SERVICE = value.DATA.ORDER_SERVICE;

                result = Bussiness.VTP.Insert(obj);
                 
            }
            if (result >= 0) return HttpStatusCode.OK;
            else return HttpStatusCode.BadRequest; 
        }

        // PUT: api/VTP/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/VTP/5
        public void Delete(int id)
        {
        }
    }
}
