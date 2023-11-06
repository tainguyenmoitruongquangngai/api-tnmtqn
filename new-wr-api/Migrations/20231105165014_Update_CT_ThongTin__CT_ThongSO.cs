using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace new_wr_api.Migrations
{
    /// <inheritdoc />
    public partial class Update_CT_ThongTin__CT_ThongSO : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DungTichTT",
                table: "CT_ThongTin");

            migrationBuilder.DropColumn(
                name: "HHaLuuTT",
                table: "CT_ThongTin");

            migrationBuilder.DropColumn(
                name: "HThuongLuuTT",
                table: "CT_ThongTin");

            migrationBuilder.DropColumn(
                name: "Loi",
                table: "CT_ThongTin");

            migrationBuilder.DropColumn(
                name: "MatKetNoi",
                table: "CT_ThongTin");

            migrationBuilder.DropColumn(
                name: "QMaxTT",
                table: "CT_ThongTin");

            migrationBuilder.DropColumn(
                name: "QMinTT",
                table: "CT_ThongTin");

            migrationBuilder.DropColumn(
                name: "QXaMaxTT",
                table: "CT_ThongTin");

            migrationBuilder.DropColumn(
                name: "QXaTranTT",
                table: "CT_ThongTin");

            migrationBuilder.DropColumn(
                name: "CapCT",
                table: "CT_ThongSo");

            migrationBuilder.RenameColumn(
                name: "ThoiGianTT",
                table: "CT_ThongTin",
                newName: "CapCT");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CapCT",
                table: "CT_ThongTin",
                newName: "ThoiGianTT");

            migrationBuilder.AddColumn<double>(
                name: "DungTichTT",
                table: "CT_ThongTin",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "HHaLuuTT",
                table: "CT_ThongTin",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "HThuongLuuTT",
                table: "CT_ThongTin",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Loi",
                table: "CT_ThongTin",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MatKetNoi",
                table: "CT_ThongTin",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "QMaxTT",
                table: "CT_ThongTin",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "QMinTT",
                table: "CT_ThongTin",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "QXaMaxTT",
                table: "CT_ThongTin",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "QXaTranTT",
                table: "CT_ThongTin",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "CapCT",
                table: "CT_ThongSo",
                type: "float",
                nullable: true);
        }
    }
}
