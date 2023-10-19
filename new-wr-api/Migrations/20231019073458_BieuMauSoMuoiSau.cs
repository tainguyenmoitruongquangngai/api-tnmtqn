using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace new_wr_api.Migrations
{
    /// <inheritdoc />
    public partial class BieuMauSoMuoiSau : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BieuMauSoMuoiSau",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoaiGiayPhep = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TongGPCapKyTruoc = table.Column<double>(type: "float", nullable: true),
                    TongGPCapKyBaoCao = table.Column<double>(type: "float", nullable: true),
                    TongGPBoCapKyTruoc = table.Column<double>(type: "float", nullable: true),
                    TongGPBoCapKyBaoCao = table.Column<double>(type: "float", nullable: true),
                    TongGPDiaPhuongCapKyTruoc = table.Column<double>(type: "float", nullable: true),
                    TongGPDiaPhuongCapBaoCao = table.Column<double>(type: "float", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BieuMauSoMuoiSau", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BieuMauSoMuoiSau");
        }
    }
}
