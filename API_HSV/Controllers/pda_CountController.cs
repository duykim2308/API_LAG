using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class pda_CountController : ApiController
    {
        // GET: api/pda_Count
        public List<DataObjects.PDA.PDA_Count> Get()
        {
            List<DataObjects.PDA.PDA_Count> pDA_Counts = new List<DataObjects.PDA.PDA_Count>();
            pDA_Counts = Bussiness.PDA.GetCount();
            return pDA_Counts;
        }

        // GET: api/pda_Count/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/pda_Count
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/pda_Count/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/pda_Count/5
        public void Delete(int id)
        {
        }
    }
}
