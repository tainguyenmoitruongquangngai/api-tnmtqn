using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace new_wr_api.Migrations
{
    /// <inheritdoc />
    public partial class BieuMauSoNam : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BieuMauSoNam",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenTram = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LuuLuongThang1 = table.Column<double>(type: "float", nullable: true),
                    LuuLuongThang2 = table.Column<double>(type: "float", nullable: true),
                    LuuLuongThang3 = table.Column<double>(type: "float", nullable: true),
                    LuuLuongThang4 = table.Column<double>(type: "float", nullable: true),
                    LuuLuongThang5 = table.Column<double>(type: "float", nullable: true),
                    LuuLuongThang6 = table.Column<double>(type: "float", nullable: true),
                    LuuLuongThang7 = table.Column<double>(type: "float", nullable: true),
                    LuuLuongThang8 = table.Column<double>(type: "float", nullable: true),
                    LuuLuongThang9 = table.Column<double>(type: "float", nullable: true),
                    LuuLuongThang10 = table.Column<double>(type: "float", nullable: true),
                    LuuLuongThang11 = table.Column<double>(type: "float", nullable: true),
                    LuuLuongThang12 = table.Column<double>(type: "float", nullable: true),
                    LuuLuongNam = table.Column<double>(type: "float", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BieuMauSoNam", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BieuMauSoNam");
        }
    }
}
