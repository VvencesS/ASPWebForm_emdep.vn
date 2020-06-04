<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ASPWebForm_emdep.vn.Default" %>

<%@ Register Src="~/cms/display/DisplayLoadControl.ascx" TagPrefix="uc1" TagName="DisplayLoadControl" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>EmDep.vn</title>
    <link href="css/index.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div id="dongke"></div>
            <!--đầu trang-->
            <div id="dautrang">
                <div class="contener">
                    <div id="logo">
                        <div id="logochu">
                            <asp:Literal ID="ltrLogo" runat="server"></asp:Literal>
                        </div>
                        <div id="logoanh">
                            <asp:Literal ID="ltrBanner" runat="server"></asp:Literal>
                        </div>
                    </div>
                </div>
            </div>

            <!--menu đầu trang-->
            <div id="menudautrang">
                <div class="contener">
                    <div id="menutrai">
                        <ul class="menungang">
                            <asp:Literal ID="ltrMenu" runat="server"></asp:Literal>
                        </ul>
                    </div>
                    <div id="dangnhap">
                        <asp:PlaceHolder ID="plChuaDangNhap" runat="server">
                            <ul>
                                <li class="dangnhap1">/<a href="Default.aspx?modul=ThanhVien&modulphu=DangKy">Đăng ký</a></li>
                                <li class="dangnhap2"><a href="Default.aspx?modul=ThanhVien&modulphu=DangNhap">Đăng nhập</a></li>
                            </ul>
                        </asp:PlaceHolder>

                        <asp:PlaceHolder ID="plDaDangNhap" runat="server" Visible="False">
                            <ul>
                                <li class="dangnhap1">/<asp:LinkButton ID="lbtDangXuat" runat="server" CausesValidation="False" OnClick="lbtDangXuat_Click">Đăng xuất</asp:LinkButton></li>
                                <li class="dangnhap2">
                                    <asp:Literal ID="ltrTenKhachHang" runat="server"></asp:Literal></li>
                            </ul>
                        </asp:PlaceHolder>
                    </div>
                </div>
            </div>

            <!--thanh tìm kiếm + giỏ hàng-->
            <div id="timkiem">
                <div class="contener">
                    <div id="timkiem">
                        <div class="timkiemtrai">
                            <div class="timkiemanh"></div>
                        </div>
                        <div class="timkiemphai">
                            <div class="giohang">
                                <a id="cart" style="display: inline-block" href="/Default.aspx?modul=SanPham&modulphu=GioHang"></a>
                            </div>
                            <div class="hotline">
                                <div class="label">HOTLINE</div>
                                <div class="number">096.3290.731 - 090.2234.481</div>
                            </div>
                            <div class="otimkiem">
                                <div class="search">
                                    <div id="searchForm" name="searchForm">
                                        <input type="text" class="key" placeholder="Từ khóa tìm kiếm" value="" name="pr_name" id="keysearch">
                                        <input type="submit" value="Tìm kiếm" class="submit">
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

            <!--thân trang-->
            <div id="thantrang">
                <div class="contener">
                    <div id="trangtrai">
                        <asp:PlaceHolder ID="plDanhMucSanPham" runat="server">
                            <div id="danhmuc">
                                <div class="daumuc"><a>DANH MỤC SẢN PHẨM</a></div>
                                <div class="ditmuc">
                                    <ul>
                                        <asp:Literal ID="ltrDanhMucSanPham" runat="server"></asp:Literal>
                                    </ul>
                                </div>
                            </div>
                        </asp:PlaceHolder>
                        <asp:PlaceHolder ID="plDanhMucTinTuc" runat="server" Visible="False">
                            <div id="danhmuc">
                                <div class="daumuc"><a>DANH MỤC TIN TỨC</a></div>
                                <div class="ditmuc">
                                    <ul>
                                        <asp:Literal ID="ltrDanhMucTinTuc" runat="server"></asp:Literal>
                                    </ul>
                                </div>
                            </div>
                        </asp:PlaceHolder>
                        <div id="hotro">
                            <div id="pichotro">
                                <div class="logohotro">
                                    <img src="../css/images/akmasa.png" title="pichtro" />
                                </div>
                                <h3>Hỗ trợ trực tuyến</h3>
                            </div>
                            <div class="support">
                                <div class="text-center">
                                    <p>
                                        <span class="supp-name">Hồng Anh</span>
                                        <br />
                                        <span class="phone">090.2234.481</span>
                                    </p>
                                    <a href="skype:?chat" class="skype">
                                        <img src="../css/images/skype-icon.png" />
                                    </a>
                                    <a href="ymsgr:sendim?pinkypinky_vn" class="yahoo">
                                        <img src="../css/images/yahoo-icon.png" />
                                    </a>
                                </div>
                                <div class="text-center">
                                    <p>
                                        <span class="supp-name">Số hotline</span>
                                        <br />
                                        <span class="phone">096.3290.731</span>
                                    </p>
                                </div>
                                <div class="text-center">
                                    <p>
                                        <span class="supp-name">Thời gian làm việc</span>
                                        <br />
                                        <span class="phone">24/24</span>
                                    </p>
                                </div>
                            </div>
                        </div>
                        <div id="thanhtoan">
                            <div class="title-thanhtoan">
                                <a>THÔNG TIN GIAO DỊCH</a>
                            </div>
                            <div class="thongtinnganhang">
                                <div class="nganhang">
                                    <img src="../css/images/nganhang/vietcombank.png" />
                                    <p>
                                        <strong>Ngân hàng Vietcombank</strong>
                                        <br>
                                        Số TK: 0011 0031 68537
                                <br>
                                        Chủ TK: Hồng Anh
                                <br>
                                        Chi nhánh Hội sở - Hà Nội
                                    </p>
                                </div>
                                <div class="nganhang">
                                    <img src="../css/images/nganhang/agribank.png" />
                                    <p>
                                        <strong>Ngân hàng Agribank</strong>
                                        <br>
                                        Số TK: 0011 0031 68537
                                <br>
                                        Chủ TK: Hồng Anh
                                <br>
                                        Chi nhánh Hội sở - Hà Nội
                                    </p>
                                </div>
                                <div class="nganhang">
                                    <img src="../css/images/nganhang/vietinbank.png" />
                                    <p>
                                        <strong>Ngân hàng Vietincombank</strong>
                                        <br>
                                        Số TK: 0011 0031 68537
                                <br>
                                        Chủ TK: Hồng Anh
                                <br>
                                        Chi nhánh Hội sở - Hà Nội
                                    </p>
                                </div>
                            </div>
                        </div>
                        <div id="thongketruycap">
                            <div class="title-thongke">
                                <a>THỐNG KÊ TRUY CẬP</a>
                            </div>
                            <div class="so-thongke">
                                <p>Đang online: 100000</p>
                                <p>Lượt truy cập: 1000500</p>
                            </div>
                        </div>
                    </div>
                    <div id="trangphai">
                        <uc1:DisplayLoadControl runat="server" ID="DisplayLoadControl" />
                    </div>
                </div>
            </div>

            <!--chân trang-->
            <div id="footer">
                <div class="contener">
                    <div class=" menufoter">
                        <p>©2015 Copyright by EmDep.vn</p>
                    </div>
                </div>
            </div>
        </div>
    </form>
    <script src="js/jquery-1.8.3.min.js"></script>
</body>
</html>
