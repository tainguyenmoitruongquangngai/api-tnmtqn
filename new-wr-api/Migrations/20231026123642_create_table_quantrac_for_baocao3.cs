using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace new_wr_api.Migrations
{
    /// <inheritdoc />
    public partial class create_table_quantrac_for_baocao3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CheDoQuanTracLuuLuongDongChayToiThieu_CongTrinhQuanTracLuuLuong_MaCongTrinhQuanTracLuuLuong",
                table: "CheDoQuanTracLuuLuongDongChayToiThieu");

            migrationBuilder.DropForeignKey(
                name: "FK_GiaTriQuanTracLuuLuongXa_CongTrinhQuanTracLuuLuong_MaCongTrinhQuanTracLuuLuong",
                table: "GiaTriQuanTracLuuLuongXa");

            migrationBuilder.DropForeignKey(
                name: "FK_ThongTinChatLuongNuoc_CongTrinhQuanTracLuuLuong_MaCongTrinhQuanTracLuuLuong",
                table: "ThongTinChatLuongNuoc");

            migrationBuilder.DropForeignKey(
                name: "FK_ThongTinLuuLuongXaCuaCt_CongTrinhQuanTracLuuLuong_MaCongTrinhQuanTracLuuLuong",
                table: "ThongTinLuuLuongXaCuaCt");

            migrationBuilder.DropTable(
                name: "CongTrinhQuanTracLuuLuong");

            migrationBuilder.CreateTable(
                name: "CongTrinhQuanTracLuuLuongXaDCTT",
                columns: table => new
                {
                    MaCongTrinhQuanTracLuuLuong = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaCongTrinhHoChua = table.Column<int>(type: "int", nullable: true),
                    TenCtQuanTracXaDuyTriDctt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToaDoX = table.Column<float>(type: "real", nullable: true),
                    ToaDoY = table.Column<float>(type: "real", nullable: true),
                    CapCongTrinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NguonNuocKhaiThac = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GiaTriDcttDoiVoiSongSuoi = table.Column<float>(type: "real", nullable: true),
                    GiaTriDcttHaLuuHoChua = table.Column<float>(type: "real", nullable: true),
                    DiaDiemCongTrinh_Xa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiaDiemCongTrinh_Huyen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhanLoaiHoChuaTheoMDSDMaPhanLoaiHoChuaTheoMDSD = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CongTrinhQuanTracLuuLuongXaDCTT", x => x.MaCongTrinhQuanTracLuuLuong);
                    table.ForeignKey(
                        name: "FK_CongTrinhQuanTracLuuLuongXaDCTT_CongTrinhHoChua_MaCongTrinhHoChua",
                        column: x => x.MaCongTrinhHoChua,
                        principalTable: "CongTrinhHoChua",
                        principalColumn: "MaCongTrinhHoChua");
                    table.ForeignKey(
                        name: "FK_CongTrinhQuanTracLuuLuongXaDCTT_PhanLoaiHoChuaTheoMDSD_PhanLoaiHoChuaTheoMDSDMaPhanLoaiHoChuaTheoMDSD",
                        column: x => x.PhanLoaiHoChuaTheoMDSDMaPhanLoaiHoChuaTheoMDSD,
                        principalTable: "PhanLoaiHoChuaTheoMDSD",
                        principalColumn: "MaPhanLoaiHoChuaTheoMDSD");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CongTrinhQuanTracLuuLuongXaDCTT_MaCongTrinhHoChua",
                table: "CongTrinhQuanTracLuuLuongXaDCTT",
                column: "MaCongTrinhHoChua");

            migrationBuilder.CreateIndex(
                name: "IX_CongTrinhQuanTracLuuLuongXaDCTT_PhanLoaiHoChuaTheoMDSDMaPhanLoaiHoChuaTheoMDSD",
                table: "CongTrinhQuanTracLuuLuongXaDCTT",
                column: "PhanLoaiHoChuaTheoMDSDMaPhanLoaiHoChuaTheoMDSD");

            migrationBuilder.AddForeignKey(
                name: "FK_CheDoQuanTracLuuLuongDongChayToiThieu_CongTrinhQuanTracLuuLuongXaDCTT_MaCongTrinhQuanTracLuuLuong",
                table: "CheDoQuanTracLuuLuongDongChayToiThieu",
                column: "MaCongTrinhQuanTracLuuLuong",
                principalTable: "CongTrinhQuanTracLuuLuongXaDCTT",
                principalColumn: "MaCongTrinhQuanTracLuuLuong");

            migrationBuilder.AddForeignKey(
                name: "FK_GiaTriQuanTracLuuLuongXa_CongTrinhQuanTracLuuLuongXaDCTT_MaCongTrinhQuanTracLuuLuong",
                table: "GiaTriQuanTracLuuLuongXa",
                column: "MaCongTrinhQuanTracLuuLuong",
                principalTable: "CongTrinhQuanTracLuuLuongXaDCTT",
                principalColumn: "MaCongTrinhQuanTracLuuLuong");

            migrationBuilder.AddForeignKey(
                name: "FK_ThongTinChatLuongNuoc_CongTrinhQuanTracLuuLuongXaDCTT_MaCongTrinhQuanTracLuuLuong",
                table: "ThongTinChatLuongNuoc",
                column: "MaCongTrinhQuanTracLuuLuong",
                principalTable: "CongTrinhQuanTracLuuLuongXaDCTT",
                principalColumn: "MaCongTrinhQuanTracLuuLuong");

            migrationBuilder.AddForeignKey(
                name: "FK_ThongTinLuuLuongXaCuaCt_CongTrinhQuanTracLuuLuongXaDCTT_MaCongTrinhQuanTracLuuLuong",
                table: "ThongTinLuuLuongXaCuaCt",
                column: "MaCongTrinhQuanTracLuuLuong",
                principalTable: "CongTrinhQuanTracLuuLuongXaDCTT",
                principalColumn: "MaCongTrinhQuanTracLuuLuong");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CheDoQuanTracLuuLuongDongChayToiThieu_CongTrinhQuanTracLuuLuongXaDCTT_MaCongTrinhQuanTracLuuLuong",
                table: "CheDoQuanTracLuuLuongDongChayToiThieu");

            migrationBuilder.DropForeignKey(
                name: "FK_GiaTriQuanTracLuuLuongXa_CongTrinhQuanTracLuuLuongXaDCTT_MaCongTrinhQuanTracLuuLuong",
                table: "GiaTriQuanTracLuuLuongXa");

            migrationBuilder.DropForeignKey(
                name: "FK_ThongTinChatLuongNuoc_CongTrinhQuanTracLuuLuongXaDCTT_MaCongTrinhQuanTracLuuLuong",
                table: "ThongTinChatLuongNuoc");

            migrationBuilder.DropForeignKey(
                name: "FK_ThongTinLuuLuongXaCuaCt_CongTrinhQuanTracLuuLuongXaDCTT_MaCongTrinhQuanTracLuuLuong",
                table: "ThongTinLuuLuongXaCuaCt");

            migrationBuilder.DropTable(
                name: "CongTrinhQuanTracLuuLuongXaDCTT");

            migrationBuilder.CreateTable(
                name: "CongTrinhQuanTracLuuLuong",
                columns: table => new
                {
                    MaCongTrinhQuanTracLuuLuong = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaPhanLoaiHoChuaTheoMDSD = table.Column<int>(type: "int", nullable: true),
                    CapCongTrinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiaDiemCongTrinh_Huyen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiaDiemCongTrinh_Xa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GiaTriDcttDoiVoiSongSuoi = table.Column<float>(type: "real", nullable: true),
                    GiaTriDcttHaLuuHoChua = table.Column<float>(type: "real", nullable: true),
                    NguonNuocKhaiThac = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenCtQuanTracXaDuyTriDctt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToaDoX = table.Column<float>(type: "real", nullable: true),
                    ToaDoY = table.Column<float>(type: "real", nullable: true)
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

            migrationBuilder.CreateIndex(
                name: "IX_CongTrinhQuanTracLuuLuong_MaPhanLoaiHoChuaTheoMDSD",
                table: "CongTrinhQuanTracLuuLuong",
                column: "MaPhanLoaiHoChuaTheoMDSD");

            migrationBuilder.AddForeignKey(
                name: "FK_CheDoQuanTracLuuLuongDongChayToiThieu_CongTrinhQuanTracLuuLuong_MaCongTrinhQuanTracLuuLuong",
                table: "CheDoQuanTracLuuLuongDongChayToiThieu",
                column: "MaCongTrinhQuanTracLuuLuong",
                principalTable: "CongTrinhQuanTracLuuLuong",
                principalColumn: "MaCongTrinhQuanTracLuuLuong");

            migrationBuilder.AddForeignKey(
                name: "FK_GiaTriQuanTracLuuLuongXa_CongTrinhQuanTracLuuLuong_MaCongTrinhQuanTracLuuLuong",
                table: "GiaTriQuanTracLuuLuongXa",
                column: "MaCongTrinhQuanTracLuuLuong",
                principalTable: "CongTrinhQuanTracLuuLuong",
                principalColumn: "MaCongTrinhQuanTracLuuLuong");

            migrationBuilder.AddForeignKey(
                name: "FK_ThongTinChatLuongNuoc_CongTrinhQuanTracLuuLuong_MaCongTrinhQuanTracLuuLuong",
                table: "ThongTinChatLuongNuoc",
                column: "MaCongTrinhQuanTracLuuLuong",
                principalTable: "CongTrinhQuanTracLuuLuong",
                principalColumn: "MaCongTrinhQuanTracLuuLuong");

            migrationBuilder.AddForeignKey(
                name: "FK_ThongTinLuuLuongXaCuaCt_CongTrinhQuanTracLuuLuong_MaCongTrinhQuanTracLuuLuong",
                table: "ThongTinLuuLuongXaCuaCt",
                column: "MaCongTrinhQuanTracLuuLuong",
                principalTable: "CongTrinhQuanTracLuuLuong",
                principalColumn: "MaCongTrinhQuanTracLuuLuong");
        }
    }
}
