using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace new_wr_api.Migrations
{
    /// <inheritdoc />
    public partial class update_KKTNN_NuocMua : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_KKTNN_NuocMua_TongLuong_IdTram",
                table: "KKTNN_NuocMua_TongLuong");

            migrationBuilder.RenameColumn(
                name: "TenLoaiCT",
                table: "Tram_LoaiTram",
                newName: "TenLoaiTram");

            migrationBuilder.RenameColumn(
                name: "MaLoaiCT",
                table: "Tram_LoaiTram",
                newName: "MaLoaiTram");

            migrationBuilder.AlterColumn<string>(
                name: "IdXa",
                table: "Tram_ThongTin",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IdHuyen",
                table: "Tram_ThongTin",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nam",
                table: "KKTNN_NuocMua_TongLuong",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tram_ThongTin_IdHuyen",
                table: "Tram_ThongTin",
                column: "IdHuyen");

            migrationBuilder.CreateIndex(
                name: "IX_Tram_ThongTin_IdLoaiTram",
                table: "Tram_ThongTin",
                column: "IdLoaiTram");

            migrationBuilder.CreateIndex(
                name: "IX_Tram_ThongTin_IdXa",
                table: "Tram_ThongTin",
                column: "IdXa");

            migrationBuilder.CreateIndex(
                name: "IX_KKTNN_NuocMua_TongLuong_IdTram",
                table: "KKTNN_NuocMua_TongLuong",
                column: "IdTram",
                unique: true,
                filter: "[IdTram] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Tram_ThongTin_Huyen_IdHuyen",
                table: "Tram_ThongTin",
                column: "IdHuyen",
                principalTable: "Huyen",
                principalColumn: "IdHuyen");

            migrationBuilder.AddForeignKey(
                name: "FK_Tram_ThongTin_Tram_LoaiTram_IdLoaiTram",
                table: "Tram_ThongTin",
                column: "IdLoaiTram",
                principalTable: "Tram_LoaiTram",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tram_ThongTin_Xa_IdXa",
                table: "Tram_ThongTin",
                column: "IdXa",
                principalTable: "Xa",
                principalColumn: "IdXa");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tram_ThongTin_Huyen_IdHuyen",
                table: "Tram_ThongTin");

            migrationBuilder.DropForeignKey(
                name: "FK_Tram_ThongTin_Tram_LoaiTram_IdLoaiTram",
                table: "Tram_ThongTin");

            migrationBuilder.DropForeignKey(
                name: "FK_Tram_ThongTin_Xa_IdXa",
                table: "Tram_ThongTin");

            migrationBuilder.DropIndex(
                name: "IX_Tram_ThongTin_IdHuyen",
                table: "Tram_ThongTin");

            migrationBuilder.DropIndex(
                name: "IX_Tram_ThongTin_IdLoaiTram",
                table: "Tram_ThongTin");

            migrationBuilder.DropIndex(
                name: "IX_Tram_ThongTin_IdXa",
                table: "Tram_ThongTin");

            migrationBuilder.DropIndex(
                name: "IX_KKTNN_NuocMua_TongLuong_IdTram",
                table: "KKTNN_NuocMua_TongLuong");

            migrationBuilder.DropColumn(
                name: "Nam",
                table: "KKTNN_NuocMua_TongLuong");

            migrationBuilder.RenameColumn(
                name: "TenLoaiTram",
                table: "Tram_LoaiTram",
                newName: "TenLoaiCT");

            migrationBuilder.RenameColumn(
                name: "MaLoaiTram",
                table: "Tram_LoaiTram",
                newName: "MaLoaiCT");

            migrationBuilder.AlterColumn<int>(
                name: "IdXa",
                table: "Tram_ThongTin",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "IdHuyen",
                table: "Tram_ThongTin",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_KKTNN_NuocMua_TongLuong_IdTram",
                table: "KKTNN_NuocMua_TongLuong",
                column: "IdTram");
        }
    }
}
