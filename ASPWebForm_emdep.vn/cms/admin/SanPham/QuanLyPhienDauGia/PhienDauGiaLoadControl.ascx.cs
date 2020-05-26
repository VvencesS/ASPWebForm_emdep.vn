using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPWebForm_emdep.vn.cms.admin.SanPham.QuanLyPhienDauGia
{
    public partial class PhienDauGiaLoadControl : System.Web.UI.UserControl
    {
        private string thaotac = "null";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["thaotac"] != null)
                thaotac = Request.QueryString["thaotac"];
            switch (thaotac)
            {
                case "ThemMoi":
                case "ChinhSua":
                    plLoadControl.Controls.Add(LoadControl("PhienDauGia_ThemMoi.ascx"));
                    break;
                case "HienThi":
                    plLoadControl.Controls.Add(LoadControl("PhienDauGia_HienThi.ascx"));
                    break;

                case "ChiTiet":
                    plLoadControl.Controls.Add(LoadControl("PhienDauGia_ChiTiet.ascx"));
                    break;

                default:
                    plLoadControl.Controls.Add(LoadControl("PhienDauGia_HienThi.ascx"));
                    break;

            }
        }
    }
}