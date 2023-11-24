using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace new_wr_api.Migrations
{
    /// <inheritdoc />
    public partial class Update_Table_LuuLuongTheoMucDich : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TaiKhoanSua",
                table: "LuuLuongTheoMucDich",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TaiKhoanTao",
                table: "LuuLuongTheoMucDich",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ThoiGianSua",
                table: "LuuLuongTheoMucDich",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ThoiGianTao",
                table: "LuuLuongTheoMucDich",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TaiKhoanSua",
                table: "LuuLuongTheoMucDich");

            migrationBuilder.DropColumn(
                name: "TaiKhoanTao",
                table: "LuuLuongTheoMucDich");

            migrationBuilder.DropColumn(
                name: "ThoiGianSua",
                table: "LuuLuongTheoMucDich");

            migrationBuilder.DropColumn(
                name: "ThoiGianTao",
                table: "LuuLuongTheoMucDich");
        }
    }
}
