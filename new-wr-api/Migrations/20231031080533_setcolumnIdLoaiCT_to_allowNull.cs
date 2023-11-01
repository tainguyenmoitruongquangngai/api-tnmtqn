using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace new_wr_api.Migrations
{
    /// <inheritdoc />
    public partial class setcolumnIdLoaiCT_to_allowNull : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CT_ThongTin_CT_Loai_IdLoaiCT",
                table: "CT_ThongTin");

            migrationBuilder.AlterColumn<int>(
                name: "IdLoaiCT",
                table: "CT_ThongTin",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_CT_ThongTin_CT_Loai_IdLoaiCT",
                table: "CT_ThongTin",
                column: "IdLoaiCT",
                principalTable: "CT_Loai",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CT_ThongTin_CT_Loai_IdLoaiCT",
                table: "CT_ThongTin");

            migrationBuilder.AlterColumn<int>(
                name: "IdLoaiCT",
                table: "CT_ThongTin",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CT_ThongTin_CT_Loai_IdLoaiCT",
                table: "CT_ThongTin",
                column: "IdLoaiCT",
                principalTable: "CT_Loai",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
