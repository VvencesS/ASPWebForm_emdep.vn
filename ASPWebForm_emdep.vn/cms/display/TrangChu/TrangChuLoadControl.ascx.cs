using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPWebForm_emdep.vn.cms.display.TrangChu
{
    public partial class TrangChuLoadControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ltrSlide.Text = LaySlide();

                
            }
        }
        #region Lấy ảnh slide
        private string LaySlide()
        {
            string s = "";

            //Code lấy ra vị trí quảng nhóm cáo
            DataTable dt = new DataTable();
            dt = ASPWebForm_emdep.vn.App_Code.Database.NhomQuangCao.Thongtin_Nhomquangcao_by_vitriqc("slide");

            //Nếu tồn tại vị trí nhóm quảng cáo --> tìm quảng cáo trong nhóm đó
            if (dt.Rows.Count > 0)
            {
                //Gọi tới phương thức lấy ảnh quảng cáo theo id nhóm quảng cáo
                s = LayAnhSlide(dt.Rows[0]["NhomQuangCaoID"].ToString());
            }

            return s;
        }

        private string LayAnhSlide(string nhomQuangCaoID)
        {
            string s = "";

            DataTable dt = new DataTable();
            dt = ASPWebForm_emdep.vn.App_Code.Database.QuangCao.Thongtin_Quangcao_by_nhomquangcaoid(nhomQuangCaoID);
            if (dt.Rows.Count > 0)
            {

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    s += @"
                    <div data-p='225.00' style='display: none;'>                      
                        <img data-u='image' src='/pic/quangcao/" + dt.Rows[i]["AnhQC"] + @"' alt='" + dt.Rows[i]["TenQC"] + @"' />
                    </div>";
                }

            }

            return s;
        }
        #endregion
    }
}