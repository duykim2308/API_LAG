using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class pda_SOHeaderController : ApiController
    {
        // GET: api/pda_SOHeader
        public List<DataObjects.PDA.PDA_SOHeader> Get()
        {
            List<DataObjects.PDA.PDA_SOHeader> array = new List<DataObjects.PDA.PDA_SOHeader>();
            array = Bussiness.PDA.GetSOHeader(DateTime.Now, DateTime.Now, "");
            return array;
        }

        // GET: api/pda_SOHeader/5
        public List<DataObjects.PDA.PDA_SOHeader> Get(string id)
        {
            List<DataObjects.PDA.PDA_SOHeader> array = new List<DataObjects.PDA.PDA_SOHeader>();
            array = Bussiness.PDA.GetSOHeader(DateTime.Now, DateTime.Now, "");
            return array;
        }

        // POST: api/pda_SOHeader
        public List<DataObjects.PDA.PDA_SOHeader> Post(DataObjects.PDA.PDA_SOHeader obj)
        {
            List<DataObjects.PDA.PDA_SOHeader> lsArray = new List<DataObjects.PDA.PDA_SOHeader>();
            try
            {
                lsArray = Bussiness.PDA.GetSOHeader(obj.inputSO.FromDate, obj.inputSO.ToDate, obj.inputSO.StockID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lsArray;
        }

        // PUT: api/pda_SOHeader/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/pda_SOHeader/5
        public void Delete(int id)
        {
        }
    }
}
