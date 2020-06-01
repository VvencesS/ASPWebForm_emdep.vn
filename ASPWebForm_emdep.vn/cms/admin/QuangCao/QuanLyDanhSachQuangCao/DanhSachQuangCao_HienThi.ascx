<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DanhSachQuangCao_HienThi.ascx.cs" Inherits="ASPWebForm_emdep.vn.cms.admin.QuangCao.QuanLyDanhSachQuangCao.DanhSachQuangCao_HienThi" %>
<div class="head">
    Danh sách quảng cáo đã tạo. 
    <div class="fr ter"><a class="btThemMoi" href="/Admin.aspx?modul=QuangCao&modulphu=DanhSachQuangCao&thaotac=ThemMoi">Thêm mới nhóm sản phẩm</a></div>
    <div class="cb"></div>
</div>
<div class="KhungChuaBang">
   <table class="tbDanhMuc">
       <tr>
           <th class="cotMa">Mã</th>
           <th class="cotTen">Tên quảng cáo</th>
           <th class="cotAnh">Ảnh quảng cáo</th>
           <th class="cotThuTu">Thứ tự</th>
           <th class="cotCongCu">Công cụ</th>
       </tr>
       <asp:Literal ID="ltrQuangCao" runat="server"></asp:Literal>
   </table>
</div>

<script type="text/javascript">
    function XoaQuangCao(QuangCaoID) {
        if (confirm("Bạn chắc chắn muốn xóa nhóm sản phẩn này")) {
            //Viết code xóa danh mục tại đây

            $.post("cms/admin/QuangCao/QuanLyDanhSachQuangCao/Ajax/QuangCao.aspx",
                {
                    "ThaoTac": "XoaQuangCao",
                    "QuangCaoID": QuangCaoID
                },
                function (data, status) {
                    //alert("Data :" + data + "\n Status :" + status);
                    if (data == 1) {
                        //thực hiện thành công => ẩn dòng vừa xóa đi
                        $("#maDong_" + QuangCaoID).slideUp();

                    }
                });
        }
    }
</script>