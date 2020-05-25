<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SanPhamLoadControl.ascx.cs" Inherits="ASPWebForm_emdep.vn.cms.admin.SanPham.SanPhamLoadControl" %>
<div class="container">
    <div style="clear:both;height:20px"></div>
    <div class="cotTrai">
        <div class="head">
            Quản lý
        </div>
        <ul>
            <li><a class="" href="Admin.aspx?modul=SanPham&modulphu=DanhMuc">Danh mục sản phẩm</a></li>
            <li><a class="" href="Admin.aspx?modul=SanPham&modulphu=DanhSachSanPham">Danh sách sản phẩm</a></li>
            <li><a class="" href="Admin.aspx?modul=SanPham&modulphu=Mau">Màu sản phẩm</a></li>
            <li><a class="" href="Admin.aspx?modul=SanPham&modulphu=ChatLieu">Chất liệu sản phẩm</a></li>
            <li><a class="" href="Admin.aspx?modul=SanPham&modulphu=Size">Size sản phẩm</a></li>
            <li><a class="" href="Admin.aspx?modul=SanPham&modulphu=NhomSanPham">Nhóm Sản Phẩm</a></li>
            <li><a class="" href="Admin.aspx?modul=SanPham&modulphu=PhienDauGia">Phiên đấu giá</a></li>
            <li><a class="" href="Admin.aspx?modul=SanPham&modulphu=DonHang">Đơn hàng</a></li>
        </ul>
        <%--<div class="head">
            Thêm mới
        </div>
        <ul>
            <li><a class="" href="Admin.aspx?modul=SanPham&modulphu=DanhMuc&thaotac=ThemMoi">Danh mục sản phẩm</a></li>
            <li><a class="" href="Admin.aspx?modul=SanPham&modulphu=DanhSachSanPham&thaotac=ThemMoi">Danh sách sản phẩm</a></li>
            <li><a class="" href="Admin.aspx?modul=SanPham&modulphu=Mau&thaotac=ThemMoi">Màu sản phẩm</a></li>
            <li><a class="" href="Admin.aspx?modul=SanPham&modulphu=ChatLieu&thaotac=ThemMoi">Chất liệu sản phẩm</a></li>
            <li><a class="" href="Admin.aspx?modul=SanPham&modulphu=Size&thaotac=ThemMoi">Size sản phẩm</a></li>
            <li><a class="" href="Admin.aspx?modul=SanPham&modulphu=NhomSanPham&thaotac=ThemMoi">Nhóm Sản Phẩm</a></li>
            <li><a class="" href="Admin.aspx?modul=SanPham&modulphu=PhienDauGia&thaotac=ThemMoi">Phiên đấu giá</a></li>
        </ul>--%>
    </div>
    <div class="cotPhai">
        <asp:PlaceHolder ID="plSanPhamLoadControl" runat="server"></asp:PlaceHolder>
    </div>
    <div class="cb"></div>

</div>