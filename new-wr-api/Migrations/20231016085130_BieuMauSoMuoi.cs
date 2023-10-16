using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace new_wr_api.Migrations
{
    /// <inheritdoc />
    public partial class BieuMauSoMuoi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BieuMauSoMuoi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LuuVucSong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TongCongTrinh = table.Column<double>(type: "float", nullable: true),
                    CTTuoiNuocMat = table.Column<double>(type: "float", nullable: true),
                    CTTuoiNuocDuoiDat = table.Column<double>(type: "float", nullable: true),
                    CTThuyDien = table.Column<double>(type: "float", nullable: true),
                    CTMucDichKhacNuocMat = table.Column<double>(type: "float", nullable: true),
                    CTMucDichKhacNuocDuoiDat = table.Column<double>(type: "float", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BieuMauSoMuoi", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BieuMauSoMuoi");
        }
    }
}
