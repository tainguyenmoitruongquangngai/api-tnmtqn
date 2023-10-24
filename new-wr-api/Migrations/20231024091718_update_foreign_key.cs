using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace new_wr_api.Migrations
{
    /// <inheritdoc />
    public partial class update_foreign_key : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_TLN_NuocMua_TongLuong_IdTram",
                table: "TLN_NuocMua_TongLuong",
                column: "IdTram");

            migrationBuilder.AddForeignKey(
                name: "FK_TLN_NuocMua_TongLuong_Tram_ThongTin_IdTram",
                table: "TLN_NuocMua_TongLuong",
                column: "IdTram",
                principalTable: "Tram_ThongTin",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TLN_NuocMua_TongLuong_Tram_ThongTin_IdTram",
                table: "TLN_NuocMua_TongLuong");

            migrationBuilder.DropIndex(
                name: "IX_TLN_NuocMua_TongLuong_IdTram",
                table: "TLN_NuocMua_TongLuong");
        }
    }
}
