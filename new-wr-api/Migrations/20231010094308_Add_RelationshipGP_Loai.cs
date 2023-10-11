using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace new_wr_api.Migrations
{
    /// <inheritdoc />
    public partial class Add_RelationshipGP_Loai : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GP_ThongTin_CT_Loai_IdLoaiGP",
                table: "GP_ThongTin");

            migrationBuilder.DropForeignKey(
                name: "FK_GP_ThongTin_GP_Loai_GP_LoaiId",
                table: "GP_ThongTin");

            migrationBuilder.DropIndex(
                name: "IX_GP_ThongTin_GP_LoaiId",
                table: "GP_ThongTin");

            migrationBuilder.DropColumn(
                name: "GP_LoaiId",
                table: "GP_ThongTin");

            migrationBuilder.AddForeignKey(
                name: "FK_GP_ThongTin_GP_Loai_IdLoaiGP",
                table: "GP_ThongTin",
                column: "IdLoaiGP",
                principalTable: "GP_Loai",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GP_ThongTin_GP_Loai_IdLoaiGP",
                table: "GP_ThongTin");

            migrationBuilder.AddColumn<int>(
                name: "GP_LoaiId",
                table: "GP_ThongTin",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_GP_ThongTin_GP_LoaiId",
                table: "GP_ThongTin",
                column: "GP_LoaiId");

            migrationBuilder.AddForeignKey(
                name: "FK_GP_ThongTin_CT_Loai_IdLoaiGP",
                table: "GP_ThongTin",
                column: "IdLoaiGP",
                principalTable: "CT_Loai",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GP_ThongTin_GP_Loai_GP_LoaiId",
                table: "GP_ThongTin",
                column: "GP_LoaiId",
                principalTable: "GP_Loai",
                principalColumn: "Id");
        }
    }
}
