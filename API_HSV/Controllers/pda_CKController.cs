using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class pda_CKController : ApiController
    {
        // GET: api/pda_CK
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/pda_CK/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/pda_CK
        public int Post(DataObjects.PDA.PDA_CK obj)
        {
            return Bussiness.PDA.CreateCK(obj);
        }

        // PUT: api/pda_CK/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/pda_CK/5
        public void Delete(int id)
        {
        }
    }
}
