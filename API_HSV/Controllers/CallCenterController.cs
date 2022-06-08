using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    [OverrideAuthentication]
    public class CallCenterController : ApiController
    {
        // GET: api/CallCenter
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

       
        [HttpGet]
        [Route("api/CallCenter/call_in")] 
        public int GetInComing(string phone, string extension, string callid)
        {
            if (Bussiness.CallCenter.Create(phone, extension, callid, 0, "", "") > 0)
                return 200;
            else
                return 404;
        }
         
        [HttpGet]
        [Route("api/CallCenter/hangup")]
        public int GetHangUp(string callid)
        {
            if (Bussiness.CallCenter.Create("", "", callid, 0, "", "") > 0)
                return 200;
            else
                return 404;
        }

        [HttpGet]
        [Route("api/CallCenter/calldata")]
        public int GetCallDat(string callid, string calldate, int duration, string status, string extension, string phone, string recordingfile)
        {
            if (Bussiness.CallCenter.Create("", "", callid, duration, status, recordingfile) > 0)
                return 200;
            else
                return 404;
        }

        // POST: api/CallCenter
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/CallCenter/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/CallCenter/5
        public void Delete(int id)
        {
        }
    }
}
