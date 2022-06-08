using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class pda_ErrorController : ApiController
    {
        // GET: api/pda_Error
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/pda_Error/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/pda_Error
        public int Post(List<DataObjects.PDA.PDA_Error> obj)
        {
            return Bussiness.PDA.CreateError(obj);
        }

        // PUT: api/pda_Error/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/pda_Error/5
        public void Delete(int id)
        {
        }
    }
}
