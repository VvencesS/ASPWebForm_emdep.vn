using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPWebForm_emdep.vn.cms.admin.TinTuc
{
    public partial class TinTucLoadControl : System.Web.UI.UserControl
    {
        private string modulphu = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["modulphu"] != null)
                modulphu = Request.QueryString["modulphu"];
            switch (modulphu)
            {
                case "DanhSachTinTuc":
                    plTinTucLoadControl.Controls.Add(LoadControl("DanhSachTinTuc/DanhSachTinTucLoadControl.ascx"));
                    break;

                case "DanhMucTin":
                    plTinTucLoadControl.Controls.Add(LoadControl("DanhMucTin/DanhMucTinLoadControl.ascx"));
                    break;

                default:
                    plTinTucLoadControl.Controls.Add(LoadControl("DanhSachTinTuc/DanhSachTinTucLoadControl.ascx"));
                    break;


            }
        }
    }
}