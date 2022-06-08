using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class pda_ItemBarcodeFilterController : ApiController
    {
        // GET: api/pda_ItemBarcodeFilter
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/pda_ItemBarcodeFilter/5
        public List<DataObjects.PDA.PDA_ItemBarcode> Get(int id)
        {
            List<DataObjects.PDA.PDA_ItemBarcode> array = new List<DataObjects.PDA.PDA_ItemBarcode>();
            array = Bussiness.PDA.GetItemBarcodeFilter(id);
            return array;
        }

        // POST: api/pda_ItemBarcodeFilter
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/pda_ItemBarcodeFilter/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/pda_ItemBarcodeFilter/5
        public void Delete(int id)
        {
        }
    }
}
