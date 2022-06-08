using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class pda_KKController : ApiController
    {
        // GET: api/pda_KK
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/pda_KK/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/pda_KK
        public int Post(List<DataObjects.PDA.PDA_KK> obj)
        {
            return Bussiness.PDA.CreateKK(obj);
        }

        // PUT: api/pda_KK/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/pda_KK/5
        public void Delete(int id)
        {
        }
    }
}
