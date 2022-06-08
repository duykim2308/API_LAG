using Bussiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class pda_ItemBarcodeController : ApiController
    {
        // GET: api/pda_ItemBarcode
        public List<DataObjects.PDA.PDA_ItemBarcode> Get()
        {
            List<DataObjects.PDA.PDA_ItemBarcode> array = new List<DataObjects.PDA.PDA_ItemBarcode>();
            array = Bussiness.PDA.GetItemBarcode("");
            return array;
        }

        // GET: api/pda_ItemBarcode/5
        public List<DataObjects.PDA.PDA_ItemBarcode> Get(string id)
        {
            List<DataObjects.PDA.PDA_ItemBarcode> array = new List<DataObjects.PDA.PDA_ItemBarcode>();
            array = Bussiness.PDA.GetItemBarcode(id);
            return array;
        }

        // POST: api/pda_ItemBarcode
        public DataObjects.PDA.PDA_Status Post(DataObjects.PDA.PDA_ItemBarcode obj)
        {
            DataObjects.PDA.PDA_Status status = new DataObjects.PDA.PDA_Status();
                if (Bussiness.PDA.CreateItemBarcode(obj) == 1)
                {
                    status.ID = 1;
                    status.Name = "Thành công";
                }
                else
                {
                    status.ID = 2;
                    status.Name = "Thất bại";
                }
            return status;
        }

        // PUT: api/pda_ItemBarcode/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/pda_ItemBarcode/5
        public void Delete(int id)
        {
        }
    }
}
