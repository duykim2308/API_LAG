using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class AX_TrackingSerialController : ApiController
    {
        // GET: api/AXTrackingSerial
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        //http://erpapi.liena.vn:8082/api/AXTrackingSerial/080220037680
        [HttpGet]
        [Route("api/AXTrackingSerial/{search}")]
        public DataObjects.LAG.AX_TrackingSerial GetTrackingSerial(string search)
        {
            return Bussiness.LAG.AX_TrackingSerial.Get(search);
        }

        // POST: api/AXTrackingSerial
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/AXTrackingSerial/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/AXTrackingSerial/5
        public void Delete(int id)
        {
        }
    }
}
