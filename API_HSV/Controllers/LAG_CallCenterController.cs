using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class LAG_CallCenterController : ApiController
    {
        // GET: api/LAG_CallCenter
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/LAG_CallCenter/5
        public string Get(int id)
        {
            return "value";
        }
        /*        
         secret_key = edd415986d686a2a3155932ec2fdb7fe
         <callback_url>?secret=<secret_key>&callstatus=Start&calluuid=1512439806.4165&direction=inbound&callernumber=0912345678&destinationnumber=8888&starttime=20171205T091023&dnis=1900000&calltype=Inbound_ACD&version=4&queue=8888
         <callback_url>?secret=<secret_key>&callstatus=Dialing&calluuid=1512439826.4230&direction=inbound&callernumber=0912345678&destinationnumber=105&starttime=20171205T091026&parentcalluuid=1512439806.4165&agentname=105&starttime=20171205T091026&version=4
         <callback_url>?secret=<secret_key>&callstatus=DialAnswer&calluuid=1512439806.4165&childcalluuid=1512439826.4230&callernumber=0912345678&destinationnumber=105&version=4
         <callback_url>?secret=<secret_key>&callstatus=CDR&calluuid=1512439806.4165&starttime=20171205T091006&answertime=20171205T091007&endtime=20171205T091034&billduration=27&totalduration=28&disposition=ANSWERED&monitorfilename=<record_file_name>&version=4
         <callback_url>?secret=<secret_key>&callstatus=Trim&calluuid=1512439826.4230&version=4
         <callback_url>?secret=<secret_key>&callstatus=HangUp&calluuid=1512439806.4165&datereceived=20171205T091035&causetxt=16&context=bG9jYWw%3D&version=4
         <callback_url>?secret=<secret_key>&callstatus=SyncCurCalls&calluuids=&version=4
        */

        // GET: api/LAG_CallCenter
        [HttpGet]
        [Route("api/LAG_CallCenter")]
        public HttpStatusCode GetStart(string secret)
        {
            return HttpStatusCode.OK; 
        }

        // GET: api/LAG_CallCenter
        [HttpGet]
        [Route("api/LAG_CallCenter")]
        public HttpStatusCode GetStart(string secret, string callstatus, string calluuid, string direction, string callernumber, string destinationnumber, string starttime
            , string dnis, string calltype, string version, string queue)
        {
            int result = 0;
            DataObjects.LAG.STEL_CallCenterXML obj = new DataObjects.LAG.STEL_CallCenterXML();
            if (secret == ConfigurationManager.AppSettings["stel_secret"].ToString())
            {
                obj.direction = direction;
                obj.callstatus = callstatus;
                obj.workstatus = "";
                obj.starttime = DateTime.ParseExact(starttime, "yyyyMMddTmmssff", CultureInfo.InvariantCulture);
                obj.answertime = null ; ;
                obj.totalduration = 0;
                obj.billduration = 0;
                obj.calluuid = calluuid;
                obj.user = "";
                obj.userextension = queue;
                obj.customer = "";
                obj.customernumber = destinationnumber;
                obj.customertype = "";
                obj.customercode = "";
                obj.calltype = calltype;
                obj.disposition = "";
                obj.dnis = dnis;
                obj.causetxt = "";
                result = Bussiness.LAG.STEL_CallCenter.Create(obj);
            }
            if (result >= 0) return HttpStatusCode.OK;
            else return HttpStatusCode.BadRequest;
        }

        // GET: api/LAG_CallCenter
        [HttpGet]
        [Route("api/LAG_CallCenter")]
        public HttpStatusCode GetDialing(string secret, string callstatus, string calluuid, string direction, string callernumber, string destinationnumber, string calltype
            , string parentcalluuid, string agentname, string starttime, string version)
        {
            int result = 0;
            DataObjects.LAG.STEL_CallCenterXML obj = new DataObjects.LAG.STEL_CallCenterXML();
            if (secret == ConfigurationManager.AppSettings["stel_secret"].ToString())
            {
                obj.direction = direction;
                obj.callstatus = callstatus;
                obj.workstatus = "";
                obj.starttime = DateTime.ParseExact(starttime, "yyyyMMddTmmssff", CultureInfo.InvariantCulture);
                obj.answertime = null;
                obj.totalduration = 0;
                obj.billduration = 0;
                obj.calluuid = calluuid;
                obj.user = "";
                obj.userextension = "";
                obj.customer = "";
                obj.customernumber = callernumber;
                obj.customertype = "";
                obj.customercode = "";
                obj.calltype = calltype;
                obj.disposition = "";
                obj.dnis = "";
                obj.causetxt = "";
                result = Bussiness.LAG.STEL_CallCenter.Create(obj);
            }
            if (result >= 0) return HttpStatusCode.OK;
            else return HttpStatusCode.BadRequest;
        }

        // GET: api/LAG_CallCenter
        [HttpGet]
        [Route("api/LAG_CallCenter")]
        public HttpStatusCode GetDialAnswer(string secret, string callstatus, string calluuid, string childcalluuid, string callernumber, string destinationnumber, string version)
        {
            int result = 0;
            DataObjects.LAG.STEL_CallCenterXML obj = new DataObjects.LAG.STEL_CallCenterXML();
            if (secret == ConfigurationManager.AppSettings["stel_secret"].ToString())
            {
                obj.direction = "";
                obj.callstatus = callstatus;
                obj.workstatus = "";
                obj.starttime = null;
                obj.answertime = null;
                obj.totalduration = 0;
                obj.billduration = 0;
                obj.calluuid = calluuid;
                obj.user = "";
                obj.userextension = "";
                obj.customer = "";
                obj.customernumber = callernumber;
                obj.customertype = "";
                obj.customercode = "";
                obj.calltype = "";
                obj.disposition = "";
                obj.dnis = "";
                obj.causetxt = "";
                result = Bussiness.LAG.STEL_CallCenter.Create(obj);
            }
            if (result >= 0) return HttpStatusCode.OK;
            else return HttpStatusCode.BadRequest;
        }

        // GET: api/LAG_CallCenter
        [HttpGet]
        [Route("api/LAG_CallCenter")]
        public HttpStatusCode GetCDR(string secret, string callstatus, string calluuid, string starttime, string answertime, int billduration, int totalduration
            , string disposition, string monitorfilename, string version)
        {
            int result = 0;
            DataObjects.LAG.STEL_CallCenterXML obj = new DataObjects.LAG.STEL_CallCenterXML();
            if (secret == ConfigurationManager.AppSettings["stel_secret"].ToString())
            {
                obj.direction = "";
                obj.callstatus = callstatus;
                obj.workstatus = "";
                obj.starttime = DateTime.ParseExact(starttime, "yyyyMMddTmmssff", CultureInfo.InvariantCulture);
                obj.answertime = DateTime.ParseExact(answertime, "yyyyMMddTmmssff", CultureInfo.InvariantCulture);
                obj.totalduration = totalduration;
                obj.billduration = billduration;
                obj.calluuid = calluuid;
                obj.user = "";
                obj.userextension = "";
                obj.customer = "";
                obj.customernumber = "";
                obj.customertype = "";
                obj.customercode = "";
                obj.calltype = "";
                obj.disposition = disposition;
                obj.dnis = "";
                obj.causetxt = monitorfilename;
                result = Bussiness.LAG.STEL_CallCenter.Create(obj);
            }
            if (result >= 0) return HttpStatusCode.OK;
            else return HttpStatusCode.BadRequest;
        }

        // GET: api/LAG_CallCenter
        [HttpGet]
        [Route("api/LAG_CallCenter")]
        public HttpStatusCode GetTrim(string secret, string callstatus, string calluuid, string version)
        {
            int result = 0;
            DataObjects.LAG.STEL_CallCenterXML obj = new DataObjects.LAG.STEL_CallCenterXML();
            if (secret == ConfigurationManager.AppSettings["stel_secret"].ToString())
            {
                obj.direction = "";
                obj.callstatus = callstatus;
                obj.workstatus = "";
                obj.starttime = null;
                obj.answertime = null;
                obj.totalduration = 0;
                obj.billduration = 0;
                obj.calluuid = calluuid;
                obj.user = "";
                obj.userextension = "";
                obj.customer = "";
                obj.customernumber = "";
                obj.customertype = "";
                obj.customercode = "";
                obj.calltype = "";
                obj.disposition = "";
                obj.dnis = "";
                obj.causetxt = "";
                result = Bussiness.LAG.STEL_CallCenter.Create(obj);
            }
            if (result >= 0) return HttpStatusCode.OK;
            else return HttpStatusCode.BadRequest;
        }

        // GET: api/LAG_CallCenter
        [HttpGet]
        [Route("api/LAG_CallCenter")]
        public HttpStatusCode GetHangUp(string secret, string callstatus, string calluuid, string datereceived
            , string causetxt, string context, string version)
        {
            int result = 0;
            DataObjects.LAG.STEL_CallCenterXML obj = new DataObjects.LAG.STEL_CallCenterXML();
            if (secret == ConfigurationManager.AppSettings["stel_secret"].ToString())
            {
                obj.direction = "";
                obj.callstatus = callstatus;
                obj.workstatus = "";
                obj.starttime = DateTime.ParseExact(datereceived, "yyyyMMddTmmssff", CultureInfo.InvariantCulture);
                obj.answertime = null;
                obj.totalduration = 0;
                obj.billduration = 0;
                obj.calluuid = calluuid;
                obj.user = "";
                obj.userextension = "";
                obj.customer = "";
                obj.customernumber = "";
                obj.customertype = "";
                obj.customercode = "";
                obj.calltype = "";
                obj.disposition = "";
                obj.dnis = "";
                obj.causetxt = causetxt;
                result = Bussiness.LAG.STEL_CallCenter.Create(obj);
            }
            if (result >= 0) return HttpStatusCode.OK;
            else return HttpStatusCode.BadRequest;
        }


        // POST: api/LAG_CallCenter
        [HttpPost]
        [Route("api/LAG_CallCenter")]
        public HttpStatusCode Post(DataObjects.LAG.STEL_CallCenter value)
        {
            int result = 0;
            DataObjects.LAG.STEL_CallCenterXML obj = new DataObjects.LAG.STEL_CallCenterXML();
            if (value != null)
            {
                obj.worldfonepbxmanagerid = value.worldfonepbxmanagerid;
                obj.direction = value.direction;
                obj.callstatus = value.callstatus;
                obj.workstatus = value.workstatus;
                obj.starttime = value.starttime;
                obj.answertime = value.answertime;
                obj.totalduration = value.totalduration;
                obj.billduration = value.billduration;
                obj.calluuid = value.calluuid;
                obj.user = value.user;
                obj.userextension = value.userextension;
                obj.customer = value.customer;
                obj.customernumber = value.customernumber;
                obj.customertype = value.customertype;
                obj.customercode = value.customercode;
                obj.calltype = value.calltype;
                obj.disposition = value.disposition;
                obj.dnis = value.dnis;
                obj.causetxt = value.causetxt;

                result = Bussiness.LAG.STEL_CallCenter.Create(obj);
            }
            if (result >= 0) return HttpStatusCode.OK;
            else return HttpStatusCode.BadRequest;
        }

        // PUT: api/LAG_CallCenter/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/LAG_CallCenter/5
        public void Delete(int id)
        {
        }
    }
}
