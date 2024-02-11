using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace new_wr_api.Migrations
{
    /// <inheritdoc />
    public partial class InitialzeDatabase : Migration
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
                name: "DonViDo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DonViDo", x => x.Id);
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
                name: "MucDichKT",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MucDich = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianTao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanTao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianSua = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaiKhoanSua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DaXoa = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MucDichKT", x => x.Id);
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
                    TenLoaiTram = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaLoaiTram = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    IdMucDichKT = table.Column<int>(type: "int", nullable: true),
                    TenCT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaCT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ViTriCT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    X = table.Column<double>(type: "float", nullable: true),
                    Y = table.Column<double>(type: "float", nullable: true),
                    CapCT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NamBatDauVanHanh = table.Column<int>(type: "int", nullable: true),
                    NguonNuocKT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhuongThucKT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NguonNuocXT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianKT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianHNK = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MucDichKT = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                        name: "FK_CT_ThongTin_MucDichKT_IdMucDichKT",
                        column: x => x.IdMucDichKT,
                        principalTable: "MucDichKT",
                        principalColumn: "Id");
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
                name: "Tram_ThongTin",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdXa = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    IdHuyen = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    IdLoaiTram = table.Column<int>(type: "int", nullable: true),
                    MaTram = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenTram = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiaChiTram = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    X = table.Column<double>(type: "float", nullable: true),
                    Y = table.Column<double>(type: "float", nullable: true),
                    NgayBatDau = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgayKetThuc = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.ForeignKey(
                        name: "FK_Tram_ThongTin_Huyen_IdHuyen",
                        column: x => x.IdHuyen,
                        principalTable: "Huyen",
                        principalColumn: "IdHuyen");
                    table.ForeignKey(
                        name: "FK_Tram_ThongTin_Tram_LoaiTram_IdLoaiTram",
                        column: x => x.IdLoaiTram,
                        principalTable: "Tram_LoaiTram",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Tram_ThongTin_Xa_IdXa",
                        column: x => x.IdXa,
                        principalTable: "Xa",
                        principalColumn: "IdXa");
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
                    IdMucDich = table.Column<int>(type: "int", nullable: true),
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
                    table.ForeignKey(
                        name: "FK_LuuLuongTheoMucDich_MucDichKT_IdMucDich",
                        column: x => x.IdMucDich,
                        principalTable: "MucDichKT",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "KKTNN_NuocMua_TongLuong",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdTram = table.Column<int>(type: "int", nullable: true),
                    Nam = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                name: "IX_CT_ThongTin_IdMucDichKT",
                table: "CT_ThongTin",
                column: "IdMucDichKT");

            migrationBuilder.CreateIndex(
                name: "IX_CT_ThongTin_IdTangChuaNuoc",
                table: "CT_ThongTin",
                column: "IdTangChuaNuoc");

            migrationBuilder.CreateIndex(
                name: "IX_CT_ThongTin_IdXa",
                table: "CT_ThongTin",
                column: "IdXa");

            migrationBuilder.CreateIndex(
                name: "IX_DoanSong_IdSong",
                table: "DoanSong",
                column: "IdSong");

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
                name: "IX_LuuLuongTheoMucDich_IdCT",
                table: "LuuLuongTheoMucDich",
                column: "IdCT");

            migrationBuilder.CreateIndex(
                name: "IX_LuuLuongTheoMucDich_IdMucDich",
                table: "LuuLuongTheoMucDich",
                column: "IdMucDich");

            migrationBuilder.CreateIndex(
                name: "IX_Song_IdLuuVuc",
                table: "Song",
                column: "IdLuuVuc");

            migrationBuilder.CreateIndex(
                name: "IX_ThongSoLtd_IdDoanSong",
                table: "ThongSoLtd",
                column: "IdDoanSong",
                unique: true,
                filter: "[IdDoanSong] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Tram_ThongTin_IdHuyen",
                table: "Tram_ThongTin",
                column: "IdHuyen");

            migrationBuilder.CreateIndex(
                name: "IX_Tram_ThongTin_IdLoaiTram",
                table: "Tram_ThongTin",
                column: "IdLoaiTram");

            migrationBuilder.CreateIndex(
                name: "IX_Tram_ThongTin_IdXa",
                table: "Tram_ThongTin",
                column: "IdXa");

            migrationBuilder.CreateIndex(
                name: "IX_Xa_IdHuyen",
                table: "Xa",
                column: "IdHuyen");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                name: "CT_ThongSo");

            migrationBuilder.DropTable(
                name: "Dashboards");

            migrationBuilder.DropTable(
                name: "DonViDo");

            migrationBuilder.DropTable(
                name: "DonViHC");

            migrationBuilder.DropTable(
                name: "Functions");

            migrationBuilder.DropTable(
                name: "GP_TCQ");

            migrationBuilder.DropTable(
                name: "GS_DuLieu");

            migrationBuilder.DropTable(
                name: "GS_TaiKhoanTruyen");

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
                name: "LuuLuongTheoMucDich");

            migrationBuilder.DropTable(
                name: "Permissions");

            migrationBuilder.DropTable(
                name: "RoleDashboards");

            migrationBuilder.DropTable(
                name: "ThongSoCLNAo");

            migrationBuilder.DropTable(
                name: "ThongSoCLNSong");

            migrationBuilder.DropTable(
                name: "ThongSoLtd");

            migrationBuilder.DropTable(
                name: "TieuVungLuuVuc");

            migrationBuilder.DropTable(
                name: "UserDashboards");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "CT_HangMuc");

            migrationBuilder.DropTable(
                name: "GP_ThongTin");

            migrationBuilder.DropTable(
                name: "TCQ_ThongTin");

            migrationBuilder.DropTable(
                name: "Tram_ThongTin");

            migrationBuilder.DropTable(
                name: "DoanSong");

            migrationBuilder.DropTable(
                name: "CT_ThongTin");

            migrationBuilder.DropTable(
                name: "GP_Loai");

            migrationBuilder.DropTable(
                name: "ToChuc_CaNhan");

            migrationBuilder.DropTable(
                name: "Tram_LoaiTram");

            migrationBuilder.DropTable(
                name: "Song");

            migrationBuilder.DropTable(
                name: "CT_Loai");

            migrationBuilder.DropTable(
                name: "MucDichKT");

            migrationBuilder.DropTable(
                name: "TangChuaNuoc");

            migrationBuilder.DropTable(
                name: "Xa");

            migrationBuilder.DropTable(
                name: "LuuVucSong");

            migrationBuilder.DropTable(
                name: "Huyen");
        }
    }
}
