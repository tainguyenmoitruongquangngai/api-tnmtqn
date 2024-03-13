using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace new_wr_api.Migrations
{
    /// <inheritdoc />
    public partial class Muahientai : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MuaHienTai",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TramMua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LuongMua1Gio = table.Column<double>(type: "float", nullable: true),
                    NguongMua1Gio = table.Column<double>(type: "float", nullable: true),
                    LuongMua3Gio = table.Column<double>(type: "float", nullable: true),
                    NguongMua3Gio = table.Column<double>(type: "float", nullable: true),
                    LuongMua6Gio = table.Column<double>(type: "float", nullable: true),
                    NguongMua6Gio = table.Column<double>(type: "float", nullable: true),
                    LuongMua12Gio = table.Column<double>(type: "float", nullable: true),
                    NguongMua12Gio = table.Column<double>(type: "float", nullable: true),
                    LuongMua24Gio = table.Column<double>(type: "float", nullable: true),
                    NguongMua24Gio = table.Column<double>(type: "float", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianTao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanTao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianSua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanSua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DaXoa = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MuaHienTai", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MuaHienTai");
        }
    }
}
