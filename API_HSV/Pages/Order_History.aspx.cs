using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace API.Pages
{
    public partial class Order_History : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GetData();
        }

        #region Common


        private string GetID()
        {
            if (Request.QueryString["ID"] != null)
            {

                return Request.QueryString["ID"];
            }
            else
                return "";
        }


        private void GetData()
        {
            string ID = GetID();
            DataSet ds = new DataSet();
            ds = Bussiness.Order.Order_History(ID);
            if (ds.Tables.Count == 2)
            {
                DataTable dtheader = new DataTable();
                dtheader = ds.Tables[0];
                DataTable dtHistory = new DataTable();
                dtHistory = ds.Tables[1];

                if (dtheader.Rows.Count == 1)
                {
                    Page.Title = "Vstyle.vn " + dtheader.Rows[0]["Mã ĐH"].ToString();

                    l_DonHang.InnerText = dtheader.Rows[0]["Mã ĐH"].ToString();
                    l_TrangThai.InnerText = dtheader.Rows[0]["Trạng Thái"].ToString();
                    l_KhachHang.InnerText = dtheader.Rows[0]["Tên KH"].ToString();
                    l_SDT.InnerText = dtheader.Rows[0]["SĐT KH"].ToString();
                    l_DiaChi.InnerText = "Địa chỉ: " + dtheader.Rows[0]["ĐC KH"].ToString();
                    l_TienHang.InnerText = "Tiền hàng: " + int.Parse(dtheader.Rows[0]["Tiền hàng"].ToString()).ToString("N0") + " ₫";
                    l_PhiVanChuyen.InnerText = "Phí vận chuyển: " + int.Parse(dtheader.Rows[0]["Phí Vận Chuyển"].ToString()).ToString("N0") + " ₫";
                    l_ChiecKhau.InnerText = "Chiết khấu: -" + int.Parse(dtheader.Rows[0]["Chiếc Khấu"].ToString()).ToString("N0") + " ₫";
                    l_DaThanhToan.InnerText = "Đã thanh toán: " + int.Parse(dtheader.Rows[0]["Đã thanh toán"].ToString()).ToString("N0") + " ₫";
                    l_PhaiThu.InnerText = int.Parse(dtheader.Rows[0]["Phải thu"].ToString()).ToString("N0") + " ₫";

                }

                if (dtHistory.Rows.Count > 0)
                {
                    gvHistory.DataSource = dtHistory;
                    gvHistory.DataBind();
                }
            }

        }


        #endregion
    }
}