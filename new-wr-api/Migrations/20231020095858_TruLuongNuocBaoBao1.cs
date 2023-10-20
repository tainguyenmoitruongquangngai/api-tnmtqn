using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace new_wr_api.Migrations
{
    /// <inheritdoc />
    public partial class TruLuongNuocBaoBao1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MaTangChuaNuoc",
                table: "TLN_CongTrinh",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MaChiTieu",
                table: "ThongTinVeChatLuongNuoc",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TLN_CongTrinh_MaTangChuaNuoc",
                table: "TLN_CongTrinh",
                column: "MaTangChuaNuoc");

            migrationBuilder.CreateIndex(
                name: "IX_ThongTinVeChatLuongNuoc_MaChiTieu",
                table: "ThongTinVeChatLuongNuoc",
                column: "MaChiTieu");

            migrationBuilder.AddForeignKey(
                name: "FK_ThongTinVeChatLuongNuoc_ThongTinVeCacChiTieuPhanTichCLN_MaChiTieu",
                table: "ThongTinVeChatLuongNuoc",
                column: "MaChiTieu",
                principalTable: "ThongTinVeCacChiTieuPhanTichCLN",
                principalColumn: "MaChiTieu");

            migrationBuilder.AddForeignKey(
                name: "FK_TLN_CongTrinh_TLN_TangChuaNuoc_MaTangChuaNuoc",
                table: "TLN_CongTrinh",
                column: "MaTangChuaNuoc",
                principalTable: "TLN_TangChuaNuoc",
                principalColumn: "MaTangChuaNuoc");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ThongTinVeChatLuongNuoc_ThongTinVeCacChiTieuPhanTichCLN_MaChiTieu",
                table: "ThongTinVeChatLuongNuoc");

            migrationBuilder.DropForeignKey(
                name: "FK_TLN_CongTrinh_TLN_TangChuaNuoc_MaTangChuaNuoc",
                table: "TLN_CongTrinh");

            migrationBuilder.DropIndex(
                name: "IX_TLN_CongTrinh_MaTangChuaNuoc",
                table: "TLN_CongTrinh");

            migrationBuilder.DropIndex(
                name: "IX_ThongTinVeChatLuongNuoc_MaChiTieu",
                table: "ThongTinVeChatLuongNuoc");

            migrationBuilder.DropColumn(
                name: "MaTangChuaNuoc",
                table: "TLN_CongTrinh");

            migrationBuilder.DropColumn(
                name: "MaChiTieu",
                table: "ThongTinVeChatLuongNuoc");
        }
    }
}
