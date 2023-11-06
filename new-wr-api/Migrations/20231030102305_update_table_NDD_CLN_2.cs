using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace new_wr_api.Migrations
{
    /// <inheritdoc />
    public partial class update_table_NDD_CLN_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "AmoniMax",
                table: "TLN_NuocDuoiDat_ChatLuong",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "AmoniMin",
                table: "TLN_NuocDuoiDat_ChatLuong",
                type: "float",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AmoniMax",
                table: "TLN_NuocDuoiDat_ChatLuong");

            migrationBuilder.DropColumn(
                name: "AmoniMin",
                table: "TLN_NuocDuoiDat_ChatLuong");
        }
    }
}
