using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace new_wr_api.Migrations
{
    /// <inheritdoc />
    public partial class BieuMauSoBa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BieuMauSoBa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenTram = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiKyQuanTrac = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LuongMuaThang1 = table.Column<double>(type: "float", nullable: true),
                    LuongMuaThang2 = table.Column<double>(type: "float", nullable: true),
                    LuongMuaThang3 = table.Column<double>(type: "float", nullable: true),
                    LuongMuaThang4 = table.Column<double>(type: "float", nullable: true),
                    LuongMuaThang5 = table.Column<double>(type: "float", nullable: true),
                    LuongMuaThang6 = table.Column<double>(type: "float", nullable: true),
                    LuongMuaThang7 = table.Column<double>(type: "float", nullable: true),
                    LuongMuaThang8 = table.Column<double>(type: "float", nullable: true),
                    LuongMuaThang9 = table.Column<double>(type: "float", nullable: true),
                    LuongMuaThang10 = table.Column<double>(type: "float", nullable: true),
                    LuongMuaThang11 = table.Column<double>(type: "float", nullable: true),
                    LuongMuaThang12 = table.Column<double>(type: "float", nullable: true),
                    LuongMuaNam = table.Column<double>(type: "float", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BieuMauSoBa", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BieuMauSoBa");
        }
    }
}
