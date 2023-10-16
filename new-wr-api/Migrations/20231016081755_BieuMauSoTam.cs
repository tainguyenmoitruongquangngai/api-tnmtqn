using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace new_wr_api.Migrations
{
    /// <inheritdoc />
    public partial class BieuMauSoTam : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BieuMauSoTam",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TangChuaNuoc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SLGieng = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MucNuocMaxKyTruoc = table.Column<double>(type: "float", nullable: true),
                    MucNuocMaxKyBaoCao = table.Column<double>(type: "float", nullable: true),
                    MucNuocMediumKyTruoc = table.Column<double>(type: "float", nullable: true),
                    MucNuocMediumKyBaoCao = table.Column<double>(type: "float", nullable: true),
                    MucNuocMinKyTruoc = table.Column<double>(type: "float", nullable: true),
                    MucNuocMinKyBaoCao = table.Column<double>(type: "float", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BieuMauSoTam", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BieuMauSoTam");
        }
    }
}
