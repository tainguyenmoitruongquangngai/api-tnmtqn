using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace new_wr_api.Migrations
{
    /// <inheritdoc />
    public partial class create_table_quantrac_for_baocao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PhanLoaiHoChuaTheoMDSD",
                columns: table => new
                {
                    MaPhanLoaiHoChuaTheoMDSD = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLoaiHoChua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhanLoaiHoChuaTheoMDSD", x => x.MaPhanLoaiHoChuaTheoMDSD);
                });

            migrationBuilder.CreateTable(
                name: "CongTrinhHoChua",
                columns: table => new
                {
                    MaCongTrinhHoChua = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaPhanLoaiHoChuaTheoMDSD = table.Column<int>(type: "int", nullable: true),
                    TenCtHoChua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToaDoX_Hochua = table.Column<double>(type: "float", nullable: true),
                    ToaDoY_Hochua = table.Column<double>(type: "float", nullable: true),
                    DiaDiemCtHoChua = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CongTrinhHoChua", x => x.MaCongTrinhHoChua);
                    table.ForeignKey(
                        name: "FK_CongTrinhHoChua_PhanLoaiHoChuaTheoMDSD_MaPhanLoaiHoChuaTheoMDSD",
                        column: x => x.MaPhanLoaiHoChuaTheoMDSD,
                        principalTable: "PhanLoaiHoChuaTheoMDSD",
                        principalColumn: "MaPhanLoaiHoChuaTheoMDSD");
                });

            migrationBuilder.CreateTable(
                name: "CongTrinhQuanTracLuuLuong",
                columns: table => new
                {
                    MaCongTrinhQuanTracLuuLuong = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaPhanLoaiHoChuaTheoMDSD = table.Column<int>(type: "int", nullable: true),
                    TenCtQuanTracXaDuyTriDctt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToaDoX = table.Column<float>(type: "real", nullable: true),
                    ToaDoY = table.Column<float>(type: "real", nullable: true),
                    CapCongTrinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NguonNuocKhaiThac = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GiaTriDcttDoiVoiSongSuoi = table.Column<float>(type: "real", nullable: true),
                    GiaTriDcttHaLuuHoChua = table.Column<float>(type: "real", nullable: true),
                    DiaDiemCongTrinh_Xa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiaDiemCongTrinh_Huyen = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CongTrinhQuanTracLuuLuong", x => x.MaCongTrinhQuanTracLuuLuong);
                    table.ForeignKey(
                        name: "FK_CongTrinhQuanTracLuuLuong_PhanLoaiHoChuaTheoMDSD_MaPhanLoaiHoChuaTheoMDSD",
                        column: x => x.MaPhanLoaiHoChuaTheoMDSD,
                        principalTable: "PhanLoaiHoChuaTheoMDSD",
                        principalColumn: "MaPhanLoaiHoChuaTheoMDSD");
                });

            migrationBuilder.CreateTable(
                name: "CacCapBaoDongMucNuocLu",
                columns: table => new
                {
                    MaCacCapBaoDongMucNuocLu = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaCongTrinhHoChua = table.Column<int>(type: "int", nullable: true),
                    TenSong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenTramThuyVan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MucNuocTuongUngVoiCapBaoDong1 = table.Column<double>(type: "float", nullable: true),
                    MucNuocTuongUngVoiCapBaoDong2 = table.Column<double>(type: "float", nullable: true),
                    MucNuocTuongUngVoiCapBaoDong3 = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CacCapBaoDongMucNuocLu", x => x.MaCacCapBaoDongMucNuocLu);
                    table.ForeignKey(
                        name: "FK_CacCapBaoDongMucNuocLu_CongTrinhHoChua_MaCongTrinhHoChua",
                        column: x => x.MaCongTrinhHoChua,
                        principalTable: "CongTrinhHoChua",
                        principalColumn: "MaCongTrinhHoChua");
                });

            migrationBuilder.CreateTable(
                name: "CheDoQuanTracMucNuoc",
                columns: table => new
                {
                    MaCheDoQuanTracMucNuoc = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaCongTrinhHoChua = table.Column<int>(type: "int", nullable: true),
                    CheDoQuanTracMucNuocHoMuaLu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CheDoQuanTracMucNuocHoMuaKiet = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CheDoQuanTracMucNuoc", x => x.MaCheDoQuanTracMucNuoc);
                    table.ForeignKey(
                        name: "FK_CheDoQuanTracMucNuoc_CongTrinhHoChua_MaCongTrinhHoChua",
                        column: x => x.MaCongTrinhHoChua,
                        principalTable: "CongTrinhHoChua",
                        principalColumn: "MaCongTrinhHoChua");
                });

            migrationBuilder.CreateTable(
                name: "GiaTriMucNuocQuanTrac",
                columns: table => new
                {
                    MaGiaTriMucNuocQuanTrac = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaCongTrinhHoChua = table.Column<int>(type: "int", nullable: true),
                    MaThongTinCongTrinh = table.Column<int>(type: "int", nullable: true),
                    MucNuocHo = table.Column<double>(type: "float", nullable: true),
                    MucNuocThuongLuu = table.Column<double>(type: "float", nullable: true),
                    MucNuocHaLuu = table.Column<double>(type: "float", nullable: true),
                    ThoiGianQuanTracMucNuoc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GiaTriMucNuocQuanTrac", x => x.MaGiaTriMucNuocQuanTrac);
                    table.ForeignKey(
                        name: "FK_GiaTriMucNuocQuanTrac_CongTrinhHoChua_MaCongTrinhHoChua",
                        column: x => x.MaCongTrinhHoChua,
                        principalTable: "CongTrinhHoChua",
                        principalColumn: "MaCongTrinhHoChua");
                    table.ForeignKey(
                        name: "FK_GiaTriMucNuocQuanTrac_ThongTinCongTrinh_MaThongTinCongTrinh",
                        column: x => x.MaThongTinCongTrinh,
                        principalTable: "ThongTinCongTrinh",
                        principalColumn: "MaThongTinCongTrinh");
                });

            migrationBuilder.CreateTable(
                name: "ThongSoThietKeCuaMucNuoc",
                columns: table => new
                {
                    MaThongSoThietKeCuaMucNuoc = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaCongTrinhHoChua = table.Column<int>(type: "int", nullable: true),
                    MucNuocChet = table.Column<double>(type: "float", nullable: true),
                    MucNuocDangBinhThuong = table.Column<double>(type: "float", nullable: true),
                    MucNuocPhongLu = table.Column<double>(type: "float", nullable: true),
                    MucNuocLuKiemTra = table.Column<double>(type: "float", nullable: true),
                    MucNuocLuThietKe = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThongSoThietKeCuaMucNuoc", x => x.MaThongSoThietKeCuaMucNuoc);
                    table.ForeignKey(
                        name: "FK_ThongSoThietKeCuaMucNuoc_CongTrinhHoChua_MaCongTrinhHoChua",
                        column: x => x.MaCongTrinhHoChua,
                        principalTable: "CongTrinhHoChua",
                        principalColumn: "MaCongTrinhHoChua");
                });

            migrationBuilder.CreateTable(
                name: "CheDoQuanTracLuuLuongDongChayToiThieu",
                columns: table => new
                {
                    MaCheDoQuanTracLuuLuongDongChayToiThieu = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaCongTrinhQuanTracLuuLuong = table.Column<int>(type: "int", nullable: true),
                    QuanTracLuuLuongXaDuyTriDcttVaoMuaLu = table.Column<double>(type: "float", nullable: true),
                    QuanTracLuuLuongXaDuyTriDcttVaoMuaCan = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CheDoQuanTracLuuLuongDongChayToiThieu", x => x.MaCheDoQuanTracLuuLuongDongChayToiThieu);
                    table.ForeignKey(
                        name: "FK_CheDoQuanTracLuuLuongDongChayToiThieu_CongTrinhQuanTracLuuLuong_MaCongTrinhQuanTracLuuLuong",
                        column: x => x.MaCongTrinhQuanTracLuuLuong,
                        principalTable: "CongTrinhQuanTracLuuLuong",
                        principalColumn: "MaCongTrinhQuanTracLuuLuong");
                });

            migrationBuilder.CreateTable(
                name: "ThongTinChatLuongNuoc",
                columns: table => new
                {
                    MaThongTinChatLuongNuoc = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaCongTrinhQuanTracLuuLuong = table.Column<int>(type: "int", nullable: true),
                    NhietDo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ph = table.Column<double>(type: "float", nullable: true),
                    Bod5 = table.Column<double>(type: "float", nullable: true),
                    Cod = table.Column<double>(type: "float", nullable: true),
                    Do = table.Column<double>(type: "float", nullable: true),
                    Nh4 = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThongTinChatLuongNuoc", x => x.MaThongTinChatLuongNuoc);
                    table.ForeignKey(
                        name: "FK_ThongTinChatLuongNuoc_CongTrinhQuanTracLuuLuong_MaCongTrinhQuanTracLuuLuong",
                        column: x => x.MaCongTrinhQuanTracLuuLuong,
                        principalTable: "CongTrinhQuanTracLuuLuong",
                        principalColumn: "MaCongTrinhQuanTracLuuLuong");
                });

            migrationBuilder.CreateTable(
                name: "ThongTinLuuLuongXaCuaCt",
                columns: table => new
                {
                    MaThongTinLuuLuongXaCuaCt = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaCongTrinhQuanTracLuuLuong = table.Column<int>(type: "int", nullable: true),
                    LuuLuongXaLonNhatDuyTriDctt = table.Column<double>(type: "float", nullable: true),
                    LuuLuongXaNhoNhatDuyTriDctt = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThongTinLuuLuongXaCuaCt", x => x.MaThongTinLuuLuongXaCuaCt);
                    table.ForeignKey(
                        name: "FK_ThongTinLuuLuongXaCuaCt_CongTrinhQuanTracLuuLuong_MaCongTrinhQuanTracLuuLuong",
                        column: x => x.MaCongTrinhQuanTracLuuLuong,
                        principalTable: "CongTrinhQuanTracLuuLuong",
                        principalColumn: "MaCongTrinhQuanTracLuuLuong");
                });

            migrationBuilder.CreateTable(
                name: "ThongTinCongTrinhHoChua",
                columns: table => new
                {
                    MaThongTinCongTrinh = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaCongTrinhHoChua = table.Column<int>(type: "int", nullable: true),
                    PhuongThucKhaiThac = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CheDoKhaiThac = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MucDichKhaiThac = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DungTichChetCuaHoChua = table.Column<double>(type: "float", nullable: true),
                    DungTichToanBoHoChua = table.Column<double>(type: "float", nullable: true),
                    DungTichHuuIchCuaHoChua = table.Column<double>(type: "float", nullable: true),
                    GiaTriMucNuocQuanTracMaGiaTriMucNuocQuanTrac = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThongTinCongTrinhHoChua", x => x.MaThongTinCongTrinh);
                    table.ForeignKey(
                        name: "FK_ThongTinCongTrinhHoChua_CongTrinhHoChua_MaCongTrinhHoChua",
                        column: x => x.MaCongTrinhHoChua,
                        principalTable: "CongTrinhHoChua",
                        principalColumn: "MaCongTrinhHoChua");
                    table.ForeignKey(
                        name: "FK_ThongTinCongTrinhHoChua_GiaTriMucNuocQuanTrac_GiaTriMucNuocQuanTracMaGiaTriMucNuocQuanTrac",
                        column: x => x.GiaTriMucNuocQuanTracMaGiaTriMucNuocQuanTrac,
                        principalTable: "GiaTriMucNuocQuanTrac",
                        principalColumn: "MaGiaTriMucNuocQuanTrac");
                });

            migrationBuilder.CreateTable(
                name: "GiaTriQuanTracLuuLuongXa",
                columns: table => new
                {
                    MaGiaTriQuanTracLuuLuongXa = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaCongTrinhQuanTracLuuLuong = table.Column<int>(type: "int", nullable: true),
                    MaThongTinChatLuongNuoc = table.Column<int>(type: "int", nullable: true),
                    ThoiGianQuanTracLuuLuongXaDuyTriDctt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TanSuatQuanTracLuuLuongXaDuyTriDctt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ViTriQuanTracLuuLuongDuyTriDctt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LuuLuongXaCuaCongTrinh = table.Column<double>(type: "float", nullable: true),
                    TinhTrang = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MucNuocHoTruocKhiXa = table.Column<double>(type: "float", nullable: true),
                    MucNuocHoSauKhiXa = table.Column<double>(type: "float", nullable: true),
                    MucNuocSong = table.Column<double>(type: "float", nullable: true),
                    DungTichHoHuaIchCuaHoChuaSauKhiXa = table.Column<double>(type: "float", nullable: true),
                    DungTichToanBoHoChuaSauKhiXa = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GiaTriQuanTracLuuLuongXa", x => x.MaGiaTriQuanTracLuuLuongXa);
                    table.ForeignKey(
                        name: "FK_GiaTriQuanTracLuuLuongXa_CongTrinhQuanTracLuuLuong_MaCongTrinhQuanTracLuuLuong",
                        column: x => x.MaCongTrinhQuanTracLuuLuong,
                        principalTable: "CongTrinhQuanTracLuuLuong",
                        principalColumn: "MaCongTrinhQuanTracLuuLuong");
                    table.ForeignKey(
                        name: "FK_GiaTriQuanTracLuuLuongXa_ThongTinChatLuongNuoc_MaThongTinChatLuongNuoc",
                        column: x => x.MaThongTinChatLuongNuoc,
                        principalTable: "ThongTinChatLuongNuoc",
                        principalColumn: "MaThongTinChatLuongNuoc");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CacCapBaoDongMucNuocLu_MaCongTrinhHoChua",
                table: "CacCapBaoDongMucNuocLu",
                column: "MaCongTrinhHoChua",
                unique: true,
                filter: "[MaCongTrinhHoChua] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CheDoQuanTracLuuLuongDongChayToiThieu_MaCongTrinhQuanTracLuuLuong",
                table: "CheDoQuanTracLuuLuongDongChayToiThieu",
                column: "MaCongTrinhQuanTracLuuLuong",
                unique: true,
                filter: "[MaCongTrinhQuanTracLuuLuong] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CheDoQuanTracMucNuoc_MaCongTrinhHoChua",
                table: "CheDoQuanTracMucNuoc",
                column: "MaCongTrinhHoChua",
                unique: true,
                filter: "[MaCongTrinhHoChua] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CongTrinhHoChua_MaPhanLoaiHoChuaTheoMDSD",
                table: "CongTrinhHoChua",
                column: "MaPhanLoaiHoChuaTheoMDSD");

            migrationBuilder.CreateIndex(
                name: "IX_CongTrinhQuanTracLuuLuong_MaPhanLoaiHoChuaTheoMDSD",
                table: "CongTrinhQuanTracLuuLuong",
                column: "MaPhanLoaiHoChuaTheoMDSD");

            migrationBuilder.CreateIndex(
                name: "IX_GiaTriMucNuocQuanTrac_MaCongTrinhHoChua",
                table: "GiaTriMucNuocQuanTrac",
                column: "MaCongTrinhHoChua",
                unique: true,
                filter: "[MaCongTrinhHoChua] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_GiaTriMucNuocQuanTrac_MaThongTinCongTrinh",
                table: "GiaTriMucNuocQuanTrac",
                column: "MaThongTinCongTrinh");

            migrationBuilder.CreateIndex(
                name: "IX_GiaTriQuanTracLuuLuongXa_MaCongTrinhQuanTracLuuLuong",
                table: "GiaTriQuanTracLuuLuongXa",
                column: "MaCongTrinhQuanTracLuuLuong",
                unique: true,
                filter: "[MaCongTrinhQuanTracLuuLuong] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_GiaTriQuanTracLuuLuongXa_MaThongTinChatLuongNuoc",
                table: "GiaTriQuanTracLuuLuongXa",
                column: "MaThongTinChatLuongNuoc",
                unique: true,
                filter: "[MaThongTinChatLuongNuoc] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ThongSoThietKeCuaMucNuoc_MaCongTrinhHoChua",
                table: "ThongSoThietKeCuaMucNuoc",
                column: "MaCongTrinhHoChua",
                unique: true,
                filter: "[MaCongTrinhHoChua] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ThongTinChatLuongNuoc_MaCongTrinhQuanTracLuuLuong",
                table: "ThongTinChatLuongNuoc",
                column: "MaCongTrinhQuanTracLuuLuong",
                unique: true,
                filter: "[MaCongTrinhQuanTracLuuLuong] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ThongTinCongTrinhHoChua_GiaTriMucNuocQuanTracMaGiaTriMucNuocQuanTrac",
                table: "ThongTinCongTrinhHoChua",
                column: "GiaTriMucNuocQuanTracMaGiaTriMucNuocQuanTrac");

            migrationBuilder.CreateIndex(
                name: "IX_ThongTinCongTrinhHoChua_MaCongTrinhHoChua",
                table: "ThongTinCongTrinhHoChua",
                column: "MaCongTrinhHoChua",
                unique: true,
                filter: "[MaCongTrinhHoChua] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ThongTinLuuLuongXaCuaCt_MaCongTrinhQuanTracLuuLuong",
                table: "ThongTinLuuLuongXaCuaCt",
                column: "MaCongTrinhQuanTracLuuLuong",
                unique: true,
                filter: "[MaCongTrinhQuanTracLuuLuong] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CacCapBaoDongMucNuocLu");

            migrationBuilder.DropTable(
                name: "CheDoQuanTracLuuLuongDongChayToiThieu");

            migrationBuilder.DropTable(
                name: "CheDoQuanTracMucNuoc");

            migrationBuilder.DropTable(
                name: "GiaTriQuanTracLuuLuongXa");

            migrationBuilder.DropTable(
                name: "ThongSoThietKeCuaMucNuoc");

            migrationBuilder.DropTable(
                name: "ThongTinCongTrinhHoChua");

            migrationBuilder.DropTable(
                name: "ThongTinLuuLuongXaCuaCt");

            migrationBuilder.DropTable(
                name: "ThongTinChatLuongNuoc");

            migrationBuilder.DropTable(
                name: "GiaTriMucNuocQuanTrac");

            migrationBuilder.DropTable(
                name: "CongTrinhQuanTracLuuLuong");

            migrationBuilder.DropTable(
                name: "CongTrinhHoChua");

            migrationBuilder.DropTable(
                name: "PhanLoaiHoChuaTheoMDSD");
        }
    }
}
