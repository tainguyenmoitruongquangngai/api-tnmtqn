using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace new_wr_api.Migrations
{
    /// <inheritdoc />
    public partial class create_table_quantrac_for_baocao1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MaLoaiCT",
                table: "QLC_CongTrinh",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "QLC_LoaiCT",
                columns: table => new
                {
                    MaLoaiCT = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLoaiCT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KyHieuLoaiCT = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QLC_LoaiCT", x => x.MaLoaiCT);
                });

            migrationBuilder.CreateIndex(
                name: "IX_QLC_CongTrinh_MaLoaiCT",
                table: "QLC_CongTrinh",
                column: "MaLoaiCT");

            migrationBuilder.AddForeignKey(
                name: "FK_QLC_CongTrinh_QLC_LoaiCT_MaLoaiCT",
                table: "QLC_CongTrinh",
                column: "MaLoaiCT",
                principalTable: "QLC_LoaiCT",
                principalColumn: "MaLoaiCT");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_QLC_CongTrinh_QLC_LoaiCT_MaLoaiCT",
                table: "QLC_CongTrinh");

            migrationBuilder.DropTable(
                name: "QLC_LoaiCT");

            migrationBuilder.DropIndex(
                name: "IX_QLC_CongTrinh_MaLoaiCT",
                table: "QLC_CongTrinh");

            migrationBuilder.DropColumn(
                name: "MaLoaiCT",
                table: "QLC_CongTrinh");
        }
    }
}
