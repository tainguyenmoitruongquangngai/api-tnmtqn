using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace new_wr_api.Migrations
{
    /// <inheritdoc />
    public partial class create_table_quantrac_for_baocao2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DuLieuQuanTracCuaCTKTNDD",
                columns: table => new
                {
                    MaDuLieuQuanTracCuaCTKTNDD = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaThongTinCongTrinh = table.Column<int>(type: "int", nullable: true),
                    LuuLuongKTGiengKhoan = table.Column<double>(type: "float", nullable: true),
                    MucNuocTrongGiengKT = table.Column<double>(type: "float", nullable: true),
                    MucNuocTrongGiengQT = table.Column<double>(type: "float", nullable: true),
                    TrangThaiVH = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DuLieuQuanTracCuaCTKTNDD", x => x.MaDuLieuQuanTracCuaCTKTNDD);
                    table.ForeignKey(
                        name: "FK_DuLieuQuanTracCuaCTKTNDD_QLC_CongTrinh_MaThongTinCongTrinh",
                        column: x => x.MaThongTinCongTrinh,
                        principalTable: "QLC_CongTrinh",
                        principalColumn: "MaCT");
                });

            migrationBuilder.CreateTable(
                name: "DuLieuQuanTracCuaCTXaThai",
                columns: table => new
                {
                    MaDuLieuQuanTracCongTrinhXaThai = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaThongTinCongTrinh = table.Column<int>(type: "int", nullable: true),
                    LuuLuongNuocThaiSauXuLy = table.Column<double>(type: "float", nullable: true),
                    ChatLuongNuocThaiSauXuLy = table.Column<double>(type: "float", nullable: true),
                    LuuLuongNuocThaiTaiNguonTiepNhan = table.Column<double>(type: "float", nullable: true),
                    TrangThaiVH = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DuLieuQuanTracCuaCTXaThai", x => x.MaDuLieuQuanTracCongTrinhXaThai);
                    table.ForeignKey(
                        name: "FK_DuLieuQuanTracCuaCTXaThai_QLC_CongTrinh_MaThongTinCongTrinh",
                        column: x => x.MaThongTinCongTrinh,
                        principalTable: "QLC_CongTrinh",
                        principalColumn: "MaCT");
                });

            migrationBuilder.CreateTable(
                name: "SoLieuQuanTrac",
                columns: table => new
                {
                    MaSoLieuQuanTrac = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaThongTinCongTrinh = table.Column<int>(type: "int", nullable: true),
                    LuuLuongKTLonNhat = table.Column<double>(type: "float", nullable: true),
                    GiaTriLuuLuongKhaiThac = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SoLieuQuanTrac", x => x.MaSoLieuQuanTrac);
                    table.ForeignKey(
                        name: "FK_SoLieuQuanTrac_QLC_CongTrinh_MaThongTinCongTrinh",
                        column: x => x.MaThongTinCongTrinh,
                        principalTable: "QLC_CongTrinh",
                        principalColumn: "MaCT");
                });

            migrationBuilder.CreateIndex(
                name: "IX_DuLieuQuanTracCuaCTKTNDD_MaThongTinCongTrinh",
                table: "DuLieuQuanTracCuaCTKTNDD",
                column: "MaThongTinCongTrinh");

            migrationBuilder.CreateIndex(
                name: "IX_DuLieuQuanTracCuaCTXaThai_MaThongTinCongTrinh",
                table: "DuLieuQuanTracCuaCTXaThai",
                column: "MaThongTinCongTrinh");

            migrationBuilder.CreateIndex(
                name: "IX_SoLieuQuanTrac_MaThongTinCongTrinh",
                table: "SoLieuQuanTrac",
                column: "MaThongTinCongTrinh");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DuLieuQuanTracCuaCTKTNDD");

            migrationBuilder.DropTable(
                name: "DuLieuQuanTracCuaCTXaThai");

            migrationBuilder.DropTable(
                name: "SoLieuQuanTrac");
        }
    }
}
