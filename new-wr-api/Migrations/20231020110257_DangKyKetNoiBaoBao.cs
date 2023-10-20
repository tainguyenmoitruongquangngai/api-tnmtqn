using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace new_wr_api.Migrations
{
    /// <inheritdoc />
    public partial class DangKyKetNoiBaoBao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SoLuongNDD_TLN_TangChuaNuoc_MaTangChuaNuoc",
                table: "SoLuongNDD");

            migrationBuilder.DropForeignKey(
                name: "FK_ThongTinVeChatLuongNuoc_TLN_CongTrinh_MaCt",
                table: "ThongTinVeChatLuongNuoc");

            migrationBuilder.DropForeignKey(
                name: "FK_ThongTinVeHoatDongCuaCongTrinh_TLN_CongTrinh_MaCt",
                table: "ThongTinVeHoatDongCuaCongTrinh");

            migrationBuilder.DropForeignKey(
                name: "FK_ThongTinVeMucNuocTinh_TLN_CongTrinh_MaCt",
                table: "ThongTinVeMucNuocTinh");

            migrationBuilder.DropForeignKey(
                name: "FK_ThongTinVeTruLuongNuoc_TLN_CongTrinh_MaCt",
                table: "ThongTinVeTruLuongNuoc");

            migrationBuilder.DropForeignKey(
                name: "FK_TongLuongNuocMan_TLN_TangChuaNuoc_MaTangChuaNuoc",
                table: "TongLuongNuocMan");

            migrationBuilder.DropTable(
                name: "TLN_CongTrinh");

            migrationBuilder.DropTable(
                name: "TLN_TangChuaNuoc");

            migrationBuilder.CreateTable(
                name: "QLC_TangChuaNuoc",
                columns: table => new
                {
                    MaTangChuaNuoc = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenTCN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KyHieuTCN = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QLC_TangChuaNuoc", x => x.MaTangChuaNuoc);
                });

            migrationBuilder.CreateTable(
                name: "ThongTinCQNN",
                columns: table => new
                {
                    MaThongTinCQNN = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenCQNN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiaChiCQNN = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThongTinCQNN", x => x.MaThongTinCQNN);
                });

            migrationBuilder.CreateTable(
                name: "ThongTinTCCN",
                columns: table => new
                {
                    MaThongTinTCCN = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenTCCN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiaChiTCCN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThongTinLienHeTCCN = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThongTinTCCN", x => x.MaThongTinTCCN);
                });

            migrationBuilder.CreateTable(
                name: "ChuyenVien",
                columns: table => new
                {
                    MaChuyenVien = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaThongTinCQNN = table.Column<int>(type: "int", nullable: true),
                    TenChuyenVien = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoDienThoai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChuyenVien", x => x.MaChuyenVien);
                    table.ForeignKey(
                        name: "FK_ChuyenVien_ThongTinCQNN_MaThongTinCQNN",
                        column: x => x.MaThongTinCQNN,
                        principalTable: "ThongTinCQNN",
                        principalColumn: "MaThongTinCQNN");
                });

            migrationBuilder.CreateTable(
                name: "QLC_CongTrinh",
                columns: table => new
                {
                    MaCT = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaTangChuaNuoc = table.Column<int>(type: "int", nullable: true),
                    MaThongTinTCCN = table.Column<int>(type: "int", nullable: true),
                    TenCT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KyHieuCT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiaChiCT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    X = table.Column<double>(type: "float", nullable: true),
                    Y = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QLC_CongTrinh", x => x.MaCT);
                    table.ForeignKey(
                        name: "FK_QLC_CongTrinh_QLC_TangChuaNuoc_MaTangChuaNuoc",
                        column: x => x.MaTangChuaNuoc,
                        principalTable: "QLC_TangChuaNuoc",
                        principalColumn: "MaTangChuaNuoc");
                    table.ForeignKey(
                        name: "FK_QLC_CongTrinh_ThongTinTCCN_MaThongTinTCCN",
                        column: x => x.MaThongTinTCCN,
                        principalTable: "ThongTinTCCN",
                        principalColumn: "MaThongTinTCCN");
                });

            migrationBuilder.CreateTable(
                name: "ThongTinKetNoi",
                columns: table => new
                {
                    MaThongTinKetNoi = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaCt = table.Column<int>(type: "int", nullable: false),
                    TaiKhoanKetNoi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MatKhauKetNoi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiaChiNhanDuLieu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThongTinKetNoi", x => x.MaThongTinKetNoi);
                    table.ForeignKey(
                        name: "FK_ThongTinKetNoi_QLC_CongTrinh_MaCt",
                        column: x => x.MaCt,
                        principalTable: "QLC_CongTrinh",
                        principalColumn: "MaCT",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TrangThaiTaiKhoan",
                columns: table => new
                {
                    MaTrangThaiTaiKhoan = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaCt = table.Column<int>(type: "int", nullable: true),
                    TenTrangThai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianCapNhat = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrangThaiTaiKhoan", x => x.MaTrangThaiTaiKhoan);
                    table.ForeignKey(
                        name: "FK_TrangThaiTaiKhoan_QLC_CongTrinh_MaCt",
                        column: x => x.MaCt,
                        principalTable: "QLC_CongTrinh",
                        principalColumn: "MaCT");
                });

            migrationBuilder.CreateTable(
                name: "TaiKhoanKetNoi",
                columns: table => new
                {
                    MaTaiKhoanKetNoi = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaTrangThaiTaiKhoan = table.Column<int>(type: "int", nullable: true),
                    MaCt = table.Column<int>(type: "int", nullable: true),
                    TaiKhoan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MatKhau = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaiKhoanKetNoi", x => x.MaTaiKhoanKetNoi);
                    table.ForeignKey(
                        name: "FK_TaiKhoanKetNoi_QLC_CongTrinh_MaCt",
                        column: x => x.MaCt,
                        principalTable: "QLC_CongTrinh",
                        principalColumn: "MaCT");
                    table.ForeignKey(
                        name: "FK_TaiKhoanKetNoi_TrangThaiTaiKhoan_MaTrangThaiTaiKhoan",
                        column: x => x.MaTrangThaiTaiKhoan,
                        principalTable: "TrangThaiTaiKhoan",
                        principalColumn: "MaTrangThaiTaiKhoan");
                });

            migrationBuilder.CreateTable(
                name: "DuLieuKetNoi",
                columns: table => new
                {
                    MaDuLieuKetNoi = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaCt = table.Column<int>(type: "int", nullable: true),
                    MaTaiKhoanKetNoi = table.Column<int>(type: "int", nullable: true),
                    LoaiDuLieuKetNoi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DuLieu = table.Column<double>(type: "float", nullable: true),
                    DonViDo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DuLieuKetNoi", x => x.MaDuLieuKetNoi);
                    table.ForeignKey(
                        name: "FK_DuLieuKetNoi_QLC_CongTrinh_MaCt",
                        column: x => x.MaCt,
                        principalTable: "QLC_CongTrinh",
                        principalColumn: "MaCT");
                    table.ForeignKey(
                        name: "FK_DuLieuKetNoi_TaiKhoanKetNoi_MaTaiKhoanKetNoi",
                        column: x => x.MaTaiKhoanKetNoi,
                        principalTable: "TaiKhoanKetNoi",
                        principalColumn: "MaTaiKhoanKetNoi");
                });

            migrationBuilder.CreateTable(
                name: "LichSuKetNoi",
                columns: table => new
                {
                    MaLichSuKetNoi = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaCt = table.Column<int>(type: "int", nullable: true),
                    MaTaiKhoanKetNoi = table.Column<int>(type: "int", nullable: true),
                    VanHanhLoi = table.Column<bool>(type: "bit", nullable: true),
                    VanHanhDung = table.Column<bool>(type: "bit", nullable: true),
                    MatKetNoi = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LichSuKetNoi", x => x.MaLichSuKetNoi);
                    table.ForeignKey(
                        name: "FK_LichSuKetNoi_QLC_CongTrinh_MaCt",
                        column: x => x.MaCt,
                        principalTable: "QLC_CongTrinh",
                        principalColumn: "MaCT");
                    table.ForeignKey(
                        name: "FK_LichSuKetNoi_TaiKhoanKetNoi_MaTaiKhoanKetNoi",
                        column: x => x.MaTaiKhoanKetNoi,
                        principalTable: "TaiKhoanKetNoi",
                        principalColumn: "MaTaiKhoanKetNoi");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChuyenVien_MaThongTinCQNN",
                table: "ChuyenVien",
                column: "MaThongTinCQNN",
                unique: true,
                filter: "[MaThongTinCQNN] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DuLieuKetNoi_MaCt",
                table: "DuLieuKetNoi",
                column: "MaCt",
                unique: true,
                filter: "[MaCt] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DuLieuKetNoi_MaTaiKhoanKetNoi",
                table: "DuLieuKetNoi",
                column: "MaTaiKhoanKetNoi",
                unique: true,
                filter: "[MaTaiKhoanKetNoi] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_LichSuKetNoi_MaCt",
                table: "LichSuKetNoi",
                column: "MaCt",
                unique: true,
                filter: "[MaCt] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_LichSuKetNoi_MaTaiKhoanKetNoi",
                table: "LichSuKetNoi",
                column: "MaTaiKhoanKetNoi",
                unique: true,
                filter: "[MaTaiKhoanKetNoi] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_QLC_CongTrinh_MaTangChuaNuoc",
                table: "QLC_CongTrinh",
                column: "MaTangChuaNuoc");

            migrationBuilder.CreateIndex(
                name: "IX_QLC_CongTrinh_MaThongTinTCCN",
                table: "QLC_CongTrinh",
                column: "MaThongTinTCCN");

            migrationBuilder.CreateIndex(
                name: "IX_TaiKhoanKetNoi_MaCt",
                table: "TaiKhoanKetNoi",
                column: "MaCt",
                unique: true,
                filter: "[MaCt] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_TaiKhoanKetNoi_MaTrangThaiTaiKhoan",
                table: "TaiKhoanKetNoi",
                column: "MaTrangThaiTaiKhoan",
                unique: true,
                filter: "[MaTrangThaiTaiKhoan] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ThongTinKetNoi_MaCt",
                table: "ThongTinKetNoi",
                column: "MaCt",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TrangThaiTaiKhoan_MaCt",
                table: "TrangThaiTaiKhoan",
                column: "MaCt",
                unique: true,
                filter: "[MaCt] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_SoLuongNDD_QLC_TangChuaNuoc_MaTangChuaNuoc",
                table: "SoLuongNDD",
                column: "MaTangChuaNuoc",
                principalTable: "QLC_TangChuaNuoc",
                principalColumn: "MaTangChuaNuoc");

            migrationBuilder.AddForeignKey(
                name: "FK_ThongTinVeChatLuongNuoc_QLC_CongTrinh_MaCt",
                table: "ThongTinVeChatLuongNuoc",
                column: "MaCt",
                principalTable: "QLC_CongTrinh",
                principalColumn: "MaCT");

            migrationBuilder.AddForeignKey(
                name: "FK_ThongTinVeHoatDongCuaCongTrinh_QLC_CongTrinh_MaCt",
                table: "ThongTinVeHoatDongCuaCongTrinh",
                column: "MaCt",
                principalTable: "QLC_CongTrinh",
                principalColumn: "MaCT");

            migrationBuilder.AddForeignKey(
                name: "FK_ThongTinVeMucNuocTinh_QLC_CongTrinh_MaCt",
                table: "ThongTinVeMucNuocTinh",
                column: "MaCt",
                principalTable: "QLC_CongTrinh",
                principalColumn: "MaCT");

            migrationBuilder.AddForeignKey(
                name: "FK_ThongTinVeTruLuongNuoc_QLC_CongTrinh_MaCt",
                table: "ThongTinVeTruLuongNuoc",
                column: "MaCt",
                principalTable: "QLC_CongTrinh",
                principalColumn: "MaCT");

            migrationBuilder.AddForeignKey(
                name: "FK_TongLuongNuocMan_QLC_TangChuaNuoc_MaTangChuaNuoc",
                table: "TongLuongNuocMan",
                column: "MaTangChuaNuoc",
                principalTable: "QLC_TangChuaNuoc",
                principalColumn: "MaTangChuaNuoc");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SoLuongNDD_QLC_TangChuaNuoc_MaTangChuaNuoc",
                table: "SoLuongNDD");

            migrationBuilder.DropForeignKey(
                name: "FK_ThongTinVeChatLuongNuoc_QLC_CongTrinh_MaCt",
                table: "ThongTinVeChatLuongNuoc");

            migrationBuilder.DropForeignKey(
                name: "FK_ThongTinVeHoatDongCuaCongTrinh_QLC_CongTrinh_MaCt",
                table: "ThongTinVeHoatDongCuaCongTrinh");

            migrationBuilder.DropForeignKey(
                name: "FK_ThongTinVeMucNuocTinh_QLC_CongTrinh_MaCt",
                table: "ThongTinVeMucNuocTinh");

            migrationBuilder.DropForeignKey(
                name: "FK_ThongTinVeTruLuongNuoc_QLC_CongTrinh_MaCt",
                table: "ThongTinVeTruLuongNuoc");

            migrationBuilder.DropForeignKey(
                name: "FK_TongLuongNuocMan_QLC_TangChuaNuoc_MaTangChuaNuoc",
                table: "TongLuongNuocMan");

            migrationBuilder.DropTable(
                name: "ChuyenVien");

            migrationBuilder.DropTable(
                name: "DuLieuKetNoi");

            migrationBuilder.DropTable(
                name: "LichSuKetNoi");

            migrationBuilder.DropTable(
                name: "ThongTinKetNoi");

            migrationBuilder.DropTable(
                name: "ThongTinCQNN");

            migrationBuilder.DropTable(
                name: "TaiKhoanKetNoi");

            migrationBuilder.DropTable(
                name: "TrangThaiTaiKhoan");

            migrationBuilder.DropTable(
                name: "QLC_CongTrinh");

            migrationBuilder.DropTable(
                name: "QLC_TangChuaNuoc");

            migrationBuilder.DropTable(
                name: "ThongTinTCCN");

            migrationBuilder.CreateTable(
                name: "TLN_TangChuaNuoc",
                columns: table => new
                {
                    MaTangChuaNuoc = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KyHieuTCN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenTCN = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TLN_TangChuaNuoc", x => x.MaTangChuaNuoc);
                });

            migrationBuilder.CreateTable(
                name: "TLN_CongTrinh",
                columns: table => new
                {
                    MaCT = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaTangChuaNuoc = table.Column<int>(type: "int", nullable: true),
                    DiaChiCT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KyHieuCT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenCT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    X = table.Column<double>(type: "float", nullable: true),
                    Y = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TLN_CongTrinh", x => x.MaCT);
                    table.ForeignKey(
                        name: "FK_TLN_CongTrinh_TLN_TangChuaNuoc_MaTangChuaNuoc",
                        column: x => x.MaTangChuaNuoc,
                        principalTable: "TLN_TangChuaNuoc",
                        principalColumn: "MaTangChuaNuoc");
                });

            migrationBuilder.CreateIndex(
                name: "IX_TLN_CongTrinh_MaTangChuaNuoc",
                table: "TLN_CongTrinh",
                column: "MaTangChuaNuoc");

            migrationBuilder.AddForeignKey(
                name: "FK_SoLuongNDD_TLN_TangChuaNuoc_MaTangChuaNuoc",
                table: "SoLuongNDD",
                column: "MaTangChuaNuoc",
                principalTable: "TLN_TangChuaNuoc",
                principalColumn: "MaTangChuaNuoc");

            migrationBuilder.AddForeignKey(
                name: "FK_ThongTinVeChatLuongNuoc_TLN_CongTrinh_MaCt",
                table: "ThongTinVeChatLuongNuoc",
                column: "MaCt",
                principalTable: "TLN_CongTrinh",
                principalColumn: "MaCT");

            migrationBuilder.AddForeignKey(
                name: "FK_ThongTinVeHoatDongCuaCongTrinh_TLN_CongTrinh_MaCt",
                table: "ThongTinVeHoatDongCuaCongTrinh",
                column: "MaCt",
                principalTable: "TLN_CongTrinh",
                principalColumn: "MaCT");

            migrationBuilder.AddForeignKey(
                name: "FK_ThongTinVeMucNuocTinh_TLN_CongTrinh_MaCt",
                table: "ThongTinVeMucNuocTinh",
                column: "MaCt",
                principalTable: "TLN_CongTrinh",
                principalColumn: "MaCT");

            migrationBuilder.AddForeignKey(
                name: "FK_ThongTinVeTruLuongNuoc_TLN_CongTrinh_MaCt",
                table: "ThongTinVeTruLuongNuoc",
                column: "MaCt",
                principalTable: "TLN_CongTrinh",
                principalColumn: "MaCT");

            migrationBuilder.AddForeignKey(
                name: "FK_TongLuongNuocMan_TLN_TangChuaNuoc_MaTangChuaNuoc",
                table: "TongLuongNuocMan",
                column: "MaTangChuaNuoc",
                principalTable: "TLN_TangChuaNuoc",
                principalColumn: "MaTangChuaNuoc");
        }
    }
}
