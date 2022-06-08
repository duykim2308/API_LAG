using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class pda_ItemController : ApiController
    {
        // GET: api/Item
        public List<DataObjects.PDA.PDA_Item> Get()
        {
            List<DataObjects.PDA.PDA_Item> lsArray = new List<DataObjects.PDA.PDA_Item>();
            try
            {
                lsArray = Bussiness.PDA.GetItem("");
            }
            catch (Exception ex)
            {

            }
            return lsArray;
        }

        // GET: api/Item/5
        public List<DataObjects.PDA.PDA_Item> Get(string id)
        {
            List<DataObjects.PDA.PDA_Item> lsArray = new List<DataObjects.PDA.PDA_Item>();
            try
            {
                lsArray = Bussiness.PDA.GetItem(id);
            }
            catch (Exception ex)
            {

            }
            return lsArray;
        }

        // POST: api/Item
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Item/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Item/5
        public void Delete(int id)
        {
        }
    }
}
