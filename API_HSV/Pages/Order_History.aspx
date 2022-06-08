<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Order_History.aspx.cs" Inherits="API.Pages.Order_History" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <meta name="apple-mobile-web-app-capable" content="yes" />
    <link rel="shortcut icon" href="http://theme.hstatic.net/1000391653/1000651513/14/favicon.png?v=158" />
    <link href="/Content/bootstrap.min.css" rel="stylesheet" />
    <link href="/Content/bootstrap-theme.min.css" rel="stylesheet" />
    <link href="/Content/Style.css" rel="stylesheet" />
    <link href="/Content/themes/base/all.css" rel="stylesheet" />

    <script src="/Scripts/jquery-3.2.1.min.js"></script>
    <script src="/Scripts/jquery-ui-1.12.1.min.js"></script>
    <script src="/Scripts/bootstrap.min.js"></script>
    <script src="/Scripts/analyticstracking.js"></script>
    <style type="text/css">
        .label_header {
            font-size: x-large;
        }

        .label_Large {
            font-size: xx-large;
        }

        .label_tile {
            font-size: x-large;
        }
    </style>
    <script>
        // Remove URL Tag Parameter from Address Bar
        if (window.parent.location.href.match(/ID=/)) {
            if (typeof (history.pushState) != "undefined") {
                var obj = { Title: document.title, Url: window.parent.location.pathname };
                history.pushState(obj, obj.Title, obj.Url);
            } else {
                window.parent.location = window.parent.location.pathname;
            }
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">


        <div class="row">
            <div class="col-xs-12 col-sm-12 col-md-12 col-lg-12">
                <asp:Label ID="Label1" class="label label-danger text-center" runat="server"></asp:Label>
                <div class="form-horizontal panel panel-info">
                    <div class="label-info" style="background-color: #e3fef6"><a></a></div>
                    <div class="form-group form-group-sm panel-body" style="text-align: center">
                        <br />
                        <br />
                        <a href="http://vstyle.vn">
                            <img src="data:image/png;base64,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" alt="Cọ số 168 - LARGE ANGLED CONTOUR BRUSH" />
                        </a>
                        <h3 style="text-align: center">VSTYLE.VN - Hàng Hiệu Chính Hãng
                        </h3>
                    </div>
                </div>
            </div>
        </div>

        <%--        <div class="col-xs-2 col-sm-2 col-md-2 col-lg-2">
        </div>--%>
        <div class="col-xs-12 col-sm-12 col-md-12 col-lg-12">

            <div class="row" style="text-align: left">
                <div class="col-xs-12 col-sm-12 col-md-12 col-lg-12">
                    <asp:Label ID="lbError" class="label label-danger text-center" runat="server"></asp:Label>
                    <div class="form-horizontal panel panel-info">
                        <div>
                            <h3>
                                <div class="col-sm-12">
                                    <div class="col-sm-6">
                                        <label class="label_Large" id="l_DonHang" style="font-size:xxx-large" runat="server"></label>
                                    </div>
                                    <div class="col-sm-6">
                                        <label class="label_tile" id="l_TrangThai" runat="server"></label>
                                    </div>
                                </div>

                            </h3>
                        </div>
                        <div class="form-group form-group-sm panel-body">

                            <div class="col-sm-12">

                                <div class="col-sm-6">
                                    <label class="label_Large" id="l_KhachHang" runat="server"></label>
                                </div>

                                <div class="col-sm-6">
                                    <label class="label_Large" id="l_SDT" runat="server"></label>
                                </div>

                                <div class="col-sm-12">
                                    <label class="label_header" id="l_DiaChi" runat="server">Địa Chỉ:  </label>
                                </div>

                                <div class="col-sm-6">
                                    <label class="label_header" id="l_TienHang" runat="server">Tiền hàng:  </label>
                                </div>

                                <div class="col-sm-6">

                                    <label class="label_header" id="l_ChiecKhau" runat="server">Chiết khấu:  </label>
                                </div>

                                <div class="col-sm-6">
                                    <label class="label_header" id="l_PhiVanChuyen" runat="server">Phí vận chuyển:  </label>
                                </div>

                                <div class="col-sm-6">
                                    <label class="label_header" id="l_DaThanhToan" runat="server">Đã thanh toán:  </label>
                                </div>

                                <div class="col-sm-6">
                                    <label class="label_header" runat="server">Phải thu:  </label>
                                    <label class="label_Large" id="l_PhaiThu" runat="server"></label>
                                </div>


                            </div>

                            <div class="col-sm-12" style="height: 20px">
                            </div>

                            <div class="col-sm-12">
                                <asp:GridView ID="gvHistory" runat="server" CssClass="table table-responsive table-hover table-striped table-bordered table-condensed" AutoGenerateColumns="False">
                                    <Columns>

                                        <%--<asp:BoundField DataField="STT" HeaderStyle-Font-Size="XX-Large" HeaderText="STT" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" ItemStyle-Width="5%" />--%>

                                        <asp:BoundField DataField="Time" HeaderText="" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-center" DataFormatString="{0:dd/MM/yyyy HH:mm}" ItemStyle-Width="25%" />
                                        <asp:BoundField DataField="Title" HeaderText="" HeaderStyle-CssClass="text-center" ItemStyle-CssClass="text-left" ItemStyle-Width="65%" />

                                    </Columns>
                                    <HeaderStyle CssClass="text-center" />
                                    <RowStyle CssClass="cursor-pointer" Font-Size="x-Large" />
                                    <PagerStyle CssClass="pagination-ys" />
                                    <FooterStyle CssClass="info" Font-Bold="True" />
                                </asp:GridView>
                            </div>

                        </div>
                    </div>
                </div>
            </div>

        </div>

        <%-- <div class="col-xs-2 col-sm-2 col-md-2 col-lg-2">
        </div>--%>
    </form>
</body>
</html>
