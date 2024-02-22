using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace new_wr_api.Migrations
{
    /// <inheritdoc />
    public partial class PhanDoanSong : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PhanDoanSong",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LuuVucSong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Song = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenDoanSong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhanDoan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChieuDai = table.Column<double>(type: "float", nullable: true),
                    DienTichLV = table.Column<double>(type: "float", nullable: true),
                    XDau = table.Column<double>(type: "float", nullable: true),
                    YDau = table.Column<double>(type: "float", nullable: true),
                    XCuoi = table.Column<double>(type: "float", nullable: true),
                    YCuoi = table.Column<double>(type: "float", nullable: true),
                    DiaGioiHanhChinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MucDichSuDung = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChatLuongNuoc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TaiKhoanTao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianSua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanSua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DaXoa = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhanDoanSong", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PhanDoanSong");
        }
    }
}
