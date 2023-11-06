using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace new_wr_api.Migrations
{
    /// <inheritdoc />
    public partial class update_column_NDD : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ChieuSauPhanBoDen",
                table: "TLN_NuocDuoiDat_SoLuong");

            migrationBuilder.DropColumn(
                name: "ChieuSauPhanBoTu",
                table: "TLN_NuocDuoiDat_SoLuong");

            migrationBuilder.DropColumn(
                name: "DienTichPhanBo",
                table: "TLN_NuocDuoiDat_SoLuong");

            migrationBuilder.DropColumn(
                name: "HTBThayDoi",
                table: "TLN_NuocDuoiDat_SoLuong");

            migrationBuilder.DropColumn(
                name: "HmaxThayDoi",
                table: "TLN_NuocDuoiDat_SoLuong");

            migrationBuilder.DropColumn(
                name: "HminThayDoi",
                table: "TLN_NuocDuoiDat_SoLuong");

            migrationBuilder.AddColumn<int>(
                name: "SoLuongGieng",
                table: "TLN_NuocDuoiDat_SoLuong",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SoLuongGieng",
                table: "TLN_NuocDuoiDat_SoLuong");

            migrationBuilder.AddColumn<double>(
                name: "ChieuSauPhanBoDen",
                table: "TLN_NuocDuoiDat_SoLuong",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "ChieuSauPhanBoTu",
                table: "TLN_NuocDuoiDat_SoLuong",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "DienTichPhanBo",
                table: "TLN_NuocDuoiDat_SoLuong",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "HTBThayDoi",
                table: "TLN_NuocDuoiDat_SoLuong",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "HmaxThayDoi",
                table: "TLN_NuocDuoiDat_SoLuong",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "HminThayDoi",
                table: "TLN_NuocDuoiDat_SoLuong",
                type: "float",
                nullable: true);
        }
    }
}
