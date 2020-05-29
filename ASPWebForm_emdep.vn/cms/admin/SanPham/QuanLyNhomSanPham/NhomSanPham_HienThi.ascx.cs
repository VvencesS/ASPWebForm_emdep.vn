using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPWebForm_emdep.vn.cms.admin.SanPham.QuanLyNhomSanPham
{
    public partial class NhomSanPham_HienThi : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                LayNhomSanPham();
        }

        private void LayNhomSanPham()
        {
            DataTable dt = new DataTable();
            dt = ASPWebForm_emdep.vn.App_Code.Database.NhomSanPham.Thongtin_Nhomsp();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ltrNhomSanPham.Text += @"
                <tr id='maDong_" + dt.Rows[i]["NhomID"] + @"'>
                    <td class='cotMa'>" + dt.Rows[i]["NhomID"] + @"</td>
                    <td class='cotTen'>" + dt.Rows[i]["TenNhom"] + @"</td>
                    <td class='cotAnh'>
                        <img class='anhDaiDien'src='/pic/SanPham/" + dt.Rows[i]["AnhDaiDien"] + @"'/>
                        <img class='anhDaiDienHover'src='/pic/SanPham/" + dt.Rows[i]["AnhDaiDien"] + @"'/>
                    </td>
                    <td class='cotThuTu'>" + dt.Rows[i]["ThuTu"] + @"</td>
                    <td class='cotSoSanPhamHienThi'>" + dt.Rows[i]["SoSPHienThi"] + @"</td>
                    <td class='cotCongCu'>
              
                        <a href='Admin.aspx?modul=SanPham&modulphu=NhomSanPham&thaotac=ChinhSua&id=" + dt.Rows[i]["NhomID"] + @"' class='sua' title='Sửa'></a>
                        <a href='javascript:XoaNhomSanPham(" + dt.Rows[i]["NhomID"] + @")' class='xoa' title='Xóa'></a>
                    </td>
                </tr>
                ";
            }

        }
    }
}