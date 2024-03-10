using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace new_wr_api.Migrations
{
    /// <inheritdoc />
    public partial class VHHC : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VHHC_HoChua_ThongSoKT",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenHoChua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThuocLVS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FLv = table.Column<double>(type: "float", nullable: true),
                    XTbNam = table.Column<double>(type: "float", nullable: true),
                    QoTbNam = table.Column<double>(type: "float", nullable: true),
                    P002 = table.Column<double>(type: "float", nullable: true),
                    P01 = table.Column<double>(type: "float", nullable: true),
                    P02 = table.Column<double>(type: "float", nullable: true),
                    P05 = table.Column<double>(type: "float", nullable: true),
                    MNDBT = table.Column<double>(type: "float", nullable: true),
                    MNC = table.Column<double>(type: "float", nullable: true),
                    MNMaxP002 = table.Column<double>(type: "float", nullable: true),
                    MNMaxP01 = table.Column<double>(type: "float", nullable: true),
                    MNMaxP02 = table.Column<double>(type: "float", nullable: true),
                    MNMaxP05 = table.Column<double>(type: "float", nullable: true),
                    WToanBo = table.Column<double>(type: "float", nullable: true),
                    WHuuIch = table.Column<double>(type: "float", nullable: true),
                    WNam = table.Column<double>(type: "float", nullable: true),
                    WNhieuNam = table.Column<double>(type: "float", nullable: true),
                    WChet = table.Column<double>(type: "float", nullable: true),
                    QDamBao = table.Column<double>(type: "float", nullable: true),
                    QMin = table.Column<double>(type: "float", nullable: true),
                    QMax = table.Column<double>(type: "float", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianTao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanTao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianSua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanSua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DaXoa = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VHHC_HoChua_ThongSoKT", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VHHC_LuuVucSong",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LuuVucSong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DienTichLuuVuc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChieuDaiSongChinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BanDo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoDoCacCT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoQuyTrinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TepDinhKem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianTao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanTao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianSua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanSua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DaXoa = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VHHC_LuuVucSong", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VHHC_HoChua_ThongSoKT");

            migrationBuilder.DropTable(
                name: "VHHC_LuuVucSong");
        }
    }
}
