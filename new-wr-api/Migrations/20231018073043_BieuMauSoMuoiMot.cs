using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace new_wr_api.Migrations
{
    /// <inheritdoc />
    public partial class BieuMauSoMuoiMot : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BieuMauSoMuoiMot",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LuuVucSong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TongSoCongTrinh = table.Column<double>(type: "float", nullable: true),
                    CongTrinhHoChua = table.Column<double>(type: "float", nullable: true),
                    CongTrinhDapDang = table.Column<double>(type: "float", nullable: true),
                    CongTrinhCong = table.Column<double>(type: "float", nullable: true),
                    CongTrinhTramBom = table.Column<double>(type: "float", nullable: true),
                    CongTrinhKhacNuocMat = table.Column<double>(type: "float", nullable: true),
                    CongTrinhGieng = table.Column<double>(type: "float", nullable: true),
                    CongTrinhKhacNDD = table.Column<double>(type: "float", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BieuMauSoMuoiMot", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BieuMauSoMuoiMot");
        }
    }
}
