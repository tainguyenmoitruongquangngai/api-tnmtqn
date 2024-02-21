using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace new_wr_api.Migrations
{
    /// <inheritdoc />
    public partial class DuLieuNguonNuocNhan : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DuLieuNguonNuocNhan",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Song = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenDoanSong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChieuDai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LuuLuongDongChay = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CnnBOD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CnnCOD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CnnAmoni = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CnnTongN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CnnTongP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CnnTSS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CnnColiform = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LnnBOD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LnnCOD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LnnAmoni = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LnnTongN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LnnTongP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LnnTSS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LnnColiform = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CqcBOD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CqcCOD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CqcAmoni = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CqcTongN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CqcTongP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CqcTSS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CqcColiform = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LtdBOD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LtdCOD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LtdAmoni = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LtdTongN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LtdTongP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LtdTSS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LtdColiform = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TaiKhoanTao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianSua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanSua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DaXoa = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DuLieuNguonNuocNhan", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DuLieuNguonNuocNhan");
        }
    }
}
