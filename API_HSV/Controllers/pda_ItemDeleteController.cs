using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class pda_ItemDeleteController : ApiController
    {
        // GET: api/pda_ItemDelete
        public List<DataObjects.PDA.PDA_Item> Get()
        {
            List<DataObjects.PDA.PDA_Item> lsArray = new List<DataObjects.PDA.PDA_Item>();
            try
            {
                lsArray = Bussiness.PDA.DeleteItem();
            }
            catch (Exception ex)
            {

            }
            return lsArray;
        }

        // GET: api/pda_ItemDelete/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/pda_ItemDelete
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/pda_ItemDelete/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/pda_ItemDelete/5
        public void Delete(int id)
        {
        }
    }
}
