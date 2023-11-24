using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace new_wr_api.Migrations
{
    /// <inheritdoc />
    public partial class Update__CT_ThongTin_And__CT_ThongSo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CHeDoXT",
                table: "CT_ThongTin");

            migrationBuilder.DropColumn(
                name: "PhuongThucXT",
                table: "CT_ThongTin");

            migrationBuilder.AddColumn<int>(
                name: "SoDiemXaThai",
                table: "CT_ThongTin",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CheDoXT",
                table: "CT_ThongSo",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhuongThucXT",
                table: "CT_ThongSo",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SoDiemXaThai",
                table: "CT_ThongTin");

            migrationBuilder.DropColumn(
                name: "CheDoXT",
                table: "CT_ThongSo");

            migrationBuilder.DropColumn(
                name: "PhuongThucXT",
                table: "CT_ThongSo");

            migrationBuilder.AddColumn<string>(
                name: "CHeDoXT",
                table: "CT_ThongTin",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhuongThucXT",
                table: "CT_ThongTin",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
