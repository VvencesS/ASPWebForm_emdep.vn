<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MenuLoadControl.ascx.cs" Inherits="ASPWebForm_emdep.vn.cms.admin.Menu.MenuLoadControl" %>
<div class="container">
    <div style="clear:both;height:20px"></div>
    <div class="cotTrai">
        <div class="head">
            Quản lý
        </div>
        <ul>
            <li><a class="<%=DanhDau("Menu","DanhSachMenu","") %>" href="Admin.aspx?modul=Menu&modulphu=DanhSachMenu">Danh sách Menu</a></li>
        </ul>
        <div class="head">
            Thêm mới
        </div>
        <ul>
            <li><a class="<%=DanhDau("Menu","DanhSachMenu","ThemMoi") %>" href="Admin.aspx?modul=Menu&modulphu=DanhSachMenu&thaotac=ThemMoi">Danh sách Menu</a></li>            
        </ul>
    </div>
    <div class="cotPhai">
        <asp:PlaceHolder ID="plLoadControl" runat="server"></asp:PlaceHolder>
    </div>
    <div class="cb"></div>

</div>