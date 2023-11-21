using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace new_wr_api.Migrations
{
    /// <inheritdoc />
    public partial class DoanSong : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DoanSong",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenDoanSong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdLVSong = table.Column<int>(type: "int", nullable: true),
                    IdSong = table.Column<int>(type: "int", nullable: true),
                    ChieuDai = table.Column<double>(type: "float", nullable: true),
                    DienTichLV = table.Column<double>(type: "float", nullable: true),
                    DiaGioiHanhChinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MucDichSuDung = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XDau = table.Column<double>(type: "float", nullable: true),
                    YDau = table.Column<double>(type: "float", nullable: true),
                    XCuoi = table.Column<double>(type: "float", nullable: true),
                    YCuoi = table.Column<double>(type: "float", nullable: true),
                    Qs = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoanSong", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DoanSong_Song_IdSong",
                        column: x => x.IdSong,
                        principalTable: "Song",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ThongSoLtd",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdDoanSong = table.Column<int>(type: "int", nullable: true),
                    pHTd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BODTd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CODTd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TSSTd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TongPTd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TongNTd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TongColiformTd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AmoniTd = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThongSoLtd", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ThongSoLtd_DoanSong_IdDoanSong",
                        column: x => x.IdDoanSong,
                        principalTable: "DoanSong",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_DoanSong_IdSong",
                table: "DoanSong",
                column: "IdSong");

            migrationBuilder.CreateIndex(
                name: "IX_ThongSoLtd_IdDoanSong",
                table: "ThongSoLtd",
                column: "IdDoanSong",
                unique: true,
                filter: "[IdDoanSong] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ThongSoLtd");

            migrationBuilder.DropTable(
                name: "DoanSong");
        }
    }
}
