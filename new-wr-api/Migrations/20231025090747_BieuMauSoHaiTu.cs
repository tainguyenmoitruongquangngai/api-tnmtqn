using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace new_wr_api.Migrations
{
    /// <inheritdoc />
    public partial class BieuMauSoHaiTu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BieuMauSoHaiLam",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ThongSoQuanTrac = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NongDoLonNhat = table.Column<double>(type: "float", nullable: true),
                    NongDoNhoNhat = table.Column<double>(type: "float", nullable: true),
                    NongDoQuyDinh = table.Column<double>(type: "float", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BieuMauSoHaiLam", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BieuMauSoHaiTu",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ThoiGian = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LuuLuongXaThaiLonNhat = table.Column<double>(type: "float", nullable: true),
                    LuuLuongXaThaiNhoNhat = table.Column<double>(type: "float", nullable: true),
                    LuuLuongXaThaiChoPhep = table.Column<double>(type: "float", nullable: true),
                    SoNgayXaThai = table.Column<double>(type: "float", nullable: true),
                    TongLuongXaThai = table.Column<double>(type: "float", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BieuMauSoHaiTu", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BieuMauSoHaiLam");

            migrationBuilder.DropTable(
                name: "BieuMauSoHaiTu");
        }
    }
}
