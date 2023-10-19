using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace new_wr_api.Migrations
{
    /// <inheritdoc />
    public partial class BieuMauSoMuoiChin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BieuMauSoMuoiChin",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoCuocThanhTraKyTruoc = table.Column<double>(type: "float", nullable: true),
                    SoCuocThanhTraKyBaoCao = table.Column<double>(type: "float", nullable: true),
                    SoDoiTuongThanhTraKyTruoc = table.Column<double>(type: "float", nullable: true),
                    SoDoiTuongThanhTraKyBaoCao = table.Column<double>(type: "float", nullable: true),
                    SoTCCNXuPhatKyTruoc = table.Column<double>(type: "float", nullable: true),
                    SoTCCNXuPhatKyBaoCao = table.Column<double>(type: "float", nullable: true),
                    TongTienXuPhatKyTruoc = table.Column<double>(type: "float", nullable: true),
                    TongTienXuPhatKyBaoCao = table.Column<double>(type: "float", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BieuMauSoMuoiChin", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BieuMauSoMuoiChin");
        }
    }
}
