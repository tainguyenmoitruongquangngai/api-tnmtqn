using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace new_wr_api.Migrations
{
    /// <inheritdoc />
    public partial class InitDbase : Migration
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
                    IdHuyen = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                name: "Huyen",
                columns: table => new
                {
                    IdHuyen = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenHuyen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CapHanhChinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianTao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanTao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianSua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanSua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DaXoa = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Huyen", x => x.IdHuyen);
                });

            migrationBuilder.CreateTable(
                name: "KKTNN_NuocDuoiDat_ChatLuong",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdXa = table.Column<int>(type: "int", nullable: true),
                    IdHuyen = table.Column<int>(type: "int", nullable: true),
                    pHMax = table.Column<double>(type: "float", nullable: true),
                    pHMin = table.Column<double>(type: "float", nullable: true),
                    DoCungMax = table.Column<double>(type: "float", nullable: true),
                    DoCungMin = table.Column<double>(type: "float", nullable: true),
                    NitratMax = table.Column<double>(type: "float", nullable: true),
                    NitratMin = table.Column<double>(type: "float", nullable: true),
                    AmoniMax = table.Column<double>(type: "float", nullable: true),
                    AmoniMin = table.Column<double>(type: "float", nullable: true),
                    SulfatMax = table.Column<double>(type: "float", nullable: true),
                    SulfatMin = table.Column<double>(type: "float", nullable: true),
                    AsenMax = table.Column<double>(type: "float", nullable: true),
                    AsenMin = table.Column<double>(type: "float", nullable: true),
                    DaXoa = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KKTNN_NuocDuoiDat_ChatLuong", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KKTNN_NuocMat_ChatLuong",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdXa = table.Column<int>(type: "int", nullable: true),
                    IdHuyen = table.Column<int>(type: "int", nullable: true),
                    IdTinh = table.Column<int>(type: "int", nullable: true),
                    IdLuuVucSong = table.Column<int>(type: "int", nullable: true),
                    ViTriQuanTrac = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GiaTriWQI = table.Column<double>(type: "float", nullable: true),
                    BOD5Max = table.Column<double>(type: "float", nullable: true),
                    BOD5Min = table.Column<double>(type: "float", nullable: true),
                    CODMax = table.Column<double>(type: "float", nullable: true),
                    CODMin = table.Column<double>(type: "float", nullable: true),
                    DOMax = table.Column<double>(type: "float", nullable: true),
                    DOMin = table.Column<double>(type: "float", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGian = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DaXoa = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KKTNN_NuocMat_ChatLuong", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KKTNN_NuocMat_SoLuong_AoHoDamPha",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NguonNuocKhaiThac = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThuocHeThongSong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DienTichMatNuoc = table.Column<double>(type: "float", nullable: true),
                    DungTichToanBo = table.Column<double>(type: "float", nullable: true),
                    DungTichHuuIch = table.Column<double>(type: "float", nullable: true),
                    Xa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Huyen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MucDich = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianTao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanTao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianSua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanSua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DaXoa = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KKTNN_NuocMat_SoLuong_AoHoDamPha", x => x.Id);
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
                    IdXa = table.Column<int>(type: "int", nullable: true),
                    IdHuyen = table.Column<int>(type: "int", nullable: true),
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
                name: "PhanLoaiHoChuaTheoMDSD",
                columns: table => new
                {
                    MaPhanLoaiHoChuaTheoMDSD = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLoaiHoChua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhanLoaiHoChuaTheoMDSD", x => x.MaPhanLoaiHoChuaTheoMDSD);
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
                name: "QLC_LoaiCT",
                columns: table => new
                {
                    MaLoaiCT = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLoaiCT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KyHieuLoaiCT = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QLC_LoaiCT", x => x.MaLoaiCT);
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
                name: "ThongSoCLNAo",
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
                    Chiorophylla = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_ThongSoCLNAo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ThongSoCLNSong",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    pH = table.Column<double>(type: "float", nullable: true),
                    BOD = table.Column<double>(type: "float", nullable: true),
                    COD = table.Column<double>(type: "float", nullable: true),
                    TOC = table.Column<double>(type: "float", nullable: true),
                    TSS = table.Column<double>(type: "float", nullable: true),
                    DO = table.Column<double>(type: "float", nullable: true),
                    TongPhosphor = table.Column<double>(type: "float", nullable: true),
                    TongNito = table.Column<double>(type: "float", nullable: true),
                    TongColiform = table.Column<double>(type: "float", nullable: true),
                    ColiformChiuNhiet = table.Column<double>(type: "float", nullable: true),
                    Amoni = table.Column<double>(type: "float", nullable: true),
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
                name: "Xa",
                columns: table => new
                {
                    IdXa = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenXa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CapHanhChinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianTao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanTao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianSua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanSua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DaXoa = table.Column<bool>(type: "bit", nullable: true),
                    IdHuyen = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Xa", x => x.IdXa);
                    table.ForeignKey(
                        name: "FK_Xa_Huyen_IdHuyen",
                        column: x => x.IdHuyen,
                        principalTable: "Huyen",
                        principalColumn: "IdHuyen");
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
                name: "KKTNN_NuocMat_TongLuong",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdLuuVucSong = table.Column<int>(type: "int", nullable: true),
                    Nam = table.Column<int>(type: "int", nullable: true),
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
                    table.PrimaryKey("PK_KKTNN_NuocMat_TongLuong", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KKTNN_NuocMat_TongLuong_LuuVucSong_IdLuuVucSong",
                        column: x => x.IdLuuVucSong,
                        principalTable: "LuuVucSong",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Song",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdLuuVuc = table.Column<int>(type: "int", nullable: true),
                    TenSong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XDauSong = table.Column<double>(type: "float", nullable: true),
                    YDauSong = table.Column<double>(type: "float", nullable: true),
                    IdXaDauSong = table.Column<int>(type: "int", nullable: true),
                    IdHuyenDauSong = table.Column<int>(type: "int", nullable: true),
                    XCuoiSong = table.Column<double>(type: "float", nullable: true),
                    YCuoiSong = table.Column<double>(type: "float", nullable: true),
                    IdXaCuoiSong = table.Column<int>(type: "int", nullable: true),
                    IdHuyenCuoiSong = table.Column<int>(type: "int", nullable: true),
                    MaSong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Qtt = table.Column<double>(type: "float", nullable: true),
                    ChuGiai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianTao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanTao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianSua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanSua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DaXoa = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Song", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Song_LuuVucSong_IdLuuVuc",
                        column: x => x.IdLuuVuc,
                        principalTable: "LuuVucSong",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CongTrinhHoChua",
                columns: table => new
                {
                    MaCongTrinhHoChua = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaPhanLoaiHoChuaTheoMDSD = table.Column<int>(type: "int", nullable: true),
                    TenCtHoChua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToaDoX_Hochua = table.Column<double>(type: "float", nullable: true),
                    ToaDoY_Hochua = table.Column<double>(type: "float", nullable: true),
                    DiaDiemCtHoChua = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CongTrinhHoChua", x => x.MaCongTrinhHoChua);
                    table.ForeignKey(
                        name: "FK_CongTrinhHoChua_PhanLoaiHoChuaTheoMDSD_MaPhanLoaiHoChuaTheoMDSD",
                        column: x => x.MaPhanLoaiHoChuaTheoMDSD,
                        principalTable: "PhanLoaiHoChuaTheoMDSD",
                        principalColumn: "MaPhanLoaiHoChuaTheoMDSD");
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
                name: "KKTNN_NuocDuoiDat_SoLuong",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdTangChuaNuoc = table.Column<int>(type: "int", nullable: true),
                    SoLuongGieng = table.Column<int>(type: "int", nullable: true),
                    HmaxKyTruoc = table.Column<double>(type: "float", nullable: true),
                    HmaxBaoCao = table.Column<double>(type: "float", nullable: true),
                    HTBKyTruoc = table.Column<double>(type: "float", nullable: true),
                    HTBBaoCao = table.Column<double>(type: "float", nullable: true),
                    HminKyTruoc = table.Column<double>(type: "float", nullable: true),
                    HminBaoCao = table.Column<double>(type: "float", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DaXoa = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KKTNN_NuocDuoiDat_SoLuong", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KKTNN_NuocDuoiDat_SoLuong_TangChuaNuoc_IdTangChuaNuoc",
                        column: x => x.IdTangChuaNuoc,
                        principalTable: "TangChuaNuoc",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "KKTNN_NuocDuoiDat_TongLuong",
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
                    table.PrimaryKey("PK_KKTNN_NuocDuoiDat_TongLuong", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KKTNN_NuocDuoiDat_TongLuong_TangChuaNuoc_IdTangChuaNuoc",
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
                    MaLoaiCT = table.Column<int>(type: "int", nullable: true),
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
                        name: "FK_QLC_CongTrinh_QLC_LoaiCT_MaLoaiCT",
                        column: x => x.MaLoaiCT,
                        principalTable: "QLC_LoaiCT",
                        principalColumn: "MaLoaiCT");
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
                name: "KKTNN_NuocMua_TongLuong",
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
                    table.PrimaryKey("PK_KKTNN_NuocMua_TongLuong", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KKTNN_NuocMua_TongLuong_Tram_ThongTin_IdTram",
                        column: x => x.IdTram,
                        principalTable: "Tram_ThongTin",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CT_ThongTin",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdLoaiCT = table.Column<int>(type: "int", nullable: true),
                    IdHuyen = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    IdXa = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    IdSong = table.Column<int>(type: "int", nullable: true),
                    IdLuuVuc = table.Column<int>(type: "int", nullable: true),
                    IdTieuLuuVuc = table.Column<int>(type: "int", nullable: true),
                    IdTangChuaNuoc = table.Column<int>(type: "int", nullable: true),
                    TenCT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaCT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ViTriCT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    X = table.Column<double>(type: "float", nullable: true),
                    Y = table.Column<double>(type: "float", nullable: true),
                    CapCT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NamBatDauVanHanh = table.Column<int>(type: "int", nullable: true),
                    NguonNuocKT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MucDichhKT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhuongThucKT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NguonNuocXT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianKT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianHNK = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MucDichHNK = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MucDichhTD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuyMoHNK = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianXD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoLuongGiengKT = table.Column<int>(type: "int", nullable: true),
                    SoLuongGiengQT = table.Column<int>(type: "int", nullable: true),
                    SoDiemXaThai = table.Column<int>(type: "int", nullable: true),
                    SoLuongGieng = table.Column<int>(type: "int", nullable: true),
                    KhoiLuongCacHangMucTD = table.Column<int>(type: "int", nullable: true),
                    QKTThietKe = table.Column<int>(type: "int", nullable: true),
                    QKTThucTe = table.Column<int>(type: "int", nullable: true),
                    ViTriXT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChuThich = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TaiKhoan = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CT_ThongTin_Huyen_IdHuyen",
                        column: x => x.IdHuyen,
                        principalTable: "Huyen",
                        principalColumn: "IdHuyen");
                    table.ForeignKey(
                        name: "FK_CT_ThongTin_TangChuaNuoc_IdTangChuaNuoc",
                        column: x => x.IdTangChuaNuoc,
                        principalTable: "TangChuaNuoc",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CT_ThongTin_Xa_IdXa",
                        column: x => x.IdXa,
                        principalTable: "Xa",
                        principalColumn: "IdXa");
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
                name: "DoanSong",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenDoanSong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdLVSong = table.Column<int>(type: "int", nullable: true),
                    IdSong = table.Column<int>(type: "int", nullable: true),
                    ChieuDai = table.Column<double>(type: "float", nullable: true),
                    DienTichLV = table.Column<double>(type: "float", nullable: true),
                    DiaGioiHanhChinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MucDichSuDung = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XDau = table.Column<double>(type: "float", nullable: true),
                    YDau = table.Column<double>(type: "float", nullable: true),
                    XCuoi = table.Column<double>(type: "float", nullable: true),
                    YCuoi = table.Column<double>(type: "float", nullable: true),
                    Qs = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoanSong", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DoanSong_Song_IdSong",
                        column: x => x.IdSong,
                        principalTable: "Song",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "KKTNN_NuocMat_SoLuong_SongSuoi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdSong = table.Column<int>(type: "int", nullable: true),
                    ChayRa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChieuDai = table.Column<double>(type: "float", nullable: true),
                    ChieuDaiThuocTinh_ThanhPho = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianTao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanTao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianSua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanSua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DaXoa = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KKTNN_NuocMat_SoLuong_SongSuoi", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KKTNN_NuocMat_SoLuong_SongSuoi_Song_IdSong",
                        column: x => x.IdSong,
                        principalTable: "Song",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CacCapBaoDongMucNuocLu",
                columns: table => new
                {
                    MaCacCapBaoDongMucNuocLu = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaCongTrinhHoChua = table.Column<int>(type: "int", nullable: true),
                    TenSong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenTramThuyVan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MucNuocTuongUngVoiCapBaoDong1 = table.Column<double>(type: "float", nullable: true),
                    MucNuocTuongUngVoiCapBaoDong2 = table.Column<double>(type: "float", nullable: true),
                    MucNuocTuongUngVoiCapBaoDong3 = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CacCapBaoDongMucNuocLu", x => x.MaCacCapBaoDongMucNuocLu);
                    table.ForeignKey(
                        name: "FK_CacCapBaoDongMucNuocLu_CongTrinhHoChua_MaCongTrinhHoChua",
                        column: x => x.MaCongTrinhHoChua,
                        principalTable: "CongTrinhHoChua",
                        principalColumn: "MaCongTrinhHoChua");
                });

            migrationBuilder.CreateTable(
                name: "CheDoQuanTracMucNuoc",
                columns: table => new
                {
                    MaCheDoQuanTracMucNuoc = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaCongTrinhHoChua = table.Column<int>(type: "int", nullable: true),
                    CheDoQuanTracMucNuocHoMuaLu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CheDoQuanTracMucNuocHoMuaKiet = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CheDoQuanTracMucNuoc", x => x.MaCheDoQuanTracMucNuoc);
                    table.ForeignKey(
                        name: "FK_CheDoQuanTracMucNuoc_CongTrinhHoChua_MaCongTrinhHoChua",
                        column: x => x.MaCongTrinhHoChua,
                        principalTable: "CongTrinhHoChua",
                        principalColumn: "MaCongTrinhHoChua");
                });

            migrationBuilder.CreateTable(
                name: "CongTrinhQuanTracLuuLuongXaDCTT",
                columns: table => new
                {
                    MaCongTrinhQuanTracLuuLuong = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaCongTrinhHoChua = table.Column<int>(type: "int", nullable: true),
                    TenCtQuanTracXaDuyTriDctt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToaDoX = table.Column<float>(type: "real", nullable: true),
                    ToaDoY = table.Column<float>(type: "real", nullable: true),
                    CapCongTrinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NguonNuocKhaiThac = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GiaTriDcttDoiVoiSongSuoi = table.Column<float>(type: "real", nullable: true),
                    GiaTriDcttHaLuuHoChua = table.Column<float>(type: "real", nullable: true),
                    DiaDiemCongTrinh_Xa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiaDiemCongTrinh_Huyen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhanLoaiHoChuaTheoMDSDMaPhanLoaiHoChuaTheoMDSD = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CongTrinhQuanTracLuuLuongXaDCTT", x => x.MaCongTrinhQuanTracLuuLuong);
                    table.ForeignKey(
                        name: "FK_CongTrinhQuanTracLuuLuongXaDCTT_CongTrinhHoChua_MaCongTrinhHoChua",
                        column: x => x.MaCongTrinhHoChua,
                        principalTable: "CongTrinhHoChua",
                        principalColumn: "MaCongTrinhHoChua");
                    table.ForeignKey(
                        name: "FK_CongTrinhQuanTracLuuLuongXaDCTT_PhanLoaiHoChuaTheoMDSD_PhanLoaiHoChuaTheoMDSDMaPhanLoaiHoChuaTheoMDSD",
                        column: x => x.PhanLoaiHoChuaTheoMDSDMaPhanLoaiHoChuaTheoMDSD,
                        principalTable: "PhanLoaiHoChuaTheoMDSD",
                        principalColumn: "MaPhanLoaiHoChuaTheoMDSD");
                });

            migrationBuilder.CreateTable(
                name: "GiaTriMucNuocQuanTrac",
                columns: table => new
                {
                    MaGiaTriMucNuocQuanTrac = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaCongTrinhHoChua = table.Column<int>(type: "int", nullable: true),
                    MaThongTinCongTrinh = table.Column<int>(type: "int", nullable: true),
                    MucNuocHo = table.Column<double>(type: "float", nullable: true),
                    MucNuocThuongLuu = table.Column<double>(type: "float", nullable: true),
                    MucNuocHaLuu = table.Column<double>(type: "float", nullable: true),
                    ThoiGianQuanTracMucNuoc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GiaTriMucNuocQuanTrac", x => x.MaGiaTriMucNuocQuanTrac);
                    table.ForeignKey(
                        name: "FK_GiaTriMucNuocQuanTrac_CongTrinhHoChua_MaCongTrinhHoChua",
                        column: x => x.MaCongTrinhHoChua,
                        principalTable: "CongTrinhHoChua",
                        principalColumn: "MaCongTrinhHoChua");
                    table.ForeignKey(
                        name: "FK_GiaTriMucNuocQuanTrac_ThongTinCongTrinh_MaThongTinCongTrinh",
                        column: x => x.MaThongTinCongTrinh,
                        principalTable: "ThongTinCongTrinh",
                        principalColumn: "MaThongTinCongTrinh");
                });

            migrationBuilder.CreateTable(
                name: "HangMucDapTran",
                columns: table => new
                {
                    MaHangMucDapTran = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaCongTrinhHoChua = table.Column<int>(type: "int", nullable: true),
                    TenDapTran = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToaDoX_DapTran = table.Column<double>(type: "float", nullable: true),
                    ToaDoY_DapTran = table.Column<double>(type: "float", nullable: true),
                    DiaDienXayDungDapTran_Xa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiaDienXayDungDapTran_Huyen = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HangMucDapTran", x => x.MaHangMucDapTran);
                    table.ForeignKey(
                        name: "FK_HangMucDapTran_CongTrinhHoChua_MaCongTrinhHoChua",
                        column: x => x.MaCongTrinhHoChua,
                        principalTable: "CongTrinhHoChua",
                        principalColumn: "MaCongTrinhHoChua");
                });

            migrationBuilder.CreateTable(
                name: "HangMucNhaMay",
                columns: table => new
                {
                    MaHangMucNhaMay = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaCongTrinhHoChua = table.Column<int>(type: "int", nullable: true),
                    ToaDoX_NhaMay = table.Column<double>(type: "float", nullable: true),
                    ToaDoY_NhaMay = table.Column<double>(type: "float", nullable: true),
                    DiaDiemDatNhaMay_Xa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiaDiemDatNhaMay_Huyen = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HangMucNhaMay", x => x.MaHangMucNhaMay);
                    table.ForeignKey(
                        name: "FK_HangMucNhaMay_CongTrinhHoChua_MaCongTrinhHoChua",
                        column: x => x.MaCongTrinhHoChua,
                        principalTable: "CongTrinhHoChua",
                        principalColumn: "MaCongTrinhHoChua");
                });

            migrationBuilder.CreateTable(
                name: "ThongSoThietKeCuaMucNuoc",
                columns: table => new
                {
                    MaThongSoThietKeCuaMucNuoc = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaCongTrinhHoChua = table.Column<int>(type: "int", nullable: true),
                    MucNuocChet = table.Column<double>(type: "float", nullable: true),
                    MucNuocDangBinhThuong = table.Column<double>(type: "float", nullable: true),
                    MucNuocPhongLu = table.Column<double>(type: "float", nullable: true),
                    MucNuocLuKiemTra = table.Column<double>(type: "float", nullable: true),
                    MucNuocLuThietKe = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThongSoThietKeCuaMucNuoc", x => x.MaThongSoThietKeCuaMucNuoc);
                    table.ForeignKey(
                        name: "FK_ThongSoThietKeCuaMucNuoc_CongTrinhHoChua_MaCongTrinhHoChua",
                        column: x => x.MaCongTrinhHoChua,
                        principalTable: "CongTrinhHoChua",
                        principalColumn: "MaCongTrinhHoChua");
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
                name: "DuLieuQuanTracCuaCTKTNDD",
                columns: table => new
                {
                    MaDuLieuQuanTracCuaCTKTNDD = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaThongTinCongTrinh = table.Column<int>(type: "int", nullable: true),
                    LuuLuongKTGiengKhoan = table.Column<double>(type: "float", nullable: true),
                    MucNuocTrongGiengKT = table.Column<double>(type: "float", nullable: true),
                    MucNuocTrongGiengQT = table.Column<double>(type: "float", nullable: true),
                    TrangThaiVH = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DuLieuQuanTracCuaCTKTNDD", x => x.MaDuLieuQuanTracCuaCTKTNDD);
                    table.ForeignKey(
                        name: "FK_DuLieuQuanTracCuaCTKTNDD_QLC_CongTrinh_MaThongTinCongTrinh",
                        column: x => x.MaThongTinCongTrinh,
                        principalTable: "QLC_CongTrinh",
                        principalColumn: "MaCT");
                });

            migrationBuilder.CreateTable(
                name: "DuLieuQuanTracCuaCTXaThai",
                columns: table => new
                {
                    MaDuLieuQuanTracCongTrinhXaThai = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaThongTinCongTrinh = table.Column<int>(type: "int", nullable: true),
                    LuuLuongNuocThaiSauXuLy = table.Column<double>(type: "float", nullable: true),
                    ChatLuongNuocThaiSauXuLy = table.Column<double>(type: "float", nullable: true),
                    LuuLuongNuocThaiTaiNguonTiepNhan = table.Column<double>(type: "float", nullable: true),
                    TrangThaiVH = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DuLieuQuanTracCuaCTXaThai", x => x.MaDuLieuQuanTracCongTrinhXaThai);
                    table.ForeignKey(
                        name: "FK_DuLieuQuanTracCuaCTXaThai_QLC_CongTrinh_MaThongTinCongTrinh",
                        column: x => x.MaThongTinCongTrinh,
                        principalTable: "QLC_CongTrinh",
                        principalColumn: "MaCT");
                });

            migrationBuilder.CreateTable(
                name: "SoLieuQuanTrac",
                columns: table => new
                {
                    MaSoLieuQuanTrac = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaThongTinCongTrinh = table.Column<int>(type: "int", nullable: true),
                    LuuLuongKTLonNhat = table.Column<double>(type: "float", nullable: true),
                    GiaTriLuuLuongKhaiThac = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SoLieuQuanTrac", x => x.MaSoLieuQuanTrac);
                    table.ForeignKey(
                        name: "FK_SoLieuQuanTrac_QLC_CongTrinh_MaThongTinCongTrinh",
                        column: x => x.MaThongTinCongTrinh,
                        principalTable: "QLC_CongTrinh",
                        principalColumn: "MaCT");
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
                name: "LuuLuongTheoMucDich",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCT = table.Column<int>(type: "int", nullable: true),
                    MucDich = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LuuLuong = table.Column<double>(type: "float", nullable: true),
                    DonViDo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianTao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanTao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianSua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanSua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DaXoa = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LuuLuongTheoMucDich", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LuuLuongTheoMucDich_CT_ThongTin_IdCT",
                        column: x => x.IdCT,
                        principalTable: "CT_ThongTin",
                        principalColumn: "Id");
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
                name: "ThongSoLtd",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdDoanSong = table.Column<int>(type: "int", nullable: true),
                    pHTd = table.Column<double>(type: "float", nullable: true),
                    BODTd = table.Column<double>(type: "float", nullable: true),
                    CODTd = table.Column<double>(type: "float", nullable: true),
                    TSSTd = table.Column<double>(type: "float", nullable: true),
                    TongPTd = table.Column<double>(type: "float", nullable: true),
                    TongNTd = table.Column<double>(type: "float", nullable: true),
                    TongColiformTd = table.Column<double>(type: "float", nullable: true),
                    AmoniTd = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThongSoLtd", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ThongSoLtd_DoanSong_IdDoanSong",
                        column: x => x.IdDoanSong,
                        principalTable: "DoanSong",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CheDoQuanTracLuuLuongDongChayToiThieu",
                columns: table => new
                {
                    MaCheDoQuanTracLuuLuongDongChayToiThieu = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaCongTrinhQuanTracLuuLuong = table.Column<int>(type: "int", nullable: true),
                    QuanTracLuuLuongXaDuyTriDcttVaoMuaLu = table.Column<double>(type: "float", nullable: true),
                    QuanTracLuuLuongXaDuyTriDcttVaoMuaCan = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CheDoQuanTracLuuLuongDongChayToiThieu", x => x.MaCheDoQuanTracLuuLuongDongChayToiThieu);
                    table.ForeignKey(
                        name: "FK_CheDoQuanTracLuuLuongDongChayToiThieu_CongTrinhQuanTracLuuLuongXaDCTT_MaCongTrinhQuanTracLuuLuong",
                        column: x => x.MaCongTrinhQuanTracLuuLuong,
                        principalTable: "CongTrinhQuanTracLuuLuongXaDCTT",
                        principalColumn: "MaCongTrinhQuanTracLuuLuong");
                });

            migrationBuilder.CreateTable(
                name: "ThongTinChatLuongNuoc",
                columns: table => new
                {
                    MaThongTinChatLuongNuoc = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaCongTrinhQuanTracLuuLuong = table.Column<int>(type: "int", nullable: true),
                    NhietDo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ph = table.Column<double>(type: "float", nullable: true),
                    Bod5 = table.Column<double>(type: "float", nullable: true),
                    Cod = table.Column<double>(type: "float", nullable: true),
                    Do = table.Column<double>(type: "float", nullable: true),
                    Nh4 = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThongTinChatLuongNuoc", x => x.MaThongTinChatLuongNuoc);
                    table.ForeignKey(
                        name: "FK_ThongTinChatLuongNuoc_CongTrinhQuanTracLuuLuongXaDCTT_MaCongTrinhQuanTracLuuLuong",
                        column: x => x.MaCongTrinhQuanTracLuuLuong,
                        principalTable: "CongTrinhQuanTracLuuLuongXaDCTT",
                        principalColumn: "MaCongTrinhQuanTracLuuLuong");
                });

            migrationBuilder.CreateTable(
                name: "ThongTinLuuLuongXaCuaCt",
                columns: table => new
                {
                    MaThongTinLuuLuongXaCuaCt = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaCongTrinhQuanTracLuuLuong = table.Column<int>(type: "int", nullable: true),
                    LuuLuongXaLonNhatDuyTriDctt = table.Column<double>(type: "float", nullable: true),
                    LuuLuongXaNhoNhatDuyTriDctt = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThongTinLuuLuongXaCuaCt", x => x.MaThongTinLuuLuongXaCuaCt);
                    table.ForeignKey(
                        name: "FK_ThongTinLuuLuongXaCuaCt_CongTrinhQuanTracLuuLuongXaDCTT_MaCongTrinhQuanTracLuuLuong",
                        column: x => x.MaCongTrinhQuanTracLuuLuong,
                        principalTable: "CongTrinhQuanTracLuuLuongXaDCTT",
                        principalColumn: "MaCongTrinhQuanTracLuuLuong");
                });

            migrationBuilder.CreateTable(
                name: "ThongTinCongTrinhHoChua",
                columns: table => new
                {
                    MaThongTinCongTrinh = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaCongTrinhHoChua = table.Column<int>(type: "int", nullable: true),
                    PhuongThucKhaiThac = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CheDoKhaiThac = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MucDichKhaiThac = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DungTichChetCuaHoChua = table.Column<double>(type: "float", nullable: true),
                    DungTichToanBoHoChua = table.Column<double>(type: "float", nullable: true),
                    DungTichHuuIchCuaHoChua = table.Column<double>(type: "float", nullable: true),
                    GiaTriMucNuocQuanTracMaGiaTriMucNuocQuanTrac = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThongTinCongTrinhHoChua", x => x.MaThongTinCongTrinh);
                    table.ForeignKey(
                        name: "FK_ThongTinCongTrinhHoChua_CongTrinhHoChua_MaCongTrinhHoChua",
                        column: x => x.MaCongTrinhHoChua,
                        principalTable: "CongTrinhHoChua",
                        principalColumn: "MaCongTrinhHoChua");
                    table.ForeignKey(
                        name: "FK_ThongTinCongTrinhHoChua_GiaTriMucNuocQuanTrac_GiaTriMucNuocQuanTracMaGiaTriMucNuocQuanTrac",
                        column: x => x.GiaTriMucNuocQuanTracMaGiaTriMucNuocQuanTrac,
                        principalTable: "GiaTriMucNuocQuanTrac",
                        principalColumn: "MaGiaTriMucNuocQuanTrac");
                });

            migrationBuilder.CreateTable(
                name: "GiaTriQuanTracLuuLuongXaTran",
                columns: table => new
                {
                    MaGiaTriQuanTracLuuLuongXaTran = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaHangMucDapTran = table.Column<int>(type: "int", nullable: true),
                    MucNuocHoChua = table.Column<double>(type: "float", nullable: true),
                    MucNuocThuongLuu = table.Column<double>(type: "float", nullable: true),
                    MucNuocHaLuu = table.Column<double>(type: "float", nullable: true),
                    LuuLuongNuocVeHo = table.Column<double>(type: "float", nullable: true),
                    LuuLuongXaQuaTranLonNhat = table.Column<double>(type: "float", nullable: true),
                    LuuLuongXaQuaTranNhoNhat = table.Column<double>(type: "float", nullable: true),
                    LuuLuongXaQuaTranTrungBinh = table.Column<double>(type: "float", nullable: true),
                    ThoiGianBatDauXaTran = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ThoiGianKetThucXaTran = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GiaTriQuanTracLuuLuongXaTran", x => x.MaGiaTriQuanTracLuuLuongXaTran);
                    table.ForeignKey(
                        name: "FK_GiaTriQuanTracLuuLuongXaTran_HangMucDapTran_MaHangMucDapTran",
                        column: x => x.MaHangMucDapTran,
                        principalTable: "HangMucDapTran",
                        principalColumn: "MaHangMucDapTran");
                });

            migrationBuilder.CreateTable(
                name: "PhanLoaiDapTran",
                columns: table => new
                {
                    MaPhanLoaiDapTran = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaHangMucDapTran = table.Column<int>(type: "int", nullable: true),
                    PhanLoaiTheoHinhDangCuaVao = table.Column<bool>(type: "bit", nullable: true),
                    PhanLoaiTheoHinhDangVaKichThuocMatCatNgangDapTran = table.Column<bool>(type: "bit", nullable: true),
                    PhanLoaiTheoHinhDangTuyenDap = table.Column<bool>(type: "bit", nullable: true),
                    PhanLoaiTheoCheDoChay = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhanLoaiDapTran", x => x.MaPhanLoaiDapTran);
                    table.ForeignKey(
                        name: "FK_PhanLoaiDapTran_HangMucDapTran_MaHangMucDapTran",
                        column: x => x.MaHangMucDapTran,
                        principalTable: "HangMucDapTran",
                        principalColumn: "MaHangMucDapTran");
                });

            migrationBuilder.CreateTable(
                name: "ThongSoDapTran",
                columns: table => new
                {
                    MaThongSoDapTran = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaHangMucDapTran = table.Column<int>(type: "int", nullable: true),
                    MaCongTrinhHoChua = table.Column<int>(type: "int", nullable: true),
                    HinhThucDapTran = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KetCauDap = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CaoTrinhNguongTran = table.Column<double>(type: "float", nullable: true),
                    SoKhoangTran = table.Column<int>(type: "int", nullable: true),
                    ChieuDaiKhoangTran = table.Column<double>(type: "float", nullable: true),
                    ChieuCaoDapTran = table.Column<double>(type: "float", nullable: true),
                    BeRongKhoanTran = table.Column<double>(type: "float", nullable: true),
                    CaoTrinhDinhTran = table.Column<double>(type: "float", nullable: true),
                    CaoDoMuiPhun = table.Column<double>(type: "float", nullable: true),
                    ChieuCaoDapLonNhat = table.Column<double>(type: "float", nullable: true),
                    KhaNangXaTranUngVoiMnlkt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KhaNangXaTranUngVoiMnltk = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThongSoDapTran", x => x.MaThongSoDapTran);
                    table.ForeignKey(
                        name: "FK_ThongSoDapTran_CongTrinhHoChua_MaCongTrinhHoChua",
                        column: x => x.MaCongTrinhHoChua,
                        principalTable: "CongTrinhHoChua",
                        principalColumn: "MaCongTrinhHoChua");
                    table.ForeignKey(
                        name: "FK_ThongSoDapTran_HangMucDapTran_MaHangMucDapTran",
                        column: x => x.MaHangMucDapTran,
                        principalTable: "HangMucDapTran",
                        principalColumn: "MaHangMucDapTran");
                });

            migrationBuilder.CreateTable(
                name: "CheDoGiamSatLuuLuongXaQuaNhaMay",
                columns: table => new
                {
                    MaCheDoGiamSatLuuLuongXaQuaNhaMay = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaHangMucNhaMay = table.Column<int>(type: "int", nullable: true),
                    GiamSatTuDong = table.Column<bool>(type: "bit", nullable: true),
                    GiamSatDinhKy = table.Column<bool>(type: "bit", nullable: true),
                    GiamSatDinhKyMuaLu = table.Column<bool>(type: "bit", nullable: true),
                    GiamSatDinhKyMuaCan = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CheDoGiamSatLuuLuongXaQuaNhaMay", x => x.MaCheDoGiamSatLuuLuongXaQuaNhaMay);
                    table.ForeignKey(
                        name: "FK_CheDoGiamSatLuuLuongXaQuaNhaMay_HangMucNhaMay_MaHangMucNhaMay",
                        column: x => x.MaHangMucNhaMay,
                        principalTable: "HangMucNhaMay",
                        principalColumn: "MaHangMucNhaMay");
                });

            migrationBuilder.CreateTable(
                name: "CheDoQuanTracLuuLuongXaQuaNhaMay",
                columns: table => new
                {
                    MaCheDoQuanTracLuuLuongXaQuaNhaMay = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaHangMucNhaMay = table.Column<int>(type: "int", nullable: true),
                    QuanTracTrongMuaLu = table.Column<int>(type: "int", nullable: true),
                    QuanTracTruocMuaLu = table.Column<int>(type: "int", nullable: true),
                    QuanTracSauMuaLu = table.Column<int>(type: "int", nullable: true),
                    QuanTracTrongMuaCan = table.Column<int>(type: "int", nullable: true),
                    DieuKienThoiTietBinhThuong = table.Column<int>(type: "int", nullable: true),
                    BaoKhanCap = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CheDoQuanTracLuuLuongXaQuaNhaMay", x => x.MaCheDoQuanTracLuuLuongXaQuaNhaMay);
                    table.ForeignKey(
                        name: "FK_CheDoQuanTracLuuLuongXaQuaNhaMay_HangMucNhaMay_MaHangMucNhaMay",
                        column: x => x.MaHangMucNhaMay,
                        principalTable: "HangMucNhaMay",
                        principalColumn: "MaHangMucNhaMay");
                });

            migrationBuilder.CreateTable(
                name: "GiaTriLuuLuongXaQuaNhaMay",
                columns: table => new
                {
                    MaGiaTriLuuLuongXaQuaNhaMay = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaHangMucNhaMay = table.Column<int>(type: "int", nullable: true),
                    MaCongTrinhHoChua = table.Column<int>(type: "int", nullable: true),
                    LuuLuongXaQuaNhaMay = table.Column<double>(type: "float", nullable: true),
                    NgayGhiNhanLuuLuongXaQuaNhaMay = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GioGhiNhanLuuLuongXaQuaNhaMay = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GiaTriLuuLuongXaQuaNhaMay", x => x.MaGiaTriLuuLuongXaQuaNhaMay);
                    table.ForeignKey(
                        name: "FK_GiaTriLuuLuongXaQuaNhaMay_CongTrinhHoChua_MaCongTrinhHoChua",
                        column: x => x.MaCongTrinhHoChua,
                        principalTable: "CongTrinhHoChua",
                        principalColumn: "MaCongTrinhHoChua");
                    table.ForeignKey(
                        name: "FK_GiaTriLuuLuongXaQuaNhaMay_HangMucNhaMay_MaHangMucNhaMay",
                        column: x => x.MaHangMucNhaMay,
                        principalTable: "HangMucNhaMay",
                        principalColumn: "MaHangMucNhaMay");
                });

            migrationBuilder.CreateTable(
                name: "ThongTinNhaMay",
                columns: table => new
                {
                    MaThongTinNhaMay = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaHangMucNhaMay = table.Column<int>(type: "int", nullable: true),
                    LuuLuongLonNhatQuaNhaMay = table.Column<double>(type: "float", nullable: true),
                    SoToMay = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CongSuatMoiToMay = table.Column<double>(type: "float", nullable: true),
                    KichThuocNhaMay = table.Column<double>(type: "float", nullable: true),
                    CaoTrinhSanLapMay = table.Column<double>(type: "float", nullable: true),
                    CaoTrinhSanChongLuNhaMay = table.Column<double>(type: "float", nullable: true),
                    LuuLuongThietKe = table.Column<double>(type: "float", nullable: true),
                    LuuLuongDamBao = table.Column<double>(type: "float", nullable: true),
                    CongSuatDamBao = table.Column<double>(type: "float", nullable: true),
                    CongSuatLapMay = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThongTinNhaMay", x => x.MaThongTinNhaMay);
                    table.ForeignKey(
                        name: "FK_ThongTinNhaMay_HangMucNhaMay_MaHangMucNhaMay",
                        column: x => x.MaHangMucNhaMay,
                        principalTable: "HangMucNhaMay",
                        principalColumn: "MaHangMucNhaMay");
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
                name: "CT_ThongSo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCT = table.Column<int>(type: "int", nullable: true),
                    IdHangMucCT = table.Column<int>(type: "int", nullable: true),
                    CaoTrinhCong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CheDoKT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CaoTrinhDap = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CheDoXT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChieuCaoDap = table.Column<double>(type: "float", nullable: true),
                    ChieuDaiCong = table.Column<double>(type: "float", nullable: true),
                    ChieuDaiDap = table.Column<double>(type: "float", nullable: true),
                    DuongKinhCong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChieuRongDap = table.Column<double>(type: "float", nullable: true),
                    NguongTran = table.Column<double>(type: "float", nullable: true),
                    ChieuSauDoanThuNuocDen = table.Column<double>(type: "float", nullable: true),
                    ChieuSauDoanThuNuocTu = table.Column<double>(type: "float", nullable: true),
                    CongSuatBom = table.Column<double>(type: "float", nullable: true),
                    CongSuatDamBao = table.Column<double>(type: "float", nullable: true),
                    CongSuatLM = table.Column<double>(type: "float", nullable: true),
                    DienTichLuuVuc = table.Column<double>(type: "float", nullable: true),
                    DienTichTuoiThietKe = table.Column<double>(type: "float", nullable: true),
                    DienTichTuoiThucTe = table.Column<double>(type: "float", nullable: true),
                    DungTichChet = table.Column<double>(type: "float", nullable: true),
                    DungTichHuuIch = table.Column<double>(type: "float", nullable: true),
                    DungTichToanBo = table.Column<double>(type: "float", nullable: true),
                    HBeHut = table.Column<double>(type: "float", nullable: true),
                    HDatOngLocDen = table.Column<double>(type: "float", nullable: true),
                    HDatOngLocTu = table.Column<double>(type: "float", nullable: true),
                    HDoanThuNuocDen = table.Column<double>(type: "float", nullable: true),
                    HDoanThuNuocTu = table.Column<double>(type: "float", nullable: true),
                    HDong = table.Column<double>(type: "float", nullable: true),
                    Hgieng = table.Column<double>(type: "float", nullable: true),
                    HGiengKT = table.Column<double>(type: "float", nullable: true),
                    HHaLuu = table.Column<double>(type: "float", nullable: true),
                    HHaThap = table.Column<double>(type: "float", nullable: true),
                    Hlu = table.Column<double>(type: "float", nullable: true),
                    Hmax = table.Column<double>(type: "float", nullable: true),
                    Hmin = table.Column<double>(type: "float", nullable: true),
                    HThuongLuu = table.Column<double>(type: "float", nullable: true),
                    HTinh = table.Column<double>(type: "float", nullable: true),
                    HtoiThieu = table.Column<double>(type: "float", nullable: true),
                    KichThuocCong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KqKf = table.Column<double>(type: "float", nullable: true),
                    LuongNuocKT = table.Column<double>(type: "float", nullable: true),
                    MNC = table.Column<double>(type: "float", nullable: true),
                    MNDBT = table.Column<double>(type: "float", nullable: true),
                    MNLKT = table.Column<double>(type: "float", nullable: true),
                    MNLTK = table.Column<double>(type: "float", nullable: true),
                    MuaTrungBinhNam = table.Column<double>(type: "float", nullable: true),
                    MucNuocDong = table.Column<double>(type: "float", nullable: true),
                    MucNuocTinh = table.Column<double>(type: "float", nullable: true),
                    PhuongThucXT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QBomLonNhat = table.Column<double>(type: "float", nullable: true),
                    QBomThietKe = table.Column<double>(type: "float", nullable: true),
                    QDamBao = table.Column<double>(type: "float", nullable: true),
                    QKhaiThac = table.Column<double>(type: "float", nullable: true),
                    QKTCapNuocSinhHoat = table.Column<double>(type: "float", nullable: true),
                    QKTLonNhat = table.Column<double>(type: "float", nullable: true),
                    QLonNhatTruocLu = table.Column<double>(type: "float", nullable: true),
                    QMaxKT = table.Column<double>(type: "float", nullable: true),
                    QmaxNM = table.Column<double>(type: "float", nullable: true),
                    QMaxXaThai = table.Column<double>(type: "float", nullable: true),
                    QThietKe = table.Column<double>(type: "float", nullable: true),
                    QThucTe = table.Column<double>(type: "float", nullable: true),
                    QTrungBinhNam = table.Column<double>(type: "float", nullable: true),
                    Qtt = table.Column<double>(type: "float", nullable: true),
                    QXaThai = table.Column<double>(type: "float", nullable: true),
                    QXaThaiLonNhat = table.Column<double>(type: "float", nullable: true),
                    QXaThaiTB = table.Column<double>(type: "float", nullable: true),
                    QXaTran = table.Column<double>(type: "float", nullable: true),
                    SoLuongMayBom = table.Column<int>(type: "int", nullable: true),
                    ThoiGianBomLonNhat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianBomNhoNhat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianBomTB = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                name: "GiaTriQuanTracLuuLuongXa",
                columns: table => new
                {
                    MaGiaTriQuanTracLuuLuongXa = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaCongTrinhQuanTracLuuLuong = table.Column<int>(type: "int", nullable: true),
                    MaThongTinChatLuongNuoc = table.Column<int>(type: "int", nullable: true),
                    ThoiGianQuanTracLuuLuongXaDuyTriDctt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TanSuatQuanTracLuuLuongXaDuyTriDctt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ViTriQuanTracLuuLuongDuyTriDctt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LuuLuongXaCuaCongTrinh = table.Column<double>(type: "float", nullable: true),
                    TinhTrang = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MucNuocHoTruocKhiXa = table.Column<double>(type: "float", nullable: true),
                    MucNuocHoSauKhiXa = table.Column<double>(type: "float", nullable: true),
                    MucNuocSong = table.Column<double>(type: "float", nullable: true),
                    DungTichHoHuaIchCuaHoChuaSauKhiXa = table.Column<double>(type: "float", nullable: true),
                    DungTichToanBoHoChuaSauKhiXa = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GiaTriQuanTracLuuLuongXa", x => x.MaGiaTriQuanTracLuuLuongXa);
                    table.ForeignKey(
                        name: "FK_GiaTriQuanTracLuuLuongXa_CongTrinhQuanTracLuuLuongXaDCTT_MaCongTrinhQuanTracLuuLuong",
                        column: x => x.MaCongTrinhQuanTracLuuLuong,
                        principalTable: "CongTrinhQuanTracLuuLuongXaDCTT",
                        principalColumn: "MaCongTrinhQuanTracLuuLuong");
                    table.ForeignKey(
                        name: "FK_GiaTriQuanTracLuuLuongXa_ThongTinChatLuongNuoc_MaThongTinChatLuongNuoc",
                        column: x => x.MaThongTinChatLuongNuoc,
                        principalTable: "ThongTinChatLuongNuoc",
                        principalColumn: "MaThongTinChatLuongNuoc");
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
                name: "IX_CacCapBaoDongMucNuocLu_MaCongTrinhHoChua",
                table: "CacCapBaoDongMucNuocLu",
                column: "MaCongTrinhHoChua",
                unique: true,
                filter: "[MaCongTrinhHoChua] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CheDoGiamSatLuuLuongXaQuaNhaMay_MaHangMucNhaMay",
                table: "CheDoGiamSatLuuLuongXaQuaNhaMay",
                column: "MaHangMucNhaMay",
                unique: true,
                filter: "[MaHangMucNhaMay] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CheDoKhaiThacCongTrinh_MaThongTinCongTrinh",
                table: "CheDoKhaiThacCongTrinh",
                column: "MaThongTinCongTrinh",
                unique: true,
                filter: "[MaThongTinCongTrinh] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CheDoQuanTracLuuLuongDongChayToiThieu_MaCongTrinhQuanTracLuuLuong",
                table: "CheDoQuanTracLuuLuongDongChayToiThieu",
                column: "MaCongTrinhQuanTracLuuLuong",
                unique: true,
                filter: "[MaCongTrinhQuanTracLuuLuong] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CheDoQuanTracLuuLuongXaQuaNhaMay_MaHangMucNhaMay",
                table: "CheDoQuanTracLuuLuongXaQuaNhaMay",
                column: "MaHangMucNhaMay",
                unique: true,
                filter: "[MaHangMucNhaMay] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CheDoQuanTracMucNuoc_MaCongTrinhHoChua",
                table: "CheDoQuanTracMucNuoc",
                column: "MaCongTrinhHoChua",
                unique: true,
                filter: "[MaCongTrinhHoChua] IS NOT NULL");

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
                name: "IX_CongTrinhHoChua_MaPhanLoaiHoChuaTheoMDSD",
                table: "CongTrinhHoChua",
                column: "MaPhanLoaiHoChuaTheoMDSD");

            migrationBuilder.CreateIndex(
                name: "IX_CongTrinhQuanTracLuuLuongXaDCTT_MaCongTrinhHoChua",
                table: "CongTrinhQuanTracLuuLuongXaDCTT",
                column: "MaCongTrinhHoChua");

            migrationBuilder.CreateIndex(
                name: "IX_CongTrinhQuanTracLuuLuongXaDCTT_PhanLoaiHoChuaTheoMDSDMaPhanLoaiHoChuaTheoMDSD",
                table: "CongTrinhQuanTracLuuLuongXaDCTT",
                column: "PhanLoaiHoChuaTheoMDSDMaPhanLoaiHoChuaTheoMDSD");

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
                name: "IX_CT_ThongTin_IdHuyen",
                table: "CT_ThongTin",
                column: "IdHuyen");

            migrationBuilder.CreateIndex(
                name: "IX_CT_ThongTin_IdLoaiCT",
                table: "CT_ThongTin",
                column: "IdLoaiCT");

            migrationBuilder.CreateIndex(
                name: "IX_CT_ThongTin_IdTangChuaNuoc",
                table: "CT_ThongTin",
                column: "IdTangChuaNuoc");

            migrationBuilder.CreateIndex(
                name: "IX_CT_ThongTin_IdXa",
                table: "CT_ThongTin",
                column: "IdXa");

            migrationBuilder.CreateIndex(
                name: "IX_DacTrungSongSuoi_MaSong_Suoi_KenhRach",
                table: "DacTrungSongSuoi",
                column: "MaSong_Suoi_KenhRach");

            migrationBuilder.CreateIndex(
                name: "IX_DoanSong_IdSong",
                table: "DoanSong",
                column: "IdSong");

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
                name: "IX_DuLieuQuanTracCuaCTKTNDD_MaThongTinCongTrinh",
                table: "DuLieuQuanTracCuaCTKTNDD",
                column: "MaThongTinCongTrinh");

            migrationBuilder.CreateIndex(
                name: "IX_DuLieuQuanTracCuaCTXaThai_MaThongTinCongTrinh",
                table: "DuLieuQuanTracCuaCTXaThai",
                column: "MaThongTinCongTrinh");

            migrationBuilder.CreateIndex(
                name: "IX_GiaTriLuuLuongXaQuaNhaMay_MaCongTrinhHoChua",
                table: "GiaTriLuuLuongXaQuaNhaMay",
                column: "MaCongTrinhHoChua",
                unique: true,
                filter: "[MaCongTrinhHoChua] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_GiaTriLuuLuongXaQuaNhaMay_MaHangMucNhaMay",
                table: "GiaTriLuuLuongXaQuaNhaMay",
                column: "MaHangMucNhaMay",
                unique: true,
                filter: "[MaHangMucNhaMay] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_GiaTriMucNuocQuanTrac_MaCongTrinhHoChua",
                table: "GiaTriMucNuocQuanTrac",
                column: "MaCongTrinhHoChua",
                unique: true,
                filter: "[MaCongTrinhHoChua] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_GiaTriMucNuocQuanTrac_MaThongTinCongTrinh",
                table: "GiaTriMucNuocQuanTrac",
                column: "MaThongTinCongTrinh");

            migrationBuilder.CreateIndex(
                name: "IX_GiaTriQuanTracLuuLuongXa_MaCongTrinhQuanTracLuuLuong",
                table: "GiaTriQuanTracLuuLuongXa",
                column: "MaCongTrinhQuanTracLuuLuong",
                unique: true,
                filter: "[MaCongTrinhQuanTracLuuLuong] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_GiaTriQuanTracLuuLuongXa_MaThongTinChatLuongNuoc",
                table: "GiaTriQuanTracLuuLuongXa",
                column: "MaThongTinChatLuongNuoc",
                unique: true,
                filter: "[MaThongTinChatLuongNuoc] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_GiaTriQuanTracLuuLuongXaTran_MaHangMucDapTran",
                table: "GiaTriQuanTracLuuLuongXaTran",
                column: "MaHangMucDapTran",
                unique: true,
                filter: "[MaHangMucDapTran] IS NOT NULL");

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
                name: "IX_HangMucDapTran_MaCongTrinhHoChua",
                table: "HangMucDapTran",
                column: "MaCongTrinhHoChua",
                unique: true,
                filter: "[MaCongTrinhHoChua] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_HangMucNhaMay_MaCongTrinhHoChua",
                table: "HangMucNhaMay",
                column: "MaCongTrinhHoChua",
                unique: true,
                filter: "[MaCongTrinhHoChua] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_KKTNN_NuocDuoiDat_SoLuong_IdTangChuaNuoc",
                table: "KKTNN_NuocDuoiDat_SoLuong",
                column: "IdTangChuaNuoc");

            migrationBuilder.CreateIndex(
                name: "IX_KKTNN_NuocDuoiDat_TongLuong_IdTangChuaNuoc",
                table: "KKTNN_NuocDuoiDat_TongLuong",
                column: "IdTangChuaNuoc");

            migrationBuilder.CreateIndex(
                name: "IX_KKTNN_NuocMat_SoLuong_SongSuoi_IdSong",
                table: "KKTNN_NuocMat_SoLuong_SongSuoi",
                column: "IdSong");

            migrationBuilder.CreateIndex(
                name: "IX_KKTNN_NuocMat_TongLuong_IdLuuVucSong",
                table: "KKTNN_NuocMat_TongLuong",
                column: "IdLuuVucSong");

            migrationBuilder.CreateIndex(
                name: "IX_KKTNN_NuocMua_TongLuong_IdTram",
                table: "KKTNN_NuocMua_TongLuong",
                column: "IdTram");

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
                name: "IX_LuuLuongTheoMucDich_IdCT",
                table: "LuuLuongTheoMucDich",
                column: "IdCT");

            migrationBuilder.CreateIndex(
                name: "IX_PhanCapCongTrinhCong_MaThongTinCongTrinh",
                table: "PhanCapCongTrinhCong",
                column: "MaThongTinCongTrinh",
                unique: true,
                filter: "[MaThongTinCongTrinh] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_PhanLoaiDapTran_MaHangMucDapTran",
                table: "PhanLoaiDapTran",
                column: "MaHangMucDapTran",
                unique: true,
                filter: "[MaHangMucDapTran] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_QLC_CongTrinh_MaLoaiCT",
                table: "QLC_CongTrinh",
                column: "MaLoaiCT");

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
                name: "IX_SoLieuQuanTrac_MaThongTinCongTrinh",
                table: "SoLieuQuanTrac",
                column: "MaThongTinCongTrinh");

            migrationBuilder.CreateIndex(
                name: "IX_SoLuongNDD_MaTangChuaNuoc",
                table: "SoLuongNDD",
                column: "MaTangChuaNuoc",
                unique: true,
                filter: "[MaTangChuaNuoc] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Song_IdLuuVuc",
                table: "Song",
                column: "IdLuuVuc");

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
                name: "IX_ThongSoDapTran_MaCongTrinhHoChua",
                table: "ThongSoDapTran",
                column: "MaCongTrinhHoChua",
                unique: true,
                filter: "[MaCongTrinhHoChua] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ThongSoDapTran_MaHangMucDapTran",
                table: "ThongSoDapTran",
                column: "MaHangMucDapTran",
                unique: true,
                filter: "[MaHangMucDapTran] IS NOT NULL");

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
                name: "IX_ThongSoLtd_IdDoanSong",
                table: "ThongSoLtd",
                column: "IdDoanSong",
                unique: true,
                filter: "[IdDoanSong] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ThongSoThietKeCuaMucNuoc_MaCongTrinhHoChua",
                table: "ThongSoThietKeCuaMucNuoc",
                column: "MaCongTrinhHoChua",
                unique: true,
                filter: "[MaCongTrinhHoChua] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ThongSoVanHanhThucTe_MaThongTinCongTrinh",
                table: "ThongSoVanHanhThucTe",
                column: "MaThongTinCongTrinh");

            migrationBuilder.CreateIndex(
                name: "IX_ThongTinChatLuongNuoc_MaCongTrinhQuanTracLuuLuong",
                table: "ThongTinChatLuongNuoc",
                column: "MaCongTrinhQuanTracLuuLuong",
                unique: true,
                filter: "[MaCongTrinhQuanTracLuuLuong] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ThongTinCongTrinhHoChua_GiaTriMucNuocQuanTracMaGiaTriMucNuocQuanTrac",
                table: "ThongTinCongTrinhHoChua",
                column: "GiaTriMucNuocQuanTracMaGiaTriMucNuocQuanTrac");

            migrationBuilder.CreateIndex(
                name: "IX_ThongTinCongTrinhHoChua_MaCongTrinhHoChua",
                table: "ThongTinCongTrinhHoChua",
                column: "MaCongTrinhHoChua",
                unique: true,
                filter: "[MaCongTrinhHoChua] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ThongTinKetNoi_MaCt",
                table: "ThongTinKetNoi",
                column: "MaCt",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ThongTinLuuLuongXaCuaCt_MaCongTrinhQuanTracLuuLuong",
                table: "ThongTinLuuLuongXaCuaCt",
                column: "MaCongTrinhQuanTracLuuLuong",
                unique: true,
                filter: "[MaCongTrinhQuanTracLuuLuong] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ThongTinNhaMay_MaHangMucNhaMay",
                table: "ThongTinNhaMay",
                column: "MaHangMucNhaMay",
                unique: true,
                filter: "[MaHangMucNhaMay] IS NOT NULL");

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

            migrationBuilder.CreateIndex(
                name: "IX_Xa_IdHuyen",
                table: "Xa",
                column: "IdHuyen");

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
                name: "CacCapBaoDongMucNuocLu");

            migrationBuilder.DropTable(
                name: "CheDoGiamSatLuuLuongXaQuaNhaMay");

            migrationBuilder.DropTable(
                name: "CheDoKhaiThacCongTrinh");

            migrationBuilder.DropTable(
                name: "CheDoQuanTracLuuLuongDongChayToiThieu");

            migrationBuilder.DropTable(
                name: "CheDoQuanTracLuuLuongXaQuaNhaMay");

            migrationBuilder.DropTable(
                name: "CheDoQuanTracMucNuoc");

            migrationBuilder.DropTable(
                name: "ChuyenVien");

            migrationBuilder.DropTable(
                name: "CLNMatTheoWQI");

            migrationBuilder.DropTable(
                name: "CT_ThongSo");

            migrationBuilder.DropTable(
                name: "Dashboards");

            migrationBuilder.DropTable(
                name: "DMSS_AoHo");

            migrationBuilder.DropTable(
                name: "DMSS_DiemCuoiSongSuoi");

            migrationBuilder.DropTable(
                name: "DMSS_DiemDauSongSuoi");

            migrationBuilder.DropTable(
                name: "DMSS_SongSuoiNoiTinh");

            migrationBuilder.DropTable(
                name: "DonViHC");

            migrationBuilder.DropTable(
                name: "DuLieuKetNoi");

            migrationBuilder.DropTable(
                name: "DuLieuQuanTracCuaCTKTNDD");

            migrationBuilder.DropTable(
                name: "DuLieuQuanTracCuaCTXaThai");

            migrationBuilder.DropTable(
                name: "Functions");

            migrationBuilder.DropTable(
                name: "GiaTriLuuLuongXaQuaNhaMay");

            migrationBuilder.DropTable(
                name: "GiaTriQuanTracLuuLuongXa");

            migrationBuilder.DropTable(
                name: "GiaTriQuanTracLuuLuongXaTran");

            migrationBuilder.DropTable(
                name: "GP_TCQ");

            migrationBuilder.DropTable(
                name: "GS_DuLieu");

            migrationBuilder.DropTable(
                name: "GS_TaiKhoanTruyen");

            migrationBuilder.DropTable(
                name: "HSKTCT_FilePDFHSKTCongTrinh");

            migrationBuilder.DropTable(
                name: "HSKTCT_LoaiHSKTCongTrinh");

            migrationBuilder.DropTable(
                name: "HSKTCT_ThongTinTaiLieuHSKTTram");

            migrationBuilder.DropTable(
                name: "HSKTCT_ToChucThucHienQuanTrac");

            migrationBuilder.DropTable(
                name: "KKTNN_NuocDuoiDat_ChatLuong");

            migrationBuilder.DropTable(
                name: "KKTNN_NuocDuoiDat_SoLuong");

            migrationBuilder.DropTable(
                name: "KKTNN_NuocDuoiDat_TongLuong");

            migrationBuilder.DropTable(
                name: "KKTNN_NuocMat_ChatLuong");

            migrationBuilder.DropTable(
                name: "KKTNN_NuocMat_SoLuong_AoHoDamPha");

            migrationBuilder.DropTable(
                name: "KKTNN_NuocMat_SoLuong_SongSuoi");

            migrationBuilder.DropTable(
                name: "KKTNN_NuocMat_TongLuong");

            migrationBuilder.DropTable(
                name: "KKTNN_NuocMua_TongLuong");

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
                name: "LichSuKetNoi");

            migrationBuilder.DropTable(
                name: "LuuLuongTheoMucDich");

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
                name: "Permissions");

            migrationBuilder.DropTable(
                name: "PhanCapCongTrinhCong");

            migrationBuilder.DropTable(
                name: "PhanLoaiDapTran");

            migrationBuilder.DropTable(
                name: "RoleDashboards");

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
                name: "SoLieuQuanTrac");

            migrationBuilder.DropTable(
                name: "SoLuongNDD");

            migrationBuilder.DropTable(
                name: "ThoiGianVanHanhCongTrinh");

            migrationBuilder.DropTable(
                name: "ThongSoCLNAo");

            migrationBuilder.DropTable(
                name: "ThongSoCLNSong");

            migrationBuilder.DropTable(
                name: "ThongSoDapTran");

            migrationBuilder.DropTable(
                name: "ThongSoKyThuatCongTrinh");

            migrationBuilder.DropTable(
                name: "ThongSoLtd");

            migrationBuilder.DropTable(
                name: "ThongSoThietKeCuaMucNuoc");

            migrationBuilder.DropTable(
                name: "ThongTinCongTrinhHoChua");

            migrationBuilder.DropTable(
                name: "ThongTinKetNoi");

            migrationBuilder.DropTable(
                name: "ThongTinLuuLuongXaCuaCt");

            migrationBuilder.DropTable(
                name: "ThongTinNhaMay");

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
                name: "TT_Huyen");

            migrationBuilder.DropTable(
                name: "TT_ThongTinTieuVung");

            migrationBuilder.DropTable(
                name: "TT_TieuVungTNN");

            migrationBuilder.DropTable(
                name: "TT_Xa");

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
                name: "ThongTinChatLuongNuoc");

            migrationBuilder.DropTable(
                name: "GP_ThongTin");

            migrationBuilder.DropTable(
                name: "TCQ_ThongTin");

            migrationBuilder.DropTable(
                name: "Tram_ThongTin");

            migrationBuilder.DropTable(
                name: "TaiKhoanKetNoi");

            migrationBuilder.DropTable(
                name: "HangMucDapTran");

            migrationBuilder.DropTable(
                name: "ThongSoVanHanhThucTe");

            migrationBuilder.DropTable(
                name: "DoanSong");

            migrationBuilder.DropTable(
                name: "GiaTriMucNuocQuanTrac");

            migrationBuilder.DropTable(
                name: "HangMucNhaMay");

            migrationBuilder.DropTable(
                name: "ThongTinVeCacChiTieuPhanTichCLN");

            migrationBuilder.DropTable(
                name: "SoLieuMua");

            migrationBuilder.DropTable(
                name: "CongTrinhQuanTracLuuLuongXaDCTT");

            migrationBuilder.DropTable(
                name: "CT_ThongTin");

            migrationBuilder.DropTable(
                name: "GP_Loai");

            migrationBuilder.DropTable(
                name: "ToChuc_CaNhan");

            migrationBuilder.DropTable(
                name: "TrangThaiTaiKhoan");

            migrationBuilder.DropTable(
                name: "Song");

            migrationBuilder.DropTable(
                name: "ThongTinCongTrinh");

            migrationBuilder.DropTable(
                name: "PhuongPhapTinhMua");

            migrationBuilder.DropTable(
                name: "TramQuanTracLuongMua");

            migrationBuilder.DropTable(
                name: "CongTrinhHoChua");

            migrationBuilder.DropTable(
                name: "CT_Loai");

            migrationBuilder.DropTable(
                name: "TangChuaNuoc");

            migrationBuilder.DropTable(
                name: "Xa");

            migrationBuilder.DropTable(
                name: "QLC_CongTrinh");

            migrationBuilder.DropTable(
                name: "LuuVucSong");

            migrationBuilder.DropTable(
                name: "LoaiTramQuanTracLuongMua");

            migrationBuilder.DropTable(
                name: "PhanLoaiHoChuaTheoMDSD");

            migrationBuilder.DropTable(
                name: "Huyen");

            migrationBuilder.DropTable(
                name: "QLC_LoaiCT");

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
