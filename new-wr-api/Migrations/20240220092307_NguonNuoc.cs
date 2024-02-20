using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace new_wr_api.Migrations
{
    /// <inheritdoc />
    public partial class NguonNuoc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KKTNN_NuocDuoiDat_ChatLuong");

            migrationBuilder.CreateTable(
                name: "NN_AoHoDamPhaKhongDuocSanLap",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenHoChua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Xa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Huyen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NguonNuoc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThuocLVS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LoaiHinhChucNang = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DienTichMatNuoc = table.Column<double>(type: "float", nullable: true),
                    DungTichToanBo = table.Column<double>(type: "float", nullable: true),
                    DungTichHuuIch = table.Column<double>(type: "float", nullable: true),
                    DungTichPhongLu = table.Column<double>(type: "float", nullable: true),
                    MucNuocDangBinhThuong = table.Column<double>(type: "float", nullable: true),
                    MucNuocChet = table.Column<double>(type: "float", nullable: true),
                    NamHoanThanh = table.Column<int>(type: "int", nullable: true),
                    DonQuayLyVanHanh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThuocDanhMucKhongSanLap = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuyetDinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianTao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanTao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianSua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanSua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DaXoa = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NN_AoHoDamPhaKhongDuocSanLap", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NN_CNNN_Ho",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenHoChua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThuocLVS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XaPhuongTT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HuyenTP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DienTichMatNuoc = table.Column<double>(type: "float", nullable: true),
                    DungTichToanBo = table.Column<double>(type: "float", nullable: true),
                    DungTichHuuIch = table.Column<double>(type: "float", nullable: true),
                    NamHoanThanh = table.Column<int>(type: "int", nullable: true),
                    DonViQuanLyVanHanh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChucNangNguonNuoc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MucTieuChatLuong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianTao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanTao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianSua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanSua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DaXoa = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NN_CNNN_Ho", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NN_CNNN_SongSuoi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaSong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenSongSuoi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChayRa = table.Column<double>(type: "float", nullable: true),
                    ChieuDai = table.Column<double>(type: "float", nullable: true),
                    DiaPhanHanhChinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Huyen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XDiemDau = table.Column<double>(type: "float", nullable: true),
                    YDiemDau = table.Column<double>(type: "float", nullable: true),
                    XDiemCuoi = table.Column<double>(type: "float", nullable: true),
                    YDiemCuoi = table.Column<double>(type: "float", nullable: true),
                    ChucNangNguonNuoc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MucTieuChatLuong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianThucHien = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ThoiGianTao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanTao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianSua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanSua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DaXoa = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NN_CNNN_SongSuoi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NN_CNNN_TangChuaNuoc",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ViTriPhamVi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XaPhuongTT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HuyenTP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenTCN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LoaiChuaNuoc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChieuSauPhanBo = table.Column<double>(type: "float", nullable: true),
                    ChucNangNguonNuoc = table.Column<double>(type: "float", nullable: true),
                    MucTieuChatLuongNuoc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianTao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanTao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianSua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanSua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DaXoa = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NN_CNNN_TangChuaNuoc", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NN_DCTT_HaDuHoChua",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenCT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThuocLVS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XaPhuongTT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HuyenTP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NguonNuocKhaiThac = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QttSauDap = table.Column<double>(type: "float", nullable: true),
                    QttSauCT = table.Column<double>(type: "float", nullable: true),
                    QttQuyDinhKhac = table.Column<double>(type: "float", nullable: true),
                    LoaiHinhCT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianTao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanTao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianSua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanSua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DaXoa = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NN_DCTT_HaDuHoChua", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NN_DCTT_SongSuoi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenSong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThuocLVS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenDiem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XaPhuongTT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HuyenTP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    X = table.Column<double>(type: "float", nullable: true),
                    Y = table.Column<double>(type: "float", nullable: true),
                    DienTichViTriXacDinhQtt = table.Column<double>(type: "float", nullable: true),
                    Qtt = table.Column<double>(type: "float", nullable: true),
                    ThoiGianTao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanTao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianSua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanSua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DaXoa = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NN_DCTT_SongSuoi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NN_HanhLangBaoVeNN_AoHoDamTuNhienNhanTao",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XaPhuongTT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HuyenTP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DungTichHo106m3 = table.Column<double>(type: "float", nullable: true),
                    PhamViHanhLang = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThuocDienCamMocHanhLang = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianTao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanTao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianSua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanSua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DaXoa = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NN_HanhLangBaoVeNN_AoHoDamTuNhienNhanTao", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NN_HanhLangBaoVeNN_HoThuyLoiItHon1m3",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XaPhuongTT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HuyenTP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DungTichHo106m3 = table.Column<double>(type: "float", nullable: true),
                    PhamViHanhLang = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThuocDienCamMocHanhLang = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianTao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanTao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianSua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanSua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DaXoa = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NN_HanhLangBaoVeNN_HoThuyLoiItHon1m3", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NN_HanhLangBaoVeNN_HoThuyLoiNhieuHon1m3",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XaPhuongTT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HuyenTP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DungTichHo106m3 = table.Column<double>(type: "float", nullable: true),
                    PhamViHanhLang = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThuocDienCamMocHanhLang = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianTao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanTao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianSua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanSua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DaXoa = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NN_HanhLangBaoVeNN_HoThuyLoiNhieuHon1m3", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NN_HanhLangBaoVeNN_SongSuoi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DoanSong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChieuDai = table.Column<double>(type: "float", nullable: true),
                    DiaPhanHanhChinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Huyen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XDiemDau = table.Column<double>(type: "float", nullable: true),
                    YDiemDau = table.Column<double>(type: "float", nullable: true),
                    XDiemCuoi = table.Column<double>(type: "float", nullable: true),
                    YDiemCuoi = table.Column<double>(type: "float", nullable: true),
                    ChucNang = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhamViHanhLangBaoVe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianThucHien = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ThoiGianTao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanTao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianSua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanSua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DaXoa = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NN_HanhLangBaoVeNN_SongSuoi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NN_LuuVucSong",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaSong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CapSong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenSongSuoi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChayRa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChieuDai = table.Column<double>(type: "float", nullable: true),
                    DienTich = table.Column<double>(type: "float", nullable: true),
                    Tinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThuocLVS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LoaiSongSuoi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianTao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanTao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianSua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanSua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DaXoa = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NN_LuuVucSong", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NN_MatCatSongSuoi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SoHieuMatCat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenSongSuoi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThuocLVS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XBoTrai = table.Column<double>(type: "float", nullable: true),
                    YBoTrai = table.Column<double>(type: "float", nullable: true),
                    XBoPhai = table.Column<double>(type: "float", nullable: true),
                    YBoPhai = table.Column<double>(type: "float", nullable: true),
                    Xa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Huyen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TinhTP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoHieuDiem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KhoangCach = table.Column<double>(type: "float", nullable: true),
                    CaoDoDaySong = table.Column<double>(type: "float", nullable: true),
                    ThoiGianDo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MucNuocSong = table.Column<double>(type: "float", nullable: true),
                    DonViDoDacKhaoSat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianTao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanTao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianSua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanSua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DaXoa = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NN_MatCatSongSuoi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NN_NguongKhaiThacNDD",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenTCN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LoaiChuaNuoc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Xa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Huyen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TinhTP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DienTichPhanBo = table.Column<double>(type: "float", nullable: true),
                    KhoangChieuSauPhanBo = table.Column<double>(type: "float", nullable: true),
                    NguongGHKTLuuLuong = table.Column<double>(type: "float", nullable: true),
                    NguongGHKTMucNuoc = table.Column<double>(type: "float", nullable: true),
                    QDPheDuyetNguongGioiHanKT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianTao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanTao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianSua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanSua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DaXoa = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NN_NguongKhaiThacNDD", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NN_NguonNuoc_AoHoDamPha",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenHoChua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NguonNuoc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThuocLVS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DienTichMatNuoc = table.Column<double>(type: "float", nullable: true),
                    XaPhuongTT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HuyenTP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DungTichToanBo = table.Column<double>(type: "float", nullable: true),
                    DungTichHuuIch = table.Column<double>(type: "float", nullable: true),
                    DungTichPhongLu = table.Column<double>(type: "float", nullable: true),
                    MNDBT = table.Column<double>(type: "float", nullable: true),
                    MNC = table.Column<double>(type: "float", nullable: true),
                    NamXayDung = table.Column<int>(type: "int", nullable: true),
                    DonViQuanLyVanHanh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhamViHanhLang = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThuocDienCamMocHanhLang = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianTao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanTao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianSua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanSua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DaXoa = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NN_NguonNuoc_AoHoDamPha", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NN_NguonNuoc_SongSuoi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaSong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenSongSuoi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChayRa = table.Column<double>(type: "float", nullable: true),
                    ChieuDai = table.Column<double>(type: "float", nullable: true),
                    DiaPhanHanhChinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Huyen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XDiemDau = table.Column<double>(type: "float", nullable: true),
                    YDiemDau = table.Column<double>(type: "float", nullable: true),
                    XDiemCuoi = table.Column<double>(type: "float", nullable: true),
                    YDiemCuoi = table.Column<double>(type: "float", nullable: true),
                    ChucNang = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhamViHanhLangBaoVe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianThucHien = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ThoiGianTao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanTao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianSua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanSua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DaXoa = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NN_NguonNuoc_SongSuoi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NN_NguonNuoc_TangChuaNuoc",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenTangChuaNuoc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LoaiChuaNuoc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThuocLVS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XaPhuongTT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HuyenTP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DungTichPhanBo = table.Column<double>(type: "float", nullable: true),
                    KhoangChieuSauPhanBo = table.Column<double>(type: "float", nullable: true),
                    ThoiGianTao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanTao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianSua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanSua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DaXoa = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NN_NguonNuoc_TangChuaNuoc", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NN_VungCamHanCheKTNDD",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenVungCamHanChe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DienTichVungCamHanChe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Xa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Huyen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TinhTP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhamViChieuSau = table.Column<double>(type: "float", nullable: true),
                    CacBienPhapHanCheKT = table.Column<double>(type: "float", nullable: true),
                    QDPheDuyetVungCamKT = table.Column<double>(type: "float", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianTao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanTao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianSua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanSua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DaXoa = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NN_VungCamHanCheKTNDD", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NN_AoHoDamPhaKhongDuocSanLap");

            migrationBuilder.DropTable(
                name: "NN_CNNN_Ho");

            migrationBuilder.DropTable(
                name: "NN_CNNN_SongSuoi");

            migrationBuilder.DropTable(
                name: "NN_CNNN_TangChuaNuoc");

            migrationBuilder.DropTable(
                name: "NN_DCTT_HaDuHoChua");

            migrationBuilder.DropTable(
                name: "NN_DCTT_SongSuoi");

            migrationBuilder.DropTable(
                name: "NN_HanhLangBaoVeNN_AoHoDamTuNhienNhanTao");

            migrationBuilder.DropTable(
                name: "NN_HanhLangBaoVeNN_HoThuyLoiItHon1m3");

            migrationBuilder.DropTable(
                name: "NN_HanhLangBaoVeNN_HoThuyLoiNhieuHon1m3");

            migrationBuilder.DropTable(
                name: "NN_HanhLangBaoVeNN_SongSuoi");

            migrationBuilder.DropTable(
                name: "NN_LuuVucSong");

            migrationBuilder.DropTable(
                name: "NN_MatCatSongSuoi");

            migrationBuilder.DropTable(
                name: "NN_NguongKhaiThacNDD");

            migrationBuilder.DropTable(
                name: "NN_NguonNuoc_AoHoDamPha");

            migrationBuilder.DropTable(
                name: "NN_NguonNuoc_SongSuoi");

            migrationBuilder.DropTable(
                name: "NN_NguonNuoc_TangChuaNuoc");

            migrationBuilder.DropTable(
                name: "NN_VungCamHanCheKTNDD");

            migrationBuilder.CreateTable(
                name: "KKTNN_NuocDuoiDat_ChatLuong",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AmoniMax = table.Column<double>(type: "float", nullable: true),
                    AmoniMin = table.Column<double>(type: "float", nullable: true),
                    AsenMax = table.Column<double>(type: "float", nullable: true),
                    AsenMin = table.Column<double>(type: "float", nullable: true),
                    DaXoa = table.Column<bool>(type: "bit", nullable: true),
                    DoCungMax = table.Column<double>(type: "float", nullable: true),
                    DoCungMin = table.Column<double>(type: "float", nullable: true),
                    IdHuyen = table.Column<int>(type: "int", nullable: true),
                    IdXa = table.Column<int>(type: "int", nullable: true),
                    NitratMax = table.Column<double>(type: "float", nullable: true),
                    NitratMin = table.Column<double>(type: "float", nullable: true),
                    SulfatMax = table.Column<double>(type: "float", nullable: true),
                    SulfatMin = table.Column<double>(type: "float", nullable: true),
                    pHMax = table.Column<double>(type: "float", nullable: true),
                    pHMin = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KKTNN_NuocDuoiDat_ChatLuong", x => x.Id);
                });
        }
    }
}
