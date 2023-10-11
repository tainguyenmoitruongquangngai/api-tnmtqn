using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace new_wr_api.Migrations
{
    /// <inheritdoc />
    public partial class BieuMauSoHai : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BieuMauSoHai",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenTram = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiKyQuanTrac = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MuaNamKyTruoc = table.Column<double>(type: "float", nullable: true),
                    MuaNamBaoCao = table.Column<double>(type: "float", nullable: true),
                    MuaNamThayDoi = table.Column<double>(type: "float", nullable: true),
                    MuaMuaKyTruoc = table.Column<double>(type: "float", nullable: true),
                    MuaMuaBaoCao = table.Column<double>(type: "float", nullable: true),
                    MuaMuaThayDoi = table.Column<double>(type: "float", nullable: true),
                    MuaKhoKyTruoc = table.Column<double>(type: "float", nullable: true),
                    MuaKhoBaoCao = table.Column<double>(type: "float", nullable: true),
                    MuaKhoThayDoi = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BieuMauSoHai", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BieuMauSoHai");
        }
    }
}
