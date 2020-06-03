using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPWebForm_emdep.vn.cms.display.TinTuc
{
    public partial class ChiTietTinTuc : System.Web.UI.UserControl
    {
        private string id = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] != null)
                id = Request.QueryString["id"];

            if (!IsPostBack)
                LayChiTietTinTuc(id);
        }

        private void LayChiTietTinTuc(string id)
        {
            CapNhatLuotXemTin(id);

            DataTable dt = new DataTable();
            dt = ASPWebForm_emdep.vn.App_Code.Database.TinTuc.Thongtin_Tintuc_by_id(id);
            if (dt.Rows.Count > 0)
            {
                ltrTieuDeTin.Text = dt.Rows[0]["TieuDe"].ToString();
                ltrNgayDang.Text = ((DateTime)dt.Rows[0]["NgayDang"]).ToString("dd/MM/yyyy");
                ltrLuotXem.Text = dt.Rows[0]["LuotXem"].ToString();
                ltrNoiDungChiTiet.Text = dt.Rows[0]["ChiTiet"].ToString();
            }
        }

        private void CapNhatLuotXemTin(string id)
        {
            ASPWebForm_emdep.vn.App_Code.Database.TinTuc.CapNhatLuotXemTinTuc(id);
        }
    }
}