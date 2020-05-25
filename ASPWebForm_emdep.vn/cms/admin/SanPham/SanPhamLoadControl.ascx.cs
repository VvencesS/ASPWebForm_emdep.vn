using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPWebForm_emdep.vn.cms.admin.SanPham
{
    public partial class SanPhamLoadControl : System.Web.UI.UserControl
    {
        private string modulphu = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["modulphu"] != null)
                modulphu = Request.QueryString["modulphu"];
            switch (modulphu)
            {
                case "DanhMuc":
                    plSanPhamLoadControl.Controls.Add(LoadControl("QuanLyDanhMuc/DanhMucLoadControl.ascx"));
                    break;

                case "DanhSachSanPham":
                    plSanPhamLoadControl.Controls.Add(LoadControl("QuanLySanPham/SanPhamLoadControl.ascx"));
                    break;

                case "Mau":
                    plSanPhamLoadControl.Controls.Add(LoadControl("QuanLyMau/MauLoadControl.ascx"));
                    break;

                case "ChatLieu":
                    plSanPhamLoadControl.Controls.Add(LoadControl("QuanLyChatLieu/ChatLieuLoadControl.ascx"));
                    break;

                case "Size":
                    plSanPhamLoadControl.Controls.Add(LoadControl("QuanLySize/SizeLoadControl.ascx"));
                    break;

                case "NhomSanPham":
                    plSanPhamLoadControl.Controls.Add(LoadControl("QuanLyNhomSanPham/NhomLoadControl.ascx"));
                    break;

                case "PhienDauGia":
                    plSanPhamLoadControl.Controls.Add(LoadControl("QuanLyPhienDauGia/PhienDauGiaLoadControl.ascx"));
                    break;

                case "DonHang":
                    plSanPhamLoadControl.Controls.Add(LoadControl("QuanLyDonHang/DonHangLoadControl.ascx"));
                    break;

                default:
                    plSanPhamLoadControl.Controls.Add(LoadControl("QuanLySanPham/SanPhamLoadControl.ascx"));
                    break;


            }
        }
    }
}