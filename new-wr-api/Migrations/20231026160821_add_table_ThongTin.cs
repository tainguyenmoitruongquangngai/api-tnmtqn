using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace new_wr_api.Migrations
{
    /// <inheritdoc />
    public partial class add_table_ThongTin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DMSS_AoHo",
                columns: table => new
                {
                    MaHo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenHoChua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Thon_Ban = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Xa_Phuong_ThiTran = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Huyen_ThanhPho = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NguonNuoc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThuocHeThongSong = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DMSS_AoHo", x => x.MaHo);
                });

            migrationBuilder.CreateTable(
                name: "DMSS_DiemCuoiSongSuoi",
                columns: table => new
                {
                    MaDiemCuoiSong_Suoi = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DiemCuoiSong_Suoi_ToaDoX = table.Column<double>(type: "float", nullable: true),
                    DiemCuoiSong_Suoi_ToaDoY = table.Column<double>(type: "float", nullable: true),
                    DiemCuoiSong_Suoi_Thon_Ban = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiemCuoiSong_Suoi_Xa_Phuong_ThiTran = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiemCuoiSong_Suoi_Huyen_ThanhPho = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DMSS_DiemCuoiSongSuoi", x => x.MaDiemCuoiSong_Suoi);
                });

            migrationBuilder.CreateTable(
                name: "DMSS_DiemDauSongSuoi",
                columns: table => new
                {
                    MaDiemDauSong_Suoi = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DiemDauSong_Suoi_ToaDoX = table.Column<double>(type: "float", nullable: true),
                    DiemDauSong_Suoi_ToaDoY = table.Column<double>(type: "float", nullable: true),
                    DiemDauSong_Suoi_Thon_Ban = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiemDauSong_Suoi_Xa_Phuong_ThiTran = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiemDauSong_Suoi_Huyen_ThanhPho = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DMSS_DiemDauSongSuoi", x => x.MaDiemDauSong_Suoi);
                });

            migrationBuilder.CreateTable(
                name: "DMSS_SongSuoiNoiTinh",
                columns: table => new
                {
                    MaSong = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaDiemDauSong_Suoi = table.Column<int>(type: "int", nullable: true),
                    MaDiemCuoiSong_Suoi = table.Column<int>(type: "int", nullable: true),
                    TenSongSuoi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChayRa = table.Column<double>(type: "float", nullable: true),
                    ChieuDai = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DMSS_SongSuoiNoiTinh", x => x.MaSong);
                });

            migrationBuilder.CreateTable(
                name: "HSKTCT_FilePDFHSKTCongTrinh",
                columns: table => new
                {
                    MaFilePDFHoSoKyThuatCongTrinh = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CacTaiLieuHsktTramDuoiDangFilePDF = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HSKTCT_FilePDFHSKTCongTrinh", x => x.MaFilePDFHoSoKyThuatCongTrinh);
                });

            migrationBuilder.CreateTable(
                name: "HSKTCT_LoaiHSKTCongTrinh",
                columns: table => new
                {
                    MaLoaiHoSoKTCongTrinh = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaCongTrinh = table.Column<int>(type: "int", nullable: true),
                    MaToChucThucHien = table.Column<int>(type: "int", nullable: true),
                    MaTaiLieu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaFilePDF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenLoaiHoSo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HSKTCT_LoaiHSKTCongTrinh", x => x.MaLoaiHoSoKTCongTrinh);
                });

            migrationBuilder.CreateTable(
                name: "HSKTCT_ThongTinTaiLieuHSKTTram",
                columns: table => new
                {
                    MaTaiLieu = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenTaiLieu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KyHieuTaiLieu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NguoiLapHoSo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NguoiKiemTraHoSo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HSKTCT_ThongTinTaiLieuHSKTTram", x => x.MaTaiLieu);
                });

            migrationBuilder.CreateTable(
                name: "HSKTCT_ToChucThucHienQuanTrac",
                columns: table => new
                {
                    MaToChucThucHien = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenToChucThucHien = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HSKTCT_ToChucThucHienQuanTrac", x => x.MaToChucThucHien);
                });

            migrationBuilder.CreateTable(
                name: "KQCGHTHGPKTSDN_CongTrinh",
                columns: table => new
                {
                    MaCongTrinh = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenCongTrinh = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KQCGHTHGPKTSDN_CongTrinh", x => x.MaCongTrinh);
                });

            migrationBuilder.CreateTable(
                name: "KQCGHTHGPKTSDN_FileGiayPhepKTSDN",
                columns: table => new
                {
                    MaFileGiayPhepKTSDN = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaThongTinGiayPhepKTSDN = table.Column<int>(type: "int", nullable: true),
                    FileScanGiayPhepKTSDN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FileScanGiayToLienQuanCuaGiayPhepKTSDN = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KQCGHTHGPKTSDN_FileGiayPhepKTSDN", x => x.MaFileGiayPhepKTSDN);
                });

            migrationBuilder.CreateTable(
                name: "KQCGHTHGPKTSDN_HoSoGiaHanDieuChinhTheoGiayPhep",
                columns: table => new
                {
                    MaHoSoGiaHan_ThuHoi_DieuChinhTheoGiayPhepKTSDN = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaThongTinGiayPhepKTSDN = table.Column<int>(type: "int", nullable: true),
                    MaCongTrinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HoSoGiaHan_ThuHoi_DieuChinh = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KQCGHTHGPKTSDN_HoSoGiaHanDieuChinhTheoGiayPhep", x => x.MaHoSoGiaHan_ThuHoi_DieuChinhTheoGiayPhepKTSDN);
                });

            migrationBuilder.CreateTable(
                name: "KQCGHTHGPKTSDN_QuanLyNgayCapPhepKTSDN",
                columns: table => new
                {
                    MaQuanLyNgayCapPhepKTSDN = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaThongTinGiayPhepKTSDN = table.Column<int>(type: "int", nullable: true),
                    NgayKyGiayPhepKTSDN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgayGiayPhepCoHieuLucKTSDN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgayGiayPhepHetHanKTSDN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CoQuanCapPhepKTSDN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenChuGiayPhepKTSDN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiaChiChuGiayPhepKTSDN = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KQCGHTHGPKTSDN_QuanLyNgayCapPhepKTSDN", x => x.MaQuanLyNgayCapPhepKTSDN);
                });

            migrationBuilder.CreateTable(
                name: "KQCGHTHGPKTSDN_ThanhTraKiemTraKetQuaThucHienTheoGiayPhep",
                columns: table => new
                {
                    MaThanhTra_KiemTraKetQuaThucHienTheoGiayPhepKTSDN = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaThongTinGiayPhepKTSDN = table.Column<int>(type: "int", nullable: true),
                    MaCongTrinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HoSoKetQuaThanhTra_KiemTr = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KQCGHTHGPKTSDN_ThanhTraKiemTraKetQuaThucHienTheoGiayPhep", x => x.MaThanhTra_KiemTraKetQuaThucHienTheoGiayPhepKTSDN);
                });

            migrationBuilder.CreateTable(
                name: "KQCGHTHGPKTSDN_ThongTinGiayPhepKTSDN",
                columns: table => new
                {
                    MaThongTinGiayPhepKTSDN = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaCongTrinh = table.Column<int>(type: "int", nullable: true),
                    SoGiayPhepKTSDN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenGiayPhepKTSDN = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KQCGHTHGPKTSDN_ThongTinGiayPhepKTSDN", x => x.MaThongTinGiayPhepKTSDN);
                });

            migrationBuilder.CreateTable(
                name: "NCKTSDN_KhaNangDapUngNguonNuoc",
                columns: table => new
                {
                    MaKhaNangDapUngNguonNuoc = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaLoaiTaiNguyenNuoc = table.Column<int>(type: "int", nullable: true),
                    LuuVuc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TongLuongNuoc = table.Column<double>(type: "float", nullable: true),
                    TongNhuCauNuoc = table.Column<double>(type: "float", nullable: true),
                    TiLeSoVoiNhuCau = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NCKTSDN_KhaNangDapUngNguonNuoc", x => x.MaKhaNangDapUngNguonNuoc);
                });

            migrationBuilder.CreateTable(
                name: "NCKTSDN_LoaiTaiNguyenNuoc",
                columns: table => new
                {
                    MaLoaiTaiNguyenNuoc = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaKhaNangDapUngNguonNuoc = table.Column<int>(type: "int", nullable: true),
                    LuuVuc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TongLuongNuoc = table.Column<double>(type: "float", nullable: true),
                    TongNhuCauNuoc = table.Column<double>(type: "float", nullable: true),
                    TiLeSoVoiNhuCau = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NCKTSDN_LoaiTaiNguyenNuoc", x => x.MaLoaiTaiNguyenNuoc);
                });

            migrationBuilder.CreateTable(
                name: "NCKTSDN_MucNuocLonNhatCoTheKhaiThac",
                columns: table => new
                {
                    MaMucNuocLonNhatCoTheKhaiThac = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SoHieuLoKhoan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ViTriKhaiThac = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChieuSauLoKhoan = table.Column<double>(type: "float", nullable: true),
                    MucNuocTinh = table.Column<double>(type: "float", nullable: true),
                    GioiHanChieuSauMucNuocKhaiThac = table.Column<double>(type: "float", nullable: true),
                    ChieuSauMucNuocLonNhatKhaiThac = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NCKTSDN_MucNuocLonNhatCoTheKhaiThac", x => x.MaMucNuocLonNhatCoTheKhaiThac);
                });

            migrationBuilder.CreateTable(
                name: "NCKTSDN_NhuCauSuDungNuoc",
                columns: table => new
                {
                    MaNhuCauSuDungNuoc = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaLoaiTaiNguyenNuoc = table.Column<int>(type: "int", nullable: true),
                    MaTongLuongNuoc = table.Column<int>(type: "int", nullable: true),
                    MaMucNuocLonNhatCoTheKhaiThac = table.Column<int>(type: "int", nullable: true),
                    MaKhaNangDapUngNguonNuoc = table.Column<int>(type: "int", nullable: true),
                    TieuVungLuuVuc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LoaiNhuCau = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThangI = table.Column<double>(type: "float", nullable: true),
                    ThangII = table.Column<double>(type: "float", nullable: true),
                    ThangIII = table.Column<double>(type: "float", nullable: true),
                    ThangIV = table.Column<double>(type: "float", nullable: true),
                    ThangV = table.Column<double>(type: "float", nullable: true),
                    ThangVI = table.Column<double>(type: "float", nullable: true),
                    ThangVII = table.Column<double>(type: "float", nullable: true),
                    ThangVIII = table.Column<double>(type: "float", nullable: true),
                    ThangIX = table.Column<double>(type: "float", nullable: true),
                    ThangX = table.Column<double>(type: "float", nullable: true),
                    ThangXI = table.Column<double>(type: "float", nullable: true),
                    ThangXII = table.Column<double>(type: "float", nullable: true),
                    TBNam = table.Column<double>(type: "float", nullable: true),
                    W = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NCKTSDN_NhuCauSuDungNuoc", x => x.MaNhuCauSuDungNuoc);
                });

            migrationBuilder.CreateTable(
                name: "NCKTSDN_TongLuongNuoc",
                columns: table => new
                {
                    MaTongLuongNuoc = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaLoaiTaiNguyenNuoc = table.Column<int>(type: "int", nullable: true),
                    TieuVungLuuVuc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TongLuongMua = table.Column<double>(type: "float", nullable: true),
                    LuuLuongDongChayMat = table.Column<double>(type: "float", nullable: true),
                    TruLuongTiemNangNuocNgam = table.Column<double>(type: "float", nullable: true),
                    ModulDongChayNgam = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NCKTSDN_TongLuongNuoc", x => x.MaTongLuongNuoc);
                });

            migrationBuilder.CreateTable(
                name: "SLCLNMNDD_LoaiNuoc",
                columns: table => new
                {
                    MaLoaiNuoc = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLoaiNuoc = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SLCLNMNDD_LoaiNuoc", x => x.MaLoaiNuoc);
                });

            migrationBuilder.CreateTable(
                name: "SLCLNMNDD_LuuVuc",
                columns: table => new
                {
                    MaLuuVuc = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLuuVuc = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SLCLNMNDD_LuuVuc", x => x.MaLuuVuc);
                });

            migrationBuilder.CreateTable(
                name: "SLCLNMNDD_SoLuongNuoc",
                columns: table => new
                {
                    MaSoLuongNuoc = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaLuuVuc = table.Column<int>(type: "int", nullable: true),
                    MaLoaiNuoc = table.Column<int>(type: "int", nullable: true),
                    MaViTriDieuTra = table.Column<int>(type: "int", nullable: true),
                    MaTiemNangNuocDuoiDat = table.Column<int>(type: "int", nullable: true),
                    SoLuongGieng = table.Column<int>(type: "int", nullable: true),
                    MucNuocTrungBinh = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SLCLNMNDD_SoLuongNuoc", x => x.MaSoLuongNuoc);
                });

            migrationBuilder.CreateTable(
                name: "SLCLNMNDD_Song",
                columns: table => new
                {
                    MaSong = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenSong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaLuuVuc = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SLCLNMNDD_Song", x => x.MaSong);
                });

            migrationBuilder.CreateTable(
                name: "SLCLNMNDD_ThongSoSong",
                columns: table => new
                {
                    MaThongSoCuaSong = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaSong = table.Column<int>(type: "int", nullable: true),
                    DoDai = table.Column<double>(type: "float", nullable: true),
                    DoRongLongSong = table.Column<double>(type: "float", nullable: true),
                    DoSauMucNuoc = table.Column<double>(type: "float", nullable: true),
                    TocDoDongChay = table.Column<double>(type: "float", nullable: true),
                    DacDiemDoanSong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CacCongTrinhKTSDNuocMatTrenSong = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SLCLNMNDD_ThongSoSong", x => x.MaThongSoCuaSong);
                });

            migrationBuilder.CreateTable(
                name: "SLCLNMNDD_TiemNangNuocDuoiDat",
                columns: table => new
                {
                    MaTiemNangNuocDuoiDat = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GiaTriModulDongNgam_Min = table.Column<double>(type: "float", nullable: true),
                    GiaTriModulDongNgam_Max = table.Column<double>(type: "float", nullable: true),
                    GiaTriModulDongNgam_TB = table.Column<double>(type: "float", nullable: true),
                    TruLuongDongTuNhienQd = table.Column<double>(type: "float", nullable: true),
                    TenTangChuaNuoc = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SLCLNMNDD_TiemNangNuocDuoiDat", x => x.MaTiemNangNuocDuoiDat);
                });

            migrationBuilder.CreateTable(
                name: "SLCLNMNDD_ViTriDieuTra",
                columns: table => new
                {
                    MaViTriDieuTra = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ViTriVungDieuTra_ToaDoX = table.Column<int>(type: "int", nullable: true),
                    ViTriVungDieuTra_ToaDoY = table.Column<int>(type: "int", nullable: true),
                    ViTriCongTrinhXaThaiVaoNguonNuoc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToaDoViTriXaThai_ToaDoX = table.Column<int>(type: "int", nullable: true),
                    ToaDoViTriXaThai_ToaDoY = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SLCLNMNDD_ViTriDieuTra", x => x.MaViTriDieuTra);
                });

            migrationBuilder.CreateTable(
                name: "SLCLNMNDD_WMuaCan",
                columns: table => new
                {
                    MaSoTongLuongNuocMuaCan = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaLoaiNuoc = table.Column<int>(type: "int", nullable: true),
                    MaLuuVuc = table.Column<int>(type: "int", nullable: true),
                    TongLuongNuocTrungBinhMuaCan = table.Column<double>(type: "float", nullable: true),
                    TongLuongNuocMuaCanKyTruoc = table.Column<double>(type: "float", nullable: true),
                    TongLuongNuocMuaCanKyBaoCao = table.Column<double>(type: "float", nullable: true),
                    TongLuongNuocMuaCanThayDoi = table.Column<double>(type: "float", nullable: true),
                    KhoangThoiGianDuLieuThuThap = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SLCLNMNDD_WMuaCan", x => x.MaSoTongLuongNuocMuaCan);
                });

            migrationBuilder.CreateTable(
                name: "SLCLNMNDD_WMuaLu",
                columns: table => new
                {
                    MaSoTongLuongNuocMuaLu = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaLoaiNuoc = table.Column<int>(type: "int", nullable: true),
                    MaLuuVuc = table.Column<int>(type: "int", nullable: true),
                    TongLuongNuocTrungBinhMuaLu = table.Column<double>(type: "float", nullable: true),
                    TongLuongNuocMuaLuKyTruoc = table.Column<double>(type: "float", nullable: true),
                    TongLuongNuocMuaLuKyBaoCao = table.Column<double>(type: "float", nullable: true),
                    TongLuongNuocMuaLuThayDoi = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SLCLNMNDD_WMuaLu", x => x.MaSoTongLuongNuocMuaLu);
                });

            migrationBuilder.CreateTable(
                name: "SLCLNMNDD_WNam",
                columns: table => new
                {
                    MaTongLuongNuocNam = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaLoaiNuoc = table.Column<int>(type: "int", nullable: true),
                    MaLuuVuc = table.Column<int>(type: "int", nullable: true),
                    TongLuongNuocNam = table.Column<double>(type: "float", nullable: true),
                    TongLuongNuocNamKyTruoc = table.Column<double>(type: "float", nullable: true),
                    TongLuongNuocNamKyBaoCao = table.Column<double>(type: "float", nullable: true),
                    TongLuongNuocNamThayDoi = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SLCLNMNDD_WNam", x => x.MaTongLuongNuocNam);
                });

            migrationBuilder.CreateTable(
                name: "SLDTKSDCTV_PhanLoaiDieuTra",
                columns: table => new
                {
                    MaPhanLoaiDieuTra = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tenloaidieutra = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SLDTKSDCTV_PhanLoaiDieuTra", x => x.MaPhanLoaiDieuTra);
                });

            migrationBuilder.CreateTable(
                name: "SLDTKSDCTV_PhuongPhapDieuTraDiaChatThuyVan",
                columns: table => new
                {
                    MaPhuongPhapDieuTraDiaChatThuyVan = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhuongPhapVienTham = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhuongPhapDiaVatLy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhuongPhapDiaChat = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SLDTKSDCTV_PhuongPhapDieuTraDiaChatThuyVan", x => x.MaPhuongPhapDieuTraDiaChatThuyVan);
                });

            migrationBuilder.CreateTable(
                name: "SLDTKSDCTV_SoLieuDieuTraNDD",
                columns: table => new
                {
                    MaSoLieuDieuTra = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SoHieuLoKhoan = table.Column<int>(type: "int", nullable: true),
                    ChieuSau = table.Column<double>(type: "float", nullable: true),
                    ChieuDayTangChuaNuoc = table.Column<double>(type: "float", nullable: true),
                    MucNuocTinh = table.Column<double>(type: "float", nullable: true),
                    MucNuocHaThap = table.Column<double>(type: "float", nullable: true),
                    LuuLuongThucHut_LS = table.Column<double>(type: "float", nullable: true),
                    LuuLuongThucHut_m3Ngay = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TruLuongKhaiThac = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SLDTKSDCTV_SoLieuDieuTraNDD", x => x.MaSoLieuDieuTra);
                });

            migrationBuilder.CreateTable(
                name: "SLDTKSDCTV_ThongTinVungDieuTra",
                columns: table => new
                {
                    MaThongTinVungDieuTra = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaPhanLoaiDieuTra = table.Column<int>(type: "int", nullable: true),
                    MaTieuVungQuyHoach = table.Column<int>(type: "int", nullable: true),
                    MaPhuongPhapDieuTraDiaChatThuyVan = table.Column<int>(type: "int", nullable: true),
                    MaSoLieuDieuTra = table.Column<int>(type: "int", nullable: true),
                    MaHuyen = table.Column<int>(type: "int", nullable: true),
                    MaXa = table.Column<int>(type: "int", nullable: true),
                    DiaDiemDieuTra = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SLDTKSDCTV_ThongTinVungDieuTra", x => x.MaThongTinVungDieuTra);
                });

            migrationBuilder.CreateTable(
                name: "SLDTKSDCTV_TieuVungQuyHoach",
                columns: table => new
                {
                    MaTieuVungQuyHoach = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TieuVungQuyHoach = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SLDTKSDCTV_TieuVungQuyHoach", x => x.MaTieuVungQuyHoach);
                });

            migrationBuilder.CreateTable(
                name: "TT_Huyen",
                columns: table => new
                {
                    MaHuyen = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenHuyen = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TT_Huyen", x => x.MaHuyen);
                });

            migrationBuilder.CreateTable(
                name: "TT_ThongTinTieuVung",
                columns: table => new
                {
                    MaThongTin = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaTieuVung = table.Column<int>(type: "int", nullable: false),
                    MaHuyen = table.Column<int>(type: "int", nullable: true),
                    MaXa = table.Column<int>(type: "int", nullable: true),
                    DienTichTieuVung = table.Column<double>(type: "float", nullable: true),
                    LuuLuongNuocTrungBinh = table.Column<double>(type: "float", nullable: true),
                    DanSo = table.Column<double>(type: "float", nullable: true),
                    LoaiTaiNguyenNuoc = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TT_ThongTinTieuVung", x => x.MaThongTin);
                });

            migrationBuilder.CreateTable(
                name: "TT_TieuVungTNN",
                columns: table => new
                {
                    MaTieuVung = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaHuyen = table.Column<int>(type: "int", nullable: true),
                    MaXa = table.Column<int>(type: "int", nullable: true),
                    TenTieuVung = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TT_TieuVungTNN", x => x.MaTieuVung);
                });

            migrationBuilder.CreateTable(
                name: "TT_Xa",
                columns: table => new
                {
                    MaXa = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaHuyen = table.Column<int>(type: "int", nullable: true),
                    TenXa = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TT_Xa", x => x.MaXa);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DMSS_AoHo");

            migrationBuilder.DropTable(
                name: "DMSS_DiemCuoiSongSuoi");

            migrationBuilder.DropTable(
                name: "DMSS_DiemDauSongSuoi");

            migrationBuilder.DropTable(
                name: "DMSS_SongSuoiNoiTinh");

            migrationBuilder.DropTable(
                name: "HSKTCT_FilePDFHSKTCongTrinh");

            migrationBuilder.DropTable(
                name: "HSKTCT_LoaiHSKTCongTrinh");

            migrationBuilder.DropTable(
                name: "HSKTCT_ThongTinTaiLieuHSKTTram");

            migrationBuilder.DropTable(
                name: "HSKTCT_ToChucThucHienQuanTrac");

            migrationBuilder.DropTable(
                name: "KQCGHTHGPKTSDN_CongTrinh");

            migrationBuilder.DropTable(
                name: "KQCGHTHGPKTSDN_FileGiayPhepKTSDN");

            migrationBuilder.DropTable(
                name: "KQCGHTHGPKTSDN_HoSoGiaHanDieuChinhTheoGiayPhep");

            migrationBuilder.DropTable(
                name: "KQCGHTHGPKTSDN_QuanLyNgayCapPhepKTSDN");

            migrationBuilder.DropTable(
                name: "KQCGHTHGPKTSDN_ThanhTraKiemTraKetQuaThucHienTheoGiayPhep");

            migrationBuilder.DropTable(
                name: "KQCGHTHGPKTSDN_ThongTinGiayPhepKTSDN");

            migrationBuilder.DropTable(
                name: "NCKTSDN_KhaNangDapUngNguonNuoc");

            migrationBuilder.DropTable(
                name: "NCKTSDN_LoaiTaiNguyenNuoc");

            migrationBuilder.DropTable(
                name: "NCKTSDN_MucNuocLonNhatCoTheKhaiThac");

            migrationBuilder.DropTable(
                name: "NCKTSDN_NhuCauSuDungNuoc");

            migrationBuilder.DropTable(
                name: "NCKTSDN_TongLuongNuoc");

            migrationBuilder.DropTable(
                name: "SLCLNMNDD_LoaiNuoc");

            migrationBuilder.DropTable(
                name: "SLCLNMNDD_LuuVuc");

            migrationBuilder.DropTable(
                name: "SLCLNMNDD_SoLuongNuoc");

            migrationBuilder.DropTable(
                name: "SLCLNMNDD_Song");

            migrationBuilder.DropTable(
                name: "SLCLNMNDD_ThongSoSong");

            migrationBuilder.DropTable(
                name: "SLCLNMNDD_TiemNangNuocDuoiDat");

            migrationBuilder.DropTable(
                name: "SLCLNMNDD_ViTriDieuTra");

            migrationBuilder.DropTable(
                name: "SLCLNMNDD_WMuaCan");

            migrationBuilder.DropTable(
                name: "SLCLNMNDD_WMuaLu");

            migrationBuilder.DropTable(
                name: "SLCLNMNDD_WNam");

            migrationBuilder.DropTable(
                name: "SLDTKSDCTV_PhanLoaiDieuTra");

            migrationBuilder.DropTable(
                name: "SLDTKSDCTV_PhuongPhapDieuTraDiaChatThuyVan");

            migrationBuilder.DropTable(
                name: "SLDTKSDCTV_SoLieuDieuTraNDD");

            migrationBuilder.DropTable(
                name: "SLDTKSDCTV_ThongTinVungDieuTra");

            migrationBuilder.DropTable(
                name: "SLDTKSDCTV_TieuVungQuyHoach");

            migrationBuilder.DropTable(
                name: "TT_Huyen");

            migrationBuilder.DropTable(
                name: "TT_ThongTinTieuVung");

            migrationBuilder.DropTable(
                name: "TT_TieuVungTNN");

            migrationBuilder.DropTable(
                name: "TT_Xa");
        }
    }
}
