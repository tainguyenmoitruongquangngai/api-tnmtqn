using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace new_wr_api.Migrations
{
    /// <inheritdoc />
    public partial class BieuMauSoHaiBa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BieuMauSoHaiBa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ThoiGian = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LuuLuongKhaiThacLonNhat = table.Column<double>(type: "float", nullable: true),
                    LuuLuongKhaiThacNhoNhat = table.Column<double>(type: "float", nullable: true),
                    LuuLuongKTDuocCapPhep = table.Column<double>(type: "float", nullable: true),
                    SoNgayKhaiThac = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MucNuocKhaiThacLonNhat = table.Column<double>(type: "float", nullable: true),
                    MucNuocKhaiThacNhoNhat = table.Column<double>(type: "float", nullable: true),
                    ChieuSauMucNuocDongMax = table.Column<double>(type: "float", nullable: true),
                    TongLuongKhaiThac = table.Column<double>(type: "float", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BieuMauSoHaiBa", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BieuMauSoHaiBa");
        }
    }
}
