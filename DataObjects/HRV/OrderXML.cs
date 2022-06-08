using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects.HRV
{
    public class OrderXML
    {
        public int id { get; set; }
        public string order_number { get; set; }
        public string name { get; set; }
        public string note { get; set; }
        public string tags { get; set; }
        public string closed_at { get; set; }
        public string created_at { get; set; }
        public string cancelled_at { get; set; }
        public string updated_at { get; set; }
        public string confirmed_at { get; set; }
        public string closed_status { get; set; }
        public string financial_status { get; set; }
        public string fulfillment_status { get; set; }
        public string gateway_code { get; set; }
        public double subtotal_price { get; set; }
        public double total_discounts { get; set; }
        public double total_line_items_price { get; set; }
        public double total_price { get; set; }
        public double total_tax { get; set; }
        public double total_weight { get; set; }
        public string cancelled_status { get; set; }
        public string confirmed_status { get; set; }
        public string Comments { get; set; }
        public string CommentsName { get; set; }
        public string source { get; set; }
        public string source_name { get; set; }
        public int ref_order_id { get; set; }
        public string utm_source { get; set; }
        public string utm_medium { get; set; }
        public string utm_campaign { get; set; }
        public string utm_term { get; set; }
        public string utm_content { get; set; }

        public List<ShippingLine> ShippingLines { get; set; }
        public List<LineItem> LineItems { get; set; }
        public List<Fulfillment> Fulfillments { get; set; }
        public List<DiscountCode> DiscountCodes { get; set; }
        public List<Transaction> Transactions { get; set; }

        public ShippingAddress Shipping { get; set; }
        public Customer Customers { get; set; }
        public ClientDetail ClientDetails { get; set; }

        public OrderXML()
        {

        }

        public OrderXML(Order order)
        {
            this.id = order.id;
            this.order_number = order.order_number;
            this.name = order.name;
            this.note = order.note;
            this.tags = order.tags;
            this.closed_at = order.closed_at;
            this.created_at = order.created_at;
            this.cancelled_at = order.cancelled_at;
            this.updated_at = order.updated_at;
            this.confirmed_at = order.confirmed_at;
            this.closed_status = order.closed_status;
            this.financial_status = order.financial_status;
            this.fulfillment_status = order.fulfillment_status;
            this.gateway_code = order.gateway_code;
            this.subtotal_price = order.subtotal_price;
            this.total_discounts = order.total_discounts;
            this.total_line_items_price = order.total_line_items_price;
            this.total_price = order.total_price;
            this.total_tax = order.total_tax;
            this.total_weight = order.total_weight;
            this.cancelled_status = order.cancelled_status;
            this.confirmed_status = order.confirmed_status;
            //this.Comments = order.Comments;
            //this.CommentsName = order.CommentsName;
            this.source = order.source;
            this.source_name = order.source_name;
            this.ref_order_id = order.ref_order_id;
            this.utm_source = order.utm_source;
            this.utm_medium = order.utm_medium;
            this.utm_campaign = order.utm_campaign;
            this.utm_term = order.utm_term;
            this.utm_content = order.utm_content;

            //ShippingLines = new List<ShippingLine>();
            //foreach (DMS.DataObjects.HRV.ShippingLine item in order.shipping_lines)
            //    this.ShippingLines.Add(new ShippingLine(order.id, item));

            LineItems = new List<LineItem>();
            foreach (DataObjects.HRV.LineItem item in order.line_items)
                this.LineItems.Add(new LineItem(order.id, item));

            Fulfillments = new List<Fulfillment>();
            foreach (DataObjects.HRV.Fulfillments item in order.fulfillments)
                this.Fulfillments.Add(new Fulfillment(item));

            DiscountCodes = new List<DiscountCode>();
            foreach (DataObjects.HRV.DiscountCode item in order.discount_codes)
                this.DiscountCodes.Add(new DiscountCode(order.id, item));

            Transactions = new List<Transaction>();
            foreach (DataObjects.HRV.Transaction item in order.transactions)
                this.Transactions.Add(new Transaction(item));

            Shipping = new ShippingAddress(order.id, order.shipping_address);
            Customers = new Customer(order.id, order.customer);
            ClientDetails = new ClientDetail(order.id, order.client_details);
        }

        public class ShippingLine
        {
            public int order_id { get; set; }
            public string code { get; set; }
            public double price { get; set; }
            public string title { get; set; }


            public ShippingLine()
            {

            }
            public ShippingLine(int _order_id, DataObjects.HRV.ShippingLine line)
            {
                this.order_id = _order_id;
                this.code = line.code;
                this.price = line.price;
                this.title = line.title;

            }
        }

        public class LineItem
        {
            public double id { get; set; }
            public double order_id { get; set; }
            public int fulfillable_quantity { get; set; }
            public string fulfillment_status { get; set; }
            public double grams { get; set; }
            public double price { get; set; }
            public double price_original { get; set; }
            public string product_id { get; set; }
            public int quantity { get; set; }
            public bool requires_shipping { get; set; }
            public string sku { get; set; }
            public string title { get; set; }
            public string variant_id { get; set; }
            public string variant_title { get; set; }
            public string vendor { get; set; }
            public string name { get; set; }
            public bool gift_card { get; set; }
            public bool taxable { get; set; }

            public LineItem()
            {

            }

            public LineItem(int _order_id, DataObjects.HRV.LineItem lineItem)
            {
                this.id = lineItem.id;
                this.order_id = _order_id;
                this.fulfillable_quantity = lineItem.fulfillable_quantity;
                this.fulfillment_status = lineItem.fulfillment_status;
                this.grams = lineItem.grams;
                this.price = lineItem.price;
                this.price_original = lineItem.price_original;
                this.product_id = lineItem.product_id;
                this.quantity = lineItem.quantity;
                this.requires_shipping = lineItem.requires_shipping;
                this.sku = lineItem.sku;
                this.title = lineItem.title;
                this.variant_id = lineItem.variant_id;
                this.variant_title = lineItem.variant_title;
                this.vendor = lineItem.vendor;
                this.name = lineItem.name;
                this.gift_card = lineItem.gift_card;
                this.taxable = lineItem.taxable;
            }
        }

        public class Fulfillment
        {
            public string created_at { get; set; }
            public int id { get; set; }
            public int order_id { get; set; }
            public string status { get; set; }
            public string tracking_company { get; set; }
            public string tracking_number { get; set; }
            public string tracking_url { get; set; }
            public string updated_at { get; set; }
            public bool notify_customer { get; set; }
            public string district_code { get; set; }
            public double cod_amount { get; set; }
            public string carrier_status_name { get; set; }
            public string carrier_cod_status_name { get; set; }

            public Fulfillment()
            {

            }

            public Fulfillment(DataObjects.HRV.Fulfillments fulfillment)
            {
                this.created_at = fulfillment.created_at;
                this.id = fulfillment.id;
                this.order_id = fulfillment.order_id;
                this.status = fulfillment.status;
                this.tracking_company = fulfillment.tracking_company;
                this.tracking_number = fulfillment.tracking_number;
                this.tracking_url = fulfillment.tracking_url;
                this.updated_at = fulfillment.updated_at;
                this.notify_customer = fulfillment.notify_customer;
                this.district_code = fulfillment.district_code;
                this.cod_amount = fulfillment.cod_amount;
                this.carrier_status_name = fulfillment.carrier_status_name;
                this.carrier_cod_status_name = fulfillment.carrier_cod_status_name;
            }
        }

        public class DiscountCode
        {
            public int order_id { get; set; }
            public double amount { get; set; }
            public string code { get; set; }
            public string type { get; set; }
            public string typecode { get; set; }
            public DiscountCode()
            {

            }

            public DiscountCode(int _order_id, DataObjects.HRV.DiscountCode code)
            {
                this.order_id = _order_id;
                this.amount = code.amount;
                this.code = code.code;
                this.type = code.type;
            }
        }

        public class Transaction
        {
            public double amount { get; set; }
            public string created_at { get; set; }
            public string gateway { get; set; }
            public int id { get; set; }
            public string kind { get; set; }
            public int order_id { get; set; }
            public bool test { get; set; }
            public int user_id { get; set; }
            public int parent_id { get; set; }
            public string currency { get; set; }
            public string haravan_transaction_id { get; set; }
            public string external_transaction_id { get; set; }
            public Transaction()
            {

            }

            public Transaction(DataObjects.HRV.Transaction transaction)
            {
                this.amount = transaction.amount;
                this.created_at = transaction.created_at;
                this.gateway = transaction.gateway;
                this.id = transaction.id;
                this.kind = transaction.kind;
                this.order_id = transaction.order_id;
                this.test = transaction.test;
                this.user_id = transaction.user_id;
                this.parent_id = transaction.parent_id != null ? transaction.parent_id.Value : 0;
                this.currency = transaction.currency;
                this.haravan_transaction_id = transaction.haravan_transaction_id;
                this.external_transaction_id = transaction.external_transaction_id;
            }
        }

        public class ShippingAddress
        {
            public int order_id { get; set; }
            public string address1 { get; set; }
            public string address2 { get; set; }
            public string city { get; set; }
            public string company { get; set; }
            public string country { get; set; }
            public string first_name { get; set; }
            public string last_name { get; set; }
            public string latitude { get; set; }
            public string longitude { get; set; }
            public string phone { get; set; }
            public string province { get; set; }
            public string zip { get; set; }
            public string name { get; set; }
            public string province_code { get; set; }
            public string country_code { get; set; }
            public string district_code { get; set; }
            public string district { get; set; }
            public string ward { get; set; }
            public string ward_code { get; set; }
            public ShippingAddress()
            {

            }

            public ShippingAddress(int _order_id, DataObjects.HRV.ShippingAddress shipping)
            {
                this.order_id = _order_id;
                this.address1 = shipping.address1;
                this.address2 = shipping.address2;
                this.city = shipping.city;
                this.company = shipping.company;
                this.country = shipping.country;
                this.first_name = shipping.first_name;
                this.last_name = shipping.last_name;
                this.latitude = shipping.latitude;
                this.longitude = shipping.longitude;
                this.phone = shipping.phone;
                this.province = shipping.province;
                this.zip = shipping.zip;
                this.name = shipping.name;
                this.province_code = shipping.province_code;
                this.country_code = shipping.country_code;
                this.district_code = shipping.district_code;
                this.district = shipping.district;
                this.ward = shipping.ward;
                this.ward_code = shipping.ward_code;
            }
        }

        public class Customer
        {
            public int order_id { get; set; }
            public string address1 { get; set; }
            public string company { get; set; }
            public string country { get; set; }
            public string first_name { get; set; }
            public int id { get; set; }
            public string last_name { get; set; }
            public string phone { get; set; }
            public string province { get; set; }
            public string zip { get; set; }
            public string name { get; set; }
            public string province_code { get; set; }
            public string country_code { get; set; }
            public string district { get; set; }
            public string district_code { get; set; }
            public bool accepts_marketing { get; set; }
            public string created_at { get; set; }
            public string email { get; set; }
            public int? last_order_id { get; set; }
            public string last_order_name { get; set; }
            public string note { get; set; }
            public int orders_count { get; set; }
            public string state { get; set; }
            public double total_spent { get; set; }
            public string updated_at { get; set; }
            public bool verified_email { get; set; }
            public bool send_email_invite { get; set; }
            public bool send_email_welcome { get; set; }

            public Customer()
            {

            }

            public Customer(int _order_id, DataObjects.HRV.Customer customer)
            {
                if (customer.addresses.Count > 0)
                {
                    DataObjects.HRV.Address addresses = customer.addresses.OrderByDescending(ob => ob.id).First();
                    this.address1 = addresses.address1;
                    this.company = addresses.company;
                    this.country = addresses.country;
                    this.phone = addresses.phone;
                    this.province = addresses.province;
                    this.zip = addresses.zip;
                    this.name = addresses.name;
                    this.province_code = addresses.province_code;
                    this.country_code = addresses.country_code;
                    this.district = addresses.district;
                    this.district_code = addresses.district_code;
                }
                this.order_id = _order_id;
                this.first_name = customer.first_name;
                this.id = customer.id;
                this.last_name = customer.last_name;
                this.accepts_marketing = customer.accepts_marketing;
                this.created_at = customer.created_at;
                this.email = customer.email;
                this.last_order_id = customer.last_order_id;
                this.last_order_name = customer.last_order_name;
                this.note = customer.note;
                this.orders_count = customer.orders_count;
                this.state = customer.state;
                this.total_spent = customer.total_spent;
                this.updated_at = customer.updated_at;
                this.verified_email = customer.verified_email;
                this.send_email_invite = customer.send_email_invite;
                this.send_email_welcome = customer.send_email_welcome;
            }
        }

        public class ClientDetail
        {
            public int order_id { get; set; }
            public object accept_language { get; set; }
            public string browser_ip { get; set; }
            public object session_hash { get; set; }
            public object user_agent { get; set; }
            public object browser_height { get; set; }
            public object browser_width { get; set; }

            public ClientDetail()
            {

            }

            public ClientDetail(int _order_id, DataObjects.HRV.ClientDetails client)
            {
                this.order_id = _order_id;
                this.browser_ip = client.browser_ip;
                this.session_hash = client.session_hash;
                this.user_agent = client.user_agent;
                this.browser_height = client.browser_height;
                this.browser_width = client.browser_width;
            }
        }
    }
}
