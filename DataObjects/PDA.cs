using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects
{
    public class PDA
    {
        public class PDA_ItemBarcode
        {
            public int ID { get; set; }
            public string Company { get; set; }
            public string Barcode { get; set; }
            public string ProductID { get; set; }
            public string Variant { get; set; }
            public string Unit { get; set; }
            public string ProductName { get; set; }
            public string Size { get; set; }
            public string UserID { get; set; }
            public string PDAID { get; set; }

            public PDA_ItemBarcode()
            {
                ID = 0;
                Company = "";
                Barcode = "";
                ProductID = "";
                Variant = "";
                Unit = "";
                ProductName = "";
                Size = "";
                UserID = "";
                PDAID = "";
            }

            public PDA_ItemBarcode(System.Data.DataRow row)
            {
                ID = Int32.Parse(row["ID"].ToString());
                Company = row["Company"].ToString();
                Barcode = row["Barcode"].ToString();
                ProductID = row["ProductID"].ToString();
                Variant = row["Variant"].ToString();
                Unit = row["Unit"].ToString();
                ProductName = row["ProductName"].ToString();
                Size = row["Size"].ToString();
                UserID = row["UserID"].ToString();
                PDAID = row["PDAID"].ToString();
            }

        }

        public class PDA_Barcode
        {
            public int ID { get; set; }
            public string Company { get; set; }
            public string Barcode { get; set; }
            public string ProductID { get; set; }
            public string Variant { get; set; }
            public string Unit { get; set; }
            public string ProductName { get; set; }
            public string Size { get; set; }
            public string UserID { get; set; }
            public string PDAID { get; set; }

            public PDA_Barcode()
            {
                ID = 0;
                Company = "";
                Barcode = "";
                ProductID = "";
                Variant = "";
                Unit = "";
                ProductName = "";
                Size = "";
                UserID = "";
                PDAID = "";
            }

            public PDA_Barcode(System.Data.DataRow row)
            {
                ID = Int32.Parse(row["ID"].ToString());
                Company = row["Company"].ToString();
                Barcode = row["Barcode"].ToString();
                ProductID = row["ProductID"].ToString();
                Variant = row["Variant"].ToString();
                Unit = row["Unit"].ToString();
                ProductName = row["ProductName"].ToString();
                Size = row["Size"].ToString();
                UserID = row["UserID"].ToString();
                PDAID = row["PDAID"].ToString();
            }

        }

        public class PDA_Item
        {
            public int ID { get; set; }
            public string ProductID { get; set; }
            public string Variant { get; set; }
            public string ProductType { get; set; }
            public string ProductName { get; set; }
            public string Unit { get; set; }
            public string Size { get; set; }


            public PDA_Item()
            {
                ID = 0;
                ProductID = "";
                Variant = "";
                ProductType = "";
                ProductName = "";
                Unit = "";
                Size = "";

            }

            public PDA_Item(System.Data.DataRow row)
            {
                ID = Int32.Parse(row["ID"].ToString());
                ProductID = row["ProductID"].ToString();
                Variant = row["Variant"].ToString();
                ProductType = row["ProductType"].ToString();
                ProductName = row["ProductName"].ToString();
                Unit = row["Unit"].ToString();
                Size = row["Size"].ToString();
            }

        }

        public class PDA_Location
        {
            public string Company { get; set; }
            public string StockID { get; set; }
            public string StockName { get; set; }
            public string StockType { get; set; }
            public Boolean Active { get; set; }


            public PDA_Location()
            {
                Company = "";
                StockID = "";
                StockName = "";
                StockType = "";
                Active = true;

            }

            public PDA_Location(System.Data.DataRow row)
            {
                Company = row["Company"].ToString();
                StockID = row["StockID"].ToString();
                StockName = row["StockName"].ToString();
                StockType = row["StockType"].ToString();
                Active = row["Active"].ToString() == "1" ? true : false;
            }

        }

        public class PDA_Status
        {
            public int ID { get; set; }
            public string Name { get; set; }

            public PDA_Status()
            {
                ID = 0;
                Name = "";
            }
        }

        public class PDA_User
        {
            public string UserID { get; set; }
            public string UserName { get; set; }
            public string Password { get; set; }
            public bool Active { get; set; }

            public PDA_User()
            {
                UserID = "";
                UserName = "";
                Password = "";
                Active = true;
            }

            public PDA_User(System.Data.DataRow row)
            {
                UserID = row["UserID"].ToString();
                UserName = row["UserName"].ToString();
                Password = row["Password"].ToString();
                Active = Boolean.Parse(row["Active"].ToString());
            }

        }

        public class PDA_Count
        {
            public string Title { get; set; }
            public float Count { get; set; }
            public float MaxID { get; set; }

            public PDA_Count()
            {
                Title = "";
                Count = 0;
                MaxID = 0;
            }

            public PDA_Count(System.Data.DataRow row)
            {
                Title = row["Title"].ToString();
                Count = float.Parse(row["Count"].ToString());
                MaxID = float.Parse(row["MaxID"].ToString());
            }

        }

        public class PDA_Error
        {
            public string IDError { get; set; }
            public string NameError { get; set; }
            public string Description { get; set; }
            public string UserID { get; set; }
            public string PDAID { get; set; }
            public DateTime CreateDate { get; set; }
            public bool Active { get; set; }

            public PDA_Error()
            {
                IDError = "";
                NameError = "";
                Description = "";
                UserID = "";
                PDAID = "";
                CreateDate = DateTime.Now;
                Active = true;
            }

            public PDA_Error(System.Data.DataRow row)
            {
                IDError = row["IDError"].ToString();
                NameError = row["NameError"].ToString();
                Description = row["Description"].ToString();
                UserID = row["UserID"].ToString();
                PDAID = row["PDAID"].ToString();
                CreateDate = row["CreateDate"].ToString() != "" ? Convert.ToDateTime(row["CreateDate"]) : DateTime.Now;
                Active = row["Active"].ToString() == "0" ? false : true;
            }

        }

        public class PDA_KK
        {
            public string KK_ID { get; set; }
            public DateTime KK_Date { get; set; }
            public string PDAID { get; set; }
            public string UserID { get; set; }
            public string StockID { get; set; }
            public string BinID { get; set; }
            public string ProductID { get; set; }
            public string Variant { get; set; }
            public string Barcode { get; set; }
            public string Unit { get; set; }
            public decimal Quantity { get; set; }
            public string Description { get; set; }
            public string Image { get; set; }
            public string CreateByUser { get; set; }
            public DateTime CreateDate { get; set; }

            public PDA_KK()
            {
                KK_ID = "";
                KK_Date = DateTime.Now;
                PDAID = "";
                UserID = "";
                StockID = "";
                BinID = "";
                ProductID = "";
                Variant = "";
                Barcode = "";
                Unit = "";
                Quantity = 0;
                Description = "";
                Image = "";
                CreateByUser = "";
                CreateDate = DateTime.Now;
            }

            public PDA_KK(System.Data.DataRow row)
            {
                KK_ID = row["KK_ID"].ToString();
                KK_Date = row["KK_Date"].ToString() != "" ? Convert.ToDateTime(row["KK_Date"]) : DateTime.Now;
                PDAID = row["PDAID"].ToString();
                UserID = row["UserID"].ToString();
                StockID = row["StockID"].ToString();
                BinID = row["BinID"].ToString();
                ProductID = row["ProductID"].ToString();
                Variant = row["Variant"].ToString();
                Barcode = row["Barcode"].ToString();
                Unit = row["Unit"].ToString();
                Quantity = row["Quantity"].ToString() != "" ? decimal.Parse(row["Quantity"].ToString()) : 0;
                Description = row["Description"].ToString();
                Image = row["Image"].ToString();
                CreateByUser = row["CreateByUser"].ToString();
                CreateDate = row["CreateDate"].ToString() != "" ? Convert.ToDateTime(row["CreateDate"]) : DateTime.Now;
            }

        }

        public class PDA_NK
        {
            public string NK_ID { get; set; }
            public string PO_ID { get; set; }
            public string NK_Type { get; set; }
            public string NK_Name { get; set; }
            public DateTime NK_Date { get; set; }
            public string UserID { get; set; }
            public string PDAID { get; set; }
            public string StockID { get; set; }
            public string ProviderID { get; set; }
            public string ProviderName { get; set; }
            public string Barcode { get; set; }
            public decimal TotalQuantity { get; set; }
            public int Status { get; set; }
            public string Description { get; set; }
            public string CreateByUser { get; set; }
            public DateTime CreateDate { get; set; }
            public string ModifyByUser { get; set; }
            public DateTime ModifyDate { get; set; }
            public Boolean Active { get; set; }

            public List<PDA_NKDetail> NKDetail { get; set; }

            public class PDA_NKDetail
            {
                public string NK_ID { get; set; }
                public int NK_Line { get; set; }
                public string ProductID { get; set; }
                public string Variant { get; set; }
                public string ProductType { get; set; }
                public string ProductName { get; set; }
                public string Barcode { get; set; }
                public decimal Quantity { get; set; }
                public string Unit { get; set; }
                public string Description { get; set; }
                public string Image { get; set; }
                public string CreateByUser { get; set; }
                public DateTime CreateDate { get; set; }
                public string ModifyByUser { get; set; }
                public DateTime ModifyDate { get; set; }
                public Boolean Active { get; set; }
            }

            public PDA_NK()
            {
                NK_ID = "";
                PO_ID = "";
                NK_Type = "";
                NK_Name = "";
                NK_Date = DateTime.Now;
                UserID = "";
                StockID = "";
                PDAID = "";
                ProviderID = "";
                ProviderName = "";
                Barcode = "";
                TotalQuantity = 0;
                Status = 0;
                Description = "";
                CreateByUser = "";
                CreateDate = DateTime.Now;
                ModifyByUser = "";
                ModifyDate = DateTime.Now;
                Active = true;

                NKDetail = new List<PDA_NKDetail>();
            }

            public PDA_NK(System.Data.DataRow row)
            {
                NK_ID = row["NK_ID"].ToString();
                PO_ID = row["PO_ID"].ToString();
                NK_Type = row["NK_Type"].ToString();
                NK_Name = row["NK_Name"].ToString();
                NK_Date = row["NK_Date"].ToString() != "" ? Convert.ToDateTime(row["NK_Date"]) : DateTime.Now;
                StockID = row["StockID"].ToString();
                ProviderID = row["ProviderID"].ToString();
                ProviderName = row["ProviderName"].ToString();
                Barcode = row["Barcode"].ToString();
                TotalQuantity = row["TotalQuantity"].ToString() != "" ? decimal.Parse(row["TotalQuantity"].ToString()) : 0;
                Status = row["Status"].ToString() != "" ? Int32.Parse(row["Status"].ToString()) : 0;
                Description = row["Description"].ToString();
                CreateByUser = row["CreateByUser"].ToString();
                CreateDate = row["CreateDate"].ToString() != "" ? Convert.ToDateTime(row["CreateDate"]) : DateTime.Now;
                ModifyByUser = row["ModifyByUser"].ToString();
                ModifyDate = row["ModifyDate"].ToString() != "" ? Convert.ToDateTime(row["ModifyDate"]) : DateTime.Now;
                Active = Boolean.Parse(row["Active"].ToString());

                NKDetail = new List<PDA_NKDetail>();
            }
        }

        public class PDA_CK
        {
            public string CK_ID { get; set; }
            public string TO_ID { get; set; }
            public string CK_Type { get; set; }
            public string CK_Name { get; set; }
            public DateTime CK_Date { get; set; }
            public string UserID { get; set; }
            public string PDAID { get; set; }
            public string StockIn { get; set; }
            public string StockOut { get; set; }
            public string Barcode { get; set; }
            public decimal TotalQuantity { get; set; }
            public int Status { get; set; }
            public string Description { get; set; }
            public string CreateByUser { get; set; }
            public DateTime CreateDate { get; set; }
            public string ModifyByUser { get; set; }
            public DateTime ModifyDate { get; set; }
            public Boolean Active { get; set; }

            public List<PDA_CKDetail> CKDetail { get; set; }

            public class PDA_CKDetail
            {
                public string CK_ID { get; set; }
                public int CK_Line { get; set; }
                public string ProductID { get; set; }
                public string Variant { get; set; }
                public string ProductType { get; set; }
                public string ProductName { get; set; }
                public string Barcode { get; set; }
                public decimal Quantity { get; set; }
                public string Unit { get; set; }
                public string Description { get; set; }
                public string Image { get; set; }
                public string CreateByUser { get; set; }
                public DateTime CreateDate { get; set; }
                public string ModifyByUser { get; set; }
                public DateTime ModifyDate { get; set; }
                public Boolean Active { get; set; }
            }

            public PDA_CK()
            {
                CK_ID = "";
                TO_ID = "";
                CK_Type = "";
                CK_Name = "";
                CK_Date = DateTime.Now;
                UserID = "";
                PDAID = "";
                StockIn = "";
                StockOut = "";
                Barcode = "";
                TotalQuantity = 0;
                Status = 0;
                Description = "";
                CreateByUser = "";
                CreateDate = DateTime.Now;
                ModifyByUser = "";
                ModifyDate = DateTime.Now;
                Active = true;

                CKDetail = new List<PDA_CKDetail>();
            }

            public PDA_CK(System.Data.DataRow row)
            {
                CK_ID = row["CK_ID"].ToString();
                TO_ID = row["TO_ID"].ToString();
                CK_Type = row["CK_Type"].ToString();
                CK_Name = row["CK_Name"].ToString();
                CK_Date = row["CK_Date"].ToString() != "" ? Convert.ToDateTime(row["CK_Date"]) : DateTime.Now;
                StockIn = row["StockIn"].ToString();
                StockOut = row["StockOut"].ToString();
                Barcode = row["Barcode"].ToString();
                TotalQuantity = row["TotalQuantity"].ToString() != "" ? decimal.Parse(row["TotalQuantity"].ToString()) : 0;
                Status = row["Status"].ToString() != "" ? Int32.Parse(row["Status"].ToString()) : 0;
                Description = row["Description"].ToString();
                CreateByUser = row["CreateByUser"].ToString();
                CreateDate = row["CreateDate"].ToString() != "" ? Convert.ToDateTime(row["CreateDate"]) : DateTime.Now;
                ModifyByUser = row["ModifyByUser"].ToString();
                ModifyDate = row["ModifyDate"].ToString() != "" ? Convert.ToDateTime(row["ModifyDate"]) : DateTime.Now;
                Active = Boolean.Parse(row["Active"].ToString());

                CKDetail = new List<PDA_CKDetail>();
            }
        }

        public class PDA_XK
        {
            public string XK_ID { get; set; }
            public string SO_ID { get; set; }
            public string XK_Type { get; set; }
            public string XK_Name { get; set; }
            public DateTime XK_Date { get; set; }
            public string UserID { get; set; }
            public string PDAID { get; set; }
            public string StockID { get; set; }
            public string CustomerID { get; set; }
            public string CustomerName { get; set; }
            public string Barcode { get; set; }
            public decimal TotalQuantity { get; set; }
            public int Status { get; set; }
            public string Description { get; set; }
            public string CreateByUser { get; set; }
            public DateTime CreateDate { get; set; }
            public string ModifyByUser { get; set; }
            public DateTime ModifyDate { get; set; }
            public Boolean Active { get; set; }

            public List<PDA_XKDetail> XKDetail { get; set; }

            public class PDA_XKDetail
            {
                public string XK_ID { get; set; }
                public int XK_Line { get; set; }
                public string ProductID { get; set; }
                public string Variant { get; set; }
                public string ProductType { get; set; }
                public string ProductName { get; set; }
                public string Barcode { get; set; }
                public decimal Quantity { get; set; }
                public string Unit { get; set; }
                public string Description { get; set; }
                public string Image { get; set; }
                public string CreateByUser { get; set; }
                public DateTime CreateDate { get; set; }
                public string ModifyByUser { get; set; }
                public DateTime ModifyDate { get; set; }
                public Boolean Active { get; set; }
            }

            public PDA_XK()
            {
                XK_ID = "";
                SO_ID = "";
                XK_Type = "";
                XK_Name = "";
                XK_Date = DateTime.Now;
                UserID = "";
                StockID = "";
                PDAID = "";
                CustomerID = "";
                CustomerName = "";
                Barcode = "";
                TotalQuantity = 0;
                Status = 0;
                Description = "";
                CreateByUser = "";
                CreateDate = DateTime.Now;
                ModifyByUser = "";
                ModifyDate = DateTime.Now;
                Active = true;

                XKDetail = new List<PDA_XKDetail>();
            }

            public PDA_XK(System.Data.DataRow row)
            {
                XK_ID = row["XK_ID"].ToString();
                SO_ID = row["SO_ID"].ToString();
                XK_Type = row["XK_Type"].ToString();
                XK_Name = row["XK_Name"].ToString();
                XK_Date = row["XK_Date"].ToString() != "" ? Convert.ToDateTime(row["XK_Date"]) : DateTime.Now;
                StockID = row["StockID"].ToString();
                CustomerID = row["CustomerID"].ToString();
                CustomerName = row["CustomerName"].ToString();
                Barcode = row["Barcode"].ToString();
                TotalQuantity = row["TotalQuantity"].ToString() != "" ? decimal.Parse(row["TotalQuantity"].ToString()) : 0;
                Status = row["Status"].ToString() != "" ? Int32.Parse(row["Status"].ToString()) : 0;
                Description = row["Description"].ToString();
                CreateByUser = row["CreateByUser"].ToString();
                CreateDate = row["CreateDate"].ToString() != "" ? Convert.ToDateTime(row["CreateDate"]) : DateTime.Now;
                ModifyByUser = row["ModifyByUser"].ToString();
                ModifyDate = row["ModifyDate"].ToString() != "" ? Convert.ToDateTime(row["ModifyDate"]) : DateTime.Now;
                Active = row["Active"].ToString() == "1" ? true : false;

                XKDetail = new List<PDA_XKDetail>();
            }
        }

        public class PDA_TOHeader
        {
            public string TO_ID { get; set; }
            public string TO_Type { get; set; }
            public string TO_Name { get; set; }
            public DateTime TO_Date { get; set; }
            public string StockIn { get; set; }
            public string StockOut { get; set; }
            public string Barcode { get; set; }
            public decimal TotalQuantity { get; set; }
            public int Status { get; set; }
            public string Description { get; set; }
            public string CreateByUser { get; set; }
            public DateTime CreateDate { get; set; }
            public string ModifyByUser { get; set; }
            public DateTime ModifyDate { get; set; }
            public Boolean Active { get; set; }

            public PDA_TOHeader()
            {
                TO_ID = "";
                TO_Type = "";
                TO_Name = "";
                TO_Date = DateTime.Now;
                StockIn = "";
                StockOut = "";
                Barcode = "";
                TotalQuantity = 0;
                Status = 0;
                Description = "";
                CreateByUser = "";
                CreateDate = DateTime.Now;
                ModifyByUser = "";
                ModifyDate = DateTime.Now;
                Active = true;

            }

            public PDA_TOHeader(System.Data.DataRow row)
            {
                TO_ID = row["TO_ID"].ToString();
                TO_Type = row["TO_Type"].ToString();
                TO_Name = row["TO_Name"].ToString();
                TO_Date = row["TO_Date"].ToString() != "" ? Convert.ToDateTime(row["TO_Date"]) : DateTime.Now;
                StockIn = row["StockIn"].ToString();
                StockOut = row["StockOut"].ToString();
                Barcode = row["Barcode"].ToString();
                TotalQuantity = row["TotalQuantity"].ToString() != "" ? decimal.Parse(row["TotalQuantity"].ToString()) : 0;
                Status = row["Status"].ToString() != "" ? Int32.Parse(row["Status"].ToString()) : 0;
                Description = row["Description"].ToString();
                CreateByUser = row["CreateByUser"].ToString();
                CreateDate = row["CreateDate"].ToString() != "" ? Convert.ToDateTime(row["CreateDate"]) : DateTime.Now;
                ModifyByUser = row["ModifyByUser"].ToString();
                ModifyDate = row["ModifyDate"].ToString() != "" ? Convert.ToDateTime(row["ModifyDate"]) : DateTime.Now;
                Active = Boolean.Parse(row["Active"].ToString());
            }

        }

        public class PDA_TO
        {
            public string TO_ID { get; set; }
            public string TO_Type { get; set; }
            public string TO_Name { get; set; }
            public DateTime TO_Date { get; set; }
            public string StockIn { get; set; }
            public string StockOut { get; set; }
            public string Barcode { get; set; }
            public decimal TotalQuantity { get; set; }
            public int Status { get; set; }
            public string Description { get; set; }
            public string CreateByUser { get; set; }
            public DateTime CreateDate { get; set; }
            public string ModifyByUser { get; set; }
            public DateTime ModifyDate { get; set; }
            public Boolean Active { get; set; }

            public List<PDA_TO_Detail> TO_Detail { get; set; }

            public class PDA_TO_Detail
            {
                public string TO_ID { get; set; }
                public int TO_Line { get; set; }
                public string StockIn { get; set; }
                public string StockOut { get; set; }
                public string ProductID { get; set; }
                public string Variant { get; set; }
                public string ProductName { get; set; }
                public string Barcode { get; set; }
                public decimal Quantity { get; set; }
                public string Unit { get; set; }
                public string Description { get; set; }
                public string CreateByUser { get; set; }
                public DateTime CreateDate { get; set; }
                public string ModifyByUser { get; set; }
                public DateTime ModifyDate { get; set; }
                public Boolean Active { get; set; }



                public PDA_TO_Detail(System.Data.DataRow row)
                {
                    TO_ID = row["TO_ID"].ToString();
                    TO_Line = row["TO_Line"].ToString() != "" ? Int32.Parse(row["TO_Line"].ToString()) : 0;
                    StockIn = row["StockIn"].ToString();
                    StockOut = row["StockOut"].ToString();
                    ProductID = row["ProductID"].ToString();
                    Variant = row["Variant"].ToString();
                    ProductName = row["ProductName"].ToString();
                    Barcode = row["Barcode"].ToString();
                    Quantity = row["Quantity"].ToString() != "" ? decimal.Parse(row["Quantity"].ToString()) : 0;
                    Unit = row["Unit"].ToString();
                    Description = row["Description"].ToString();
                    CreateByUser = row["CreateByUser"].ToString();
                    CreateDate = row["CreateDate"].ToString() != "" ? Convert.ToDateTime(row["CreateDate"]) : DateTime.Now;
                    ModifyByUser = row["ModifyByUser"].ToString();
                    ModifyDate = row["ModifyDate"].ToString() != "" ? Convert.ToDateTime(row["ModifyDate"]) : DateTime.Now;
                    Active = Boolean.Parse(row["Active"].ToString());

                }

            }

            public PDA_TO()
            {
                TO_ID = "";
                TO_Type = "";
                TO_Name = "";
                TO_Date = DateTime.Now;
                StockIn = "";
                StockOut = "";
                Barcode = "";
                TotalQuantity = 0;
                Status = 0;
                Description = "";
                CreateByUser = "";
                CreateDate = DateTime.Now;
                ModifyByUser = "";
                ModifyDate = DateTime.Now;
                Active = true;

                TO_Detail = new List<PDA_TO_Detail>();
            }

            public PDA_TO(System.Data.DataRow row)
            {
                TO_ID = row["TO_ID"].ToString();
                TO_Type = row["TO_Type"].ToString();
                TO_Name = row["TO_Name"].ToString();
                TO_Date = row["TO_Date"].ToString() != "" ? Convert.ToDateTime(row["TO_Date"]) : DateTime.Now;
                StockIn = row["StockIn"].ToString();
                StockOut = row["StockOut"].ToString();
                Barcode = row["Barcode"].ToString();
                TotalQuantity = row["TotalQuantity"].ToString() != "" ? decimal.Parse(row["TotalQuantity"].ToString()) : 0;
                Status = row["Status"].ToString() != "" ? Int32.Parse(row["Status"].ToString()) : 0;
                Description = row["Description"].ToString();
                CreateByUser = row["CreateByUser"].ToString();
                CreateDate = row["CreateDate"].ToString() != "" ? Convert.ToDateTime(row["CreateDate"]) : DateTime.Now;
                ModifyByUser = row["ModifyByUser"].ToString();
                ModifyDate = row["ModifyDate"].ToString() != "" ? Convert.ToDateTime(row["ModifyDate"]) : DateTime.Now;
                Active = Boolean.Parse(row["Active"].ToString());
                TO_Detail = new List<PDA_TO_Detail>();
            }

        }

        public class PDA_SOHeader
        {


            public InputSOHeader inputSO { get; set; }

            public string SO_ID { get; set; }
            public string SO_Type { get; set; }
            public string SO_Name { get; set; }
            public DateTime SO_Date { get; set; }
            public string StockID { get; set; }
            public string ProviderID { get; set; }
            public string ProviderName { get; set; }
            public string Barcode { get; set; }
            public decimal TotalQuantity { get; set; }
            public int Status { get; set; }
            public string Description { get; set; }
            public string CreateByUser { get; set; }
            public DateTime CreateDate { get; set; }
            public string ModifyByUser { get; set; }
            public DateTime ModifyDate { get; set; }
            public Boolean Active { get; set; }

            public class InputSOHeader
            {
                public DateTime FromDate { get; set; }
                public DateTime ToDate { get; set; }
                public string StockID { get; set; }
            }

            public PDA_SOHeader()
            {
                SO_ID = "";
                SO_Type = "";
                SO_Name = "";
                SO_Date = DateTime.Now;
                StockID = "";
                ProviderID = "";
                ProviderName = "";
                Barcode = "";
                TotalQuantity = 0;
                Status = 0;
                Description = "";
                CreateByUser = "";
                CreateDate = DateTime.Now;
                ModifyByUser = "";
                ModifyDate = DateTime.Now;
                Active = true;

            }

            public PDA_SOHeader(System.Data.DataRow row)
            {
                SO_ID = row["SO_ID"].ToString();
                SO_Type = row["SO_Type"].ToString();
                SO_Name = row["SO_Name"].ToString();
                SO_Date = row["SO_Date"].ToString() != "" ? Convert.ToDateTime(row["SO_Date"]) : DateTime.Now;
                StockID = row["StockID"].ToString();
                ProviderID = row["ProviderID"].ToString();
                ProviderName = row["ProviderName"].ToString();
                Barcode = row["Barcode"].ToString();
                TotalQuantity = row["TotalQuantity"].ToString() != "" ? decimal.Parse(row["TotalQuantity"].ToString()) : 0;
                Status = row["Status"].ToString() != "" ? Int32.Parse(row["Status"].ToString()) : 0;
                Description = row["Description"].ToString();
                CreateByUser = row["CreateByUser"].ToString();
                CreateDate = row["CreateDate"].ToString() != "" ? Convert.ToDateTime(row["CreateDate"]) : DateTime.Now;
                ModifyByUser = row["ModifyByUser"].ToString();
                ModifyDate = row["ModifyDate"].ToString() != "" ? Convert.ToDateTime(row["ModifyDate"]) : DateTime.Now;
                Active = Boolean.Parse(row["Active"].ToString());
            }

        }

        public class PDA_SO
        {
            public string SO_ID { get; set; }
            public string SO_Type { get; set; }
            public string SO_Name { get; set; }
            public DateTime SO_Date { get; set; }
            public string StockID { get; set; }
            public string CustomerID { get; set; }
            public string CustomerName { get; set; }
            public string Barcode { get; set; }
            public decimal TotalQuantity { get; set; }
            public int Status { get; set; }
            public string Description { get; set; }
            public string CreateByUser { get; set; }
            public DateTime CreateDate { get; set; }
            public string ModifyByUser { get; set; }
            public DateTime ModifyDate { get; set; }
            public Boolean Active { get; set; }

            public List<PDA_SO_Detail> SO_Detail { get; set; }

            public class PDA_SO_Detail
            {
                public string SO_ID { get; set; }
                public int SO_Line { get; set; }
                public string StockID { get; set; }
                public string ProductID { get; set; }
                public string Variant { get; set; }
                public string ProductName { get; set; }
                public string Barcode { get; set; }
                public decimal Quantity { get; set; }
                public string Unit { get; set; }
                public string Description { get; set; }
                public string CreateByUser { get; set; }
                public DateTime CreateDate { get; set; }
                public string ModifyByUser { get; set; }
                public DateTime ModifyDate { get; set; }
                public Boolean Active { get; set; }



                public PDA_SO_Detail(System.Data.DataRow row)
                {
                    SO_ID = row["SO_ID"].ToString();
                    SO_Line = row["SO_Line"].ToString() != "" ? Int32.Parse(row["SO_Line"].ToString()) : 0;
                    StockID = row["StockID"].ToString();
                    ProductID = row["ProductID"].ToString();
                    Variant = row["Variant"].ToString();
                    ProductName = row["ProductName"].ToString();
                    Barcode = row["Barcode"].ToString();
                    Quantity = row["Quantity"].ToString() != "" ? decimal.Parse(row["Quantity"].ToString()) : 0;
                    Unit = row["Unit"].ToString();
                    Description = row["Description"].ToString();
                    CreateByUser = row["CreateByUser"].ToString();
                    CreateDate = row["CreateDate"].ToString() != "" ? Convert.ToDateTime(row["CreateDate"]) : DateTime.Now;
                    ModifyByUser = row["ModifyByUser"].ToString();
                    ModifyDate = row["ModifyDate"].ToString() != "" ? Convert.ToDateTime(row["ModifyDate"]) : DateTime.Now;
                    Active = Boolean.Parse(row["Active"].ToString());

                }

            }

            public PDA_SO()
            {
                SO_ID = "";
                SO_Type = "";
                SO_Name = "";
                SO_Date = DateTime.Now;
                StockID = "";
                CustomerID = "";
                CustomerName = "";
                Barcode = "";
                TotalQuantity = 0;
                Status = 0;
                Description = "";
                CreateByUser = "";
                CreateDate = DateTime.Now;
                ModifyByUser = "";
                ModifyDate = DateTime.Now;
                Active = true;

                SO_Detail = new List<PDA_SO_Detail>();
            }

            public PDA_SO(System.Data.DataRow row)
            {
                SO_ID = row["SO_ID"].ToString();
                SO_Type = row["SO_Type"].ToString();
                SO_Name = row["SO_Name"].ToString();
                SO_Date = row["SO_Date"].ToString() != "" ? Convert.ToDateTime(row["SO_Date"]) : DateTime.Now;
                StockID = row["StockID"].ToString();
                CustomerID = row["CustomerID"].ToString();
                CustomerName = row["CustomerName"].ToString();
                Barcode = row["Barcode"].ToString();
                TotalQuantity = row["TotalQuantity"].ToString() != "" ? decimal.Parse(row["TotalQuantity"].ToString()) : 0;
                Status = row["Status"].ToString() != "" ? Int32.Parse(row["Status"].ToString()) : 0;
                Description = row["Description"].ToString();
                CreateByUser = row["CreateByUser"].ToString();
                CreateDate = row["CreateDate"].ToString() != "" ? Convert.ToDateTime(row["CreateDate"]) : DateTime.Now;
                ModifyByUser = row["ModifyByUser"].ToString();
                ModifyDate = row["ModifyDate"].ToString() != "" ? Convert.ToDateTime(row["ModifyDate"]) : DateTime.Now;
                Active = Boolean.Parse(row["Active"].ToString());
                SO_Detail = new List<PDA_SO_Detail>();
            }

        }

        public class PDA_POHeader
        {


            public InputPOHeader inputPO { get; set; }

            public string PO_ID { get; set; }
            public string PO_Type { get; set; }
            public string PO_Name { get; set; }
            public DateTime PO_Date { get; set; }
            public string StockID { get; set; }
            public string ProviderID { get; set; }
            public string ProviderName { get; set; }
            public string Barcode { get; set; }
            public decimal TotalQuantity { get; set; }
            public int Status { get; set; }
            public string Description { get; set; }
            public string CreateByUser { get; set; }
            public DateTime CreateDate { get; set; }
            public string ModifyByUser { get; set; }
            public DateTime ModifyDate { get; set; }
            public Boolean Active { get; set; }

            public class InputPOHeader
            {
                public DateTime FromDate { get; set; }
                public DateTime ToDate { get; set; }
                public string StockID { get; set; }
            }

            public PDA_POHeader()
            {
                PO_ID = "";
                PO_Type = "";
                PO_Name = "";
                PO_Date = DateTime.Now;
                StockID = "";
                ProviderID = "";
                ProviderName = "";
                Barcode = "";
                TotalQuantity = 0;
                Status = 0;
                Description = "";
                CreateByUser = "";
                CreateDate = DateTime.Now;
                ModifyByUser = "";
                ModifyDate = DateTime.Now;
                Active = true;
            }



            public PDA_POHeader(System.Data.DataRow row)
            {
                PO_ID = row["PO_ID"].ToString();
                PO_Type = row["PO_Type"].ToString();
                PO_Name = row["PO_Name"].ToString();
                PO_Date = row["PO_Date"].ToString() != "" ? Convert.ToDateTime(row["PO_Date"]) : DateTime.Now;
                StockID = row["StockID"].ToString();
                ProviderID = row["ProviderID"].ToString();
                ProviderName = row["ProviderName"].ToString();
                Barcode = row["Barcode"].ToString();
                TotalQuantity = row["TotalQuantity"].ToString() != "" ? decimal.Parse(row["TotalQuantity"].ToString()) : 0;
                Status = row["Status"].ToString() != "" ? Int32.Parse(row["Status"].ToString()) : 0;
                Description = row["Description"].ToString();
                CreateByUser = row["CreateByUser"].ToString();
                CreateDate = row["CreateDate"].ToString() != "" ? Convert.ToDateTime(row["CreateDate"]) : DateTime.Now;
                ModifyByUser = row["ModifyByUser"].ToString();
                ModifyDate = row["ModifyDate"].ToString() != "" ? Convert.ToDateTime(row["ModifyDate"]) : DateTime.Now;
                Active = Boolean.Parse(row["Active"].ToString());
            }

        }

        public class PDA_PO
        {
            public string PO_ID { get; set; }
            public string PO_Type { get; set; }
            public string PO_Name { get; set; }
            public DateTime PO_Date { get; set; }
            public string StockID { get; set; }
            public string ProviderID { get; set; }
            public string ProviderName { get; set; }
            public string Barcode { get; set; }
            public decimal TotalQuantity { get; set; }
            public int Status { get; set; }
            public string Description { get; set; }
            public string CreateByUser { get; set; }
            public DateTime CreateDate { get; set; }
            public string ModifyByUser { get; set; }
            public DateTime ModifyDate { get; set; }
            public Boolean Active { get; set; }

            public List<PDA_PO_Detail> PO_Detail { get; set; }

            public class PDA_PO_Detail
            {
                public string PO_ID { get; set; }
                public int PO_Line { get; set; }
                public string StockID { get; set; }
                public string ProductID { get; set; }
                public string Variant { get; set; }
                public string ProductName { get; set; }
                public string Barcode { get; set; }
                public decimal Quantity { get; set; }
                public string Unit { get; set; }
                public string Description { get; set; }
                public string CreateByUser { get; set; }
                public DateTime CreateDate { get; set; }
                public string ModifyByUser { get; set; }
                public DateTime ModifyDate { get; set; }
                public Boolean Active { get; set; }



                public PDA_PO_Detail(System.Data.DataRow row)
                {
                    PO_ID = row["PO_ID"].ToString();
                    PO_Line = row["PO_Line"].ToString() != "" ? Int32.Parse(row["PO_Line"].ToString()) : 0;
                    StockID = row["StockID"].ToString();
                    ProductID = row["ProductID"].ToString();
                    Variant = row["Variant"].ToString();
                    ProductName = row["ProductName"].ToString();
                    Barcode = row["Barcode"].ToString();
                    Quantity = row["Quantity"].ToString() != "" ? decimal.Parse(row["Quantity"].ToString()) : 0;
                    Unit = row["Unit"].ToString();
                    Description = row["Description"].ToString();
                    CreateByUser = row["CreateByUser"].ToString();
                    CreateDate = row["CreateDate"].ToString() != "" ? Convert.ToDateTime(row["CreateDate"]) : DateTime.Now;
                    ModifyByUser = row["ModifyByUser"].ToString();
                    ModifyDate = row["ModifyDate"].ToString() != "" ? Convert.ToDateTime(row["ModifyDate"]) : DateTime.Now;
                    Active = Boolean.Parse(row["Active"].ToString());

                }

            }

            public PDA_PO()
            {
                PO_ID = "";
                PO_Type = "";
                PO_Name = "";
                PO_Date = DateTime.Now;
                StockID = "";
                ProviderID = "";
                ProviderName = "";
                Barcode = "";
                TotalQuantity = 0;
                Status = 0;
                Description = "";
                CreateByUser = "";
                CreateDate = DateTime.Now;
                ModifyByUser = "";
                ModifyDate = DateTime.Now;
                Active = true;

                PO_Detail = new List<PDA_PO_Detail>();
            }

            public PDA_PO(System.Data.DataRow row)
            {
                PO_ID = row["PO_ID"].ToString();
                PO_Type = row["PO_Type"].ToString();
                PO_Name = row["PO_Name"].ToString();
                PO_Date = row["PO_Date"].ToString() != "" ? Convert.ToDateTime(row["PO_Date"]) : DateTime.Now;
                StockID = row["StockID"].ToString();
                ProviderID = row["ProviderID"].ToString();
                ProviderName = row["ProviderName"].ToString();
                Barcode = row["Barcode"].ToString();
                TotalQuantity = row["TotalQuantity"].ToString() != "" ? decimal.Parse(row["TotalQuantity"].ToString()) : 0;
                Status = row["Status"].ToString() != "" ? Int32.Parse(row["Status"].ToString()) : 0;
                Description = row["Description"].ToString();
                CreateByUser = row["CreateByUser"].ToString();
                CreateDate = row["CreateDate"].ToString() != "" ? Convert.ToDateTime(row["CreateDate"]) : DateTime.Now;
                ModifyByUser = row["ModifyByUser"].ToString();
                ModifyDate = row["ModifyDate"].ToString() != "" ? Convert.ToDateTime(row["ModifyDate"]) : DateTime.Now;
                Active = Boolean.Parse(row["Active"].ToString());
                PO_Detail = new List<PDA_PO_Detail>();
            }

        }

        public class PDA_Inventory
        {
            public InputInventory inputInv { get; set; }

            public DateTime Date { get; set; }
            public string StockID { get; set; }
            public string ProductID { get; set; }
            public string Variant { get; set; }
            public decimal Quantity { get; set; }
            public DateTime CreateDate { get; set; }

            public class InputInventory
            {
                public DateTime Date { get; set; }
                public string StockID { get; set; }
            }

            public PDA_Inventory()
            {
                Date = DateTime.Now;
                StockID = "";
                ProductID = "";
                Variant = "";
                Quantity = 0;
                CreateDate = DateTime.Now;
            }


            public PDA_Inventory(System.Data.DataRow row)
            {
                Date = row["Date"].ToString() != "" ? Convert.ToDateTime(row["Date"]) : DateTime.Now;
                StockID = row["StockID"].ToString();
                ProductID = row["ProductID"].ToString();
                Variant = row["Variant"].ToString();
                Quantity = Decimal.Parse(row["Quantity"].ToString());
                CreateDate = row["CreateDate"].ToString() != "" ? Convert.ToDateTime(row["CreateDate"]) : DateTime.Now;

            }

        }

    }
}
