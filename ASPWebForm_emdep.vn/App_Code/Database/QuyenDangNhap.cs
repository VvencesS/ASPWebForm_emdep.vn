using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ASPWebForm_emdep.vn.App_Code.Database
{
    /// <summary>
    /// Class thực hiện truy vấn liên quan đế bảng QuyenDangNhap
    /// </summary>
    public class QuyenDangNhap
    {
        #region Phương thức xóa Quyendangnhap
        /// Phương thức xóa Quyendangnhap theo mã Quyendangnhap truyền vào
        /// </summary>
        /// <param name="masp">mã Quyendangnhap cần xóa</param>
        public static void Quyendangnhap_Delete(string quyenid)
        {
            SqlCommand cmd = new SqlCommand("quyendangnhap_delete");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@quyenid", quyenid);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Phương thức thêm mới Quyendangnhap vào bảng Quyendangnhap
        /// <summary>
        /// Phương thức thêm mới Quyendangnhap vào bảng Quyendangnhap
        /// </summary>
        /// <param name="tenquyen"></param>

        public static void Quyendangnhap_Inser(string tenquyen, string ret)
        {
            SqlCommand cmd = new SqlCommand("quyendangnhap_inser");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tenquyen", tenquyen);
            cmd.Parameters.AddWithValue("@ret", ret);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region  Phương thức chỉnh sửa thông tin một QuyenDangNhap
        /// <summary>
        /// Phương thức chỉnh sửa thông tin một QuyenDangNhap
        /// </summary>
        /// <param name="maquyen"></param>
        /// <param name="tenquyen"></param>

        public static void Quyendangnhap_Update(string maquyen, string tenquyen)
        {
            SqlCommand cmd = new SqlCommand("quyendangnhap_update");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@maquyen", maquyen);
            cmd.Parameters.AddWithValue("@tenquyen", tenquyen);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }


        #endregion

        #region Phương thức lấy ra danh sách tất cả Quyendangnhap
        /// <summary>
        /// Phương thức lấy ra danh sách tất cả Quyendangnhap
        /// </summary>
        /// <returns></returns>
        public static DataTable Thongtin_Quyendangnhap()
        {
            SqlCommand cmd = new SqlCommand("thongtin_quyendangnhap");
            cmd.CommandType = CommandType.StoredProcedure;
            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region Phương thức lấy ra quyền đăng nhập theo mã quyền
        /// <summary>
        /// Phương thức lấy ra quyền đăng nhập theo mã quyền
        /// </summary>
        /// <param name="MaQuyen"></param>
        /// <returns></returns>
        public static DataTable Thongtin_Quyendangnhap_by_id(string MaQuyen)
        {
            SqlCommand cmd = new SqlCommand("thongtin_quyendangnhap_by_id");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaQuyen", MaQuyen);
            return SQLDatabase.GetData(cmd);
        }
        #endregion
    }
}