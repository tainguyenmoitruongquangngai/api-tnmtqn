using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace new_wr_api.Migrations
{
    /// <inheritdoc />
    public partial class update_column : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "BOD5Max",
                table: "TLN_NuocMat_ChatLuong",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "BOD5Min",
                table: "TLN_NuocMat_ChatLuong",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "CODMax",
                table: "TLN_NuocMat_ChatLuong",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "CODMin",
                table: "TLN_NuocMat_ChatLuong",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "DOMax",
                table: "TLN_NuocMat_ChatLuong",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "DOMin",
                table: "TLN_NuocMat_ChatLuong",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "HTBBaoCao",
                table: "TLN_NuocDuoiDat_SoLuong",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "HTBKyTruoc",
                table: "TLN_NuocDuoiDat_SoLuong",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "HTBThayDoi",
                table: "TLN_NuocDuoiDat_SoLuong",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "HmaxBaoCao",
                table: "TLN_NuocDuoiDat_SoLuong",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "HmaxKyTruoc",
                table: "TLN_NuocDuoiDat_SoLuong",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "HmaxThayDoi",
                table: "TLN_NuocDuoiDat_SoLuong",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "HminBaoCao",
                table: "TLN_NuocDuoiDat_SoLuong",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "HminKyTruoc",
                table: "TLN_NuocDuoiDat_SoLuong",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "HminThayDoi",
                table: "TLN_NuocDuoiDat_SoLuong",
                type: "float",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BOD5Max",
                table: "TLN_NuocMat_ChatLuong");

            migrationBuilder.DropColumn(
                name: "BOD5Min",
                table: "TLN_NuocMat_ChatLuong");

            migrationBuilder.DropColumn(
                name: "CODMax",
                table: "TLN_NuocMat_ChatLuong");

            migrationBuilder.DropColumn(
                name: "CODMin",
                table: "TLN_NuocMat_ChatLuong");

            migrationBuilder.DropColumn(
                name: "DOMax",
                table: "TLN_NuocMat_ChatLuong");

            migrationBuilder.DropColumn(
                name: "DOMin",
                table: "TLN_NuocMat_ChatLuong");

            migrationBuilder.DropColumn(
                name: "HTBBaoCao",
                table: "TLN_NuocDuoiDat_SoLuong");

            migrationBuilder.DropColumn(
                name: "HTBKyTruoc",
                table: "TLN_NuocDuoiDat_SoLuong");

            migrationBuilder.DropColumn(
                name: "HTBThayDoi",
                table: "TLN_NuocDuoiDat_SoLuong");

            migrationBuilder.DropColumn(
                name: "HmaxBaoCao",
                table: "TLN_NuocDuoiDat_SoLuong");

            migrationBuilder.DropColumn(
                name: "HmaxKyTruoc",
                table: "TLN_NuocDuoiDat_SoLuong");

            migrationBuilder.DropColumn(
                name: "HmaxThayDoi",
                table: "TLN_NuocDuoiDat_SoLuong");

            migrationBuilder.DropColumn(
                name: "HminBaoCao",
                table: "TLN_NuocDuoiDat_SoLuong");

            migrationBuilder.DropColumn(
                name: "HminKyTruoc",
                table: "TLN_NuocDuoiDat_SoLuong");

            migrationBuilder.DropColumn(
                name: "HminThayDoi",
                table: "TLN_NuocDuoiDat_SoLuong");
        }
    }
}
