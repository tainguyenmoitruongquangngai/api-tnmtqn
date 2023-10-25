using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace new_wr_api.Migrations
{
    /// <inheritdoc />
    public partial class Update_TLN_BaoCao1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MaPhuongPhapTinhMua",
                table: "TongLuongMua",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TongLuongMua_MaPhuongPhapTinhMua",
                table: "TongLuongMua",
                column: "MaPhuongPhapTinhMua",
                unique: true,
                filter: "[MaPhuongPhapTinhMua] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_TongLuongMua_PhuongPhapTinhMua_MaPhuongPhapTinhMua",
                table: "TongLuongMua",
                column: "MaPhuongPhapTinhMua",
                principalTable: "PhuongPhapTinhMua",
                principalColumn: "MaPhuongPhapTinhMua");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TongLuongMua_PhuongPhapTinhMua_MaPhuongPhapTinhMua",
                table: "TongLuongMua");

            migrationBuilder.DropIndex(
                name: "IX_TongLuongMua_MaPhuongPhapTinhMua",
                table: "TongLuongMua");

            migrationBuilder.DropColumn(
                name: "MaPhuongPhapTinhMua",
                table: "TongLuongMua");
        }
    }
}
