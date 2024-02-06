using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace new_wr_api.Migrations
{
    /// <inheritdoc />
    public partial class CreateRelationshipCT_ThongTin__MucDichKT__LuuLuongTheoMucDich : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MucDich",
                table: "LuuLuongTheoMucDich");

            migrationBuilder.AddColumn<int>(
                name: "IdMucDich",
                table: "LuuLuongTheoMucDich",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_LuuLuongTheoMucDich_IdMucDich",
                table: "LuuLuongTheoMucDich",
                column: "IdMucDich");

            migrationBuilder.AddForeignKey(
                name: "FK_LuuLuongTheoMucDich_MucDichKT_IdMucDich",
                table: "LuuLuongTheoMucDich",
                column: "IdMucDich",
                principalTable: "MucDichKT",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LuuLuongTheoMucDich_MucDichKT_IdMucDich",
                table: "LuuLuongTheoMucDich");

            migrationBuilder.DropIndex(
                name: "IX_LuuLuongTheoMucDich_IdMucDich",
                table: "LuuLuongTheoMucDich");

            migrationBuilder.DropColumn(
                name: "IdMucDich",
                table: "LuuLuongTheoMucDich");

            migrationBuilder.AddColumn<string>(
                name: "MucDich",
                table: "LuuLuongTheoMucDich",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
