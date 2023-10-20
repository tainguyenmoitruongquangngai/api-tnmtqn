using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace new_wr_api.Migrations
{
    /// <inheritdoc />
    public partial class TruLuongNuocBaoBao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LoaiTramQuanTracLuongMua",
                columns: table => new
                {
                    MaLoaiTramQuanTracLuongMua = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLoaiTram = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KyHieuLoaiTram = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiTramQuanTracLuongMua", x => x.MaLoaiTramQuanTracLuongMua);
                });

            migrationBuilder.CreateTable(
                name: "PhuongPhapTinhMua",
                columns: table => new
                {
                    MaPhuongPhapTinhMua = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenPhuongPhap = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhuongPhapTinhMua", x => x.MaPhuongPhapTinhMua);
                });

            migrationBuilder.CreateTable(
                name: "ThongTinVeCacChiTieuPhanTichCLN",
                columns: table => new
                {
                    MaChiTieu = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenChiTieu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DonVi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TieuChuan = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThongTinVeCacChiTieuPhanTichCLN", x => x.MaChiTieu);
                });

            migrationBuilder.CreateTable(
                name: "TLN_CongTrinh",
                columns: table => new
                {
                    MaCT = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenCT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KyHieuCT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiaChiCT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    X = table.Column<double>(type: "float", nullable: true),
                    Y = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TLN_CongTrinh", x => x.MaCT);
                });

            migrationBuilder.CreateTable(
                name: "TLN_TangChuaNuoc",
                columns: table => new
                {
                    MaTangChuaNuoc = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenTCN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KyHieuTCN = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TLN_TangChuaNuoc", x => x.MaTangChuaNuoc);
                });

            migrationBuilder.CreateTable(
                name: "TramQuanTracLuongMua",
                columns: table => new
                {
                    MaTramQuanTracLuongMua = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaLoaiTramQuanTracLuongMua = table.Column<int>(type: "int", nullable: true),
                    TenTramQuanTracLuongMua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToaDoTramX = table.Column<double>(type: "float", nullable: true),
                    ToaDoTramY = table.Column<double>(type: "float", nullable: true),
                    DiaChiXayDuengTramQuanTrac = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TramQuanTracLuongMua", x => x.MaTramQuanTracLuongMua);
                    table.ForeignKey(
                        name: "FK_TramQuanTracLuongMua_LoaiTramQuanTracLuongMua_MaLoaiTramQuanTracLuongMua",
                        column: x => x.MaLoaiTramQuanTracLuongMua,
                        principalTable: "LoaiTramQuanTracLuongMua",
                        principalColumn: "MaLoaiTramQuanTracLuongMua");
                });

            migrationBuilder.CreateTable(
                name: "ThongTinVeChatLuongNuoc",
                columns: table => new
                {
                    MaThongTinVeChatLuongNuoc = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaCt = table.Column<int>(type: "int", nullable: true),
                    ChatLuongNuocBanDau = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChatLuongNuocHienTai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianQuanTracChatLuongNuocHienTai = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MucDoONhiemNuoc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NguyenNhanONhiemNuoc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GiaiPhapKhacPhucONhiemNuoc = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThongTinVeChatLuongNuoc", x => x.MaThongTinVeChatLuongNuoc);
                    table.ForeignKey(
                        name: "FK_ThongTinVeChatLuongNuoc_TLN_CongTrinh_MaCt",
                        column: x => x.MaCt,
                        principalTable: "TLN_CongTrinh",
                        principalColumn: "MaCT");
                });

            migrationBuilder.CreateTable(
                name: "ThongTinVeHoatDongCuaCongTrinh",
                columns: table => new
                {
                    MaThongTinVeHoatDongCuaCongTrinh = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaCt = table.Column<int>(type: "int", nullable: true),
                    TinhTrangHoatDong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgayBatDauHoatDong = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NgayNgungHoatDong = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LyDoNgungHoatDong = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThongTinVeHoatDongCuaCongTrinh", x => x.MaThongTinVeHoatDongCuaCongTrinh);
                    table.ForeignKey(
                        name: "FK_ThongTinVeHoatDongCuaCongTrinh_TLN_CongTrinh_MaCt",
                        column: x => x.MaCt,
                        principalTable: "TLN_CongTrinh",
                        principalColumn: "MaCT");
                });

            migrationBuilder.CreateTable(
                name: "ThongTinVeMucNuocTinh",
                columns: table => new
                {
                    MaTtVeMucNuocTinh = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaCt = table.Column<int>(type: "int", nullable: true),
                    MucNuocTinhBanDau = table.Column<double>(type: "float", nullable: true),
                    MucNuocTinhHienTai = table.Column<double>(type: "float", nullable: true),
                    ThoiGianQuanTracMucNuocTinhHienTai = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LuongSuyGiamMucNuocTinh = table.Column<double>(type: "float", nullable: true),
                    TocDoSuyGiamMucNuocTinh = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThongTinVeMucNuocTinh", x => x.MaTtVeMucNuocTinh);
                    table.ForeignKey(
                        name: "FK_ThongTinVeMucNuocTinh_TLN_CongTrinh_MaCt",
                        column: x => x.MaCt,
                        principalTable: "TLN_CongTrinh",
                        principalColumn: "MaCT");
                });

            migrationBuilder.CreateTable(
                name: "ThongTinVeTruLuongNuoc",
                columns: table => new
                {
                    MaThongTinVeTruLuong = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaCt = table.Column<int>(type: "int", nullable: true),
                    TruLuongHienCo = table.Column<double>(type: "float", nullable: true),
                    TruLuongCoTheKhaiThac = table.Column<double>(type: "float", nullable: true),
                    TruLuongDaKhaiThac = table.Column<double>(type: "float", nullable: true),
                    ThoiGianBaoCaoTruLuongDaKhaiThac = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThongTinVeTruLuongNuoc", x => x.MaThongTinVeTruLuong);
                    table.ForeignKey(
                        name: "FK_ThongTinVeTruLuongNuoc_TLN_CongTrinh_MaCt",
                        column: x => x.MaCt,
                        principalTable: "TLN_CongTrinh",
                        principalColumn: "MaCT");
                });

            migrationBuilder.CreateTable(
                name: "SoLuongNDD",
                columns: table => new
                {
                    MaSoLuongNdd = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaTangChuaNuoc = table.Column<int>(type: "int", nullable: true),
                    DienTichPhanBo = table.Column<double>(type: "float", nullable: true),
                    ChieuSauPhanBoTu = table.Column<double>(type: "float", nullable: true),
                    ChieuSauPhanBoDen = table.Column<double>(type: "float", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SoLuongNDD", x => x.MaSoLuongNdd);
                    table.ForeignKey(
                        name: "FK_SoLuongNDD_TLN_TangChuaNuoc_MaTangChuaNuoc",
                        column: x => x.MaTangChuaNuoc,
                        principalTable: "TLN_TangChuaNuoc",
                        principalColumn: "MaTangChuaNuoc");
                });

            migrationBuilder.CreateTable(
                name: "TongLuongNuocMan",
                columns: table => new
                {
                    MaTongLuongNuocMan = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaTangChuaNuoc = table.Column<int>(type: "int", nullable: true),
                    DienTichPhanBoCuaNuocMan = table.Column<double>(type: "float", nullable: true),
                    TruLuongNuocMan = table.Column<double>(type: "float", nullable: true),
                    ChieuSauPhanBoTu = table.Column<double>(type: "float", nullable: true),
                    ChieuSauPhanBoDen = table.Column<double>(type: "float", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TongLuongNuocMan", x => x.MaTongLuongNuocMan);
                    table.ForeignKey(
                        name: "FK_TongLuongNuocMan_TLN_TangChuaNuoc_MaTangChuaNuoc",
                        column: x => x.MaTangChuaNuoc,
                        principalTable: "TLN_TangChuaNuoc",
                        principalColumn: "MaTangChuaNuoc");
                });

            migrationBuilder.CreateTable(
                name: "SoLieuMua",
                columns: table => new
                {
                    MaSoLieuMua = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaPhuongPhapTinhMua = table.Column<int>(type: "int", nullable: true),
                    MaTramQuanTracLuongMua = table.Column<int>(type: "int", nullable: true),
                    SoLieuMuaGio = table.Column<int>(type: "int", nullable: true),
                    SoLieuMuaNgay = table.Column<int>(type: "int", nullable: true),
                    SoLieuMuaThang = table.Column<int>(type: "int", nullable: true),
                    SoLieuMuaNam = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SoLieuMua", x => x.MaSoLieuMua);
                    table.ForeignKey(
                        name: "FK_SoLieuMua_PhuongPhapTinhMua_MaPhuongPhapTinhMua",
                        column: x => x.MaPhuongPhapTinhMua,
                        principalTable: "PhuongPhapTinhMua",
                        principalColumn: "MaPhuongPhapTinhMua");
                    table.ForeignKey(
                        name: "FK_SoLieuMua_TramQuanTracLuongMua_MaTramQuanTracLuongMua",
                        column: x => x.MaTramQuanTracLuongMua,
                        principalTable: "TramQuanTracLuongMua",
                        principalColumn: "MaTramQuanTracLuongMua");
                });

            migrationBuilder.CreateTable(
                name: "TrangThaiQuanTrac",
                columns: table => new
                {
                    MaTrangThaiQuanTrac = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaTramQuanTracLuongMua = table.Column<int>(type: "int", nullable: true),
                    TrangThai = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrangThaiQuanTrac", x => x.MaTrangThaiQuanTrac);
                    table.ForeignKey(
                        name: "FK_TrangThaiQuanTrac_TramQuanTracLuongMua_MaTramQuanTracLuongMua",
                        column: x => x.MaTramQuanTracLuongMua,
                        principalTable: "TramQuanTracLuongMua",
                        principalColumn: "MaTramQuanTracLuongMua");
                });

            migrationBuilder.CreateTable(
                name: "TongLuongMua",
                columns: table => new
                {
                    MaTongLuongMua = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaTramQuanTracLuongMua = table.Column<int>(type: "int", nullable: true),
                    MaSoLieuMua = table.Column<int>(type: "int", nullable: true),
                    LuongMuaThangI = table.Column<double>(type: "float", nullable: true),
                    LuongMuaThangII = table.Column<double>(type: "float", nullable: true),
                    LuongMuaThangIII = table.Column<double>(type: "float", nullable: true),
                    LuongMuaThangIV = table.Column<double>(type: "float", nullable: true),
                    LuongMuaThangV = table.Column<double>(type: "float", nullable: true),
                    LuongMuaThangVI = table.Column<double>(type: "float", nullable: true),
                    LuongMuaThangVII = table.Column<double>(type: "float", nullable: true),
                    LuongMuaThangVIII = table.Column<double>(type: "float", nullable: true),
                    LuongMuaThangIX = table.Column<double>(type: "float", nullable: true),
                    LuongMuaThangX = table.Column<double>(type: "float", nullable: true),
                    LuongMuaThangXI = table.Column<double>(type: "float", nullable: true),
                    LuongMuaThangXII = table.Column<double>(type: "float", nullable: true),
                    TongLuongMuaMuaLu = table.Column<double>(type: "float", nullable: true),
                    TongMuaMuaCan = table.Column<double>(type: "float", nullable: true),
                    TongLuongMuaNam = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TongLuongMua", x => x.MaTongLuongMua);
                    table.ForeignKey(
                        name: "FK_TongLuongMua_SoLieuMua_MaSoLieuMua",
                        column: x => x.MaSoLieuMua,
                        principalTable: "SoLieuMua",
                        principalColumn: "MaSoLieuMua");
                    table.ForeignKey(
                        name: "FK_TongLuongMua_TramQuanTracLuongMua_MaTramQuanTracLuongMua",
                        column: x => x.MaTramQuanTracLuongMua,
                        principalTable: "TramQuanTracLuongMua",
                        principalColumn: "MaTramQuanTracLuongMua");
                });

            migrationBuilder.CreateTable(
                name: "Ao_Ho_Dam_Pha",
                columns: table => new
                {
                    MaAo_Ho_Dam_Pha = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaLuuVucSong = table.Column<int>(type: "int", nullable: false),
                    TenAo_Ho_Dam_Pha = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiaDiemAo_Ho_Dam_Pha = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NguonNuocKhaiThac = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DienTichNuocMat = table.Column<double>(type: "float", nullable: true),
                    DungTichToanBo = table.Column<double>(type: "float", nullable: true),
                    DungTichHuuIch = table.Column<double>(type: "float", nullable: true),
                    MucDichSuDung = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ao_Ho_Dam_Pha", x => x.MaAo_Ho_Dam_Pha);
                });

            migrationBuilder.CreateTable(
                name: "CLNMatTheoWQI",
                columns: table => new
                {
                    MaChatLuongNuocMat = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaSong_Suoi_KenhRach = table.Column<int>(type: "int", nullable: true),
                    MaLuuVucSong = table.Column<int>(type: "int", nullable: true),
                    TenSong_Suoi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianDanhGia = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GiaTriWqi = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CLNMatTheoWQI", x => x.MaChatLuongNuocMat);
                });

            migrationBuilder.CreateTable(
                name: "DacTrungSongSuoi",
                columns: table => new
                {
                    MaDacTrungSongSuoi = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaSong_Suoi_KenhRach = table.Column<int>(type: "int", nullable: true),
                    MaLuuVucSong = table.Column<int>(type: "int", nullable: true),
                    DoDocLongSong = table.Column<double>(type: "float", nullable: true),
                    ChieuDaiSong = table.Column<double>(type: "float", nullable: true),
                    HeSoDongChay = table.Column<double>(type: "float", nullable: true),
                    ModulDongChay = table.Column<double>(type: "float", nullable: true),
                    LuuLuongDongChay = table.Column<double>(type: "float", nullable: true),
                    DienBienLongSong_Suoi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DacTrungSongSuoi", x => x.MaDacTrungSongSuoi);
                });

            migrationBuilder.CreateTable(
                name: "TLN_LuuVucSong",
                columns: table => new
                {
                    MaLuuVucSong = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLuuVucSong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ViTriHanhChinhCuaLVS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DienTichLuuVucSong = table.Column<double>(type: "float", nullable: true),
                    DacTrungSongSuoiMaDacTrungSongSuoi = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TLN_LuuVucSong", x => x.MaLuuVucSong);
                    table.ForeignKey(
                        name: "FK_TLN_LuuVucSong_DacTrungSongSuoi_DacTrungSongSuoiMaDacTrungSongSuoi",
                        column: x => x.DacTrungSongSuoiMaDacTrungSongSuoi,
                        principalTable: "DacTrungSongSuoi",
                        principalColumn: "MaDacTrungSongSuoi");
                });

            migrationBuilder.CreateTable(
                name: "Song_Suoi_KenhRach",
                columns: table => new
                {
                    MaSong_Suoi_KenhRach = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaLuuVucSong = table.Column<int>(type: "int", nullable: true),
                    TenSongSuoi_KenhRach = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ViTriDauSongSuoi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToaDoX_DauSong = table.Column<double>(type: "float", nullable: true),
                    ToaDoY_DauSong = table.Column<double>(type: "float", nullable: true),
                    ViTriCuoiSongSuoi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToaDoX_CuoiSong = table.Column<double>(type: "float", nullable: true),
                    ToaDoY_CuoiSong = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Song_Suoi_KenhRach", x => x.MaSong_Suoi_KenhRach);
                    table.ForeignKey(
                        name: "FK_Song_Suoi_KenhRach_TLN_LuuVucSong_MaLuuVucSong",
                        column: x => x.MaLuuVucSong,
                        principalTable: "TLN_LuuVucSong",
                        principalColumn: "MaLuuVucSong");
                });

            migrationBuilder.CreateTable(
                name: "TongLuongDongChay",
                columns: table => new
                {
                    MaTongLuongDongChay = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaLuuVucSong = table.Column<int>(type: "int", nullable: true),
                    TongLuongDongChayThangI = table.Column<double>(type: "float", nullable: true),
                    TongLuongDongChayThangII = table.Column<double>(type: "float", nullable: true),
                    TongLuongDongChayThangIII = table.Column<double>(type: "float", nullable: true),
                    TongLuongDongChayThangIV = table.Column<double>(type: "float", nullable: true),
                    TongLuongDongChayThangV = table.Column<double>(type: "float", nullable: true),
                    TongLuongDongChayThangVI = table.Column<double>(type: "float", nullable: true),
                    TongLuongDongChayThangVII = table.Column<double>(type: "float", nullable: true),
                    TongLuongDongChayThangVIII = table.Column<double>(type: "float", nullable: true),
                    TongLuongDongChayThangIX = table.Column<double>(type: "float", nullable: true),
                    TongLuongDongChayThangX = table.Column<double>(type: "float", nullable: true),
                    TongLuongDongChayThangXI = table.Column<double>(type: "float", nullable: true),
                    TongLuongDongChayThangXII = table.Column<double>(type: "float", nullable: true),
                    TongLuongDongChayMuaLu = table.Column<double>(type: "float", nullable: true),
                    TongDongChayMuaCan = table.Column<double>(type: "float", nullable: true),
                    TongLuongDongChayNam = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TongLuongDongChay", x => x.MaTongLuongDongChay);
                    table.ForeignKey(
                        name: "FK_TongLuongDongChay_TLN_LuuVucSong_MaLuuVucSong",
                        column: x => x.MaLuuVucSong,
                        principalTable: "TLN_LuuVucSong",
                        principalColumn: "MaLuuVucSong");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ao_Ho_Dam_Pha_MaLuuVucSong",
                table: "Ao_Ho_Dam_Pha",
                column: "MaLuuVucSong",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CLNMatTheoWQI_MaLuuVucSong",
                table: "CLNMatTheoWQI",
                column: "MaLuuVucSong",
                unique: true,
                filter: "[MaLuuVucSong] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CLNMatTheoWQI_MaSong_Suoi_KenhRach",
                table: "CLNMatTheoWQI",
                column: "MaSong_Suoi_KenhRach");

            migrationBuilder.CreateIndex(
                name: "IX_DacTrungSongSuoi_MaSong_Suoi_KenhRach",
                table: "DacTrungSongSuoi",
                column: "MaSong_Suoi_KenhRach");

            migrationBuilder.CreateIndex(
                name: "IX_SoLieuMua_MaPhuongPhapTinhMua",
                table: "SoLieuMua",
                column: "MaPhuongPhapTinhMua",
                unique: true,
                filter: "[MaPhuongPhapTinhMua] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_SoLieuMua_MaTramQuanTracLuongMua",
                table: "SoLieuMua",
                column: "MaTramQuanTracLuongMua",
                unique: true,
                filter: "[MaTramQuanTracLuongMua] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_SoLuongNDD_MaTangChuaNuoc",
                table: "SoLuongNDD",
                column: "MaTangChuaNuoc",
                unique: true,
                filter: "[MaTangChuaNuoc] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Song_Suoi_KenhRach_MaLuuVucSong",
                table: "Song_Suoi_KenhRach",
                column: "MaLuuVucSong",
                unique: true,
                filter: "[MaLuuVucSong] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ThongTinVeChatLuongNuoc_MaCt",
                table: "ThongTinVeChatLuongNuoc",
                column: "MaCt",
                unique: true,
                filter: "[MaCt] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ThongTinVeHoatDongCuaCongTrinh_MaCt",
                table: "ThongTinVeHoatDongCuaCongTrinh",
                column: "MaCt",
                unique: true,
                filter: "[MaCt] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ThongTinVeMucNuocTinh_MaCt",
                table: "ThongTinVeMucNuocTinh",
                column: "MaCt",
                unique: true,
                filter: "[MaCt] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ThongTinVeTruLuongNuoc_MaCt",
                table: "ThongTinVeTruLuongNuoc",
                column: "MaCt",
                unique: true,
                filter: "[MaCt] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_TLN_LuuVucSong_DacTrungSongSuoiMaDacTrungSongSuoi",
                table: "TLN_LuuVucSong",
                column: "DacTrungSongSuoiMaDacTrungSongSuoi");

            migrationBuilder.CreateIndex(
                name: "IX_TongLuongDongChay_MaLuuVucSong",
                table: "TongLuongDongChay",
                column: "MaLuuVucSong",
                unique: true,
                filter: "[MaLuuVucSong] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_TongLuongMua_MaSoLieuMua",
                table: "TongLuongMua",
                column: "MaSoLieuMua",
                unique: true,
                filter: "[MaSoLieuMua] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_TongLuongMua_MaTramQuanTracLuongMua",
                table: "TongLuongMua",
                column: "MaTramQuanTracLuongMua",
                unique: true,
                filter: "[MaTramQuanTracLuongMua] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_TongLuongNuocMan_MaTangChuaNuoc",
                table: "TongLuongNuocMan",
                column: "MaTangChuaNuoc",
                unique: true,
                filter: "[MaTangChuaNuoc] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_TramQuanTracLuongMua_MaLoaiTramQuanTracLuongMua",
                table: "TramQuanTracLuongMua",
                column: "MaLoaiTramQuanTracLuongMua",
                unique: true,
                filter: "[MaLoaiTramQuanTracLuongMua] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_TrangThaiQuanTrac_MaTramQuanTracLuongMua",
                table: "TrangThaiQuanTrac",
                column: "MaTramQuanTracLuongMua",
                unique: true,
                filter: "[MaTramQuanTracLuongMua] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Ao_Ho_Dam_Pha_TLN_LuuVucSong_MaLuuVucSong",
                table: "Ao_Ho_Dam_Pha",
                column: "MaLuuVucSong",
                principalTable: "TLN_LuuVucSong",
                principalColumn: "MaLuuVucSong",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CLNMatTheoWQI_Song_Suoi_KenhRach_MaSong_Suoi_KenhRach",
                table: "CLNMatTheoWQI",
                column: "MaSong_Suoi_KenhRach",
                principalTable: "Song_Suoi_KenhRach",
                principalColumn: "MaSong_Suoi_KenhRach");

            migrationBuilder.AddForeignKey(
                name: "FK_CLNMatTheoWQI_TLN_LuuVucSong_MaLuuVucSong",
                table: "CLNMatTheoWQI",
                column: "MaLuuVucSong",
                principalTable: "TLN_LuuVucSong",
                principalColumn: "MaLuuVucSong");

            migrationBuilder.AddForeignKey(
                name: "FK_DacTrungSongSuoi_Song_Suoi_KenhRach_MaSong_Suoi_KenhRach",
                table: "DacTrungSongSuoi",
                column: "MaSong_Suoi_KenhRach",
                principalTable: "Song_Suoi_KenhRach",
                principalColumn: "MaSong_Suoi_KenhRach");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Song_Suoi_KenhRach_TLN_LuuVucSong_MaLuuVucSong",
                table: "Song_Suoi_KenhRach");

            migrationBuilder.DropTable(
                name: "Ao_Ho_Dam_Pha");

            migrationBuilder.DropTable(
                name: "CLNMatTheoWQI");

            migrationBuilder.DropTable(
                name: "SoLuongNDD");

            migrationBuilder.DropTable(
                name: "ThongTinVeCacChiTieuPhanTichCLN");

            migrationBuilder.DropTable(
                name: "ThongTinVeChatLuongNuoc");

            migrationBuilder.DropTable(
                name: "ThongTinVeHoatDongCuaCongTrinh");

            migrationBuilder.DropTable(
                name: "ThongTinVeMucNuocTinh");

            migrationBuilder.DropTable(
                name: "ThongTinVeTruLuongNuoc");

            migrationBuilder.DropTable(
                name: "TongLuongDongChay");

            migrationBuilder.DropTable(
                name: "TongLuongMua");

            migrationBuilder.DropTable(
                name: "TongLuongNuocMan");

            migrationBuilder.DropTable(
                name: "TrangThaiQuanTrac");

            migrationBuilder.DropTable(
                name: "TLN_CongTrinh");

            migrationBuilder.DropTable(
                name: "SoLieuMua");

            migrationBuilder.DropTable(
                name: "TLN_TangChuaNuoc");

            migrationBuilder.DropTable(
                name: "PhuongPhapTinhMua");

            migrationBuilder.DropTable(
                name: "TramQuanTracLuongMua");

            migrationBuilder.DropTable(
                name: "LoaiTramQuanTracLuongMua");

            migrationBuilder.DropTable(
                name: "TLN_LuuVucSong");

            migrationBuilder.DropTable(
                name: "DacTrungSongSuoi");

            migrationBuilder.DropTable(
                name: "Song_Suoi_KenhRach");
        }
    }
}
