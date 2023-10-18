using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace new_wr_api.Migrations
{
    /// <inheritdoc />
    public partial class createtao_bang_cho_bao_cao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CheDoKhaiThacCongTrinh",
                columns: table => new
                {
                    MaCheDoKhaiThacCongTrinh = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaThongTinCongTrinh = table.Column<int>(type: "int", nullable: true),
                    CheDoKhaiThac = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CheDoKhaiThacCongTrinh", x => x.MaCheDoKhaiThacCongTrinh);
                });

            migrationBuilder.CreateTable(
                name: "PhanCapCongTrinhCong",
                columns: table => new
                {
                    MaPhanCapCongTrinhCong = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaThongTinCongTrinh = table.Column<int>(type: "int", nullable: true),
                    CapCongTrinhCong = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhanCapCongTrinhCong", x => x.MaPhanCapCongTrinhCong);
                });

            migrationBuilder.CreateTable(
                name: "ThoiGianVanHanhCongTrinh",
                columns: table => new
                {
                    MaNamVanHanh = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NamBatDauVanHanh = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThoiGianVanHanhCongTrinh", x => x.MaNamVanHanh);
                });

            migrationBuilder.CreateTable(
                name: "ThongSoKyThuatCongTrinh",
                columns: table => new
                {
                    MaThongSoKyThuatCongTrinhTramBom = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaThongTinCongTrinhTramBom = table.Column<int>(type: "int", nullable: true),
                    MaThongSoVanHanhThucTe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LuuLuongThietKe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LuuLuongThucTe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DienTichTuoiThietKe = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DienTichTuoiThucTe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LuuLuongLayNuoc = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TongLuongNuocKhaiThac = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThongSoKyThuatCongTrinh", x => x.MaThongSoKyThuatCongTrinhTramBom);
                });

            migrationBuilder.CreateTable(
                name: "ThongSoVanHanhThucTe",
                columns: table => new
                {
                    MaThongSoVanHanhThucTe = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaThongTinCongTrinh = table.Column<int>(type: "int", nullable: true),
                    LuuLuongKhaiThacThucTe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LuuLuongKhaiThacYeuCau = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LuuLuongKhaiThacChenhLech = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThongSoVanHanhThucTe", x => x.MaThongSoVanHanhThucTe);
                });

            migrationBuilder.CreateTable(
                name: "ThongTinCongTrinh",
                columns: table => new
                {
                    MaThongTinCongTrinh = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenCongTrinhKhaiThac = table.Column<int>(type: "int", nullable: true),
                    DiaDiemCongTrinh_Xa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiaDiemCongTrinh_Huyen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoCongTrinh = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThongTinCongTrinh", x => x.MaThongTinCongTrinh);
                });

            migrationBuilder.CreateTable(
                name: "ToaDoCongTrinh",
                columns: table => new
                {
                    MaToaDoCongTrinh = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaThongTinCongTrinh = table.Column<int>(type: "int", nullable: true),
                    ToaDoX_CT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToaDoY_CT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToaDoLat_CT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToaDoLng_CT = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToaDoCongTrinh", x => x.MaToaDoCongTrinh);
                });

            migrationBuilder.CreateTable(
                name: "TramBomSanXuat",
                columns: table => new
                {
                    MaTramBomSanXuat = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaThongTinCongTrinh = table.Column<int>(type: "int", nullable: true),
                    MaToaDoCongTrinh = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TramBomSanXuat", x => x.MaTramBomSanXuat);
                });

            migrationBuilder.CreateTable(
                name: "TramBomSinhHoat",
                columns: table => new
                {
                    MaTramBomSinhHoat = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaThongTinCongTrinh = table.Column<int>(type: "int", nullable: true),
                    MaToaDoCongTrinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenTramBomSinhHoat = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TramBomSinhHoat", x => x.MaTramBomSinhHoat);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CheDoKhaiThacCongTrinh");

            migrationBuilder.DropTable(
                name: "PhanCapCongTrinhCong");

            migrationBuilder.DropTable(
                name: "ThoiGianVanHanhCongTrinh");

            migrationBuilder.DropTable(
                name: "ThongSoKyThuatCongTrinh");

            migrationBuilder.DropTable(
                name: "ThongSoVanHanhThucTe");

            migrationBuilder.DropTable(
                name: "ThongTinCongTrinh");

            migrationBuilder.DropTable(
                name: "ToaDoCongTrinh");

            migrationBuilder.DropTable(
                name: "TramBomSanXuat");

            migrationBuilder.DropTable(
                name: "TramBomSinhHoat");
        }
    }
}
