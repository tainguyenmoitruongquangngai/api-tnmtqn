using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace new_wr_api.Migrations
{
    /// <inheritdoc />
    public partial class Update__CT_ThongSo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CheDoKT",
                table: "CT_ThongTin");

            migrationBuilder.AddColumn<string>(
                name: "CheDoKT",
                table: "CT_ThongSo",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "HDoanThuNuocDen",
                table: "CT_ThongSo",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "HDoanThuNuocTu",
                table: "CT_ThongSo",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "HDong",
                table: "CT_ThongSo",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "HTinh",
                table: "CT_ThongSo",
                type: "float",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CheDoKT",
                table: "CT_ThongSo");

            migrationBuilder.DropColumn(
                name: "HDoanThuNuocDen",
                table: "CT_ThongSo");

            migrationBuilder.DropColumn(
                name: "HDoanThuNuocTu",
                table: "CT_ThongSo");

            migrationBuilder.DropColumn(
                name: "HDong",
                table: "CT_ThongSo");

            migrationBuilder.DropColumn(
                name: "HTinh",
                table: "CT_ThongSo");

            migrationBuilder.AddColumn<string>(
                name: "CheDoKT",
                table: "CT_ThongTin",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
