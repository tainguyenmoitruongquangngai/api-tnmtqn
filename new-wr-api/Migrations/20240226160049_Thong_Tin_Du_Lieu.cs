using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace new_wr_api.Migrations
{
    /// <inheritdoc />
    public partial class Thong_Tin_Du_Lieu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CLN_NDD",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LuuVucSong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SongSuoiHoChua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ViTriQuanTrac = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhMax = table.Column<double>(type: "float", nullable: true),
                    PhMin = table.Column<double>(type: "float", nullable: true),
                    ColiformMax = table.Column<double>(type: "float", nullable: true),
                    ColiformMin = table.Column<double>(type: "float", nullable: true),
                    NitrateMax = table.Column<double>(type: "float", nullable: true),
                    NitrateMin = table.Column<double>(type: "float", nullable: true),
                    AmoniMax = table.Column<double>(type: "float", nullable: true),
                    AmoniMin = table.Column<double>(type: "float", nullable: true),
                    TDSMax = table.Column<double>(type: "float", nullable: true),
                    TDSMin = table.Column<double>(type: "float", nullable: true),
                    DoCungMax = table.Column<double>(type: "float", nullable: true),
                    DoCungMin = table.Column<double>(type: "float", nullable: true),
                    ASMax = table.Column<double>(type: "float", nullable: true),
                    ASMin = table.Column<double>(type: "float", nullable: true),
                    ChlorideMax = table.Column<double>(type: "float", nullable: true),
                    ChlorideMin = table.Column<double>(type: "float", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianTao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanTao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianSua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanSua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DaXoa = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CLN_NDD", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CLN_NuocMat",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LuuVucSong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SongSuoiHoChua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ViTriQuanTrac = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhMax = table.Column<double>(type: "float", nullable: true),
                    PhMin = table.Column<double>(type: "float", nullable: true),
                    BOD5Max = table.Column<double>(type: "float", nullable: true),
                    BOD5Min = table.Column<double>(type: "float", nullable: true),
                    CODMax = table.Column<double>(type: "float", nullable: true),
                    CODMin = table.Column<double>(type: "float", nullable: true),
                    TSSMax = table.Column<double>(type: "float", nullable: true),
                    TSSMin = table.Column<double>(type: "float", nullable: true),
                    DOMax = table.Column<double>(type: "float", nullable: true),
                    DOMin = table.Column<double>(type: "float", nullable: true),
                    PhosphorTPMax = table.Column<double>(type: "float", nullable: true),
                    PhosphorTPMin = table.Column<double>(type: "float", nullable: true),
                    NitoTNMax = table.Column<double>(type: "float", nullable: true),
                    NitoTNMin = table.Column<double>(type: "float", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianTao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanTao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianSua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanSua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DaXoa = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CLN_NuocMat", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CTKTSDN_KTNDDCuaHoGD",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenCongTrinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenTCCN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Xa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Huyen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    X = table.Column<double>(type: "float", nullable: true),
                    Y = table.Column<double>(type: "float", nullable: true),
                    SoThuaDat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChieuSauGieng = table.Column<double>(type: "float", nullable: true),
                    SoNguoiSD = table.Column<double>(type: "float", nullable: true),
                    TinhTrangChatLuongNuoc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TinhTrangKeKhai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianTao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanTao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianSua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanSua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DaXoa = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CTKTSDN_KTNDDCuaHoGD", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CTKTSDN_PCGP_NDD",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenCongTrinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenTCCN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NamVanHanh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Xa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Huyen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    X = table.Column<double>(type: "float", nullable: true),
                    Y = table.Column<double>(type: "float", nullable: true),
                    LuuVuc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TangChuaNuoc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoGieng = table.Column<int>(type: "int", nullable: true),
                    ChieuSauCacGieng = table.Column<double>(type: "float", nullable: true),
                    ToaDoCacGieng = table.Column<double>(type: "float", nullable: true),
                    MucDichKT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoToMay = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TongLuuLuongKT = table.Column<double>(type: "float", nullable: true),
                    CheDoKT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhuongThucKT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianVanHanh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TinhHinhCapGP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoGP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgayQuyetDinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianHieuLuc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianKetThuc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IDCongTrinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianBatDauKetNoi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianTao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanTao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianSua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanSua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DaXoa = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CTKTSDN_PCGP_NDD", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CTKTSDN_PCGP_NuocBien",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenCongTrinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenTCCN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NamVanHanh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Xa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Huyen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    X = table.Column<double>(type: "float", nullable: true),
                    Y = table.Column<double>(type: "float", nullable: true),
                    TenVungbien = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CheDoLayNuoc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiemLayNuoc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CongSuatTho = table.Column<double>(type: "float", nullable: true),
                    CongSuatTinh = table.Column<double>(type: "float", nullable: true),
                    SoToMay = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LuuLuongKTMax = table.Column<double>(type: "float", nullable: true),
                    SoMayBom = table.Column<int>(type: "int", nullable: true),
                    DiemXaNuocLamMat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LuuLuongXaMax = table.Column<double>(type: "float", nullable: true),
                    CongSuatThietKe = table.Column<double>(type: "float", nullable: true),
                    PhuongThucKT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MucDichKT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CheDoKT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoGP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgayQuyetDinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianHieuLuc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IDCongTrinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianBatDauKetNoi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianTao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanTao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianSua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanSua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DaXoa = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CTKTSDN_PCGP_NuocBien", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CTKTSDN_PCGP_NuocMat",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenCongTrinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenTCN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NamVanHanh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Xa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Huyen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    X = table.Column<double>(type: "float", nullable: true),
                    Y = table.Column<double>(type: "float", nullable: true),
                    TenSong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LuuVucSong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CaoTrinhDap = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CaoTrinhNguongTran = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LuuLuongXaLuTK = table.Column<double>(type: "float", nullable: true),
                    LuuLuongXaLuKT = table.Column<double>(type: "float", nullable: true),
                    DungTichChet = table.Column<double>(type: "float", nullable: true),
                    SoToMay = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoGP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgayQuyetDinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianHieuLuc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IDCongTrinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianBatDauKetNoi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CheDoKT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianTao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanTao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianSua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanSua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DaXoa = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CTKTSDN_PCGP_NuocMat", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CTKTSDN_PDK_NDD",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenCongTrinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenTCCN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NamVanHanh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Xa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Huyen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    X = table.Column<double>(type: "float", nullable: true),
                    Y = table.Column<double>(type: "float", nullable: true),
                    LuuVuc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TangChuaNuoc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoGieng = table.Column<int>(type: "int", nullable: true),
                    ChieuSauCacGieng = table.Column<double>(type: "float", nullable: true),
                    ToaDoCacGieng = table.Column<double>(type: "float", nullable: true),
                    MucDichKT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoToMay = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TongLuuLuongKT = table.Column<double>(type: "float", nullable: true),
                    CheDoKT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhuongThucKT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianVanHanh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TinhHinhCapGP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoGP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgayQuyetDinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianHieuLuc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianKetThuc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IDCongTrinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianBatDauKetNoi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianTao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanTao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianSua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanSua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DaXoa = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CTKTSDN_PDK_NDD", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CTKTSDN_PDK_NuocBien",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenCongTrinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenTCCN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NamVanHanh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Xa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Huyen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    X = table.Column<double>(type: "float", nullable: true),
                    Y = table.Column<double>(type: "float", nullable: true),
                    TenVungbien = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CheDoLayNuoc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiemLayNuoc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CongSuatTho = table.Column<double>(type: "float", nullable: true),
                    CongSuatTinh = table.Column<double>(type: "float", nullable: true),
                    SoToMay = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LuuLuongKTMax = table.Column<double>(type: "float", nullable: true),
                    SoMayBom = table.Column<int>(type: "int", nullable: true),
                    DiemXaNuocLamMat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LuuLuongXaMax = table.Column<double>(type: "float", nullable: true),
                    CongSuatThietKe = table.Column<double>(type: "float", nullable: true),
                    PhuongThucKT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MucDichKT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CheDoKT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoGP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgayQuyetDinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianHieuLuc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IDCongTrinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianBatDauKetNoi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianTao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanTao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianSua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanSua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DaXoa = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CTKTSDN_PDK_NuocBien", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CTKTSDN_PDK_NuocMat",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenCongTrinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenTCN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NamVanHanh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Xa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Huyen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    X = table.Column<double>(type: "float", nullable: true),
                    Y = table.Column<double>(type: "float", nullable: true),
                    TenSong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LuuVucSong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CaoTrinhDap = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CaoTrinhNguongTran = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LuuLuongXaLuTK = table.Column<double>(type: "float", nullable: true),
                    LuuLuongXaLuKT = table.Column<double>(type: "float", nullable: true),
                    DungTichChet = table.Column<double>(type: "float", nullable: true),
                    SoToMay = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoGP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgayQuyetDinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianHieuLuc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IDCongTrinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianBatDauKetNoi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CheDoKT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianTao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanTao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianSua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanSua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DaXoa = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CTKTSDN_PDK_NuocMat", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DanhMucNN_LienTinh",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaSong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenSongSuoi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChayRa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XDiemDau = table.Column<double>(type: "float", nullable: true),
                    YDiemDau = table.Column<double>(type: "float", nullable: true),
                    ThonDiemDau = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XaPhuongTTDiemDau = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HuyenTPDiemDau = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XDiemCuoi = table.Column<double>(type: "float", nullable: true),
                    YDiemCuoi = table.Column<double>(type: "float", nullable: true),
                    ThonDiemCuoi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XaPhuongTTDiemCuoi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HuyenTPDiemCuoi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianTao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanTao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianSua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanSua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DaXoa = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhMucNN_LienTinh", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DanhMucNN_NoiTinh_AoHo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaHo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenHoChua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XaPhuongTT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HuyenTP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NguonNuoc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThuocHeThongSong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianTao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanTao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianSua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanSua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DaXoa = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhMucNN_NoiTinh_AoHo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DanhMucNN_NoiTinh_SongSuoi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaSong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenSongSuoi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChayRa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XDiemDau = table.Column<double>(type: "float", nullable: true),
                    YDiemDau = table.Column<double>(type: "float", nullable: true),
                    ThonDiemDau = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XaPhuongTTDiemDau = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HuyenTPDiemDau = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XDiemCuoi = table.Column<double>(type: "float", nullable: true),
                    YDiemCuoi = table.Column<double>(type: "float", nullable: true),
                    ThonDiemCuoi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XaPhuongTTDiemCuoi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HuyenTPDiemCuoi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianTao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanTao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianSua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanSua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DaXoa = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhMucNN_NoiTinh_SongSuoi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HSKTT_NDD",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KyHieuCT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenTaiLieuHoSo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenToChucThucHienQuanTrac = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NguoiThanhLapHoSo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NguoiKiemTraHoSo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FilePDF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianTao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanTao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianSua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanSua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DaXoa = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HSKTT_NDD", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HSKTT_NuocMat",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KyHieuCT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenTaiLieuHoSo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenToChucThucHienQuanTrac = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NguoiThanhLapHoSo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NguoiKiemTraHoSo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FilePDF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianTao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanTao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianSua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanSua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DaXoa = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HSKTT_NuocMat", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SLDTKTSDN_NDD",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenChuHoCT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Xa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Huyen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoLuongGieng = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UocTinhLuongNuocKT = table.Column<double>(type: "float", nullable: true),
                    LoaiCT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HinhThucKT = table.Column<double>(type: "float", nullable: true),
                    ChieuSauKT = table.Column<double>(type: "float", nullable: true),
                    MucDichSD = table.Column<double>(type: "float", nullable: true),
                    TinhTrangSD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhieuDieuTraPDF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianTao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanTao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianSua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanSua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DaXoa = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SLDTKTSDN_NDD", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SLDTKTSDN_NuocMat",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenChuHoCT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LoaiCongTrinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Xa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Huyen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenNguonNuocKhaiThac = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MucDichSD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UocTinhLuongNuocKT = table.Column<double>(type: "float", nullable: true),
                    DienTichTuoi = table.Column<double>(type: "float", nullable: true),
                    DienTichNuoiTrongThuySan = table.Column<double>(type: "float", nullable: true),
                    CongSuatPhatDien = table.Column<double>(type: "float", nullable: true),
                    SoHoDanDuocCapNuoc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CheDoKT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FilePDF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianTao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanTao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianSua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanSua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DaXoa = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SLDTKTSDN_NuocMat", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SLDTKTSDN_XaThai",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenChuHoCT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LoaiHinhNuocThai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Xa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Huyen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuyMo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MucDichSD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DienTichTuoi = table.Column<double>(type: "float", nullable: true),
                    DienTichNuoiTrongThuySan = table.Column<double>(type: "float", nullable: true),
                    CongSuatPhatDien = table.Column<double>(type: "float", nullable: true),
                    SoHoDanDuocCapNuoc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CheDoKT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhieuDieuTraPDF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianTao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanTao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianSua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanSua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DaXoa = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SLDTKTSDN_XaThai", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SLN_TongLuongNuocMat",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LuuVucSong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TBNhieuNamDCNam = table.Column<double>(type: "float", nullable: true),
                    KyTruocDCNam = table.Column<double>(type: "float", nullable: true),
                    KyBaoCaoDCNam = table.Column<double>(type: "float", nullable: true),
                    ThayDoiDCNam = table.Column<double>(type: "float", nullable: true),
                    TBNhieuNamDCLu = table.Column<double>(type: "float", nullable: true),
                    KyTruocDCLu = table.Column<double>(type: "float", nullable: true),
                    KyBaoCaoDCLu = table.Column<double>(type: "float", nullable: true),
                    ThayDoiDCLu = table.Column<double>(type: "float", nullable: true),
                    TBNhieuNamDCMuaCan = table.Column<double>(type: "float", nullable: true),
                    KyTruocDCMuaCan = table.Column<double>(type: "float", nullable: true),
                    KyBaoCaoDCMuaCan = table.Column<double>(type: "float", nullable: true),
                    ThayDoiDCMuaCan = table.Column<double>(type: "float", nullable: true),
                    ThoiGianTao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanTao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianSua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanSua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DaXoa = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SLN_TongLuongNuocMat", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CLN_NDD");

            migrationBuilder.DropTable(
                name: "CLN_NuocMat");

            migrationBuilder.DropTable(
                name: "CTKTSDN_KTNDDCuaHoGD");

            migrationBuilder.DropTable(
                name: "CTKTSDN_PCGP_NDD");

            migrationBuilder.DropTable(
                name: "CTKTSDN_PCGP_NuocBien");

            migrationBuilder.DropTable(
                name: "CTKTSDN_PCGP_NuocMat");

            migrationBuilder.DropTable(
                name: "CTKTSDN_PDK_NDD");

            migrationBuilder.DropTable(
                name: "CTKTSDN_PDK_NuocBien");

            migrationBuilder.DropTable(
                name: "CTKTSDN_PDK_NuocMat");

            migrationBuilder.DropTable(
                name: "DanhMucNN_LienTinh");

            migrationBuilder.DropTable(
                name: "DanhMucNN_NoiTinh_AoHo");

            migrationBuilder.DropTable(
                name: "DanhMucNN_NoiTinh_SongSuoi");

            migrationBuilder.DropTable(
                name: "HSKTT_NDD");

            migrationBuilder.DropTable(
                name: "HSKTT_NuocMat");

            migrationBuilder.DropTable(
                name: "SLDTKTSDN_NDD");

            migrationBuilder.DropTable(
                name: "SLDTKTSDN_NuocMat");

            migrationBuilder.DropTable(
                name: "SLDTKTSDN_XaThai");

            migrationBuilder.DropTable(
                name: "SLN_TongLuongNuocMat");
        }
    }
}
