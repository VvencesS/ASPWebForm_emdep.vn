using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPWebForm_emdep.vn.cms.display.ThanhVien
{
    public partial class DangKy : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lbtDangKy_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu chưa có ai đăng ký email này trong phần khách hàng thì mới cho thực hiện
            if (DaTonTaiEmail(tbEmail.Text))
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "", "alert('Email này đã được đăng ký. Bạn vui lòng điền email khác để đăng ký.');", true);
            }
            else
            {
                //Thực hiện thêm mới tài khoản khách hàng
                string matkhau = ASPWebForm_emdep.vn.App_Code.MaHoa.MaHoaMD5(tbMatKhau.Text);

                ASPWebForm_emdep.vn.App_Code.Database.KhachHang.Khachang_Inser(tbHoTen.Text, tbDiaChi.Text, tbSoDienThoai.Text, tbEmail.Text, matkhau, "");

                ScriptManager.RegisterStartupScript(this, this.GetType(), "", "alert('Đã đăng ký tài khoản khách hàng thành công. Bạn có thể đăng nhập với email và mật khẩu vừa tạo.');location.href='/Default.aspx?modul=ThanhVien&modulphu=DangNhap';", true);
            }
        }

        /// <summary>
        /// Phương thức kiểm tra xem có tồn tại bản ghi khách hàng với email này không
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        private bool DaTonTaiEmail(string email)
        {
            DataTable dt = new DataTable();
            dt = ASPWebForm_emdep.vn.App_Code.Database.KhachHang.Thongtin_Khachhang_by_emailkh(email);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }
    }
}