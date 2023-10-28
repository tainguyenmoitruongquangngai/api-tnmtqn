using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace new_wr_api.Migrations
{
    /// <inheritdoc />
    public partial class create_table_quantrac_for_baocao34 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HangMucDapTran",
                columns: table => new
                {
                    MaHangMucDapTran = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaCongTrinhHoChua = table.Column<int>(type: "int", nullable: true),
                    TenDapTran = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToaDoX_DapTran = table.Column<double>(type: "float", nullable: true),
                    ToaDoY_DapTran = table.Column<double>(type: "float", nullable: true),
                    DiaDienXayDungDapTran_Xa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiaDienXayDungDapTran_Huyen = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HangMucDapTran", x => x.MaHangMucDapTran);
                    table.ForeignKey(
                        name: "FK_HangMucDapTran_CongTrinhHoChua_MaCongTrinhHoChua",
                        column: x => x.MaCongTrinhHoChua,
                        principalTable: "CongTrinhHoChua",
                        principalColumn: "MaCongTrinhHoChua");
                });

            migrationBuilder.CreateTable(
                name: "HangMucNhaMay",
                columns: table => new
                {
                    MaHangMucNhaMay = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaCongTrinhHoChua = table.Column<int>(type: "int", nullable: true),
                    ToaDoX_NhaMay = table.Column<double>(type: "float", nullable: true),
                    ToaDoY_NhaMay = table.Column<double>(type: "float", nullable: true),
                    DiaDiemDatNhaMay_Xa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiaDiemDatNhaMay_Huyen = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HangMucNhaMay", x => x.MaHangMucNhaMay);
                    table.ForeignKey(
                        name: "FK_HangMucNhaMay_CongTrinhHoChua_MaCongTrinhHoChua",
                        column: x => x.MaCongTrinhHoChua,
                        principalTable: "CongTrinhHoChua",
                        principalColumn: "MaCongTrinhHoChua");
                });

            migrationBuilder.CreateTable(
                name: "GiaTriQuanTracLuuLuongXaTran",
                columns: table => new
                {
                    MaGiaTriQuanTracLuuLuongXaTran = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaHangMucDapTran = table.Column<int>(type: "int", nullable: true),
                    MucNuocHoChua = table.Column<double>(type: "float", nullable: true),
                    MucNuocThuongLuu = table.Column<double>(type: "float", nullable: true),
                    MucNuocHaLuu = table.Column<double>(type: "float", nullable: true),
                    LuuLuongNuocVeHo = table.Column<double>(type: "float", nullable: true),
                    LuuLuongXaQuaTranLonNhat = table.Column<double>(type: "float", nullable: true),
                    LuuLuongXaQuaTranNhoNhat = table.Column<double>(type: "float", nullable: true),
                    LuuLuongXaQuaTranTrungBinh = table.Column<double>(type: "float", nullable: true),
                    ThoiGianBatDauXaTran = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ThoiGianKetThucXaTran = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GiaTriQuanTracLuuLuongXaTran", x => x.MaGiaTriQuanTracLuuLuongXaTran);
                    table.ForeignKey(
                        name: "FK_GiaTriQuanTracLuuLuongXaTran_HangMucDapTran_MaHangMucDapTran",
                        column: x => x.MaHangMucDapTran,
                        principalTable: "HangMucDapTran",
                        principalColumn: "MaHangMucDapTran");
                });

            migrationBuilder.CreateTable(
                name: "PhanLoaiDapTran",
                columns: table => new
                {
                    MaPhanLoaiDapTran = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaHangMucDapTran = table.Column<int>(type: "int", nullable: true),
                    PhanLoaiTheoHinhDangCuaVao = table.Column<bool>(type: "bit", nullable: true),
                    PhanLoaiTheoHinhDangVaKichThuocMatCatNgangDapTran = table.Column<bool>(type: "bit", nullable: true),
                    PhanLoaiTheoHinhDangTuyenDap = table.Column<bool>(type: "bit", nullable: true),
                    PhanLoaiTheoCheDoChay = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhanLoaiDapTran", x => x.MaPhanLoaiDapTran);
                    table.ForeignKey(
                        name: "FK_PhanLoaiDapTran_HangMucDapTran_MaHangMucDapTran",
                        column: x => x.MaHangMucDapTran,
                        principalTable: "HangMucDapTran",
                        principalColumn: "MaHangMucDapTran");
                });

            migrationBuilder.CreateTable(
                name: "ThongSoDapTran",
                columns: table => new
                {
                    MaThongSoDapTran = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaHangMucDapTran = table.Column<int>(type: "int", nullable: true),
                    MaCongTrinhHoChua = table.Column<int>(type: "int", nullable: true),
                    HinhThucDapTran = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KetCauDap = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CaoTrinhNguongTran = table.Column<double>(type: "float", nullable: true),
                    SoKhoangTran = table.Column<int>(type: "int", nullable: true),
                    ChieuDaiKhoangTran = table.Column<double>(type: "float", nullable: true),
                    ChieuCaoDapTran = table.Column<double>(type: "float", nullable: true),
                    BeRongKhoanTran = table.Column<double>(type: "float", nullable: true),
                    CaoTrinhDinhTran = table.Column<double>(type: "float", nullable: true),
                    CaoDoMuiPhun = table.Column<double>(type: "float", nullable: true),
                    ChieuCaoDapLonNhat = table.Column<double>(type: "float", nullable: true),
                    KhaNangXaTranUngVoiMnlkt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KhaNangXaTranUngVoiMnltk = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThongSoDapTran", x => x.MaThongSoDapTran);
                    table.ForeignKey(
                        name: "FK_ThongSoDapTran_CongTrinhHoChua_MaCongTrinhHoChua",
                        column: x => x.MaCongTrinhHoChua,
                        principalTable: "CongTrinhHoChua",
                        principalColumn: "MaCongTrinhHoChua");
                    table.ForeignKey(
                        name: "FK_ThongSoDapTran_HangMucDapTran_MaHangMucDapTran",
                        column: x => x.MaHangMucDapTran,
                        principalTable: "HangMucDapTran",
                        principalColumn: "MaHangMucDapTran");
                });

            migrationBuilder.CreateTable(
                name: "CheDoGiamSatLuuLuongXaQuaNhaMay",
                columns: table => new
                {
                    MaCheDoGiamSatLuuLuongXaQuaNhaMay = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaHangMucNhaMay = table.Column<int>(type: "int", nullable: true),
                    GiamSatTuDong = table.Column<bool>(type: "bit", nullable: true),
                    GiamSatDinhKy = table.Column<bool>(type: "bit", nullable: true),
                    GiamSatDinhKyMuaLu = table.Column<bool>(type: "bit", nullable: true),
                    GiamSatDinhKyMuaCan = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CheDoGiamSatLuuLuongXaQuaNhaMay", x => x.MaCheDoGiamSatLuuLuongXaQuaNhaMay);
                    table.ForeignKey(
                        name: "FK_CheDoGiamSatLuuLuongXaQuaNhaMay_HangMucNhaMay_MaHangMucNhaMay",
                        column: x => x.MaHangMucNhaMay,
                        principalTable: "HangMucNhaMay",
                        principalColumn: "MaHangMucNhaMay");
                });

            migrationBuilder.CreateTable(
                name: "CheDoQuanTracLuuLuongXaQuaNhaMay",
                columns: table => new
                {
                    MaCheDoQuanTracLuuLuongXaQuaNhaMay = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaHangMucNhaMay = table.Column<int>(type: "int", nullable: true),
                    QuanTracTrongMuaLu = table.Column<int>(type: "int", nullable: true),
                    QuanTracTruocMuaLu = table.Column<int>(type: "int", nullable: true),
                    QuanTracSauMuaLu = table.Column<int>(type: "int", nullable: true),
                    QuanTracTrongMuaCan = table.Column<int>(type: "int", nullable: true),
                    DieuKienThoiTietBinhThuong = table.Column<int>(type: "int", nullable: true),
                    BaoKhanCap = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CheDoQuanTracLuuLuongXaQuaNhaMay", x => x.MaCheDoQuanTracLuuLuongXaQuaNhaMay);
                    table.ForeignKey(
                        name: "FK_CheDoQuanTracLuuLuongXaQuaNhaMay_HangMucNhaMay_MaHangMucNhaMay",
                        column: x => x.MaHangMucNhaMay,
                        principalTable: "HangMucNhaMay",
                        principalColumn: "MaHangMucNhaMay");
                });

            migrationBuilder.CreateTable(
                name: "GiaTriLuuLuongXaQuaNhaMay",
                columns: table => new
                {
                    MaGiaTriLuuLuongXaQuaNhaMay = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaHangMucNhaMay = table.Column<int>(type: "int", nullable: true),
                    MaCongTrinhHoChua = table.Column<int>(type: "int", nullable: true),
                    LuuLuongXaQuaNhaMay = table.Column<double>(type: "float", nullable: true),
                    NgayGhiNhanLuuLuongXaQuaNhaMay = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GioGhiNhanLuuLuongXaQuaNhaMay = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GiaTriLuuLuongXaQuaNhaMay", x => x.MaGiaTriLuuLuongXaQuaNhaMay);
                    table.ForeignKey(
                        name: "FK_GiaTriLuuLuongXaQuaNhaMay_CongTrinhHoChua_MaCongTrinhHoChua",
                        column: x => x.MaCongTrinhHoChua,
                        principalTable: "CongTrinhHoChua",
                        principalColumn: "MaCongTrinhHoChua");
                    table.ForeignKey(
                        name: "FK_GiaTriLuuLuongXaQuaNhaMay_HangMucNhaMay_MaHangMucNhaMay",
                        column: x => x.MaHangMucNhaMay,
                        principalTable: "HangMucNhaMay",
                        principalColumn: "MaHangMucNhaMay");
                });

            migrationBuilder.CreateTable(
                name: "ThongTinNhaMay",
                columns: table => new
                {
                    MaThongTinNhaMay = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaHangMucNhaMay = table.Column<int>(type: "int", nullable: true),
                    LuuLuongLonNhatQuaNhaMay = table.Column<double>(type: "float", nullable: true),
                    SoToMay = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CongSuatMoiToMay = table.Column<double>(type: "float", nullable: true),
                    KichThuocNhaMay = table.Column<double>(type: "float", nullable: true),
                    CaoTrinhSanLapMay = table.Column<double>(type: "float", nullable: true),
                    CaoTrinhSanChongLuNhaMay = table.Column<double>(type: "float", nullable: true),
                    LuuLuongThietKe = table.Column<double>(type: "float", nullable: true),
                    LuuLuongDamBao = table.Column<double>(type: "float", nullable: true),
                    CongSuatDamBao = table.Column<double>(type: "float", nullable: true),
                    CongSuatLapMay = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThongTinNhaMay", x => x.MaThongTinNhaMay);
                    table.ForeignKey(
                        name: "FK_ThongTinNhaMay_HangMucNhaMay_MaHangMucNhaMay",
                        column: x => x.MaHangMucNhaMay,
                        principalTable: "HangMucNhaMay",
                        principalColumn: "MaHangMucNhaMay");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CheDoGiamSatLuuLuongXaQuaNhaMay_MaHangMucNhaMay",
                table: "CheDoGiamSatLuuLuongXaQuaNhaMay",
                column: "MaHangMucNhaMay",
                unique: true,
                filter: "[MaHangMucNhaMay] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CheDoQuanTracLuuLuongXaQuaNhaMay_MaHangMucNhaMay",
                table: "CheDoQuanTracLuuLuongXaQuaNhaMay",
                column: "MaHangMucNhaMay",
                unique: true,
                filter: "[MaHangMucNhaMay] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_GiaTriLuuLuongXaQuaNhaMay_MaCongTrinhHoChua",
                table: "GiaTriLuuLuongXaQuaNhaMay",
                column: "MaCongTrinhHoChua",
                unique: true,
                filter: "[MaCongTrinhHoChua] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_GiaTriLuuLuongXaQuaNhaMay_MaHangMucNhaMay",
                table: "GiaTriLuuLuongXaQuaNhaMay",
                column: "MaHangMucNhaMay",
                unique: true,
                filter: "[MaHangMucNhaMay] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_GiaTriQuanTracLuuLuongXaTran_MaHangMucDapTran",
                table: "GiaTriQuanTracLuuLuongXaTran",
                column: "MaHangMucDapTran",
                unique: true,
                filter: "[MaHangMucDapTran] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_HangMucDapTran_MaCongTrinhHoChua",
                table: "HangMucDapTran",
                column: "MaCongTrinhHoChua",
                unique: true,
                filter: "[MaCongTrinhHoChua] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_HangMucNhaMay_MaCongTrinhHoChua",
                table: "HangMucNhaMay",
                column: "MaCongTrinhHoChua",
                unique: true,
                filter: "[MaCongTrinhHoChua] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_PhanLoaiDapTran_MaHangMucDapTran",
                table: "PhanLoaiDapTran",
                column: "MaHangMucDapTran",
                unique: true,
                filter: "[MaHangMucDapTran] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ThongSoDapTran_MaCongTrinhHoChua",
                table: "ThongSoDapTran",
                column: "MaCongTrinhHoChua",
                unique: true,
                filter: "[MaCongTrinhHoChua] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ThongSoDapTran_MaHangMucDapTran",
                table: "ThongSoDapTran",
                column: "MaHangMucDapTran",
                unique: true,
                filter: "[MaHangMucDapTran] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ThongTinNhaMay_MaHangMucNhaMay",
                table: "ThongTinNhaMay",
                column: "MaHangMucNhaMay",
                unique: true,
                filter: "[MaHangMucNhaMay] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CheDoGiamSatLuuLuongXaQuaNhaMay");

            migrationBuilder.DropTable(
                name: "CheDoQuanTracLuuLuongXaQuaNhaMay");

            migrationBuilder.DropTable(
                name: "GiaTriLuuLuongXaQuaNhaMay");

            migrationBuilder.DropTable(
                name: "GiaTriQuanTracLuuLuongXaTran");

            migrationBuilder.DropTable(
                name: "PhanLoaiDapTran");

            migrationBuilder.DropTable(
                name: "ThongSoDapTran");

            migrationBuilder.DropTable(
                name: "ThongTinNhaMay");

            migrationBuilder.DropTable(
                name: "HangMucDapTran");

            migrationBuilder.DropTable(
                name: "HangMucNhaMay");
        }
    }
}
