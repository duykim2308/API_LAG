using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class HaravanController : ApiController
    {
        // GET: api/Haravan
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Haravan/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Haravan

        #region Order

        [HttpPost]
        [Route("api/Haravan/Order/Create")]
        public void CreateOrder(DataObjects.HRV.Order value)
        {
            //string postData = Newtonsoft.Json.JsonConvert.SerializeObject(value, Newtonsoft.Json.Formatting.Indented, new Newtonsoft.Json.JsonSerializerSettings()
            //{
            //    ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
            //});
            //Utilities.FileLog.WriteFileLog("DataAccess-->sp_HRV_Order_CreateXML-->CreateOrder::" + postData);

            Bussiness.HRV.Order.CreateXML(value);
        }


        [HttpPut]
        [Route("api/Haravan/Order/Update")]
        public void UpdateOrder(DataObjects.HRV.Order value)
        {
            //string postData = Newtonsoft.Json.JsonConvert.SerializeObject(value, Newtonsoft.Json.Formatting.Indented, new Newtonsoft.Json.JsonSerializerSettings()
            //{
            //    ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
            //});
            //Utilities.FileLog.WriteFileLog("DataAccess-->sp_HRV_Order_CreateXML-->UpdateOrder::" + postData);

            Bussiness.HRV.Order.CreateXML(value);
        }

        [HttpPut]
        [Route("api/Haravan/Order/Cancel")]
        public void CancelOrder(DataObjects.HRV.Order value)
        {
            //string postData = Newtonsoft.Json.JsonConvert.SerializeObject(value, Newtonsoft.Json.Formatting.Indented, new Newtonsoft.Json.JsonSerializerSettings()
            //{
            //    ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
            //});
            //Utilities.FileLog.WriteFileLog("DataAccess-->sp_HRV_Order_CreateXML-->CancelOrder::" + postData);

            Bussiness.HRV.Order.CreateXML(value);
        }

        #endregion

        #region Product

        [HttpPost]
        [Route("api/Haravan/Product/Create")]
        public void CreateProduct(DataObjects.HRV.ProductWebhook value)
        {
            //string postData = Newtonsoft.Json.JsonConvert.SerializeObject(value, Newtonsoft.Json.Formatting.Indented, new Newtonsoft.Json.JsonSerializerSettings()
            //{
            //    ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
            //});
            //Utilities.FileLog.WriteFileLog("DataAccess-->sp_HRV_Order_CreateXML-->CreateProduct::" + postData);

            DataObjects.HRV.Product product = new DataObjects.HRV.Product();
            product.body_html = value.body_html; 
            product.created_at = value.created_at;
            product.handle = value.handle;
            product.id = value.id;
            product.images = value.images;
            product.product_type = value.product_type;
            product.published_at = value.published_at;
            product.published_scope = value.published_scope;
            product.tags = value.tags;
            product.template_suffix = value.template_suffix;
            product.title = value.title;
            product.updated_at = value.updated_at;
            product.variants = value.variants;
            product.vendor = value.vendor;
            product.options = value.options;
            product.only_hide_from_list = value.only_hide_from_list; 
            List<DataObjects.HRV.Product> lsArray = new List<DataObjects.HRV.Product>();
            lsArray.Add(product);
            Bussiness.HRV.Product.Create(lsArray);
        }

        [HttpPut]
        [Route("api/Haravan/Product/Update")]
        public void UpdateProduct(DataObjects.HRV.ProductWebhook value)
        {
            string postData = Newtonsoft.Json.JsonConvert.SerializeObject(value, Newtonsoft.Json.Formatting.Indented, new Newtonsoft.Json.JsonSerializerSettings()
            {
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
            });
            Utilities.FileLog.WriteFileLog("DataAccess-->sp_HRV_Product_CreateXML-->UpdateProduct::" + postData);

            DataObjects.HRV.Product product = new DataObjects.HRV.Product();
            product.body_html = value.body_html;
            product.created_at = value.created_at;
            product.handle = value.handle;
            product.id = value.id;
            product.images = value.images;
            product.product_type = value.product_type;
            product.published_at = value.published_at;
            product.published_scope = value.published_scope;
            product.tags = value.tags;
            product.template_suffix = value.template_suffix;
            product.title = value.title;
            product.updated_at = value.updated_at;
            product.variants = value.variants;
            product.vendor = value.vendor;
            product.options = value.options;
            product.only_hide_from_list = value.only_hide_from_list;
            List<DataObjects.HRV.Product> lsArray = new List<DataObjects.HRV.Product>();
            lsArray.Add(product);
            Bussiness.HRV.Product.Create(lsArray);
        }

        [HttpDelete]
        [Route("api/Haravan/Product/Delete")]
        public void DeleteProduct(object value)
        {
            string postData = Newtonsoft.Json.JsonConvert.SerializeObject(value, Newtonsoft.Json.Formatting.Indented, new Newtonsoft.Json.JsonSerializerSettings()
            {
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
            });
            Utilities.FileLog.WriteFileLog("DataAccess-->sp_HRV_Order_CreateXML-->DeleteProduct::" + postData);

            //List<DataObjects.HRV.Product> lsArray = new List<DataObjects.HRV.Product>();
            //lsArray.AddRange(value.products);

            //Bussiness.HRV.Product.Create(lsArray);
        }

        #endregion







    }
}
