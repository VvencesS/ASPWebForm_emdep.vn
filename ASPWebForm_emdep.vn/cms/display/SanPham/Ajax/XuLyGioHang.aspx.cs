using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPWebForm_emdep.vn.cms.display.SanPham.Ajax
{
    public partial class XuLyGioHang : System.Web.UI.Page
    {
        private string thaotac = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            thaotac = Request.Params["ThaoTac"];
            switch (thaotac)
            {
                case "ThemVaoGioHang":
                    ThemVaoGioHang();
                    break;
            }
        }
        private void ThemVaoGioHang()
        {
            string ketQua = "";

            string id = Request.Params["id"];
            string soLuong = Request.Params["soLuong"];

            //Lấy thông tin chi tiết sản phẩm được add vào giỏ hàng
            DataTable dt = new DataTable();
            dt = ASPWebForm_emdep.vn.App_Code.Database.SanPham.Thongtin_Sanpham_by_id(id);
            if (dt.Rows.Count > 0)//Nếu tồn tại sản phẩm mới thực hiện thao tác
            {
                //Nếu chưa có giỏ hàng --> tạo giỏ hàng
                if (Session["GioHang"] == null)
                {
                    //Khai báo datatable để lưu thông tin sản phẩm vào giỏ hàng lần đầu tiên
                    DataTable dtGioHang = new DataTable();
                    dtGioHang.Columns.Add("MaSP");
                    dtGioHang.Columns.Add("TenSP");
                    dtGioHang.Columns.Add("AnhSP");
                    dtGioHang.Columns.Add("GiaSP");
                    dtGioHang.Columns.Add("SoLuong");

                    //Lưu các thông tin của sản phẩm hiện tại vào datatable
                    dtGioHang.Rows.Add(dt.Rows[0]["MaSP"].ToString(), dt.Rows[0]["TenSP"].ToString(),
                        dt.Rows[0]["AnhSP"].ToString(), dt.Rows[0]["GiaSP"].ToString(), soLuong);

                    //Gán giá trị của bảng tạm - datatable vào giỏ hàng
                    Session["GioHang"] = dtGioHang;

                }
                //Nếu đã có giỏ hàng --> thêm mới sản phẩm vào giỏ hàng
                else
                {
                    //Khai báo datatable để chứa giỏ hàng
                    DataTable dtGioHang = new DataTable();
                    dtGioHang = (DataTable)Session["GioHang"];

                    //Kiểm tra xem trong giỏ hàng có sản phẩm này chưa
                    //Nếu có --> tăng số lượng ở dòng chứa sản phẩm này
                    //Nếu chưa có --> thêm sản phẩm vào dòng cuối giỏ hàng

                    int viTriSPTrongGioHang = -1;//Nếu sau vòng lặp vị trí thay đổi --> tức là có sản phẩm trong giỏ hàng
                    for (int i = 0; i < dtGioHang.Rows.Count; i++)
                    {
                        if (dtGioHang.Rows[i]["MaSP"].ToString() == id)
                        {
                            //Có tồn tại sản phẩm này trong giỏ hàng
                            viTriSPTrongGioHang = i;
                            //Thoát vòng lặp
                            break;
                        }
                    }

                    //Nếu có
                    if (viTriSPTrongGioHang != -1)
                    {
                        //Lấy ra số lượng hiện tại của sản phẩm đó trong giỏ hàng
                        int soLuongHienTai = int.Parse(dtGioHang.Rows[viTriSPTrongGioHang]["SoLuong"].ToString());

                        //Tăng số lượng lên
                        soLuongHienTai += int.Parse(soLuong);

                        //Cập nhật vào dòng chứa thông tin sản phẩm hiện tại
                        dtGioHang.Rows[viTriSPTrongGioHang]["SoLuong"] = soLuongHienTai;

                        //Gán lại giá trị của bảng tạm vào giỏ hàng
                        //Gán giá trị của bảng tạm - datatable vào giỏ hàng
                        Session["GioHang"] = dtGioHang;
                    }
                    //Nếu không có trong giỏ hàng
                    else
                    {
                        //Lưu các thông tin của sản phẩm hiện tại vào datatable
                        dtGioHang.Rows.Add(dt.Rows[0]["MaSP"].ToString(), dt.Rows[0]["TenSP"].ToString(),
                            dt.Rows[0]["AnhSP"].ToString(), dt.Rows[0]["GiaSP"].ToString(), soLuong);

                        //Gán giá trị của bảng tạm - datatable vào giỏ hàng
                        Session["GioHang"] = dtGioHang;
                    }
                }
            }
            else
            {
                ketQua = "Không tồn tại sản phẩm này";
            }

            Response.Write(ketQua);
        }
    }
}