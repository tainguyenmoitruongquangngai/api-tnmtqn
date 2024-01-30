using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace new_wr_api.Migrations
{
    /// <inheritdoc />
    public partial class update_KKTNN_NuocMua3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_KKTNN_NuocMua_TongLuong_IdTram",
                table: "KKTNN_NuocMua_TongLuong");

            migrationBuilder.CreateIndex(
                name: "IX_KKTNN_NuocMua_TongLuong_IdTram",
                table: "KKTNN_NuocMua_TongLuong",
                column: "IdTram");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_KKTNN_NuocMua_TongLuong_IdTram",
                table: "KKTNN_NuocMua_TongLuong");

            migrationBuilder.CreateIndex(
                name: "IX_KKTNN_NuocMua_TongLuong_IdTram",
                table: "KKTNN_NuocMua_TongLuong",
                column: "IdTram",
                unique: true,
                filter: "[IdTram] IS NOT NULL");
        }
    }
}
