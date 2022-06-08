using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class InsiderController : ApiController
    {
        // GET: api/Insider_Email
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Insider_Email/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Insider/UserFlow
        [HttpPost]
        [Route("api/Insider/UserFlow")]
        public void Create_Processed(DataObjects.Insider.UserFlow value)
        {
            DataObjects.Insider.XML xml = new DataObjects.Insider.XML();
            xml.email = value.email;
            xml.name = value.name;
            xml.phone_number = value.phone_number;
            xml.last_visit_product = value.last_visit_product;
            xml.last_add_to_cart_poduct = value.last_add_to_cart_poduct;
            Bussiness.Insider.Create(xml);
        }

        // POST: api/Insider/Processed
        [HttpPost]
        [Route("api/Insider/Processed")]
        public void Create_Processed(DataObjects.Insider_Email.Processed value)
        {
            DataObjects.Insider_Email.XML xml = new DataObjects.Insider_Email.XML();
            xml.timestamp =  value.timestamp;
            xml.@event = value.@event;
            xml.email = value.email;
            xml.campaign_name = value.campaign_name;
            xml.variation_id = value.variation_id;
            xml.subject = value.subject;
            xml.link_clicked = "";
            xml.iid = value.iid;

            Bussiness.Insider_Email.Create(xml);
        }

        // POST: api/Insider/Delivered
        [HttpPost]
        [Route("api/Insider/Delivered")]
        public void Create_Delivered(DataObjects.Insider_Email.Delivered value)
        {
            DataObjects.Insider_Email.XML xml = new DataObjects.Insider_Email.XML();
            xml.timestamp = value.timestamp;
            xml.@event = value.@event;
            xml.email = value.email;
            xml.campaign_name = value.campaign_name;
            xml.variation_id = value.variation_id;
            xml.subject = value.subject;
            xml.link_clicked = "";
            xml.iid = value.iid;

            Bussiness.Insider_Email.Create(xml);
        }

        // POST: api/Insider/Blocked
        [HttpPost]
        [Route("api/Insider/Blocked")]
        public void Create_Blocked(DataObjects.Insider_Email.Blocked value)
        {
            DataObjects.Insider_Email.XML xml = new DataObjects.Insider_Email.XML();
            xml.timestamp = value.timestamp;
            xml.@event = value.@event;
            xml.email = value.email;
            xml.campaign_name = value.campaign_name;
            xml.variation_id = value.variation_id;
            xml.subject = value.subject;
            xml.link_clicked = "";
            xml.iid = value.iid;

            Bussiness.Insider_Email.Create(xml);
        }


        // POST: api/Insider/Bounced
        [HttpPost]
        [Route("api/Insider/Bounced")]
        public void Create_Bounced(DataObjects.Insider_Email.Bounced value)
        {
            DataObjects.Insider_Email.XML xml = new DataObjects.Insider_Email.XML();
            xml.timestamp = value.timestamp;
            xml.@event = value.@event;
            xml.email = value.email;
            xml.campaign_name = value.campaign_name;
            xml.variation_id = value.variation_id;
            xml.subject = value.subject;
            xml.link_clicked = "";
            xml.iid = value.iid;

            Bussiness.Insider_Email.Create(xml);
        }


        // POST: api/Insider/Open
        [HttpPost]
        [Route("api/Insider/Open")]
        public void Create_Open(DataObjects.Insider_Email.Open value)
        {
            DataObjects.Insider_Email.XML xml = new DataObjects.Insider_Email.XML();
            xml.timestamp = value.timestamp;
            xml.@event = value.@event;
            xml.email = value.email;
            xml.campaign_name = value.campaign_name;
            xml.variation_id = value.variation_id;
            xml.subject = value.subject;
            xml.link_clicked = "";
            xml.iid = value.iid;

            Bussiness.Insider_Email.Create(xml);
        }

        // POST: api/Insider/Click
        [HttpPost]
        [Route("api/Insider/Click")]
        public void Create_Click(DataObjects.Insider_Email.Click value)
        {
            DataObjects.Insider_Email.XML xml = new DataObjects.Insider_Email.XML();
            xml.timestamp = value.timestamp;
            xml.@event = value.@event;
            xml.email = value.email;
            xml.campaign_name = value.campaign_name;
            xml.variation_id = value.variation_id;
            xml.subject = value.subject;
            xml.link_clicked = value.link_clicked;
            xml.iid = value.iid;

            Bussiness.Insider_Email.Create(xml);
        }

        // POST: api/Insider/Unsubscribe
        [HttpPost]
        [Route("api/Insider/Unsubscribe")]
        public void Create_Unsubscribe(DataObjects.Insider_Email.Unsubscribe value)
        {
            DataObjects.Insider_Email.XML xml = new DataObjects.Insider_Email.XML();
            xml.timestamp = value.timestamp;
            xml.@event = value.@event;
            xml.email = value.email;
            xml.campaign_name = value.campaign_name;
            xml.variation_id = value.variation_id;
            xml.subject = value.subject;
            xml.link_clicked = "";
            xml.iid = value.iid;

            Bussiness.Insider_Email.Create(xml);
        }

        // POST: api/Insider/Deferred
        [HttpPost]
        [Route("api/Insider/Deferred")]
        public void Create_Deferred(DataObjects.Insider_Email.Deferred value)
        {
            DataObjects.Insider_Email.XML xml = new DataObjects.Insider_Email.XML();
            xml.timestamp = value.timestamp;
            xml.@event = value.@event;
            xml.email = value.email;
            xml.campaign_name = value.campaign_name;
            xml.variation_id = value.variation_id;
            xml.subject = value.subject;
            xml.link_clicked = "";
            xml.iid = value.iid;

            Bussiness.Insider_Email.Create(xml);
        }

        // PUT: api/Insider_Email/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Insider_Email/5
        public void Delete(int id)
        {
        }
    }
}
