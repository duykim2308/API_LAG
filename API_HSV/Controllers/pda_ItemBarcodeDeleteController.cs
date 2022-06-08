using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class pda_ItemBarcodeDeleteController : ApiController
    {
        // GET: api/pda_ItemBarcodeDelete
        public List<int> Get()
        {
            //List<DataObjects.PDA.PDA_ItemBarcode> lsArray = new List<DataObjects.PDA.PDA_ItemBarcode>();
            List<int> lsArray = new List<int>();
            try
            {
                lsArray = Bussiness.PDA.DeleteItemBarcode();
            }
            catch (Exception ex)
            {

            }
            return lsArray;
        }

        // GET: api/pda_ItemBarcodeDelete/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/pda_ItemBarcodeDelete
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/pda_ItemBarcodeDelete/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/pda_ItemBarcodeDelete/5
        public void Delete(int id)
        {
        }
    }
}
