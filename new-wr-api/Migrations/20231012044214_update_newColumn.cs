using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace new_wr_api.Migrations
{
    /// <inheritdoc />
    public partial class update_newColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SoLuongGiengQT",
                table: "TangChuaNuoc",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NgayBatDau",
                table: "LuuVucSong",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NgayKetThuc",
                table: "LuuVucSong",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ViTriQT",
                table: "LuuVucSong",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SoLuongGiengQT",
                table: "TangChuaNuoc");

            migrationBuilder.DropColumn(
                name: "NgayBatDau",
                table: "LuuVucSong");

            migrationBuilder.DropColumn(
                name: "NgayKetThuc",
                table: "LuuVucSong");

            migrationBuilder.DropColumn(
                name: "ViTriQT",
                table: "LuuVucSong");
        }
    }
}
