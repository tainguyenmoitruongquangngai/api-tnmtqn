using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace new_wr_api.Migrations
{
    /// <inheritdoc />
    public partial class update_table_Song : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Y",
                table: "Song",
                newName: "YDauSong");

            migrationBuilder.RenameColumn(
                name: "X",
                table: "Song",
                newName: "YCuoiSong");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Song",
                newName: "TenSong");

            migrationBuilder.RenameColumn(
                name: "IdXa",
                table: "Song",
                newName: "IdXaDauSong");

            migrationBuilder.RenameColumn(
                name: "IdHuyen",
                table: "Song",
                newName: "IdXaCuoiSong");

            migrationBuilder.AddColumn<int>(
                name: "IdHuyenCuoiSong",
                table: "Song",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdHuyenDauSong",
                table: "Song",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "XCuoiSong",
                table: "Song",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "XDauSong",
                table: "Song",
                type: "float",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdHuyenCuoiSong",
                table: "Song");

            migrationBuilder.DropColumn(
                name: "IdHuyenDauSong",
                table: "Song");

            migrationBuilder.DropColumn(
                name: "XCuoiSong",
                table: "Song");

            migrationBuilder.DropColumn(
                name: "XDauSong",
                table: "Song");

            migrationBuilder.RenameColumn(
                name: "YDauSong",
                table: "Song",
                newName: "Y");

            migrationBuilder.RenameColumn(
                name: "YCuoiSong",
                table: "Song",
                newName: "X");

            migrationBuilder.RenameColumn(
                name: "TenSong",
                table: "Song",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "IdXaDauSong",
                table: "Song",
                newName: "IdXa");

            migrationBuilder.RenameColumn(
                name: "IdXaCuoiSong",
                table: "Song",
                newName: "IdHuyen");
        }
    }
}
