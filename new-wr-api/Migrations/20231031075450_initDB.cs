using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace new_wr_api.Migrations
{
    /// <inheritdoc />
    public partial class initDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PasswordSalt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BieuMauSoBa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenTram = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiKyQuanTrac = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LuongMuaThang1 = table.Column<double>(type: "float", nullable: true),
                    LuongMuaThang2 = table.Column<double>(type: "float", nullable: true),
                    LuongMuaThang3 = table.Column<double>(type: "float", nullable: true),
                    LuongMuaThang4 = table.Column<double>(type: "float", nullable: true),
                    LuongMuaThang5 = table.Column<double>(type: "float", nullable: true),
                    LuongMuaThang6 = table.Column<double>(type: "float", nullable: true),
                    LuongMuaThang7 = table.Column<double>(type: "float", nullable: true),
                    LuongMuaThang8 = table.Column<double>(type: "float", nullable: true),
                    LuongMuaThang9 = table.Column<double>(type: "float", nullable: true),
                    LuongMuaThang10 = table.Column<double>(type: "float", nullable: true),
                    LuongMuaThang11 = table.Column<double>(type: "float", nullable: true),
                    LuongMuaThang12 = table.Column<double>(type: "float", nullable: true),
                    LuongMuaNam = table.Column<double>(type: "float", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BieuMauSoBa", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BieuMauSoBay",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KhuVuc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VungDieuTra = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DienTichDuocDieuTra = table.Column<double>(type: "float", nullable: true),
                    TangChuaNuocDieuTra = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TyLeDieuTra = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BieuMauSoBay", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BieuMauSoBon",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LuuVucSong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DongChayTBNam = table.Column<double>(type: "float", nullable: true),
                    DongChayKyTruoc = table.Column<double>(type: "float", nullable: true),
                    DongChayKyBaoCao = table.Column<double>(type: "float", nullable: true),
                    DongChayMuaLuTB = table.Column<double>(type: "float", nullable: true),
                    DongChayMuaLuKyTruoc = table.Column<double>(type: "float", nullable: true),
                    DongChayMuaLuKyBaoCao = table.Column<double>(type: "float", nullable: true),
                    DongChayMuaCanTB = table.Column<double>(type: "float", nullable: true),
                    DongChayMuaCanKyTruoc = table.Column<double>(type: "float", nullable: true),
                    DongChayMuaCanKyBaoCao = table.Column<double>(type: "float", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BieuMauSoBon", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BieuMauSoChin",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LuuVucSong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TongCongTrinhKyTruoc = table.Column<double>(type: "float", nullable: true),
                    TongCongTrinhKyBaoCao = table.Column<double>(type: "float", nullable: true),
                    CongTrinhNuocMatKyTruoc = table.Column<double>(type: "float", nullable: true),
                    CongTrinhNuocMatKyBaoCao = table.Column<double>(type: "float", nullable: true),
                    CongTrinhNDDKyTruoc = table.Column<double>(type: "float", nullable: true),
                    CongTrinhNDDKyBaoCao = table.Column<double>(type: "float", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BieuMauSoChin", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BieuMauSoHai",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenTram = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiKyQuanTrac = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MuaNamKyTruoc = table.Column<double>(type: "float", nullable: true),
                    MuaNamBaoCao = table.Column<double>(type: "float", nullable: true),
                    MuaNamThayDoi = table.Column<double>(type: "float", nullable: true),
                    MuaMuaKyTruoc = table.Column<double>(type: "float", nullable: true),
                    MuaMuaBaoCao = table.Column<double>(type: "float", nullable: true),
                    MuaMuaThayDoi = table.Column<double>(type: "float", nullable: true),
                    MuaKhoKyTruoc = table.Column<double>(type: "float", nullable: true),
                    MuaKhoBaoCao = table.Column<double>(type: "float", nullable: true),
                    MuaKhoThayDoi = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BieuMauSoHai", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BieuMauSoHaiBa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ThoiGian = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LuuLuongKhaiThacLonNhat = table.Column<double>(type: "float", nullable: true),
                    LuuLuongKhaiThacNhoNhat = table.Column<double>(type: "float", nullable: true),
                    LuuLuongKTDuocCapPhep = table.Column<double>(type: "float", nullable: true),
                    SoNgayKhaiThac = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MucNuocKhaiThacLonNhat = table.Column<double>(type: "float", nullable: true),
                    MucNuocKhaiThacNhoNhat = table.Column<double>(type: "float", nullable: true),
                    ChieuSauMucNuocDongMax = table.Column<double>(type: "float", nullable: true),
                    TongLuongKhaiThac = table.Column<double>(type: "float", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BieuMauSoHaiBa", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BieuMauSoHaiHai",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ThoiGian = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LuuLuongKhaiThacLonNhat = table.Column<double>(type: "float", nullable: true),
                    LuuLuongKhaiThacNhoNhat = table.Column<double>(type: "float", nullable: true),
                    LuuLuongKTDuocCapPhep = table.Column<double>(type: "float", nullable: true),
                    SoNgayKhaiThac = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TongLuongKhaiThac = table.Column<double>(type: "float", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BieuMauSoHaiHai", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BieuMauSoHaiLam",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ThongSoQuanTrac = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NongDoLonNhat = table.Column<double>(type: "float", nullable: true),
                    NongDoNhoNhat = table.Column<double>(type: "float", nullable: true),
                    NongDoQuyDinh = table.Column<double>(type: "float", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BieuMauSoHaiLam", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BieuMauSoHaiMot",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ThoiGian = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LuuLuongDenHoLonNhat = table.Column<double>(type: "float", nullable: true),
                    LuuLuongDenHoNhoNhat = table.Column<double>(type: "float", nullable: true),
                    TongLuuLuongXaLonNhat = table.Column<double>(type: "float", nullable: true),
                    TongLuuLuongXaNhoNhat = table.Column<double>(type: "float", nullable: true),
                    DongChayToiThieuLonNhat = table.Column<double>(type: "float", nullable: true),
                    DongChayToiThieuNhoNhat = table.Column<double>(type: "float", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BieuMauSoHaiMot", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BieuMauSoHaiTu",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ThoiGian = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LuuLuongXaThaiLonNhat = table.Column<double>(type: "float", nullable: true),
                    LuuLuongXaThaiNhoNhat = table.Column<double>(type: "float", nullable: true),
                    LuuLuongXaThaiChoPhep = table.Column<double>(type: "float", nullable: true),
                    SoNgayXaThai = table.Column<double>(type: "float", nullable: true),
                    TongLuongXaThai = table.Column<double>(type: "float", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BieuMauSoHaiTu", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BieuMauSoMot",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LuuVucSong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TongTramQuanTracKyTruoc = table.Column<double>(type: "float", nullable: true),
                    TongTramQuanTracBaoCao = table.Column<double>(type: "float", nullable: true),
                    TramKhiTuongKyTruoc = table.Column<double>(type: "float", nullable: true),
                    TramKhiTuongBaoCao = table.Column<double>(type: "float", nullable: true),
                    TramThuyVanKyTruoc = table.Column<double>(type: "float", nullable: true),
                    TramThuyVanKyBaoCao = table.Column<double>(type: "float", nullable: true),
                    TramTNNKyTruoc = table.Column<double>(type: "float", nullable: true),
                    TramTNNKyBaoCao = table.Column<double>(type: "float", nullable: true),
                    TramQuanTracKyTruoc = table.Column<double>(type: "float", nullable: true),
                    TramQuanTracKyBaoCao = table.Column<double>(type: "float", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BieuMauSoMot", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BieuMauSoMuoi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LuuVucSong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TongCongTrinh = table.Column<double>(type: "float", nullable: true),
                    CTTuoiNuocMat = table.Column<double>(type: "float", nullable: true),
                    CTTuoiNuocDuoiDat = table.Column<double>(type: "float", nullable: true),
                    CTThuyDien = table.Column<double>(type: "float", nullable: true),
                    CTMucDichKhacNuocMat = table.Column<double>(type: "float", nullable: true),
                    CTMucDichKhacNuocDuoiDat = table.Column<double>(type: "float", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BieuMauSoMuoi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BieuMauSoMuoiBa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ViTriQuanTrac = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BOD5LonNhat = table.Column<double>(type: "float", nullable: true),
                    BOD5NhoNhat = table.Column<double>(type: "float", nullable: true),
                    CODLonNhat = table.Column<double>(type: "float", nullable: true),
                    CODNhoNhat = table.Column<double>(type: "float", nullable: true),
                    DOLonNhat = table.Column<double>(type: "float", nullable: true),
                    DONhoNhat = table.Column<double>(type: "float", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BieuMauSoMuoiBa", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BieuMauSoMuoiBay",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TongCTPheDuyetTCQKyTruoc = table.Column<double>(type: "float", nullable: true),
                    TongCTPheDuyetTCQKyBaoCao = table.Column<double>(type: "float", nullable: true),
                    TongCTPheDuyetTCQBoKyTruoc = table.Column<double>(type: "float", nullable: true),
                    TongCTPheDuyetTCQBoKyBaoCao = table.Column<double>(type: "float", nullable: true),
                    TongCTPheDuyetTCQDiaPhuongKyTruoc = table.Column<double>(type: "float", nullable: true),
                    TongCTPheDuyetTCQDiaPhuongKyBaoCao = table.Column<double>(type: "float", nullable: true),
                    TongTCQpKyTruoc = table.Column<double>(type: "float", nullable: true),
                    TongTCQKyBaoCao = table.Column<double>(type: "float", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BieuMauSoMuoiBay", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BieuMauSoMuoiBon",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ViTriQuanTrac = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PHlonNhat = table.Column<double>(type: "float", nullable: true),
                    PHNhoNhat = table.Column<double>(type: "float", nullable: true),
                    DoCungLonNhat = table.Column<double>(type: "float", nullable: true),
                    DoCungNhoNhat = table.Column<double>(type: "float", nullable: true),
                    AmoniLonNhat = table.Column<double>(type: "float", nullable: true),
                    AmoniNhoNhat = table.Column<double>(type: "float", nullable: true),
                    NitratLonNhat = table.Column<double>(type: "float", nullable: true),
                    NitratNhoNhat = table.Column<double>(type: "float", nullable: true),
                    SulfatLonNhat = table.Column<double>(type: "float", nullable: true),
                    SulfatNhoNhat = table.Column<double>(type: "float", nullable: true),
                    AsenLonNhat = table.Column<double>(type: "float", nullable: true),
                    AsenNhoNhat = table.Column<double>(type: "float", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BieuMauSoMuoiBon", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BieuMauSoMuoiChin",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoCuocThanhTraKyTruoc = table.Column<double>(type: "float", nullable: true),
                    SoCuocThanhTraKyBaoCao = table.Column<double>(type: "float", nullable: true),
                    SoDoiTuongThanhTraKyTruoc = table.Column<double>(type: "float", nullable: true),
                    SoDoiTuongThanhTraKyBaoCao = table.Column<double>(type: "float", nullable: true),
                    SoTCCNXuPhatKyTruoc = table.Column<double>(type: "float", nullable: true),
                    SoTCCNXuPhatKyBaoCao = table.Column<double>(type: "float", nullable: true),
                    TongTienXuPhatKyTruoc = table.Column<double>(type: "float", nullable: true),
                    TongTienXuPhatKyBaoCao = table.Column<double>(type: "float", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BieuMauSoMuoiChin", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BieuMauSoMuoiHai",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LuuVucSong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TongSoCongTrinh = table.Column<double>(type: "float", nullable: true),
                    TuoiNguonNuocMat = table.Column<double>(type: "float", nullable: true),
                    TuoiNguonNuocDuoiDat = table.Column<double>(type: "float", nullable: true),
                    KhaiThacThuyDien = table.Column<double>(type: "float", nullable: true),
                    MucDichKhacNguonNuocMat = table.Column<double>(type: "float", nullable: true),
                    MucDichKhacNguonNuocDD = table.Column<double>(type: "float", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BieuMauSoMuoiHai", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BieuMauSoMuoiMot",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LuuVucSong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TongSoCongTrinh = table.Column<double>(type: "float", nullable: true),
                    CongTrinhHoChua = table.Column<double>(type: "float", nullable: true),
                    CongTrinhDapDang = table.Column<double>(type: "float", nullable: true),
                    CongTrinhCong = table.Column<double>(type: "float", nullable: true),
                    CongTrinhTramBom = table.Column<double>(type: "float", nullable: true),
                    CongTrinhKhacNuocMat = table.Column<double>(type: "float", nullable: true),
                    CongTrinhGieng = table.Column<double>(type: "float", nullable: true),
                    CongTrinhKhacNDD = table.Column<double>(type: "float", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BieuMauSoMuoiMot", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BieuMauSoMuoiNam",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CoQuanPhatHanh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VanBanKyTruoc = table.Column<double>(type: "float", nullable: true),
                    VanBanKyBaoCao = table.Column<double>(type: "float", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BieuMauSoMuoiNam", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BieuMauSoMuoiSau",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoaiGiayPhep = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TongGPCapKyTruoc = table.Column<double>(type: "float", nullable: true),
                    TongGPCapKyBaoCao = table.Column<double>(type: "float", nullable: true),
                    TongGPBoCapKyTruoc = table.Column<double>(type: "float", nullable: true),
                    TongGPBoCapKyBaoCao = table.Column<double>(type: "float", nullable: true),
                    TongGPDiaPhuongCapKyTruoc = table.Column<double>(type: "float", nullable: true),
                    TongGPDiaPhuongCapBaoCao = table.Column<double>(type: "float", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BieuMauSoMuoiSau", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BieuMauSoMuoiTam",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LuuVucSong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TongSongPheDuyetBoKyTruoc = table.Column<double>(type: "float", nullable: true),
                    TongSongPheDuyetBoKyBaoCao = table.Column<double>(type: "float", nullable: true),
                    TongSongPheDuyetDiaPhuongKyTruoc = table.Column<double>(type: "float", nullable: true),
                    TongSongPheDuyetDiaPhuongKyBaoCao = table.Column<double>(type: "float", nullable: true),
                    TongHoPheDuyetKyTruoc = table.Column<double>(type: "float", nullable: true),
                    TongHoPheDuyetKyBaoCao = table.Column<double>(type: "float", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BieuMauSoMuoiTam", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BieuMauSoNam",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenTram = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LuuLuongThang1 = table.Column<double>(type: "float", nullable: true),
                    LuuLuongThang2 = table.Column<double>(type: "float", nullable: true),
                    LuuLuongThang3 = table.Column<double>(type: "float", nullable: true),
                    LuuLuongThang4 = table.Column<double>(type: "float", nullable: true),
                    LuuLuongThang5 = table.Column<double>(type: "float", nullable: true),
                    LuuLuongThang6 = table.Column<double>(type: "float", nullable: true),
                    LuuLuongThang7 = table.Column<double>(type: "float", nullable: true),
                    LuuLuongThang8 = table.Column<double>(type: "float", nullable: true),
                    LuuLuongThang9 = table.Column<double>(type: "float", nullable: true),
                    LuuLuongThang10 = table.Column<double>(type: "float", nullable: true),
                    LuuLuongThang11 = table.Column<double>(type: "float", nullable: true),
                    LuuLuongThang12 = table.Column<double>(type: "float", nullable: true),
                    LuuLuongNam = table.Column<double>(type: "float", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BieuMauSoNam", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BieuMauSoSau",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LuuVucSong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SLHoChua = table.Column<double>(type: "float", nullable: true),
                    DungTichToanBo = table.Column<double>(type: "float", nullable: true),
                    DungTichHuuich = table.Column<double>(type: "float", nullable: true),
                    DungTichPhongLu = table.Column<double>(type: "float", nullable: true),
                    DungTichTichDuoc = table.Column<double>(type: "float", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BieuMauSoSau", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BieuMauSoTam",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TangChuaNuoc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SLGieng = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MucNuocMaxKyTruoc = table.Column<double>(type: "float", nullable: true),
                    MucNuocMaxKyBaoCao = table.Column<double>(type: "float", nullable: true),
                    MucNuocMediumKyTruoc = table.Column<double>(type: "float", nullable: true),
                    MucNuocMediumKyBaoCao = table.Column<double>(type: "float", nullable: true),
                    MucNuocMinKyTruoc = table.Column<double>(type: "float", nullable: true),
                    MucNuocMinKyBaoCao = table.Column<double>(type: "float", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BieuMauSoTam", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CT_Loai",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCha = table.Column<int>(type: "int", nullable: true),
                    TenLoaiCT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaLoaiCT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChuThich = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianTao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanTao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianSua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanSua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DaXoa = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CT_Loai", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Dashboards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PermitAccess = table.Column<bool>(type: "bit", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dashboards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DonViHC",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenTinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdTinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenHuyen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdHuyen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenXa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdXa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CapHanhChinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianTao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanTao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianSua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanSua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DaXoa = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DonViHC", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Functions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PermitCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PermitName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Functions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GP_Loai",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLoaiGP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaLoaiGP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianTao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanTao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianSua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanSua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DaXoa = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GP_Loai", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GS_DuLieu",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConstructionCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StationCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParameterName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<double>(type: "float", nullable: true),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeviceStatus = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GS_DuLieu", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GS_TaiKhoanTruyen",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CameraLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FTPAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Protocol = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Port = table.Column<int>(type: "int", nullable: true),
                    WorkingDirectory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GS_TaiKhoanTruyen", x => x.Id);
                });

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
                name: "LuuVucSong",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLVS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChuGiai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ViTriQT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgayBatDau = table.Column<int>(type: "int", nullable: true),
                    NgayKetThuc = table.Column<int>(type: "int", nullable: true),
                    ThoiGianTao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanTao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianSua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanSua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DaXoa = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LuuVucSong", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Permissions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoleId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DashboardId = table.Column<int>(type: "int", nullable: true),
                    FunctionId = table.Column<int>(type: "int", nullable: true),
                    FunctionName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FunctionCode = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permissions", x => x.Id);
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
                name: "RoleDashboards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DashboardId = table.Column<int>(type: "int", nullable: true),
                    FileControl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PermitAccess = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleDashboards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Song",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdLuuVuc = table.Column<int>(type: "int", nullable: true),
                    IdXa = table.Column<int>(type: "int", nullable: true),
                    IdHuyen = table.Column<int>(type: "int", nullable: true),
                    MaSong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    X = table.Column<double>(type: "float", nullable: true),
                    Y = table.Column<double>(type: "float", nullable: true),
                    Qtt = table.Column<double>(type: "float", nullable: true),
                    ChuGiai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianTao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanTao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianSua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanSua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DaXoa = table.Column<bool>(type: "bit", nullable: true),
                    PartRiverId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Song", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TangChuaNuoc",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenTCN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KyHieuTCN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoLuongGiengQT = table.Column<int>(type: "int", nullable: true),
                    ThoiGianTao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanTao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianSua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanSua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DaXoa = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TangChuaNuoc", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TCQ_ThongTin",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCon = table.Column<int>(type: "int", nullable: true),
                    SoQDTCQ = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgayKy = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CoQuanCP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TongTienCQ = table.Column<double>(type: "float", nullable: true),
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
                    table.PrimaryKey("PK_TCQ_ThongTin", x => x.Id);
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
                name: "TieuVungLuuVuc",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdLuuVuc = table.Column<int>(type: "int", nullable: true),
                    TieuVungQuyHoach = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChuGiai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianTao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanTao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianSua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanSua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DaXoa = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TieuVungLuuVuc", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TLN_NuocDuoiDat_ChatLuong",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    pHMax = table.Column<double>(type: "float", nullable: true),
                    pHMin = table.Column<double>(type: "float", nullable: true),
                    PHAvg = table.Column<double>(type: "float", nullable: true),
                    DoCungMax = table.Column<double>(type: "float", nullable: true),
                    DoCungMin = table.Column<double>(type: "float", nullable: true),
                    DoCungAvg = table.Column<double>(type: "float", nullable: true),
                    NitratMax = table.Column<double>(type: "float", nullable: true),
                    NitratMin = table.Column<double>(type: "float", nullable: true),
                    NitratAvg = table.Column<double>(type: "float", nullable: true),
                    SulfatMax = table.Column<double>(type: "float", nullable: true),
                    SulfatMin = table.Column<double>(type: "float", nullable: true),
                    SulfatAvg = table.Column<double>(type: "float", nullable: true),
                    AsenMax = table.Column<double>(type: "float", nullable: true),
                    AsenMin = table.Column<double>(type: "float", nullable: true),
                    AsenAvg = table.Column<double>(type: "float", nullable: true),
                    DaXoa = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TLN_NuocDuoiDat_ChatLuong", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TLN_NuocDuoiDat_SoLuong",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdTangChuaNuoc = table.Column<int>(type: "int", nullable: true),
                    DienTichPhanBo = table.Column<double>(type: "float", nullable: true),
                    ChieuSauPhanBoTu = table.Column<double>(type: "float", nullable: true),
                    ChieuSauPhanBoDen = table.Column<double>(type: "float", nullable: true),
                    HmaxKyTruoc = table.Column<double>(type: "float", nullable: true),
                    HmaxBaoCao = table.Column<double>(type: "float", nullable: true),
                    HmaxThayDoi = table.Column<double>(type: "float", nullable: true),
                    HTBKyTruoc = table.Column<double>(type: "float", nullable: true),
                    HTBBaoCao = table.Column<double>(type: "float", nullable: true),
                    HTBThayDoi = table.Column<double>(type: "float", nullable: true),
                    HminKyTruoc = table.Column<double>(type: "float", nullable: true),
                    HminBaoCao = table.Column<double>(type: "float", nullable: true),
                    HminThayDoi = table.Column<double>(type: "float", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DaXoa = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TLN_NuocDuoiDat_SoLuong", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TLN_NuocDuoiDat_TongLuong",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdTangChuaNuoc = table.Column<int>(type: "int", nullable: true),
                    NuocNgot_DienTichPhanBo = table.Column<float>(type: "real", nullable: true),
                    NuocNgot_IdXa = table.Column<int>(type: "int", nullable: true),
                    NuocNgot_IdHuyen = table.Column<int>(type: "int", nullable: true),
                    NuocNgot_TLTiemNang = table.Column<double>(type: "float", nullable: true),
                    NuocNgot_TLCoTheKhaiThac = table.Column<double>(type: "float", nullable: true),
                    NuocMan_DienTichPhanBo = table.Column<double>(type: "float", nullable: true),
                    NuocMan_IdXa = table.Column<int>(type: "int", nullable: true),
                    NuocMan_IdHuyen = table.Column<int>(type: "int", nullable: true),
                    NuocMan_TruLuong = table.Column<double>(type: "float", nullable: true),
                    DaXoa = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TLN_NuocDuoiDat_TongLuong", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TLN_NuocMat_ChatLuong",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdXa = table.Column<int>(type: "int", nullable: true),
                    IdHuyen = table.Column<int>(type: "int", nullable: true),
                    IdTinh = table.Column<int>(type: "int", nullable: true),
                    IdLuuVucSong = table.Column<int>(type: "int", nullable: true),
                    GiaTriWQI = table.Column<int>(type: "int", nullable: true),
                    BOD5Max = table.Column<double>(type: "float", nullable: true),
                    BOD5Min = table.Column<double>(type: "float", nullable: true),
                    CODMax = table.Column<double>(type: "float", nullable: true),
                    CODMin = table.Column<double>(type: "float", nullable: true),
                    DOMax = table.Column<double>(type: "float", nullable: true),
                    DOMin = table.Column<double>(type: "float", nullable: true),
                    ThoiGian = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DaXoa = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TLN_NuocMat_ChatLuong", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TLN_NuocMat_TongLuong",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdLuuVucSong = table.Column<int>(type: "int", nullable: true),
                    Nam = table.Column<int>(type: "int", nullable: true),
                    IdXa = table.Column<int>(type: "int", nullable: true),
                    IdHuyen = table.Column<int>(type: "int", nullable: true),
                    Thang1 = table.Column<double>(type: "float", nullable: true),
                    Thang2 = table.Column<double>(type: "float", nullable: true),
                    Thang3 = table.Column<double>(type: "float", nullable: true),
                    Thang4 = table.Column<double>(type: "float", nullable: true),
                    Thang5 = table.Column<double>(type: "float", nullable: true),
                    Thang6 = table.Column<double>(type: "float", nullable: true),
                    Thang7 = table.Column<double>(type: "float", nullable: true),
                    Thang8 = table.Column<double>(type: "float", nullable: true),
                    Thang9 = table.Column<double>(type: "float", nullable: true),
                    Thang10 = table.Column<double>(type: "float", nullable: true),
                    Thang11 = table.Column<double>(type: "float", nullable: true),
                    Thang12 = table.Column<double>(type: "float", nullable: true),
                    DaXoa = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TLN_NuocMat_TongLuong", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ToChuc_CaNhan",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenTCCN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaSoThue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SDT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fax = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GiamDoc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NguoiDuocUyQuyen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NguoiDaiDienPhapLuat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TaiKhoan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianTao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanTao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianSua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanSua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DaXoa = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToChuc_CaNhan", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tram_LoaiTram",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCha = table.Column<int>(type: "int", nullable: true),
                    TenLoaiCT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaLoaiCT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChuThich = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianTao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanTao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianSua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanSua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DaXoa = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tram_LoaiTram", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tram_ThongTin",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdXa = table.Column<int>(type: "int", nullable: true),
                    IdHuyen = table.Column<int>(type: "int", nullable: true),
                    IdLoaiTram = table.Column<int>(type: "int", nullable: true),
                    MaTram = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenTram = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiaChiTram = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    X = table.Column<double>(type: "float", nullable: true),
                    Y = table.Column<double>(type: "float", nullable: true),
                    NgayBatDau = table.Column<int>(type: "int", nullable: true),
                    NgayKetThuc = table.Column<int>(type: "int", nullable: true),
                    HoSoThanhLap = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HoSoHoatDong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CameraLine = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OnlineStatus = table.Column<bool>(type: "bit", nullable: true),
                    ChuThich = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianTao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanTao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianSua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanSua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DaXoa = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tram_ThongTin", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserDashboards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DashboardId = table.Column<int>(type: "int", nullable: true),
                    FileControl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PermitAccess = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDashboards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                        name: "FK_SoLuongNDD_QLC_TangChuaNuoc_MaTangChuaNuoc",
                        column: x => x.MaTangChuaNuoc,
                        principalTable: "QLC_TangChuaNuoc",
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
                        name: "FK_TongLuongNuocMan_QLC_TangChuaNuoc_MaTangChuaNuoc",
                        column: x => x.MaTangChuaNuoc,
                        principalTable: "QLC_TangChuaNuoc",
                        principalColumn: "MaTangChuaNuoc");
                });

            migrationBuilder.CreateTable(
                name: "TLN_NuocMat_SoLuong",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdSong = table.Column<int>(type: "int", nullable: true),
                    ChayRa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChieuDai = table.Column<double>(type: "float", nullable: true),
                    XDauSong = table.Column<double>(type: "float", nullable: true),
                    YDauSong = table.Column<double>(type: "float", nullable: true),
                    IdXaDauSong = table.Column<int>(type: "int", nullable: true),
                    IdHuyenDauSong = table.Column<int>(type: "int", nullable: true),
                    XCuoiSong = table.Column<double>(type: "float", nullable: true),
                    YCuoiSong = table.Column<double>(type: "float", nullable: true),
                    IdXaCuoiSong = table.Column<int>(type: "int", nullable: true),
                    IdHuyenCuoiSong = table.Column<int>(type: "int", nullable: true),
                    ThoiGianTao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanTao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianSua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanSua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DaXoa = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TLN_NuocMat_SoLuong", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TLN_NuocMat_SoLuong_Song_IdSong",
                        column: x => x.IdSong,
                        principalTable: "Song",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CT_ThongTin",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdLoaiCT = table.Column<int>(type: "int", nullable: false),
                    IdHuyen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdXa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdSong = table.Column<int>(type: "int", nullable: true),
                    IdLuuVuc = table.Column<int>(type: "int", nullable: true),
                    IdTieuLuuVuc = table.Column<int>(type: "int", nullable: true),
                    IdTangChuaNuoc = table.Column<int>(type: "int", nullable: true),
                    TaiKhoan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenCT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaCT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ViTriCT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    X = table.Column<double>(type: "float", nullable: true),
                    Y = table.Column<double>(type: "float", nullable: true),
                    NamBatDauVanHanh = table.Column<int>(type: "int", nullable: true),
                    NguonNuocKT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CheDoKT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MucDichhKT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhuongThucKT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhuongThucXT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CHeDoXT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NguonNuocXT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianKT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianHNK = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MucDichHNK = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MucDichhTD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuyMoHNK = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianXD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoLuongGiengKT = table.Column<int>(type: "int", nullable: true),
                    SoLuongGiengQT = table.Column<int>(type: "int", nullable: true),
                    ChuThich = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoLuongGieng = table.Column<int>(type: "int", nullable: true),
                    KhoiLuongCacHangMucTD = table.Column<int>(type: "int", nullable: true),
                    QKTThietKe = table.Column<int>(type: "int", nullable: true),
                    QKTThucTe = table.Column<int>(type: "int", nullable: true),
                    ViTriXT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QXaMaxTT = table.Column<double>(type: "float", nullable: true),
                    DungTichTT = table.Column<double>(type: "float", nullable: true),
                    HHaLuuTT = table.Column<double>(type: "float", nullable: true),
                    HThuongLuuTT = table.Column<double>(type: "float", nullable: true),
                    QMinTT = table.Column<double>(type: "float", nullable: true),
                    QMaxTT = table.Column<double>(type: "float", nullable: true),
                    QXaTranTT = table.Column<double>(type: "float", nullable: true),
                    ThoiGianTT = table.Column<double>(type: "float", nullable: true),
                    MatKetNoi = table.Column<int>(type: "int", nullable: true),
                    Loi = table.Column<int>(type: "int", nullable: true),
                    ThoiGianTao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanTao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianSua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanSua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DaXoa = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CT_ThongTin", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CT_ThongTin_CT_Loai_IdLoaiCT",
                        column: x => x.IdLoaiCT,
                        principalTable: "CT_Loai",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CT_ThongTin_TangChuaNuoc_IdTangChuaNuoc",
                        column: x => x.IdTangChuaNuoc,
                        principalTable: "TangChuaNuoc",
                        principalColumn: "Id");
                });

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
                    table.ForeignKey(
                        name: "FK_CheDoKhaiThacCongTrinh_ThongTinCongTrinh_MaThongTinCongTrinh",
                        column: x => x.MaThongTinCongTrinh,
                        principalTable: "ThongTinCongTrinh",
                        principalColumn: "MaThongTinCongTrinh");
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
                    table.ForeignKey(
                        name: "FK_PhanCapCongTrinhCong_ThongTinCongTrinh_MaThongTinCongTrinh",
                        column: x => x.MaThongTinCongTrinh,
                        principalTable: "ThongTinCongTrinh",
                        principalColumn: "MaThongTinCongTrinh");
                });

            migrationBuilder.CreateTable(
                name: "ThoiGianVanHanhCongTrinh",
                columns: table => new
                {
                    MaNamVanHanh = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaThongTinCongTrinh = table.Column<int>(type: "int", nullable: false),
                    NamBatDauVanHanh = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThoiGianVanHanhCongTrinh", x => x.MaNamVanHanh);
                    table.ForeignKey(
                        name: "FK_ThoiGianVanHanhCongTrinh_ThongTinCongTrinh_MaThongTinCongTrinh",
                        column: x => x.MaThongTinCongTrinh,
                        principalTable: "ThongTinCongTrinh",
                        principalColumn: "MaThongTinCongTrinh",
                        onDelete: ReferentialAction.Cascade);
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
                    table.ForeignKey(
                        name: "FK_ThongSoVanHanhThucTe_ThongTinCongTrinh_MaThongTinCongTrinh",
                        column: x => x.MaThongTinCongTrinh,
                        principalTable: "ThongTinCongTrinh",
                        principalColumn: "MaThongTinCongTrinh");
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
                    table.ForeignKey(
                        name: "FK_ToaDoCongTrinh_ThongTinCongTrinh_MaThongTinCongTrinh",
                        column: x => x.MaThongTinCongTrinh,
                        principalTable: "ThongTinCongTrinh",
                        principalColumn: "MaThongTinCongTrinh");
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
                    table.ForeignKey(
                        name: "FK_TramBomSanXuat_ThongTinCongTrinh_MaThongTinCongTrinh",
                        column: x => x.MaThongTinCongTrinh,
                        principalTable: "ThongTinCongTrinh",
                        principalColumn: "MaThongTinCongTrinh");
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
                    table.ForeignKey(
                        name: "FK_TramBomSinhHoat_ThongTinCongTrinh_MaThongTinCongTrinh",
                        column: x => x.MaThongTinCongTrinh,
                        principalTable: "ThongTinCongTrinh",
                        principalColumn: "MaThongTinCongTrinh");
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
                name: "TLN_NuocMua_TongLuong",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdTram = table.Column<int>(type: "int", nullable: true),
                    Thang1 = table.Column<double>(type: "float", nullable: true),
                    Thang2 = table.Column<double>(type: "float", nullable: true),
                    Thang3 = table.Column<double>(type: "float", nullable: true),
                    Thang4 = table.Column<double>(type: "float", nullable: true),
                    Thang5 = table.Column<double>(type: "float", nullable: true),
                    Thang6 = table.Column<double>(type: "float", nullable: true),
                    Thang7 = table.Column<double>(type: "float", nullable: true),
                    Thang8 = table.Column<double>(type: "float", nullable: true),
                    Thang9 = table.Column<double>(type: "float", nullable: true),
                    Thang10 = table.Column<double>(type: "float", nullable: true),
                    Thang11 = table.Column<double>(type: "float", nullable: true),
                    Thang12 = table.Column<double>(type: "float", nullable: true),
                    ThoiGianTao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanTao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianSua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanSua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DaXoa = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TLN_NuocMua_TongLuong", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TLN_NuocMua_TongLuong_Tram_ThongTin_IdTram",
                        column: x => x.IdTram,
                        principalTable: "Tram_ThongTin",
                        principalColumn: "Id");
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
                name: "CT_HangMuc",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCT = table.Column<int>(type: "int", nullable: true),
                    IdTangChuaNuoc = table.Column<int>(type: "int", nullable: true),
                    TenHangMuc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VịTriHangMuc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    X = table.Column<double>(type: "float", nullable: true),
                    Y = table.Column<double>(type: "float", nullable: true),
                    ChuThich = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianTao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanTao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianSua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanSua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DaXoa = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CT_HangMuc", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CT_HangMuc_CT_ThongTin_IdCT",
                        column: x => x.IdCT,
                        principalTable: "CT_ThongTin",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CT_HangMuc_TangChuaNuoc_IdTangChuaNuoc",
                        column: x => x.IdTangChuaNuoc,
                        principalTable: "TangChuaNuoc",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "GP_ThongTin",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCon = table.Column<int>(type: "int", nullable: true),
                    IdLoaiGP = table.Column<int>(type: "int", nullable: true),
                    IdTCCN = table.Column<int>(type: "int", nullable: true),
                    IdCT = table.Column<int>(type: "int", nullable: true),
                    TenGP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoGP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgayKy = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NgayCoHieuLuc = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NgayHetHieuLuc = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ThoiHan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CoQuanCapPhep = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FileGiayPhep = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FileGiayToLienQuan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FileDonXinCP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DaBiThuHoi = table.Column<bool>(type: "bit", nullable: true),
                    ThoiGianTao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanTao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianSua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanSua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DaXoa = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GP_ThongTin", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GP_ThongTin_CT_ThongTin_IdCT",
                        column: x => x.IdCT,
                        principalTable: "CT_ThongTin",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GP_ThongTin_GP_Loai_IdLoaiGP",
                        column: x => x.IdLoaiGP,
                        principalTable: "GP_Loai",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GP_ThongTin_ToChuc_CaNhan_IdTCCN",
                        column: x => x.IdTCCN,
                        principalTable: "ToChuc_CaNhan",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ThongSoKyThuatCongTrinh",
                columns: table => new
                {
                    MaThongSoKyThuatCongTrinhTramBom = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaThongTinCongTrinhTramBom = table.Column<int>(type: "int", nullable: true),
                    MaThongSoVanHanhThucTe = table.Column<int>(type: "int", nullable: true),
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
                    table.ForeignKey(
                        name: "FK_ThongSoKyThuatCongTrinh_ThongSoVanHanhThucTe_MaThongSoVanHanhThucTe",
                        column: x => x.MaThongSoVanHanhThucTe,
                        principalTable: "ThongSoVanHanhThucTe",
                        principalColumn: "MaThongSoVanHanhThucTe");
                    table.ForeignKey(
                        name: "FK_ThongSoKyThuatCongTrinh_ThongTinCongTrinh_MaThongTinCongTrinhTramBom",
                        column: x => x.MaThongTinCongTrinhTramBom,
                        principalTable: "ThongTinCongTrinh",
                        principalColumn: "MaThongTinCongTrinh");
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
                name: "ThongTinVeChatLuongNuoc",
                columns: table => new
                {
                    MaThongTinVeChatLuongNuoc = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaCt = table.Column<int>(type: "int", nullable: true),
                    MaChiTieu = table.Column<int>(type: "int", nullable: true),
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
                        name: "FK_ThongTinVeChatLuongNuoc_QLC_CongTrinh_MaCt",
                        column: x => x.MaCt,
                        principalTable: "QLC_CongTrinh",
                        principalColumn: "MaCT");
                    table.ForeignKey(
                        name: "FK_ThongTinVeChatLuongNuoc_ThongTinVeCacChiTieuPhanTichCLN_MaChiTieu",
                        column: x => x.MaChiTieu,
                        principalTable: "ThongTinVeCacChiTieuPhanTichCLN",
                        principalColumn: "MaChiTieu");
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
                        name: "FK_ThongTinVeHoatDongCuaCongTrinh_QLC_CongTrinh_MaCt",
                        column: x => x.MaCt,
                        principalTable: "QLC_CongTrinh",
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
                        name: "FK_ThongTinVeMucNuocTinh_QLC_CongTrinh_MaCt",
                        column: x => x.MaCt,
                        principalTable: "QLC_CongTrinh",
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
                        name: "FK_ThongTinVeTruLuongNuoc_QLC_CongTrinh_MaCt",
                        column: x => x.MaCt,
                        principalTable: "QLC_CongTrinh",
                        principalColumn: "MaCT");
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
                name: "TongLuongMua",
                columns: table => new
                {
                    MaTongLuongMua = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaTramQuanTracLuongMua = table.Column<int>(type: "int", nullable: true),
                    MaPhuongPhapTinhMua = table.Column<int>(type: "int", nullable: true),
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
                        name: "FK_TongLuongMua_PhuongPhapTinhMua_MaPhuongPhapTinhMua",
                        column: x => x.MaPhuongPhapTinhMua,
                        principalTable: "PhuongPhapTinhMua",
                        principalColumn: "MaPhuongPhapTinhMua");
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
                name: "CT_ThongSo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCT = table.Column<int>(type: "int", nullable: true),
                    IdHangMucCT = table.Column<int>(type: "int", nullable: true),
                    CapCT = table.Column<double>(type: "float", nullable: true),
                    DienTichLuuVuc = table.Column<double>(type: "float", nullable: true),
                    MuaTrungBinhNam = table.Column<double>(type: "float", nullable: true),
                    QTrungBinhNam = table.Column<double>(type: "float", nullable: true),
                    CongSuatLM = table.Column<double>(type: "float", nullable: true),
                    CongSuatDamBao = table.Column<double>(type: "float", nullable: true),
                    ChieuCaoDap = table.Column<double>(type: "float", nullable: true),
                    ChieuDaiDap = table.Column<double>(type: "float", nullable: true),
                    CaoTrinhDap = table.Column<double>(type: "float", nullable: true),
                    QmaxNM = table.Column<double>(type: "float", nullable: true),
                    Qtt = table.Column<double>(type: "float", nullable: true),
                    QDamBao = table.Column<double>(type: "float", nullable: true),
                    Hmax = table.Column<double>(type: "float", nullable: true),
                    Hmin = table.Column<double>(type: "float", nullable: true),
                    HtoiThieu = table.Column<double>(type: "float", nullable: true),
                    MNC = table.Column<double>(type: "float", nullable: true),
                    MNDBT = table.Column<double>(type: "float", nullable: true),
                    MNLTK = table.Column<double>(type: "float", nullable: true),
                    MNLKT = table.Column<double>(type: "float", nullable: true),
                    DungTichToanBo = table.Column<double>(type: "float", nullable: true),
                    DungTichChet = table.Column<double>(type: "float", nullable: true),
                    DungTichHuuIch = table.Column<double>(type: "float", nullable: true),
                    CaoTrinhCong = table.Column<double>(type: "float", nullable: true),
                    ChieuDaiCong = table.Column<double>(type: "float", nullable: true),
                    ChieuRongCong = table.Column<double>(type: "float", nullable: true),
                    KichThuocCong = table.Column<double>(type: "float", nullable: true),
                    SoLuongMayBom = table.Column<double>(type: "float", nullable: true),
                    QThietKe = table.Column<double>(type: "float", nullable: true),
                    QThucTe = table.Column<double>(type: "float", nullable: true),
                    DienTichTuoiThietKe = table.Column<double>(type: "float", nullable: true),
                    DienTichTuoiThucTe = table.Column<double>(type: "float", nullable: true),
                    ThoiGianBomTB = table.Column<double>(type: "float", nullable: true),
                    ThoiGianBomNhoNhat = table.Column<double>(type: "float", nullable: true),
                    ThoiGianBomLonNhat = table.Column<double>(type: "float", nullable: true),
                    ChieuSauDoanThuNuocTu = table.Column<double>(type: "float", nullable: true),
                    ChieuSauDoanThuNuocDen = table.Column<double>(type: "float", nullable: true),
                    QKTCapNuocSinhHoat = table.Column<double>(type: "float", nullable: true),
                    Hgieng = table.Column<double>(type: "float", nullable: true),
                    HGiengKT = table.Column<double>(type: "float", nullable: true),
                    PhuongThucKT = table.Column<double>(type: "float", nullable: true),
                    MucNuocTinh = table.Column<double>(type: "float", nullable: true),
                    MucNuocDong = table.Column<double>(type: "float", nullable: true),
                    TangChuaNuocKT = table.Column<double>(type: "float", nullable: true),
                    HHaThap = table.Column<double>(type: "float", nullable: true),
                    LuongNuocKT = table.Column<double>(type: "float", nullable: true),
                    HDatOngLocTu = table.Column<double>(type: "float", nullable: true),
                    HDatOngLocDen = table.Column<double>(type: "float", nullable: true),
                    QKTLonNhat = table.Column<double>(type: "float", nullable: true),
                    CongSuatBom = table.Column<double>(type: "float", nullable: true),
                    QXaThaiTB = table.Column<double>(type: "float", nullable: true),
                    QXaThaiLonNhat = table.Column<double>(type: "float", nullable: true),
                    KqKf = table.Column<double>(type: "float", nullable: true),
                    QXaTran = table.Column<double>(type: "float", nullable: true),
                    QLonNhatTruocLu = table.Column<double>(type: "float", nullable: true),
                    Hlu = table.Column<double>(type: "float", nullable: true),
                    HThuongLuu = table.Column<double>(type: "float", nullable: true),
                    HHaLuu = table.Column<double>(type: "float", nullable: true),
                    QBomThietKe = table.Column<double>(type: "float", nullable: true),
                    QBomLonNhat = table.Column<double>(type: "float", nullable: true),
                    HBeHut = table.Column<double>(type: "float", nullable: true),
                    QXaThai = table.Column<double>(type: "float", nullable: true),
                    QMaxXaThai = table.Column<double>(type: "float", nullable: true),
                    QKhaiThac = table.Column<double>(type: "float", nullable: true),
                    QMaxKT = table.Column<double>(type: "float", nullable: true),
                    ThoiGianTao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanTao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianSua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanSua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DaXoa = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CT_ThongSo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CT_ThongSo_CT_HangMuc_IdHangMucCT",
                        column: x => x.IdHangMucCT,
                        principalTable: "CT_HangMuc",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CT_ThongSo_CT_ThongTin_IdCT",
                        column: x => x.IdCT,
                        principalTable: "CT_ThongTin",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "GP_TCQ",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdGP = table.Column<int>(type: "int", nullable: false),
                    IdTCQ = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GP_TCQ", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GP_TCQ_GP_ThongTin_IdGP",
                        column: x => x.IdGP,
                        principalTable: "GP_ThongTin",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GP_TCQ_TCQ_ThongTin_IdTCQ",
                        column: x => x.IdTCQ,
                        principalTable: "TCQ_ThongTin",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CheDoKhaiThacCongTrinh_MaThongTinCongTrinh",
                table: "CheDoKhaiThacCongTrinh",
                column: "MaThongTinCongTrinh",
                unique: true,
                filter: "[MaThongTinCongTrinh] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ChuyenVien_MaThongTinCQNN",
                table: "ChuyenVien",
                column: "MaThongTinCQNN",
                unique: true,
                filter: "[MaThongTinCQNN] IS NOT NULL");

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
                name: "IX_CT_HangMuc_IdCT",
                table: "CT_HangMuc",
                column: "IdCT");

            migrationBuilder.CreateIndex(
                name: "IX_CT_HangMuc_IdTangChuaNuoc",
                table: "CT_HangMuc",
                column: "IdTangChuaNuoc");

            migrationBuilder.CreateIndex(
                name: "IX_CT_ThongSo_IdCT",
                table: "CT_ThongSo",
                column: "IdCT",
                unique: true,
                filter: "[IdCT] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CT_ThongSo_IdHangMucCT",
                table: "CT_ThongSo",
                column: "IdHangMucCT",
                unique: true,
                filter: "[IdHangMucCT] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CT_ThongTin_IdLoaiCT",
                table: "CT_ThongTin",
                column: "IdLoaiCT");

            migrationBuilder.CreateIndex(
                name: "IX_CT_ThongTin_IdTangChuaNuoc",
                table: "CT_ThongTin",
                column: "IdTangChuaNuoc");

            migrationBuilder.CreateIndex(
                name: "IX_DacTrungSongSuoi_MaSong_Suoi_KenhRach",
                table: "DacTrungSongSuoi",
                column: "MaSong_Suoi_KenhRach");

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
                name: "IX_GP_TCQ_IdGP",
                table: "GP_TCQ",
                column: "IdGP");

            migrationBuilder.CreateIndex(
                name: "IX_GP_TCQ_IdTCQ",
                table: "GP_TCQ",
                column: "IdTCQ");

            migrationBuilder.CreateIndex(
                name: "IX_GP_ThongTin_IdCT",
                table: "GP_ThongTin",
                column: "IdCT");

            migrationBuilder.CreateIndex(
                name: "IX_GP_ThongTin_IdLoaiGP",
                table: "GP_ThongTin",
                column: "IdLoaiGP");

            migrationBuilder.CreateIndex(
                name: "IX_GP_ThongTin_IdTCCN",
                table: "GP_ThongTin",
                column: "IdTCCN");

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
                name: "IX_PhanCapCongTrinhCong_MaThongTinCongTrinh",
                table: "PhanCapCongTrinhCong",
                column: "MaThongTinCongTrinh",
                unique: true,
                filter: "[MaThongTinCongTrinh] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_QLC_CongTrinh_MaTangChuaNuoc",
                table: "QLC_CongTrinh",
                column: "MaTangChuaNuoc");

            migrationBuilder.CreateIndex(
                name: "IX_QLC_CongTrinh_MaThongTinTCCN",
                table: "QLC_CongTrinh",
                column: "MaThongTinTCCN");

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
                name: "IX_ThoiGianVanHanhCongTrinh_MaThongTinCongTrinh",
                table: "ThoiGianVanHanhCongTrinh",
                column: "MaThongTinCongTrinh",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ThongSoKyThuatCongTrinh_MaThongSoVanHanhThucTe",
                table: "ThongSoKyThuatCongTrinh",
                column: "MaThongSoVanHanhThucTe",
                unique: true,
                filter: "[MaThongSoVanHanhThucTe] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ThongSoKyThuatCongTrinh_MaThongTinCongTrinhTramBom",
                table: "ThongSoKyThuatCongTrinh",
                column: "MaThongTinCongTrinhTramBom",
                unique: true,
                filter: "[MaThongTinCongTrinhTramBom] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ThongSoVanHanhThucTe_MaThongTinCongTrinh",
                table: "ThongSoVanHanhThucTe",
                column: "MaThongTinCongTrinh");

            migrationBuilder.CreateIndex(
                name: "IX_ThongTinKetNoi_MaCt",
                table: "ThongTinKetNoi",
                column: "MaCt",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ThongTinVeChatLuongNuoc_MaChiTieu",
                table: "ThongTinVeChatLuongNuoc",
                column: "MaChiTieu");

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
                name: "IX_TLN_NuocMat_SoLuong_IdSong",
                table: "TLN_NuocMat_SoLuong",
                column: "IdSong");

            migrationBuilder.CreateIndex(
                name: "IX_TLN_NuocMua_TongLuong_IdTram",
                table: "TLN_NuocMua_TongLuong",
                column: "IdTram");

            migrationBuilder.CreateIndex(
                name: "IX_ToaDoCongTrinh_MaThongTinCongTrinh",
                table: "ToaDoCongTrinh",
                column: "MaThongTinCongTrinh",
                unique: true,
                filter: "[MaThongTinCongTrinh] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_TongLuongDongChay_MaLuuVucSong",
                table: "TongLuongDongChay",
                column: "MaLuuVucSong",
                unique: true,
                filter: "[MaLuuVucSong] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_TongLuongMua_MaPhuongPhapTinhMua",
                table: "TongLuongMua",
                column: "MaPhuongPhapTinhMua",
                unique: true,
                filter: "[MaPhuongPhapTinhMua] IS NOT NULL");

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
                name: "IX_TramBomSanXuat_MaThongTinCongTrinh",
                table: "TramBomSanXuat",
                column: "MaThongTinCongTrinh",
                unique: true,
                filter: "[MaThongTinCongTrinh] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_TramBomSinhHoat_MaThongTinCongTrinh",
                table: "TramBomSinhHoat",
                column: "MaThongTinCongTrinh",
                unique: true,
                filter: "[MaThongTinCongTrinh] IS NOT NULL");

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

            migrationBuilder.CreateIndex(
                name: "IX_TrangThaiTaiKhoan_MaCt",
                table: "TrangThaiTaiKhoan",
                column: "MaCt",
                unique: true,
                filter: "[MaCt] IS NOT NULL");

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
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "BieuMauSoBa");

            migrationBuilder.DropTable(
                name: "BieuMauSoBay");

            migrationBuilder.DropTable(
                name: "BieuMauSoBon");

            migrationBuilder.DropTable(
                name: "BieuMauSoChin");

            migrationBuilder.DropTable(
                name: "BieuMauSoHai");

            migrationBuilder.DropTable(
                name: "BieuMauSoHaiBa");

            migrationBuilder.DropTable(
                name: "BieuMauSoHaiHai");

            migrationBuilder.DropTable(
                name: "BieuMauSoHaiLam");

            migrationBuilder.DropTable(
                name: "BieuMauSoHaiMot");

            migrationBuilder.DropTable(
                name: "BieuMauSoHaiTu");

            migrationBuilder.DropTable(
                name: "BieuMauSoMot");

            migrationBuilder.DropTable(
                name: "BieuMauSoMuoi");

            migrationBuilder.DropTable(
                name: "BieuMauSoMuoiBa");

            migrationBuilder.DropTable(
                name: "BieuMauSoMuoiBay");

            migrationBuilder.DropTable(
                name: "BieuMauSoMuoiBon");

            migrationBuilder.DropTable(
                name: "BieuMauSoMuoiChin");

            migrationBuilder.DropTable(
                name: "BieuMauSoMuoiHai");

            migrationBuilder.DropTable(
                name: "BieuMauSoMuoiMot");

            migrationBuilder.DropTable(
                name: "BieuMauSoMuoiNam");

            migrationBuilder.DropTable(
                name: "BieuMauSoMuoiSau");

            migrationBuilder.DropTable(
                name: "BieuMauSoMuoiTam");

            migrationBuilder.DropTable(
                name: "BieuMauSoNam");

            migrationBuilder.DropTable(
                name: "BieuMauSoSau");

            migrationBuilder.DropTable(
                name: "BieuMauSoTam");

            migrationBuilder.DropTable(
                name: "CheDoKhaiThacCongTrinh");

            migrationBuilder.DropTable(
                name: "ChuyenVien");

            migrationBuilder.DropTable(
                name: "CLNMatTheoWQI");

            migrationBuilder.DropTable(
                name: "CT_ThongSo");

            migrationBuilder.DropTable(
                name: "Dashboards");

            migrationBuilder.DropTable(
                name: "DonViHC");

            migrationBuilder.DropTable(
                name: "DuLieuKetNoi");

            migrationBuilder.DropTable(
                name: "Functions");

            migrationBuilder.DropTable(
                name: "GP_TCQ");

            migrationBuilder.DropTable(
                name: "GS_DuLieu");

            migrationBuilder.DropTable(
                name: "GS_TaiKhoanTruyen");

            migrationBuilder.DropTable(
                name: "LichSuKetNoi");

            migrationBuilder.DropTable(
                name: "LuuVucSong");

            migrationBuilder.DropTable(
                name: "Permissions");

            migrationBuilder.DropTable(
                name: "PhanCapCongTrinhCong");

            migrationBuilder.DropTable(
                name: "RoleDashboards");

            migrationBuilder.DropTable(
                name: "SoLuongNDD");

            migrationBuilder.DropTable(
                name: "ThoiGianVanHanhCongTrinh");

            migrationBuilder.DropTable(
                name: "ThongSoKyThuatCongTrinh");

            migrationBuilder.DropTable(
                name: "ThongTinKetNoi");

            migrationBuilder.DropTable(
                name: "ThongTinVeChatLuongNuoc");

            migrationBuilder.DropTable(
                name: "ThongTinVeHoatDongCuaCongTrinh");

            migrationBuilder.DropTable(
                name: "ThongTinVeMucNuocTinh");

            migrationBuilder.DropTable(
                name: "ThongTinVeTruLuongNuoc");

            migrationBuilder.DropTable(
                name: "TieuVungLuuVuc");

            migrationBuilder.DropTable(
                name: "TLN_NuocDuoiDat_ChatLuong");

            migrationBuilder.DropTable(
                name: "TLN_NuocDuoiDat_SoLuong");

            migrationBuilder.DropTable(
                name: "TLN_NuocDuoiDat_TongLuong");

            migrationBuilder.DropTable(
                name: "TLN_NuocMat_ChatLuong");

            migrationBuilder.DropTable(
                name: "TLN_NuocMat_SoLuong");

            migrationBuilder.DropTable(
                name: "TLN_NuocMat_TongLuong");

            migrationBuilder.DropTable(
                name: "TLN_NuocMua_TongLuong");

            migrationBuilder.DropTable(
                name: "ToaDoCongTrinh");

            migrationBuilder.DropTable(
                name: "TongLuongDongChay");

            migrationBuilder.DropTable(
                name: "TongLuongMua");

            migrationBuilder.DropTable(
                name: "TongLuongNuocMan");

            migrationBuilder.DropTable(
                name: "Tram_LoaiTram");

            migrationBuilder.DropTable(
                name: "TramBomSanXuat");

            migrationBuilder.DropTable(
                name: "TramBomSinhHoat");

            migrationBuilder.DropTable(
                name: "TrangThaiQuanTrac");

            migrationBuilder.DropTable(
                name: "UserDashboards");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "ThongTinCQNN");

            migrationBuilder.DropTable(
                name: "CT_HangMuc");

            migrationBuilder.DropTable(
                name: "GP_ThongTin");

            migrationBuilder.DropTable(
                name: "TCQ_ThongTin");

            migrationBuilder.DropTable(
                name: "TaiKhoanKetNoi");

            migrationBuilder.DropTable(
                name: "ThongSoVanHanhThucTe");

            migrationBuilder.DropTable(
                name: "ThongTinVeCacChiTieuPhanTichCLN");

            migrationBuilder.DropTable(
                name: "Song");

            migrationBuilder.DropTable(
                name: "Tram_ThongTin");

            migrationBuilder.DropTable(
                name: "SoLieuMua");

            migrationBuilder.DropTable(
                name: "CT_ThongTin");

            migrationBuilder.DropTable(
                name: "GP_Loai");

            migrationBuilder.DropTable(
                name: "ToChuc_CaNhan");

            migrationBuilder.DropTable(
                name: "TrangThaiTaiKhoan");

            migrationBuilder.DropTable(
                name: "ThongTinCongTrinh");

            migrationBuilder.DropTable(
                name: "PhuongPhapTinhMua");

            migrationBuilder.DropTable(
                name: "TramQuanTracLuongMua");

            migrationBuilder.DropTable(
                name: "CT_Loai");

            migrationBuilder.DropTable(
                name: "TangChuaNuoc");

            migrationBuilder.DropTable(
                name: "QLC_CongTrinh");

            migrationBuilder.DropTable(
                name: "LoaiTramQuanTracLuongMua");

            migrationBuilder.DropTable(
                name: "QLC_TangChuaNuoc");

            migrationBuilder.DropTable(
                name: "ThongTinTCCN");

            migrationBuilder.DropTable(
                name: "TLN_LuuVucSong");

            migrationBuilder.DropTable(
                name: "DacTrungSongSuoi");

            migrationBuilder.DropTable(
                name: "Song_Suoi_KenhRach");
        }
    }
}
