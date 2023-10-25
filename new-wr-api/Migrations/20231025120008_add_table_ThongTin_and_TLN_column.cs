using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace new_wr_api.Migrations
{
    /// <inheritdoc />
    public partial class add_table_ThongTin_and_TLN_column : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdHuyen",
                table: "TLN_NuocMat_TongLuong");

            migrationBuilder.DropColumn(
                name: "IdXa",
                table: "TLN_NuocMat_TongLuong");

            migrationBuilder.DropColumn(
                name: "IdHuyenCuoiSong",
                table: "TLN_NuocMat_SoLuong");

            migrationBuilder.DropColumn(
                name: "IdHuyenDauSong",
                table: "TLN_NuocMat_SoLuong");

            migrationBuilder.DropColumn(
                name: "IdXaCuoiSong",
                table: "TLN_NuocMat_SoLuong");

            migrationBuilder.DropColumn(
                name: "IdXaDauSong",
                table: "TLN_NuocMat_SoLuong");

            migrationBuilder.DropColumn(
                name: "XCuoiSong",
                table: "TLN_NuocMat_SoLuong");

            migrationBuilder.DropColumn(
                name: "XDauSong",
                table: "TLN_NuocMat_SoLuong");

            migrationBuilder.DropColumn(
                name: "YCuoiSong",
                table: "TLN_NuocMat_SoLuong");

            migrationBuilder.DropColumn(
                name: "YDauSong",
                table: "TLN_NuocMat_SoLuong");

            migrationBuilder.DropColumn(
                name: "PartRiverId",
                table: "Song");

            migrationBuilder.AddColumn<string>(
                name: "TaiKhoanSua",
                table: "TLN_NuocMat_TongLuong",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TaiKhoanTao",
                table: "TLN_NuocMat_TongLuong",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ThoiGianSua",
                table: "TLN_NuocMat_TongLuong",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ThoiGianTao",
                table: "TLN_NuocMat_TongLuong",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdHuyen",
                table: "LuuVucSong",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdXa",
                table: "LuuVucSong",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TLN_NuocMat_TongLuong_IdLuuVucSong",
                table: "TLN_NuocMat_TongLuong",
                column: "IdLuuVucSong");

            migrationBuilder.CreateIndex(
                name: "IX_Song_IdLuuVuc",
                table: "Song",
                column: "IdLuuVuc");

            migrationBuilder.AddForeignKey(
                name: "FK_Song_LuuVucSong_IdLuuVuc",
                table: "Song",
                column: "IdLuuVuc",
                principalTable: "LuuVucSong",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TLN_NuocMat_TongLuong_LuuVucSong_IdLuuVucSong",
                table: "TLN_NuocMat_TongLuong",
                column: "IdLuuVucSong",
                principalTable: "LuuVucSong",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Song_LuuVucSong_IdLuuVuc",
                table: "Song");

            migrationBuilder.DropForeignKey(
                name: "FK_TLN_NuocMat_TongLuong_LuuVucSong_IdLuuVucSong",
                table: "TLN_NuocMat_TongLuong");

            migrationBuilder.DropIndex(
                name: "IX_TLN_NuocMat_TongLuong_IdLuuVucSong",
                table: "TLN_NuocMat_TongLuong");

            migrationBuilder.DropIndex(
                name: "IX_Song_IdLuuVuc",
                table: "Song");

            migrationBuilder.DropColumn(
                name: "TaiKhoanSua",
                table: "TLN_NuocMat_TongLuong");

            migrationBuilder.DropColumn(
                name: "TaiKhoanTao",
                table: "TLN_NuocMat_TongLuong");

            migrationBuilder.DropColumn(
                name: "ThoiGianSua",
                table: "TLN_NuocMat_TongLuong");

            migrationBuilder.DropColumn(
                name: "ThoiGianTao",
                table: "TLN_NuocMat_TongLuong");

            migrationBuilder.DropColumn(
                name: "IdHuyen",
                table: "LuuVucSong");

            migrationBuilder.DropColumn(
                name: "IdXa",
                table: "LuuVucSong");

            migrationBuilder.AddColumn<int>(
                name: "IdHuyen",
                table: "TLN_NuocMat_TongLuong",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdXa",
                table: "TLN_NuocMat_TongLuong",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdHuyenCuoiSong",
                table: "TLN_NuocMat_SoLuong",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdHuyenDauSong",
                table: "TLN_NuocMat_SoLuong",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdXaCuoiSong",
                table: "TLN_NuocMat_SoLuong",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdXaDauSong",
                table: "TLN_NuocMat_SoLuong",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "XCuoiSong",
                table: "TLN_NuocMat_SoLuong",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "XDauSong",
                table: "TLN_NuocMat_SoLuong",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "YCuoiSong",
                table: "TLN_NuocMat_SoLuong",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "YDauSong",
                table: "TLN_NuocMat_SoLuong",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PartRiverId",
                table: "Song",
                type: "int",
                nullable: true);
        }
    }
}
