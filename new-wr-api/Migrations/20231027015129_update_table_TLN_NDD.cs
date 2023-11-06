using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace new_wr_api.Migrations
{
    /// <inheritdoc />
    public partial class update_table_TLN_NDD : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_TLN_NuocDuoiDat_SoLuong_IdTangChuaNuoc",
                table: "TLN_NuocDuoiDat_SoLuong",
                column: "IdTangChuaNuoc");

            migrationBuilder.AddForeignKey(
                name: "FK_TLN_NuocDuoiDat_SoLuong_TangChuaNuoc_IdTangChuaNuoc",
                table: "TLN_NuocDuoiDat_SoLuong",
                column: "IdTangChuaNuoc",
                principalTable: "TangChuaNuoc",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TLN_NuocDuoiDat_SoLuong_TangChuaNuoc_IdTangChuaNuoc",
                table: "TLN_NuocDuoiDat_SoLuong");

            migrationBuilder.DropIndex(
                name: "IX_TLN_NuocDuoiDat_SoLuong_IdTangChuaNuoc",
                table: "TLN_NuocDuoiDat_SoLuong");
        }
    }
}
