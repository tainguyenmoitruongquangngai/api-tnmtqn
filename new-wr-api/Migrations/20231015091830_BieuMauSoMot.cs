using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace new_wr_api.Migrations
{
    /// <inheritdoc />
    public partial class BieuMauSoMot : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BieuMauSoMot",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LuuVucSong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TongTramQuanTracKyTruoc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TongTramQuanTracBaoCao = table.Column<double>(type: "float", nullable: true),
                    TramKhiTuongKyTruoc = table.Column<double>(type: "float", nullable: true),
                    TramKhiTuongBaoCao = table.Column<double>(type: "float", nullable: true),
                    TramThuyVanKyTruoc = table.Column<double>(type: "float", nullable: true),
                    TramThuyVanKyBaoCao = table.Column<double>(type: "float", nullable: true),
                    TramTNNKyTruoc = table.Column<double>(type: "float", nullable: true),
                    TramTNNKyBaoCao = table.Column<double>(type: "float", nullable: true),
                    TramQuanTracKyTruoc = table.Column<double>(type: "float", nullable: true),
                    TramQuanTracKyBaoCao = table.Column<double>(type: "float", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BieuMauSoMot", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BieuMauSoMot");
        }
    }
}
