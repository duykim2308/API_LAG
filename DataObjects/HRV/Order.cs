using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects.HRV
{
    public class Order
    {
        public BillingAddress billing_address { get; set; }
        public string browser_ip { get; set; }
        public bool buyer_accepts_marketing { get; set; }
        public string cancel_reason { get; set; }
        public string cancelled_at { get; set; }
        public string cart_token { get; set; }
        public string checkout_token { get; set; }
        public ClientDetails client_details { get; set; }
        public string closed_at { get; set; }
        public string created_at { get; set; }
        public string currency { get; set; }
        public Customer customer { get; set; }
        public IList<DiscountCode> discount_codes { get; set; }
        public string email { get; set; }
        public string financial_status { get; set; }
        public IList<Fulfillments> fulfillments { get; set; }
        public string fulfillment_status { get; set; }
        public string tags { get; set; }
        public string gateway { get; set; }
        public string gateway_code { get; set; }
        public int id { get; set; }
        public string landing_site { get; set; }
        public object landing_site_ref { get; set; }
        public string source { get; set; }
        public IList<LineItem> line_items { get; set; }
        public string name { get; set; }
        public string note { get; set; }
        public int number { get; set; }
        public string order_number { get; set; }
        public object processing_method { get; set; }
        public string referring_site { get; set; }
        public IList<object> refunds { get; set; }
        public ShippingAddress shipping_address { get; set; }
        public IList<ShippingLine> shipping_lines { get; set; }
        public string source_name { get; set; }
        public double subtotal_price { get; set; }
        public object tax_lines { get; set; }
        public bool taxes_included { get; set; }
        public string token { get; set; }
        public double total_discounts { get; set; }
        public double total_line_items_price { get; set; }
        public double total_price { get; set; }
        public double total_tax { get; set; }
        public double total_weight { get; set; }
        public string updated_at { get; set; }
        public IList<Transaction> transactions { get; set; }
        public IList<object> note_attributes { get; set; }
        public string confirmed_at { get; set; }
        public string closed_status { get; set; }
        public string cancelled_status { get; set; }
        public string confirmed_status { get; set; }
        public int user_id { get; set; }
        public object device_id { get; set; }
        public int location_id { get; set; }
        public int ref_order_id { get; set; }
        public object ref_order_number { get; set; }
        public string utm_source { get; set; }
        public string utm_medium { get; set; }
        public string utm_campaign { get; set; }
        public string utm_term { get; set; }
        public string utm_content { get; set; }
        public object redeem_model { get; set; }

        public void ResetShippingAddress()
        {
            if (this.shipping_address != null)
            {
                if (this.billing_address != null)
                {
                    if (this.shipping_address.address1 == null || this.shipping_address.address1.Trim() == "")
                        this.shipping_address.address1 = this.billing_address.address1;
                    if (this.shipping_address.address2 == null || this.shipping_address.address2.ToString().Trim() == "")
                        this.shipping_address.address2 = this.billing_address.address2;
                    if (this.shipping_address.city == null || this.shipping_address.city.Trim() == "")
                        this.shipping_address.city = this.billing_address.city;
                    if (this.shipping_address.company == null || this.shipping_address.company.ToString().Trim() == "")
                        this.shipping_address.company = this.billing_address.company;
                    if (this.shipping_address.country == null || this.shipping_address.country.Trim() == "")
                        this.shipping_address.country = this.billing_address.country;
                    if (this.shipping_address.first_name == null || this.shipping_address.first_name.Trim() == "")
                        this.shipping_address.first_name = this.billing_address.first_name;
                    if (this.shipping_address.last_name == null || this.shipping_address.last_name.Trim() == "")
                        this.shipping_address.last_name = this.billing_address.last_name;
                    if (this.shipping_address.phone == null || this.shipping_address.phone.Trim() == "")
                        this.shipping_address.phone = this.billing_address.phone;
                    if (this.shipping_address.province == null || this.shipping_address.province.Trim() == "")
                        this.shipping_address.province = this.billing_address.province;
                    if (this.shipping_address.zip == null || this.shipping_address.zip.Trim() == "")
                        this.shipping_address.zip = this.billing_address.zip;
                    if (this.shipping_address.name == null || this.shipping_address.name.Trim() == "")
                        this.shipping_address.name = this.billing_address.name;
                    if (this.shipping_address.province_code == null || this.shipping_address.province_code.Trim() == "")
                        this.shipping_address.province_code = this.billing_address.province_code;
                    if (this.shipping_address.country_code == null || this.shipping_address.country_code.Trim() == "")
                        this.shipping_address.country_code = this.billing_address.country_code;
                    if (this.shipping_address.district_code == null || this.shipping_address.district_code.Trim() == "")
                        this.shipping_address.district_code = this.billing_address.district_code;
                    if (this.shipping_address.district == null || this.shipping_address.district.Trim() == "")
                        this.shipping_address.district = this.billing_address.district;

                }
            }
        }

    }
}
