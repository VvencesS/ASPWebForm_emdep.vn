using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPWebForm_emdep.vn
{
    public partial class Default : System.Web.UI.Page
    {
        private string modul = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            #region Nếu là modul tin tức --> Hiện danh mục tin., Các modul khác --> Hiện danh mục sản phẩm
            if (Request.QueryString["modul"] != null)
                modul = Request.QueryString["modul"];

            if (modul == "TinTuc")
            {
                plDanhMucTinTuc.Visible = true;
                plDanhMucSanPham.Visible = false;
            }
            else
            {
                plDanhMucTinTuc.Visible = false;
                plDanhMucSanPham.Visible = true;
            }
            #endregion
            if (!IsPostBack)
            {
                
                

                ltrLogo.Text = LayLogo();
                ltrBanner.Text = LayBanner();
                ltrMenu.Text = LayMenu();
                ltrDanhMucSanPham.Text = LayDanhMucSanPham();
                ltrDanhMucTinTuc.Text = LayDanhMucTinTuc();
            }
        }
        #region Lấy danh mục tin tức
        private string LayDanhMucTinTuc()
        {
            string s = "";
            DataTable dt = new DataTable();
            dt = ASPWebForm_emdep.vn.App_Code.Database.DanhMucTin.Thongtin_DanhmucTin_by_MaDMCha("0");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                s += @"<li><a href='/Default.aspx?modul=TinTuc&modulphu=DanhSachTinTuc&id=" + dt.Rows[i]["MaDM"] + @"' title='" + dt.Rows[i]["TenDM"] + @"'>" + dt.Rows[i]["TenDM"] + @"</a></li>";
            }
            return s;
        }
        #endregion
        #region Lấy danh mục sản phẩm
        private string LayDanhMucSanPham()
        {
            string s = "";
            DataTable dt = new DataTable();
            dt = ASPWebForm_emdep.vn.App_Code.Database.DanhMuc.Thongtin_Danhmuc_by_MaDMCha("0");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                s += @"<li><a href='/Default.aspx?modul=SanPham&modulphu=DanhSachSanPham&id=" + dt.Rows[i]["MaDM"] + @"' title='" + dt.Rows[i]["TenDM"] + @"'>" + dt.Rows[i]["TenDM"] + @"</a></li>";
            }
            return s;
        }
        #endregion
        #region Lấy menu
        private string LayMenu()
        {
            string s = "";
            DataTable dt = new DataTable();
            dt = ASPWebForm_emdep.vn.App_Code.Database.Menu.Thongtin_Menu_by_MaMenuCha("0");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string lienKet = dt.Rows[i]["LienKet"].ToString();
                if (lienKet == "")
                    lienKet = "#";

                s += @"<li class='menu1'><a href='" + lienKet + @"' title='" + dt.Rows[i]["TenMenu"] + @"'>" + dt.Rows[i]["TenMenu"] + @"</a></li>";
            }
            return s;
        }
        #endregion
        #region Lấy banner
        private string LayBanner()
        {
            string s = "";

            //Code lấy ra vị trí quảng nhóm cáo
            DataTable dt = new DataTable();
            dt = ASPWebForm_emdep.vn.App_Code.Database.NhomQuangCao.Thongtin_Nhomquangcao_by_vitriqc("banner");

            //Nếu tồn tại vị trí nhóm quảng cáo --> tìm quảng cáo trong nhóm đó
            if (dt.Rows.Count > 0)
            {
                //Gọi tới phương thức lấy ảnh quảng cáo theo id nhóm quảng cáo
                s = LayAnhBanner(dt.Rows[0]["NhomQuangCaoID"].ToString());
            }

            return s;
        }

        private string LayAnhBanner(string nhomQuangCaoID)
        {
            string s = "";

            DataTable dt = new DataTable();
            dt = ASPWebForm_emdep.vn.App_Code.Database.QuangCao.Thongtin_Quangcao_by_nhomquangcaoid(nhomQuangCaoID);
            if (dt.Rows.Count > 0)
            {
                string lienKet = dt.Rows[0]["LienKet"].ToString();
                if (lienKet == "")
                    lienKet = "#";

                s += @"
                <a href='" + lienKet + @"' title='" + dt.Rows[0]["TenQC"] + @"'>
                    <img src='/pic/QuangCao/" + dt.Rows[0]["AnhQC"] + @"' alt='" + dt.Rows[0]["TenQC"] + @"'/>
                </a>";
            }
            return s;
        }
        #endregion

        #region Lấy logo
        private string LayLogo()
        {
            string s = "";

            //Code lấy ra vị trí quảng nhóm cáo
            DataTable dt = new DataTable();
            dt = ASPWebForm_emdep.vn.App_Code.Database.NhomQuangCao.Thongtin_Nhomquangcao_by_vitriqc("logo");

            //Nếu tồn tại vị trí nhóm quảng cáo --> tìm quảng cáo trong nhóm đó
            if (dt.Rows.Count > 0)
            {
                //Gọi tới phương thức lấy ảnh quảng cáo theo id nhóm quảng cáo
                s = LayAnhLogo(dt.Rows[0]["NhomQuangCaoID"].ToString());
            }

            return s;
        }

        private string LayAnhLogo(string nhomQuangCaoID)
        {
            string s = "";

            DataTable dt = new DataTable();
            dt = ASPWebForm_emdep.vn.App_Code.Database.QuangCao.Thongtin_Quangcao_by_nhomquangcaoid(nhomQuangCaoID);
            if (dt.Rows.Count > 0)
            {
                string lienKet = dt.Rows[0]["LienKet"].ToString();
                if (lienKet == "")
                    lienKet = "#";

                s += @"
                <a href='" + lienKet + @"' title='" + dt.Rows[0]["TenQC"] + @"'>
                    <img src='/pic/QuangCao/" + dt.Rows[0]["AnhQC"] + @"' alt='" + dt.Rows[0]["TenQC"] + @"'/>
                </a>";
            }
            return s;
        }
        #endregion
    }
}