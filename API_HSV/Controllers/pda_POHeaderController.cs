using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class pda_POHeaderController : ApiController
    {
        // GET: api/pda_POHeader
        public List<DataObjects.PDA.PDA_POHeader> Get()
        {
            List<DataObjects.PDA.PDA_POHeader> lsArray = new List<DataObjects.PDA.PDA_POHeader>();
            try
            {
                lsArray = Bussiness.PDA.GetPOHeader(DateTime.Now, DateTime.Now, "");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lsArray;
        }

        // GET: api/pda_POHeader/5
        public List<DataObjects.PDA.PDA_POHeader> Get(string stockid)
        {
            List<DataObjects.PDA.PDA_POHeader> lsArray = new List<DataObjects.PDA.PDA_POHeader>();
            try
            {
                lsArray = Bussiness.PDA.GetPOHeader(DateTime.Now, DateTime.Now, stockid);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lsArray;
        }

        // POST: api/pda_POHeader
        public List<DataObjects.PDA.PDA_POHeader> Post(DataObjects.PDA.PDA_POHeader obj)
        {
            List<DataObjects.PDA.PDA_POHeader> lsArray = new List<DataObjects.PDA.PDA_POHeader>();
            try
            {
                lsArray = Bussiness.PDA.GetPOHeader(obj.inputPO.FromDate, obj.inputPO.ToDate, obj.inputPO.StockID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lsArray;
        }

        // PUT: api/pda_POHeader/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/pda_POHeader/5
        public void Delete(int id)
        {
        }
    }
}
