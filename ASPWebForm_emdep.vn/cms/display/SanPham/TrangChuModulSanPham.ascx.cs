﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPWebForm_emdep.vn.cms.display.SanPham
{
    public partial class TrangChuModulSanPham : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ltrNhomSanPham.Text = LayDanhMucSanPham();
            }
        }

        #region Lấy nhóm và các sản phẩm
        private string LayDanhMucSanPham()
        {
            string s = "";
            DataTable dt = new DataTable();
            dt = ASPWebForm_emdep.vn.App_Code.Database.DanhMuc.Thongtin_Danhmuc_by_MaDMCha("0");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                s += "<div class='sanphamnoibat'>";
                s += @"
                <a class='title-line' href='/Default.aspx?modul=SanPham&modulphu=DanhSachSanPham&id=" + dt.Rows[i]["MaDM"] + @"' title='" + dt.Rows[i]["TenDM"] + @"'>
                    <h3>" + dt.Rows[i]["TenDM"] + @"</h3>
                    <span class='xemchitiet'>Xem tất cả [+]</span>
                </a>
                ";
                s += "<div>";
                s += LayDanhSachSanPhamTheoDanhMuc(dt.Rows[i]["MaDM"].ToString());
                s += "</div>";
                s += "<div style='clear:both'></div>";
                s += "</div>";
            }

            return s;
        }

        private string LayDanhSachSanPhamTheoDanhMuc(string MaDM)
        {
            string s = "";
            DataTable dt = new DataTable();
            dt = ASPWebForm_emdep.vn.App_Code.Database.SanPham.Thongtin_Sanpham_by_madm(MaDM);

            string link = "";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                link = "Default.aspx?modul=SanPham&modulphu=ChiTietSanPham&id=" + dt.Rows[i]["MaSP"];

                s += @"
                <div class='item'>
                    <a href='" + link + @"' title='" + dt.Rows[i]["TenSP"] + @"'>
                        <img src='/pic/SanPham/" + dt.Rows[i]["AnhSP"] + @"' alt='" + dt.Rows[i]["TenSP"] + @"' />
                    </a>
                    <a class='title-sp' href='" + link + @"' title='" + dt.Rows[i]["TenSP"] + @"'>
                        " + dt.Rows[i]["TenSP"] + @"
                    </a>
                    <div class='desc'>
                        Giá: " + dt.Rows[i]["GiaSP"] + @"
                    </div>
                </div>
                ";
            }
            return s;
        }

        #endregion
    }
}