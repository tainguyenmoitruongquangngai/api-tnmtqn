using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace new_wr_api.Migrations
{
    /// <inheritdoc />
    public partial class BieuMauSoBon : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BieuMauSoBon",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LuuVucSong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DongChayTBNam = table.Column<double>(type: "float", nullable: true),
                    DongChayKyTruoc = table.Column<double>(type: "float", nullable: true),
                    DongChayKyBaoCao = table.Column<double>(type: "float", nullable: true),
                    DongChayMuaLuTB = table.Column<double>(type: "float", nullable: true),
                    DongChayMuaLuKyTruoc = table.Column<double>(type: "float", nullable: true),
                    DongChayMuaLuKyBaoCao = table.Column<double>(type: "float", nullable: true),
                    DongChayMuaCanTB = table.Column<double>(type: "float", nullable: true),
                    DongChayMuaCanKyTruoc = table.Column<double>(type: "float", nullable: true),
                    DongChayMuaCanKyBaoCao = table.Column<double>(type: "float", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BieuMauSoBon", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BieuMauSoBon");
        }
    }
}
