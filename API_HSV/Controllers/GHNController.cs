using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class GHNController : ApiController
    {
        // GET: api/GHN
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/GHN/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/GHN
        [HttpPost]
        [Route("api/GHN")]
        public HttpStatusCode Post(DataObjects.GHN value)
        {
            int result = 0;
            DataObjects.GHNXML obj = new DataObjects.GHNXML();
            if(value != null)
            {
                obj.Company = "VSTYLE";
                obj.OrderCode = value.OrderCode;
                obj.Description = value.OrderCode;
                obj.CODAmount = value.CODAmount;
                obj.CODTransferDate = value.CODTransferDate.Year < 1900 ? default(DateTime?) : DateTime.Parse(value.CODTransferDate.ToString());
                obj.Reason = value.Reason;
                obj.ReasonCode = value.ReasonCode;
                obj.ShipperName = value.ShipperName;
                obj.ShipperPhone = value.ShipperPhone;
                obj.Status = value.Status;
                obj.Time = value.Time;
                obj.TotalFee = value.TotalFee;
                obj.Type = value.Type;
                obj.Warehouse = value.Warehouse;

                result = Bussiness.GHN.Insert(obj);
            }
            if (result >= 0) return HttpStatusCode.OK;
            else return HttpStatusCode.BadRequest; 
        }

        // PUT: api/GHN/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/GHN/5
        public void Delete(int id)
        {
        }
    }
}
