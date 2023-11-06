using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace new_wr_api.Migrations
{
    /// <inheritdoc />
    public partial class update_column_NDD_TongLuong : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_TLN_NuocDuoiDat_TongLuong_IdTangChuaNuoc",
                table: "TLN_NuocDuoiDat_TongLuong",
                column: "IdTangChuaNuoc");

            migrationBuilder.AddForeignKey(
                name: "FK_TLN_NuocDuoiDat_TongLuong_TangChuaNuoc_IdTangChuaNuoc",
                table: "TLN_NuocDuoiDat_TongLuong",
                column: "IdTangChuaNuoc",
                principalTable: "TangChuaNuoc",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TLN_NuocDuoiDat_TongLuong_TangChuaNuoc_IdTangChuaNuoc",
                table: "TLN_NuocDuoiDat_TongLuong");

            migrationBuilder.DropIndex(
                name: "IX_TLN_NuocDuoiDat_TongLuong_IdTangChuaNuoc",
                table: "TLN_NuocDuoiDat_TongLuong");
        }
    }
}
