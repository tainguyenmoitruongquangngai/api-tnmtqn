using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace new_wr_api.Migrations
{
    /// <inheritdoc />
    public partial class BieuMauSoMuoiHai : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BieuMauSoMuoiHai",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LuuVucSong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TongSoCongTrinh = table.Column<double>(type: "float", nullable: true),
                    TuoiNguonNuocMat = table.Column<double>(type: "float", nullable: true),
                    TuoiNguonNuocDuoiDat = table.Column<double>(type: "float", nullable: true),
                    KhaiThacThuyDien = table.Column<double>(type: "float", nullable: true),
                    MucDichKhacNguonNuocMat = table.Column<double>(type: "float", nullable: true),
                    MucDichKhacNguonNuocDD = table.Column<double>(type: "float", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BieuMauSoMuoiHai", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BieuMauSoMuoiHai");
        }
    }
}
