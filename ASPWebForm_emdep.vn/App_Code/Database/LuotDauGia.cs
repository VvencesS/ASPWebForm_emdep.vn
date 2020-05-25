﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ASPWebForm_emdep.vn.App_Code.Database
{
    /// <summary>
    /// Summary description for LuotDauGia
    /// </summary>
    public class LuotDauGia
    {
        #region Phương thức xóa Lượt đấu giá

        public static void LuotDauGia_Delete(string MaLuotDG)
        {
            SqlCommand cmd = new SqlCommand("luotdaugia_delete");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaLuotDG", MaLuotDG);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region Phương thức thêm mới lượt đấu giá vào bảng lượt đấu giá
        /// <summary>
        /// Phương thức thêm mới lượt đấu giá vào bảng lượt đấu giá
        /// </summary>

        public static void LuotDauGia_Inser(string ThoiGianDG, string GiaDuaRa, string MaXacNhan, string MaKH, string MaPhienDG, string ret)
        {
            SqlCommand cmd = new SqlCommand("luotdaugia_inser");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ThoiGianDG", ThoiGianDG);
            cmd.Parameters.AddWithValue("@GiaDuaRa", GiaDuaRa);
            cmd.Parameters.AddWithValue("@MaXacNhan", MaXacNhan);
            cmd.Parameters.AddWithValue("@MaKH", MaKH);
            cmd.Parameters.AddWithValue("@MaPhienDG", MaPhienDG);

            cmd.Parameters.AddWithValue("@ret", ret);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        #endregion

        #region  Phương thức chỉnh sửa thông tin một lượt đấu giá
        /// <summary>
        /// Phương thức chỉnh sửa thông tin một lượt đấu giá
        /// </summary>

        public static void LuotDauGia_Update(string MaLuotDG, string ThoiGianDG, string GiaDuaRa, string MaXacNhan, string MaKH, string MaPhienDG)
        {
            SqlCommand cmd = new SqlCommand("luotdaugia_update");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaLuotDG", MaLuotDG);
            cmd.Parameters.AddWithValue("@ThoiGianDG", ThoiGianDG);
            cmd.Parameters.AddWithValue("@GiaDuaRa", GiaDuaRa);
            cmd.Parameters.AddWithValue("@MaXacNhan", MaXacNhan);
            cmd.Parameters.AddWithValue("@MaKH", MaKH);
            cmd.Parameters.AddWithValue("@MaPhienDG", MaPhienDG);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }


        #endregion

        #region Phương thức lấy ra danh sách tất cả lượt đấu giá
        /// <summary>
        /// Phương thức lấy ra danh sách tất cả lượt đấu giá
        /// </summary>
        /// <returns></returns>
        public static DataTable Thongtin_LuotDauGia()
        {
            SqlCommand cmd = new SqlCommand("thongtin_luotdaugia");
            cmd.CommandType = CommandType.StoredProcedure;
            return SQLDatabase.GetData(cmd);
        }
        #endregion

        #region Phương thức lấy ra thông tin lượt đấu giá theo id lượt đấu giá
        /// <summary>
        /// Phương thức lấy ra thông tin lượt đấu giá theo id lượt đấu giá
        /// </summary>
        /// <returns></returns>
        public static DataTable Thongtin_LuotDauGia_by_id(string MaLuotDG)
        {
            SqlCommand cmd = new SqlCommand("thongtin_luotdaugia_by_id");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaLuotDG", MaLuotDG);
            return SQLDatabase.GetData(cmd);
        }

        public static DataTable Thongtin_LuotDauGia_by_makh_maphiendg(string MaKH, string MaPhienDG)
        {
            SqlCommand cmd = new SqlCommand("thongtin_luotdaugia_by_makh_maphiendg");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaKH", MaKH);
            cmd.Parameters.AddWithValue("@MaPhienDG", MaPhienDG);
            return SQLDatabase.GetData(cmd);
        }


        public static DataTable Thongtin_LuotDauGia_by_maphiendg(string MaPhienDG)
        {
            SqlCommand cmd = new SqlCommand("thongtin_luotdaugia_by_maphiendg");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaPhienDG", MaPhienDG);
            return SQLDatabase.GetData(cmd);
        }
        #endregion
    }
}