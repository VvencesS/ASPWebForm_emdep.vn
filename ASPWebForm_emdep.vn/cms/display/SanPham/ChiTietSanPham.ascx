<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ChiTietSanPham.ascx.cs" Inherits="ASPWebForm_emdep.vn.cms.display.SanPham.ChiTietSanPham" %>
<link href="css/chi-tiet-san-pham.css" rel="stylesheet" />

<div class="chitietsp">
    <div class="baosp">
        <asp:Literal ID="ltrAnhSanPham" runat="server"></asp:Literal>
    </div>
    <div class="baochitiet">
        <div class="product-title">
            <h1><asp:Literal ID="ltrTenSanPham" runat="server"></asp:Literal></h1>
        </div>
        <div class="product-price">
            <span><asp:Literal ID="ltrGiaSP" runat="server"></asp:Literal>đ</span>
        </div>
        <div class="thongso">
            <div class="size">
                <label>Kích thước</label> <asp:Literal ID="ltrKichThuoc" runat="server"></asp:Literal>                
            </div>            
            <div class="mausac">
                <label>Màu sắc</label> <asp:Literal ID="ltrMau" runat="server"></asp:Literal> 
            </div>
            <div class="chatlieu">
                <label>Chất liệu</label> <asp:Literal ID="ltrChatLieu" runat="server"></asp:Literal> 
            </div>
            <div class="soluong">
                <label>Số lượng</label>
                <input id="quantity" type="number" name="quantity" min="1" value="1" class="tc item-quantity">
            </div>
        </div>
        <div class="row">
            <div class="giohangsp">
                <a id="add-to-cart" class="btn-detail btn-color-add" href="javascript:ThemVaoGioHang()">Thêm vào giỏ</a>
            </div>
            <div class="muangay">
                <a id="buy-now" class="btn-detail btn-color-buy" href="javascript:MuaNgay()">Mua ngay</a>
            </div>
        </div>
    </div>
    <div style="clear:both"></div>
    <div class="thongTinChiTietSanPham">
        <asp:Literal ID="ltrThongTinChiTiet" runat="server"></asp:Literal>
    </div>
</div>

<%--Các script xử lý giỏ hàng--%>
<script type="text/javascript">
    function ThemVaoGioHang() {
        var id = "<%=id%>";
        var soLuong = $("#quantity").val();

        $.post("cms/display/SanPham/Ajax/XuLyGioHang.aspx",
         {
             "ThaoTac": "ThemVaoGioHang",
             "id": id,
             "soLuong": soLuong
         },
         function (data, status) {
             //alert("Data :" + data + "\n Status :" + status);
             if (data == "") {
                 //thực hiện thành công => thông báo
                 alert("Đã thêm sản phẩm vào giỏ hàng thành công");
             } else {
                 alert(data);
             }
         });
    }

    function MuaNgay() {
        var id = "<%=id%>";
        var soLuong = $("#quantity").val();

        $.post("cms/display/SanPham/Ajax/XuLyGioHang.aspx",
         {
             "ThaoTac": "ThemVaoGioHang",
             "id": id,
             "soLuong": soLuong
         },
         function (data, status) {
             //alert("Data :" + data + "\n Status :" + status);
             if (data == "") {
                 //thực hiện thành công => thông báo
                 alert("Đã thêm sản phẩm vào giỏ hàng thành công");

                 //Đẩy về trang hiển thị giỏ hàng
                 location.href = "/Default.aspx?modul=SanPham&modulphu=GioHang";
             } else {
                 alert(data);
             }
         });
    }
</script>