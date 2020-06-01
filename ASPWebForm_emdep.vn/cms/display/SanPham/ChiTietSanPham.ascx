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