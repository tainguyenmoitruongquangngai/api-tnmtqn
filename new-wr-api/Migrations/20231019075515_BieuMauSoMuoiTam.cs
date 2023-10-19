using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace new_wr_api.Migrations
{
    /// <inheritdoc />
    public partial class BieuMauSoMuoiTam : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BieuMauSoMuoiTam",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LuuVucSong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TongSongPheDuyetBoKyTruoc = table.Column<double>(type: "float", nullable: true),
                    TongSongPheDuyetBoKyBaoCao = table.Column<double>(type: "float", nullable: true),
                    TongSongPheDuyetDiaPhuongKyTruoc = table.Column<double>(type: "float", nullable: true),
                    TongSongPheDuyetDiaPhuongKyBaoCao = table.Column<double>(type: "float", nullable: true),
                    TongHoPheDuyetKyTruoc = table.Column<double>(type: "float", nullable: true),
                    TongHoPheDuyetKyBaoCao = table.Column<double>(type: "float", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BieuMauSoMuoiTam", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BieuMauSoMuoiTam");
        }
    }
}
