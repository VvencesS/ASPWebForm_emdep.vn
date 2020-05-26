<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="KhachHangLoadControl.ascx.cs" Inherits="ASPWebForm_emdep.vn.cms.admin.KhachHang.KhachHangLoadControl" %>
<div class="container">
    <div style="clear:both;height:20px"></div>
    <div class="cotTrai">
        <div class="head">
            Quản lý
        </div>
        <ul>
            <li><a class="<%=DanhDau("KhachHang","DanhSachKhachHang","") %>" href="Admin.aspx?modul=KhachHang&modulphu=DanhSachKhachHang">Danh sách khách hàng</a></li>
        </ul>
    </div>
    <div class="cotPhai">
        <asp:PlaceHolder ID="plLoadControl" runat="server"></asp:PlaceHolder>
    </div>
    <div class="cb"></div>

</div>