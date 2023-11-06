using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace new_wr_api.Migrations
{
    /// <inheritdoc />
    public partial class ThongSoCLNSongg : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ThongSoCLNSong",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    pH = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BOD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    COD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TOC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TSS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TongPhosphor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TongNito = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TongColiform = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ColiformChiuNhiet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MucPLCLNuoc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TaiKhoanTao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianSua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanSua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DaXoa = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThongSoCLNSong", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ThongSoCLNSong");
        }
    }
}
