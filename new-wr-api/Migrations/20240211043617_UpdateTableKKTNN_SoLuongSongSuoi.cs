using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace new_wr_api.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTableKKTNN_SoLuongSongSuoi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KKTNN_NuocMat_SoLuong_SongSuoi_Song_IdSong",
                table: "KKTNN_NuocMat_SoLuong_SongSuoi");

            migrationBuilder.DropIndex(
                name: "IX_KKTNN_NuocMat_SoLuong_SongSuoi_IdSong",
                table: "KKTNN_NuocMat_SoLuong_SongSuoi");

            migrationBuilder.DropColumn(
                name: "IdSong",
                table: "KKTNN_NuocMat_SoLuong_SongSuoi");

            migrationBuilder.AddColumn<string>(
                name: "CuoiSongX",
                table: "KKTNN_NuocMat_SoLuong_SongSuoi",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CuoiSongXaHuyenTinh",
                table: "KKTNN_NuocMat_SoLuong_SongSuoi",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CuoiSongY",
                table: "KKTNN_NuocMat_SoLuong_SongSuoi",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DauSongX",
                table: "KKTNN_NuocMat_SoLuong_SongSuoi",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DauSongXaHuyenTinh",
                table: "KKTNN_NuocMat_SoLuong_SongSuoi",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DauSongY",
                table: "KKTNN_NuocMat_SoLuong_SongSuoi",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GhiChu",
                table: "KKTNN_NuocMat_SoLuong_SongSuoi",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MaSong",
                table: "KKTNN_NuocMat_SoLuong_SongSuoi",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TenSong",
                table: "KKTNN_NuocMat_SoLuong_SongSuoi",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CuoiSongX",
                table: "KKTNN_NuocMat_SoLuong_SongSuoi");

            migrationBuilder.DropColumn(
                name: "CuoiSongXaHuyenTinh",
                table: "KKTNN_NuocMat_SoLuong_SongSuoi");

            migrationBuilder.DropColumn(
                name: "CuoiSongY",
                table: "KKTNN_NuocMat_SoLuong_SongSuoi");

            migrationBuilder.DropColumn(
                name: "DauSongX",
                table: "KKTNN_NuocMat_SoLuong_SongSuoi");

            migrationBuilder.DropColumn(
                name: "DauSongXaHuyenTinh",
                table: "KKTNN_NuocMat_SoLuong_SongSuoi");

            migrationBuilder.DropColumn(
                name: "DauSongY",
                table: "KKTNN_NuocMat_SoLuong_SongSuoi");

            migrationBuilder.DropColumn(
                name: "GhiChu",
                table: "KKTNN_NuocMat_SoLuong_SongSuoi");

            migrationBuilder.DropColumn(
                name: "MaSong",
                table: "KKTNN_NuocMat_SoLuong_SongSuoi");

            migrationBuilder.DropColumn(
                name: "TenSong",
                table: "KKTNN_NuocMat_SoLuong_SongSuoi");

            migrationBuilder.AddColumn<int>(
                name: "IdSong",
                table: "KKTNN_NuocMat_SoLuong_SongSuoi",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_KKTNN_NuocMat_SoLuong_SongSuoi_IdSong",
                table: "KKTNN_NuocMat_SoLuong_SongSuoi",
                column: "IdSong");

            migrationBuilder.AddForeignKey(
                name: "FK_KKTNN_NuocMat_SoLuong_SongSuoi_Song_IdSong",
                table: "KKTNN_NuocMat_SoLuong_SongSuoi",
                column: "IdSong",
                principalTable: "Song",
                principalColumn: "Id");
        }
    }
}
