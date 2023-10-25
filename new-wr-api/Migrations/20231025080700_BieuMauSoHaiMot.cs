using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace new_wr_api.Migrations
{
    /// <inheritdoc />
    public partial class BieuMauSoHaiMot : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BieuMauSoHaiMot",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ThoiGian = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LuuLuongDenHoLonNhat = table.Column<double>(type: "float", nullable: true),
                    LuuLuongDenHoNhoNhat = table.Column<double>(type: "float", nullable: true),
                    TongLuuLuongXaLonNhat = table.Column<double>(type: "float", nullable: true),
                    TongLuuLuongXaNhoNhat = table.Column<double>(type: "float", nullable: true),
                    DongChayToiThieuLonNhat = table.Column<double>(type: "float", nullable: true),
                    DongChayToiThieuNhoNhat = table.Column<double>(type: "float", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BieuMauSoHaiMot", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BieuMauSoHaiMot");
        }
    }
}
