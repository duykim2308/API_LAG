using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class pda_POController : ApiController
    {
        // GET: api/pda_PO
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/pda_PO/5
        public List<DataObjects.PDA.PDA_PO> Get(string id)
        {
            List<DataObjects.PDA.PDA_PO> lsArray = new List<DataObjects.PDA.PDA_PO>();
            try
            {
                lsArray = Bussiness.PDA.GetPO(id, "");
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return lsArray;
        }

        public List<DataObjects.PDA.PDA_PO> Get(string id, string id2)
        {
            List<DataObjects.PDA.PDA_PO> lsArray = new List<DataObjects.PDA.PDA_PO>();
            try
            {
                lsArray = Bussiness.PDA.GetPO(id, id2);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lsArray;
        }

        // POST: api/pda_PO
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/pda_PO/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/pda_PO/5
        public void Delete(int id)
        {
        }
    }
}
