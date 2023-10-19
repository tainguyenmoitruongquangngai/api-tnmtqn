using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace new_wr_api.Migrations
{
    /// <inheritdoc />
    public partial class BieuMauSoMuoiBay : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BieuMauSoMuoiBay",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TongCTPheDuyetTCQKyTruoc = table.Column<double>(type: "float", nullable: true),
                    TongCTPheDuyetTCQKyBaoCao = table.Column<double>(type: "float", nullable: true),
                    TongCTPheDuyetTCQBoKyTruoc = table.Column<double>(type: "float", nullable: true),
                    TongCTPheDuyetTCQBoKyBaoCao = table.Column<double>(type: "float", nullable: true),
                    TongCTPheDuyetTCQDiaPhuongKyTruoc = table.Column<double>(type: "float", nullable: true),
                    TongCTPheDuyetTCQiaPhuongKyBaoCao = table.Column<double>(type: "float", nullable: true),
                    TongTCQpKyTruoc = table.Column<double>(type: "float", nullable: true),
                    TongTCQKyBaoCao = table.Column<double>(type: "float", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BieuMauSoMuoiBay", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BieuMauSoMuoiBay");
        }
    }
}
