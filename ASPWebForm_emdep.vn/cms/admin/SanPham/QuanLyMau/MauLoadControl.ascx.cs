using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPWebForm_emdep.vn.cms.admin.SanPham.QuanLyMau
{
    public partial class MauLoadControl : System.Web.UI.UserControl
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
                    plLoadControl.Controls.Add(LoadControl("Mau_ThemMoi.ascx"));
                    break;

                case "HienThi":
                    plLoadControl.Controls.Add(LoadControl("Mau_HienThi.ascx"));
                    break;

                default:
                    plLoadControl.Controls.Add(LoadControl("Mau_HienThi.ascx"));
                    break;

            }
        }
    }
}