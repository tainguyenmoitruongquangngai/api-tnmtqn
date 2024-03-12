using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace new_wr_api.Migrations
{
    /// <inheritdoc />
    public partial class DuLieuNguonThaiDiem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DuLieuNguonNuocThai");

            migrationBuilder.CreateTable(
                name: "DuLieuNguonNuocThaiDiem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdPhanDoanSong = table.Column<int>(type: "int", nullable: false),
                    LuuLuongXaThai = table.Column<double>(type: "float", nullable: true),
                    CtdiemBOD = table.Column<double>(type: "float", nullable: true),
                    CtdiemCOD = table.Column<double>(type: "float", nullable: true),
                    CtdiemAmoni = table.Column<double>(type: "float", nullable: true),
                    CtdiemTongN = table.Column<double>(type: "float", nullable: true),
                    CtdiemTongP = table.Column<double>(type: "float", nullable: true),
                    CtdiemTSS = table.Column<double>(type: "float", nullable: true),
                    CtdiemColiform = table.Column<double>(type: "float", nullable: true),
                    LtdiemBOD = table.Column<double>(type: "float", nullable: true),
                    LtdiemCOD = table.Column<double>(type: "float", nullable: true),
                    LtdiemAmoni = table.Column<double>(type: "float", nullable: true),
                    LtdiemTongN = table.Column<double>(type: "float", nullable: true),
                    LtdiemTongP = table.Column<double>(type: "float", nullable: true),
                    LtdiemTSS = table.Column<double>(type: "float", nullable: true),
                    LtdiemColiform = table.Column<double>(type: "float", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TaiKhoanTao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianSua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanSua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DaXoa = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DuLieuNguonNuocThaiDiem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DuLieuNguonNuocThaiDiem_PhanDoanSong_IdPhanDoanSong",
                        column: x => x.IdPhanDoanSong,
                        principalTable: "PhanDoanSong",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DuLieuNguonNuocThaiDiem_IdPhanDoanSong",
                table: "DuLieuNguonNuocThaiDiem",
                column: "IdPhanDoanSong",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DuLieuNguonNuocThaiDiem");

            migrationBuilder.CreateTable(
                name: "DuLieuNguonNuocThai",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CBoAmoni = table.Column<double>(type: "float", nullable: true),
                    CBoBOD = table.Column<double>(type: "float", nullable: true),
                    CBoCOD = table.Column<double>(type: "float", nullable: true),
                    CBoColiform = table.Column<double>(type: "float", nullable: true),
                    CBoTSS = table.Column<double>(type: "float", nullable: true),
                    CBoTongN = table.Column<double>(type: "float", nullable: true),
                    CBoTongP = table.Column<double>(type: "float", nullable: true),
                    CGiaCamAmoni = table.Column<double>(type: "float", nullable: true),
                    CGiaCamBOD = table.Column<double>(type: "float", nullable: true),
                    CGiaCamCOD = table.Column<double>(type: "float", nullable: true),
                    CGiaCamColiform = table.Column<double>(type: "float", nullable: true),
                    CGiaCamTSS = table.Column<double>(type: "float", nullable: true),
                    CGiaCamTongN = table.Column<double>(type: "float", nullable: true),
                    CGiaCamTongP = table.Column<double>(type: "float", nullable: true),
                    CLonAmoni = table.Column<double>(type: "float", nullable: true),
                    CLonBOD = table.Column<double>(type: "float", nullable: true),
                    CLonCOD = table.Column<double>(type: "float", nullable: true),
                    CLonColiform = table.Column<double>(type: "float", nullable: true),
                    CLonTSS = table.Column<double>(type: "float", nullable: true),
                    CLonTongN = table.Column<double>(type: "float", nullable: true),
                    CLonTongP = table.Column<double>(type: "float", nullable: true),
                    CTrauAmoni = table.Column<double>(type: "float", nullable: true),
                    CTrauBOD = table.Column<double>(type: "float", nullable: true),
                    CTrauCOD = table.Column<double>(type: "float", nullable: true),
                    CTrauColiform = table.Column<double>(type: "float", nullable: true),
                    CTrauTSS = table.Column<double>(type: "float", nullable: true),
                    CTrauTongN = table.Column<double>(type: "float", nullable: true),
                    CTrauTongP = table.Column<double>(type: "float", nullable: true),
                    CTrongcayAmoni = table.Column<double>(type: "float", nullable: true),
                    CTrongcayBOD = table.Column<double>(type: "float", nullable: true),
                    CTrongcayCOD = table.Column<double>(type: "float", nullable: true),
                    CTrongcayColiform = table.Column<double>(type: "float", nullable: true),
                    CTrongcayTSS = table.Column<double>(type: "float", nullable: true),
                    CTrongcayTongN = table.Column<double>(type: "float", nullable: true),
                    CTrongcayTongP = table.Column<double>(type: "float", nullable: true),
                    CTrongluaAmoni = table.Column<double>(type: "float", nullable: true),
                    CTrongluaBOD = table.Column<double>(type: "float", nullable: true),
                    CTrongluaCOD = table.Column<double>(type: "float", nullable: true),
                    CTrongluaColiform = table.Column<double>(type: "float", nullable: true),
                    CTrongluaTSS = table.Column<double>(type: "float", nullable: true),
                    CTrongluaTongN = table.Column<double>(type: "float", nullable: true),
                    CTrongluaTongP = table.Column<double>(type: "float", nullable: true),
                    CTrongrungAmoni = table.Column<double>(type: "float", nullable: true),
                    CTrongrungBOD = table.Column<double>(type: "float", nullable: true),
                    CTrongrungCOD = table.Column<double>(type: "float", nullable: true),
                    CTrongrungColiform = table.Column<double>(type: "float", nullable: true),
                    CTrongrungTSS = table.Column<double>(type: "float", nullable: true),
                    CTrongrungTongN = table.Column<double>(type: "float", nullable: true),
                    CTrongrungTongP = table.Column<double>(type: "float", nullable: true),
                    ChieuDai = table.Column<double>(type: "float", nullable: true),
                    CshAmoni = table.Column<double>(type: "float", nullable: true),
                    CshBOD = table.Column<double>(type: "float", nullable: true),
                    CshCOD = table.Column<double>(type: "float", nullable: true),
                    CshColiform = table.Column<double>(type: "float", nullable: true),
                    CshTSS = table.Column<double>(type: "float", nullable: true),
                    CshTongN = table.Column<double>(type: "float", nullable: true),
                    CshTongP = table.Column<double>(type: "float", nullable: true),
                    CtdAmoni = table.Column<double>(type: "float", nullable: true),
                    CtdBOD = table.Column<double>(type: "float", nullable: true),
                    CtdCOD = table.Column<double>(type: "float", nullable: true),
                    CtdColiform = table.Column<double>(type: "float", nullable: true),
                    CtdTSS = table.Column<double>(type: "float", nullable: true),
                    CtdTongN = table.Column<double>(type: "float", nullable: true),
                    CtdTongP = table.Column<double>(type: "float", nullable: true),
                    DaXoa = table.Column<bool>(type: "bit", nullable: true),
                    DienTich = table.Column<double>(type: "float", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HeSoSuyGiam = table.Column<double>(type: "float", nullable: true),
                    LtAmoni = table.Column<double>(type: "float", nullable: true),
                    LtBOD = table.Column<double>(type: "float", nullable: true),
                    LtBoAmoni = table.Column<double>(type: "float", nullable: true),
                    LtBoBOD = table.Column<double>(type: "float", nullable: true),
                    LtBoCOD = table.Column<double>(type: "float", nullable: true),
                    LtBoColiform = table.Column<double>(type: "float", nullable: true),
                    LtBoTSS = table.Column<double>(type: "float", nullable: true),
                    LtBoTongN = table.Column<double>(type: "float", nullable: true),
                    LtBoTongP = table.Column<double>(type: "float", nullable: true),
                    LtCOD = table.Column<double>(type: "float", nullable: true),
                    LtColiform = table.Column<double>(type: "float", nullable: true),
                    LtGiaCamAmoni = table.Column<double>(type: "float", nullable: true),
                    LtGiaCamBOD = table.Column<double>(type: "float", nullable: true),
                    LtGiaCamCOD = table.Column<double>(type: "float", nullable: true),
                    LtGiaCamColiform = table.Column<double>(type: "float", nullable: true),
                    LtGiaCamTSS = table.Column<double>(type: "float", nullable: true),
                    LtGiaCamTongN = table.Column<double>(type: "float", nullable: true),
                    LtGiaCamTongP = table.Column<double>(type: "float", nullable: true),
                    LtLonAmoni = table.Column<double>(type: "float", nullable: true),
                    LtLonBOD = table.Column<double>(type: "float", nullable: true),
                    LtLonCOD = table.Column<double>(type: "float", nullable: true),
                    LtLonColiform = table.Column<double>(type: "float", nullable: true),
                    LtLonTSS = table.Column<double>(type: "float", nullable: true),
                    LtLonTongN = table.Column<double>(type: "float", nullable: true),
                    LtLonTongP = table.Column<double>(type: "float", nullable: true),
                    LtTSS = table.Column<double>(type: "float", nullable: true),
                    LtTongN = table.Column<double>(type: "float", nullable: true),
                    LtTongP = table.Column<double>(type: "float", nullable: true),
                    LtTrauAmoni = table.Column<double>(type: "float", nullable: true),
                    LtTrauBOD = table.Column<double>(type: "float", nullable: true),
                    LtTrauCOD = table.Column<double>(type: "float", nullable: true),
                    LtTrauColiform = table.Column<double>(type: "float", nullable: true),
                    LtTrauTSS = table.Column<double>(type: "float", nullable: true),
                    LtTrauTongN = table.Column<double>(type: "float", nullable: true),
                    LtTrauTongP = table.Column<double>(type: "float", nullable: true),
                    LtTrongcayAmoni = table.Column<double>(type: "float", nullable: true),
                    LtTrongcayBOD = table.Column<double>(type: "float", nullable: true),
                    LtTrongcayCOD = table.Column<double>(type: "float", nullable: true),
                    LtTrongcayColiform = table.Column<double>(type: "float", nullable: true),
                    LtTrongcayTSS = table.Column<double>(type: "float", nullable: true),
                    LtTrongcayTongN = table.Column<double>(type: "float", nullable: true),
                    LtTrongcayTongP = table.Column<double>(type: "float", nullable: true),
                    LtTrongluaAmoni = table.Column<double>(type: "float", nullable: true),
                    LtTrongluaBOD = table.Column<double>(type: "float", nullable: true),
                    LtTrongluaCOD = table.Column<double>(type: "float", nullable: true),
                    LtTrongluaColiform = table.Column<double>(type: "float", nullable: true),
                    LtTrongluaTSS = table.Column<double>(type: "float", nullable: true),
                    LtTrongluaTongN = table.Column<double>(type: "float", nullable: true),
                    LtTrongluaTongP = table.Column<double>(type: "float", nullable: true),
                    LtTrongrungAmoni = table.Column<double>(type: "float", nullable: true),
                    LtTrongrungBOD = table.Column<double>(type: "float", nullable: true),
                    LtTrongrungCOD = table.Column<double>(type: "float", nullable: true),
                    LtTrongrungColiform = table.Column<double>(type: "float", nullable: true),
                    LtTrongrungTSS = table.Column<double>(type: "float", nullable: true),
                    LtTrongrungTongN = table.Column<double>(type: "float", nullable: true),
                    LtTrongrungTongP = table.Column<double>(type: "float", nullable: true),
                    LtdAmoni = table.Column<double>(type: "float", nullable: true),
                    LtdBOD = table.Column<double>(type: "float", nullable: true),
                    LtdCOD = table.Column<double>(type: "float", nullable: true),
                    LtdColiform = table.Column<double>(type: "float", nullable: true),
                    LtdTSS = table.Column<double>(type: "float", nullable: true),
                    LtdTongN = table.Column<double>(type: "float", nullable: true),
                    LtdTongP = table.Column<double>(type: "float", nullable: true),
                    LtshAmoni = table.Column<double>(type: "float", nullable: true),
                    LtshBOD = table.Column<double>(type: "float", nullable: true),
                    LtshCOD = table.Column<double>(type: "float", nullable: true),
                    LtshColiform = table.Column<double>(type: "float", nullable: true),
                    LtshTSS = table.Column<double>(type: "float", nullable: true),
                    LtshTongN = table.Column<double>(type: "float", nullable: true),
                    LtshTongP = table.Column<double>(type: "float", nullable: true),
                    LuuLuongXaDiem = table.Column<double>(type: "float", nullable: true),
                    LuuVucSong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhanDoanSong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoLuong = table.Column<int>(type: "int", nullable: true),
                    Song = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TaiKhoanSua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TaiKhoanTao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenDoanSong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianSua = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DuLieuNguonNuocThai", x => x.Id);
                });
        }
    }
}
