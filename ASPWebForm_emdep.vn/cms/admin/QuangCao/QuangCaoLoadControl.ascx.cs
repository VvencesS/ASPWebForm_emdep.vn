using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPWebForm_emdep.vn.cms.admin.QuangCao
{
    public partial class QuangCaoLoadControl : System.Web.UI.UserControl
    {
        private string modulphu = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["modulphu"] != null)
                modulphu = Request.QueryString["modulphu"];
            switch (modulphu)
            {
                case "DanhSachQuangCao":
                    plQuangCaoLoadControl.Controls.Add(LoadControl("QuanLyDanhSachQuangCao/DanhSachQuangCaoLoadControl.ascx"));
                    break;

                case "NhomQuangCao":
                    plQuangCaoLoadControl.Controls.Add(LoadControl("QuanLyNhomQuangCao/NhomQuangCaoLoadControl.ascx"));
                    break;

                default:
                    plQuangCaoLoadControl.Controls.Add(LoadControl("QuanLyDanhSachQuangCao/DanhSachQuangCaoLoadControl.ascx"));
                    break;


            }
        }
    }
}