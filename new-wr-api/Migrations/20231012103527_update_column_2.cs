using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace new_wr_api.Migrations
{
    /// <inheritdoc />
    public partial class update_column_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "DaXoa",
                table: "TLN_NuocMua_TongLuong",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TaiKhoanSua",
                table: "TLN_NuocMua_TongLuong",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TaiKhoanTao",
                table: "TLN_NuocMua_TongLuong",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ThoiGianSua",
                table: "TLN_NuocMua_TongLuong",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ThoiGianTao",
                table: "TLN_NuocMua_TongLuong",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "DaXoa",
                table: "TLN_NuocMat_TongLuong",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "DaXoa",
                table: "TLN_NuocMat_SoLuong",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "DaXoa",
                table: "TLN_NuocMat_ChatLuong",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "DaXoa",
                table: "TLN_NuocDuoiDat_TongLuong",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "DaXoa",
                table: "TLN_NuocDuoiDat_SoLuong",
                type: "bit",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TLN_NuocDuoiDat_ChatLuong",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    pHMax = table.Column<double>(type: "float", nullable: true),
                    pHMin = table.Column<double>(type: "float", nullable: true),
                    PHAvg = table.Column<double>(type: "float", nullable: true),
                    DoCungMax = table.Column<double>(type: "float", nullable: true),
                    DoCungMin = table.Column<double>(type: "float", nullable: true),
                    DoCungAvg = table.Column<double>(type: "float", nullable: true),
                    NitratMax = table.Column<double>(type: "float", nullable: true),
                    NitratMin = table.Column<double>(type: "float", nullable: true),
                    NitratAvg = table.Column<double>(type: "float", nullable: true),
                    SulfatMax = table.Column<double>(type: "float", nullable: true),
                    SulfatMin = table.Column<double>(type: "float", nullable: true),
                    SulfatAvg = table.Column<double>(type: "float", nullable: true),
                    AsenMax = table.Column<double>(type: "float", nullable: true),
                    AsenMin = table.Column<double>(type: "float", nullable: true),
                    AsenAvg = table.Column<double>(type: "float", nullable: true),
                    DaXoa = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TLN_NuocDuoiDat_ChatLuong", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TLN_NuocDuoiDat_ChatLuong");

            migrationBuilder.DropColumn(
                name: "DaXoa",
                table: "TLN_NuocMua_TongLuong");

            migrationBuilder.DropColumn(
                name: "TaiKhoanSua",
                table: "TLN_NuocMua_TongLuong");

            migrationBuilder.DropColumn(
                name: "TaiKhoanTao",
                table: "TLN_NuocMua_TongLuong");

            migrationBuilder.DropColumn(
                name: "ThoiGianSua",
                table: "TLN_NuocMua_TongLuong");

            migrationBuilder.DropColumn(
                name: "ThoiGianTao",
                table: "TLN_NuocMua_TongLuong");

            migrationBuilder.DropColumn(
                name: "DaXoa",
                table: "TLN_NuocMat_TongLuong");

            migrationBuilder.DropColumn(
                name: "DaXoa",
                table: "TLN_NuocMat_SoLuong");

            migrationBuilder.DropColumn(
                name: "DaXoa",
                table: "TLN_NuocMat_ChatLuong");

            migrationBuilder.DropColumn(
                name: "DaXoa",
                table: "TLN_NuocDuoiDat_TongLuong");

            migrationBuilder.DropColumn(
                name: "DaXoa",
                table: "TLN_NuocDuoiDat_SoLuong");
        }
    }
}
