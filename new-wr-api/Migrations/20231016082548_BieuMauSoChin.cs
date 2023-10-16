using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace new_wr_api.Migrations
{
    /// <inheritdoc />
    public partial class BieuMauSoChin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BieuMauSoChin",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LuuVucSong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TongCongTrinhKyTruoc = table.Column<double>(type: "float", nullable: true),
                    TongCongTrinhKyBaoCao = table.Column<double>(type: "float", nullable: true),
                    CongTrinhNuocMatKyTruoc = table.Column<double>(type: "float", nullable: true),
                    CongTrinhNuocMatKyBaoCao = table.Column<double>(type: "float", nullable: true),
                    CongTrinhNDDKyTruoc = table.Column<double>(type: "float", nullable: true),
                    CongTrinhNDDKyBaoCao = table.Column<double>(type: "float", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BieuMauSoChin", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BieuMauSoChin");
        }
    }
}
