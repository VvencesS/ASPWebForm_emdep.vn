using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPWebForm_emdep.vn.cms.admin.SanPham.QuanLyPhienDauGia
{
    public partial class PhienDauGia_HienThi : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                LayPhienDauGia();
        }

        private void LayPhienDauGia()
        {
            DataTable dt = new DataTable();
            dt = ASPWebForm_emdep.vn.App_Code.Database.PhienDauGia.Thongtin_PhienDauGia();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ltrPhienDauGia.Text += @"
            <tr id='maDong_" + dt.Rows[i]["MaPhienDG"] + @"'>
                <td class='cotMa'>" + dt.Rows[i]["MaPhienDG"] + @"</td>
                <td class='cotDonGia'>" + dt.Rows[i]["ThoiGianBatDau"] + @"</td>
                <td class='cotDonGia'>" + dt.Rows[i]["ThoiGianKetThuc"] + @"</td>
                <td class='cotThuTu'>" + dt.Rows[i]["MaSP"] + @"</td>
                <td class='cotDonGia'>" + dt.Rows[i]["GiaDeXuat"] + @"</td>
                <td class='cotCongCu'>
                    <a href='Admin.aspx?modul=SanPham&modulphu=PhienDauGia&thaotac=ChiTiet&id=" + dt.Rows[i]["MaPhienDG"] + @"' class='xem' title='Xem'></a>
                    <a href='Admin.aspx?modul=SanPham&modulphu=PhienDauGia&thaotac=ChinhSua&id=" + dt.Rows[i]["MaPhienDG"] + @"' class='sua' title='Sửa'></a>
                    <a href='javascript:XoaPhienDauGia(" + dt.Rows[i]["MaPhienDG"] + @")' class='xoa' title='Xóa'></a>
                </td>
            </tr>
            ";
            }

        }
    }
}