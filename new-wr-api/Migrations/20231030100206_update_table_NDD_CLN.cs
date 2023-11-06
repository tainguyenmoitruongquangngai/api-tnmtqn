using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace new_wr_api.Migrations
{
    /// <inheritdoc />
    public partial class update_table_NDD_CLN : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AsenAvg",
                table: "TLN_NuocDuoiDat_ChatLuong");

            migrationBuilder.DropColumn(
                name: "DoCungAvg",
                table: "TLN_NuocDuoiDat_ChatLuong");

            migrationBuilder.DropColumn(
                name: "NitratAvg",
                table: "TLN_NuocDuoiDat_ChatLuong");

            migrationBuilder.DropColumn(
                name: "PHAvg",
                table: "TLN_NuocDuoiDat_ChatLuong");

            migrationBuilder.DropColumn(
                name: "SulfatAvg",
                table: "TLN_NuocDuoiDat_ChatLuong");

            migrationBuilder.AddColumn<int>(
                name: "IdHuyen",
                table: "TLN_NuocDuoiDat_ChatLuong",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdXa",
                table: "TLN_NuocDuoiDat_ChatLuong",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdHuyen",
                table: "TLN_NuocDuoiDat_ChatLuong");

            migrationBuilder.DropColumn(
                name: "IdXa",
                table: "TLN_NuocDuoiDat_ChatLuong");

            migrationBuilder.AddColumn<double>(
                name: "AsenAvg",
                table: "TLN_NuocDuoiDat_ChatLuong",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "DoCungAvg",
                table: "TLN_NuocDuoiDat_ChatLuong",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "NitratAvg",
                table: "TLN_NuocDuoiDat_ChatLuong",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "PHAvg",
                table: "TLN_NuocDuoiDat_ChatLuong",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "SulfatAvg",
                table: "TLN_NuocDuoiDat_ChatLuong",
                type: "float",
                nullable: true);
        }
    }
}
