using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace new_wr_api.Migrations
{
    /// <inheritdoc />
    public partial class CreateRelationshipHM__TCN : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_CT_HangMuc_IdTangChuaNuoc",
                table: "CT_HangMuc",
                column: "IdTangChuaNuoc");

            migrationBuilder.AddForeignKey(
                name: "FK_CT_HangMuc_TangChuaNuoc_IdTangChuaNuoc",
                table: "CT_HangMuc",
                column: "IdTangChuaNuoc",
                principalTable: "TangChuaNuoc",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CT_HangMuc_TangChuaNuoc_IdTangChuaNuoc",
                table: "CT_HangMuc");

            migrationBuilder.DropIndex(
                name: "IX_CT_HangMuc_IdTangChuaNuoc",
                table: "CT_HangMuc");
        }
    }
}
