using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPWebForm_emdep.vn.cms.admin.TinTuc.DanhSachTinTuc
{
    public partial class DanhSachTinTuc_HienThi : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                LayTinTuc();
        }

        private void LayTinTuc()
        {
            DataTable dt = new DataTable();
            dt = ASPWebForm_emdep.vn.App_Code.Database.TinTuc.Thongtin_TinTuc();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ltrTinTuc.Text += @"
                <tr id='maDong_" + dt.Rows[i]["TinTucID"] + @"'>
                    <td class='cotMa'>" + dt.Rows[i]["TinTucID"] + @"</td>
                    <td class='cotTen'>" + dt.Rows[i]["TieuDe"] + @"</td>
                    <td class='cotAnh'>
                        <img class='anhDaiDien'src='/pic/TinTuc/" + dt.Rows[i]["AnhDaiDien"] + @"'/>
                        <img class='anhDaiDienHover'src='/pic/TinTuc/" + dt.Rows[i]["AnhDaiDien"] + @"'/>
                    </td>
                    <td class='cotSoLuong'>" + dt.Rows[i]["LuotXem"] + @"</td>
                    <td class='cotNgayDang'>" + dt.Rows[i]["NgayDang"] + @"</td>
                    <td class='cotThuTu'>" + dt.Rows[i]["ThuTu"] + @"</td>
                    <td class='cotCongCu'>
                        <a href='Admin.aspx?modul=TinTuc&modulphu=DanhSachTinTuc&thaotac=ChinhSua&id=" + dt.Rows[i]["TinTucID"] + @"' class='sua' title='Sửa'></a>
                        <a href='javascript:XoaTinTuc(" + dt.Rows[i]["TinTucID"] + @")' class='xoa' title='Xóa'></a>
                    </td>
                </tr>
                ";
            }

        }
    }
}