using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace new_wr_api.Migrations
{
    /// <inheritdoc />
    public partial class table_LuuLuongTheoMucDich2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LuuLuongTheoMucDich_CT_ThongTinDto_congtrinhId",
                table: "LuuLuongTheoMucDich");

            migrationBuilder.DropForeignKey(
                name: "FK_LuuLuongTheoMucDich_CT_ThongTin_CT_ThongTinId",
                table: "LuuLuongTheoMucDich");

            migrationBuilder.DropTable(
                name: "CT_HangMucDto");

            migrationBuilder.DropTable(
                name: "GP_TCQDto");

            migrationBuilder.DropTable(
                name: "GP_ThongTinDtoTCQ_ThongTinDto");

            migrationBuilder.DropTable(
                name: "GP_ThongTinDto");

            migrationBuilder.DropTable(
                name: "CT_ThongTinDto");

            migrationBuilder.DropTable(
                name: "GP_LoaiDto");

            migrationBuilder.DropTable(
                name: "TangChuaNuocDto");

            migrationBuilder.DropTable(
                name: "ToChuc_CaNhanDto");

            migrationBuilder.DropTable(
                name: "CT_LoaiDto");

            migrationBuilder.DropTable(
                name: "CT_ThongSoDto");

            migrationBuilder.DropTable(
                name: "DonViHCDto");

            migrationBuilder.DropTable(
                name: "TCQ_ThongTinDto");

            migrationBuilder.DropIndex(
                name: "IX_LuuLuongTheoMucDich_congtrinhId",
                table: "LuuLuongTheoMucDich");

            migrationBuilder.DropIndex(
                name: "IX_LuuLuongTheoMucDich_CT_ThongTinId",
                table: "LuuLuongTheoMucDich");

            migrationBuilder.DropColumn(
                name: "CT_ThongTinId",
                table: "LuuLuongTheoMucDich");

            migrationBuilder.DropColumn(
                name: "congtrinhId",
                table: "LuuLuongTheoMucDich");

            migrationBuilder.CreateIndex(
                name: "IX_LuuLuongTheoMucDich_IdCT",
                table: "LuuLuongTheoMucDich",
                column: "IdCT");

            migrationBuilder.AddForeignKey(
                name: "FK_LuuLuongTheoMucDich_CT_ThongTin_IdCT",
                table: "LuuLuongTheoMucDich",
                column: "IdCT",
                principalTable: "CT_ThongTin",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LuuLuongTheoMucDich_CT_ThongTin_IdCT",
                table: "LuuLuongTheoMucDich");

            migrationBuilder.DropIndex(
                name: "IX_LuuLuongTheoMucDich_IdCT",
                table: "LuuLuongTheoMucDich");

            migrationBuilder.AddColumn<int>(
                name: "CT_ThongTinId",
                table: "LuuLuongTheoMucDich",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "congtrinhId",
                table: "LuuLuongTheoMucDich",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CT_LoaiDto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChuThich = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DaXoa = table.Column<bool>(type: "bit", nullable: true),
                    IdCha = table.Column<int>(type: "int", nullable: true),
                    MaLoaiCT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenLoaiCT = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CT_LoaiDto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CT_ThongSoDto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CaoTrinhCong = table.Column<double>(type: "float", nullable: true),
                    CaoTrinhDap = table.Column<double>(type: "float", nullable: true),
                    ChieuCaoDap = table.Column<double>(type: "float", nullable: true),
                    ChieuDaiCong = table.Column<double>(type: "float", nullable: true),
                    ChieuDaiDap = table.Column<double>(type: "float", nullable: true),
                    ChieuRongCong = table.Column<double>(type: "float", nullable: true),
                    ChieuSauDoanThuNuocDen = table.Column<double>(type: "float", nullable: true),
                    ChieuSauDoanThuNuocTu = table.Column<double>(type: "float", nullable: true),
                    CongSuatBom = table.Column<double>(type: "float", nullable: true),
                    CongSuatDamBao = table.Column<double>(type: "float", nullable: true),
                    CongSuatLM = table.Column<double>(type: "float", nullable: true),
                    DaXoa = table.Column<bool>(type: "bit", nullable: true),
                    DienTichLuuVuc = table.Column<double>(type: "float", nullable: true),
                    DienTichTuoiThietKe = table.Column<double>(type: "float", nullable: true),
                    DienTichTuoiThucTe = table.Column<double>(type: "float", nullable: true),
                    DungTichChet = table.Column<double>(type: "float", nullable: true),
                    DungTichHuuIch = table.Column<double>(type: "float", nullable: true),
                    DungTichToanBo = table.Column<double>(type: "float", nullable: true),
                    HBeHut = table.Column<double>(type: "float", nullable: true),
                    HDatOngLocDen = table.Column<double>(type: "float", nullable: true),
                    HDatOngLocTu = table.Column<double>(type: "float", nullable: true),
                    HGiengKT = table.Column<double>(type: "float", nullable: true),
                    HHaLuu = table.Column<double>(type: "float", nullable: true),
                    HHaThap = table.Column<double>(type: "float", nullable: true),
                    HThuongLuu = table.Column<double>(type: "float", nullable: true),
                    Hgieng = table.Column<double>(type: "float", nullable: true),
                    Hlu = table.Column<double>(type: "float", nullable: true),
                    Hmax = table.Column<double>(type: "float", nullable: true),
                    Hmin = table.Column<double>(type: "float", nullable: true),
                    HtoiThieu = table.Column<double>(type: "float", nullable: true),
                    IdCT = table.Column<int>(type: "int", nullable: true),
                    IdHangMucCT = table.Column<int>(type: "int", nullable: true),
                    KichThuocCong = table.Column<double>(type: "float", nullable: true),
                    KqKf = table.Column<double>(type: "float", nullable: true),
                    LuongNuocKT = table.Column<double>(type: "float", nullable: true),
                    MNC = table.Column<double>(type: "float", nullable: true),
                    MNDBT = table.Column<double>(type: "float", nullable: true),
                    MNLKT = table.Column<double>(type: "float", nullable: true),
                    MNLTK = table.Column<double>(type: "float", nullable: true),
                    MuaTrungBinhNam = table.Column<double>(type: "float", nullable: true),
                    MucNuocDong = table.Column<double>(type: "float", nullable: true),
                    MucNuocTinh = table.Column<double>(type: "float", nullable: true),
                    QBomLonNhat = table.Column<double>(type: "float", nullable: true),
                    QBomThietKe = table.Column<double>(type: "float", nullable: true),
                    QDamBao = table.Column<double>(type: "float", nullable: true),
                    QKTCapNuocSinhHoat = table.Column<double>(type: "float", nullable: true),
                    QKTLonNhat = table.Column<double>(type: "float", nullable: true),
                    QKhaiThac = table.Column<double>(type: "float", nullable: true),
                    QLonNhatTruocLu = table.Column<double>(type: "float", nullable: true),
                    QMaxKT = table.Column<double>(type: "float", nullable: true),
                    QMaxXaThai = table.Column<double>(type: "float", nullable: true),
                    QThietKe = table.Column<double>(type: "float", nullable: true),
                    QThucTe = table.Column<double>(type: "float", nullable: true),
                    QTrungBinhNam = table.Column<double>(type: "float", nullable: true),
                    QXaThai = table.Column<double>(type: "float", nullable: true),
                    QXaThaiLonNhat = table.Column<double>(type: "float", nullable: true),
                    QXaThaiTB = table.Column<double>(type: "float", nullable: true),
                    QXaTran = table.Column<double>(type: "float", nullable: true),
                    QmaxNM = table.Column<double>(type: "float", nullable: true),
                    Qtt = table.Column<double>(type: "float", nullable: true),
                    SoLuongMayBom = table.Column<double>(type: "float", nullable: true),
                    TangChuaNuocKT = table.Column<double>(type: "float", nullable: true),
                    ThoiGianBomLonNhat = table.Column<double>(type: "float", nullable: true),
                    ThoiGianBomNhoNhat = table.Column<double>(type: "float", nullable: true),
                    ThoiGianBomTB = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CT_ThongSoDto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DonViHCDto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CapHanhChinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DaXoa = table.Column<bool>(type: "bit", nullable: true),
                    IdHuyen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdTinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdXa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenHuyen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenTinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenXa = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DonViHCDto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GP_LoaiDto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DaXoa = table.Column<bool>(type: "bit", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaLoaiGP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenLoaiGP = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GP_LoaiDto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TangChuaNuocDto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DaXoa = table.Column<bool>(type: "bit", nullable: true),
                    KyHieuTCN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenTCN = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TangChuaNuocDto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TCQ_ThongTinDto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    qd_bosungId = table.Column<int>(type: "int", nullable: true),
                    CoQuanCP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DaXoa = table.Column<bool>(type: "bit", nullable: true),
                    FilePDF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdCon = table.Column<int>(type: "int", nullable: true),
                    NgayKy = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SoQDTCQ = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TongTienCQ = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TCQ_ThongTinDto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TCQ_ThongTinDto_TCQ_ThongTinDto_qd_bosungId",
                        column: x => x.qd_bosungId,
                        principalTable: "TCQ_ThongTinDto",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ToChuc_CaNhanDto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DaXoa = table.Column<bool>(type: "bit", nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fax = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GiamDoc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaSoThue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NguoiDaiDienPhapLuat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NguoiDuocUyQuyen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SDT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TaiKhoan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenTCCN = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToChuc_CaNhanDto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CT_ThongTinDto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    donvi_hanhchinhId = table.Column<int>(type: "int", nullable: true),
                    loaiCTId = table.Column<int>(type: "int", nullable: true),
                    thongsoId = table.Column<int>(type: "int", nullable: true),
                    CHeDoXT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CapCT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CheDoKT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChuThich = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DaXoa = table.Column<bool>(type: "bit", nullable: true),
                    IdHuyen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdLoaiCT = table.Column<int>(type: "int", nullable: true),
                    IdLuuVuc = table.Column<int>(type: "int", nullable: true),
                    IdSong = table.Column<int>(type: "int", nullable: true),
                    IdTangChuaNuoc = table.Column<int>(type: "int", nullable: true),
                    IdTieuLuuVuc = table.Column<int>(type: "int", nullable: true),
                    IdXa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KhoiLuongCacHangMucTD = table.Column<int>(type: "int", nullable: true),
                    MaCT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MucDichHNK = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MucDichhKT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MucDichhTD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NamBatDauVanHanh = table.Column<int>(type: "int", nullable: true),
                    NguonNuocKT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NguonNuocXT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhuongThucKT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhuongThucXT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QKTThietKe = table.Column<int>(type: "int", nullable: true),
                    QKTThucTe = table.Column<int>(type: "int", nullable: true),
                    QuyMoHNK = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoLuongGieng = table.Column<int>(type: "int", nullable: true),
                    SoLuongGiengKT = table.Column<int>(type: "int", nullable: true),
                    SoLuongGiengQT = table.Column<int>(type: "int", nullable: true),
                    TCQ_ThongTinDtoId = table.Column<int>(type: "int", nullable: true),
                    TaiKhoan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenCT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianHNK = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianKT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianXD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ViTriCT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ViTriXT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    X = table.Column<double>(type: "float", nullable: true),
                    Y = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CT_ThongTinDto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CT_ThongTinDto_CT_LoaiDto_loaiCTId",
                        column: x => x.loaiCTId,
                        principalTable: "CT_LoaiDto",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CT_ThongTinDto_CT_ThongSoDto_thongsoId",
                        column: x => x.thongsoId,
                        principalTable: "CT_ThongSoDto",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CT_ThongTinDto_DonViHCDto_donvi_hanhchinhId",
                        column: x => x.donvi_hanhchinhId,
                        principalTable: "DonViHCDto",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CT_ThongTinDto_TCQ_ThongTinDto_TCQ_ThongTinDtoId",
                        column: x => x.TCQ_ThongTinDtoId,
                        principalTable: "TCQ_ThongTinDto",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CT_HangMucDto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    thongsoId = table.Column<int>(type: "int", nullable: true),
                    CT_ThongTinDtoId = table.Column<int>(type: "int", nullable: true),
                    ChuThich = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DaXoa = table.Column<bool>(type: "bit", nullable: true),
                    IdCT = table.Column<int>(type: "int", nullable: true),
                    IdTangChuaNuoc = table.Column<int>(type: "int", nullable: true),
                    TenHangMuc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VịTriHangMuc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    X = table.Column<double>(type: "float", nullable: true),
                    Y = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CT_HangMucDto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CT_HangMucDto_CT_ThongSoDto_thongsoId",
                        column: x => x.thongsoId,
                        principalTable: "CT_ThongSoDto",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CT_HangMucDto_CT_ThongTinDto_CT_ThongTinDtoId",
                        column: x => x.CT_ThongTinDtoId,
                        principalTable: "CT_ThongTinDto",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "GP_ThongTinDto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    congtrinhId = table.Column<int>(type: "int", nullable: true),
                    loaiGPId = table.Column<int>(type: "int", nullable: true),
                    tangchuanuocId = table.Column<int>(type: "int", nullable: true),
                    tochuc_canhanId = table.Column<int>(type: "int", nullable: true),
                    CoQuanCapPhep = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DaBiThuHoi = table.Column<bool>(type: "bit", nullable: true),
                    DaXoa = table.Column<bool>(type: "bit", nullable: true),
                    FileDonXinCP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FileGiayPhep = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FileGiayToLienQuan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GP_ThongTinDtoId = table.Column<int>(type: "int", nullable: true),
                    IdCT = table.Column<int>(type: "int", nullable: true),
                    IdCon = table.Column<int>(type: "int", nullable: true),
                    IdLoaiGP = table.Column<int>(type: "int", nullable: true),
                    IdTCCN = table.Column<int>(type: "int", nullable: true),
                    NgayCoHieuLuc = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NgayHetHieuLuc = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NgayKy = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SoGP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenGP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiHan = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GP_ThongTinDto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GP_ThongTinDto_CT_ThongTinDto_congtrinhId",
                        column: x => x.congtrinhId,
                        principalTable: "CT_ThongTinDto",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GP_ThongTinDto_GP_LoaiDto_loaiGPId",
                        column: x => x.loaiGPId,
                        principalTable: "GP_LoaiDto",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GP_ThongTinDto_GP_ThongTinDto_GP_ThongTinDtoId",
                        column: x => x.GP_ThongTinDtoId,
                        principalTable: "GP_ThongTinDto",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GP_ThongTinDto_TangChuaNuocDto_tangchuanuocId",
                        column: x => x.tangchuanuocId,
                        principalTable: "TangChuaNuocDto",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GP_ThongTinDto_ToChuc_CaNhanDto_tochuc_canhanId",
                        column: x => x.tochuc_canhanId,
                        principalTable: "ToChuc_CaNhanDto",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "GP_TCQDto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GP_ThongTinDtoId = table.Column<int>(type: "int", nullable: true),
                    IdGP = table.Column<int>(type: "int", nullable: false),
                    IdTCQ = table.Column<int>(type: "int", nullable: false),
                    TCQ_ThongTinDtoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GP_TCQDto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GP_TCQDto_GP_ThongTinDto_GP_ThongTinDtoId",
                        column: x => x.GP_ThongTinDtoId,
                        principalTable: "GP_ThongTinDto",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GP_TCQDto_TCQ_ThongTinDto_TCQ_ThongTinDtoId",
                        column: x => x.TCQ_ThongTinDtoId,
                        principalTable: "TCQ_ThongTinDto",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "GP_ThongTinDtoTCQ_ThongTinDto",
                columns: table => new
                {
                    giayphepId = table.Column<int>(type: "int", nullable: false),
                    tiencqId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GP_ThongTinDtoTCQ_ThongTinDto", x => new { x.giayphepId, x.tiencqId });
                    table.ForeignKey(
                        name: "FK_GP_ThongTinDtoTCQ_ThongTinDto_GP_ThongTinDto_giayphepId",
                        column: x => x.giayphepId,
                        principalTable: "GP_ThongTinDto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GP_ThongTinDtoTCQ_ThongTinDto_TCQ_ThongTinDto_tiencqId",
                        column: x => x.tiencqId,
                        principalTable: "TCQ_ThongTinDto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LuuLuongTheoMucDich_congtrinhId",
                table: "LuuLuongTheoMucDich",
                column: "congtrinhId");

            migrationBuilder.CreateIndex(
                name: "IX_LuuLuongTheoMucDich_CT_ThongTinId",
                table: "LuuLuongTheoMucDich",
                column: "CT_ThongTinId");

            migrationBuilder.CreateIndex(
                name: "IX_CT_HangMucDto_CT_ThongTinDtoId",
                table: "CT_HangMucDto",
                column: "CT_ThongTinDtoId");

            migrationBuilder.CreateIndex(
                name: "IX_CT_HangMucDto_thongsoId",
                table: "CT_HangMucDto",
                column: "thongsoId");

            migrationBuilder.CreateIndex(
                name: "IX_CT_ThongTinDto_donvi_hanhchinhId",
                table: "CT_ThongTinDto",
                column: "donvi_hanhchinhId");

            migrationBuilder.CreateIndex(
                name: "IX_CT_ThongTinDto_loaiCTId",
                table: "CT_ThongTinDto",
                column: "loaiCTId");

            migrationBuilder.CreateIndex(
                name: "IX_CT_ThongTinDto_TCQ_ThongTinDtoId",
                table: "CT_ThongTinDto",
                column: "TCQ_ThongTinDtoId");

            migrationBuilder.CreateIndex(
                name: "IX_CT_ThongTinDto_thongsoId",
                table: "CT_ThongTinDto",
                column: "thongsoId");

            migrationBuilder.CreateIndex(
                name: "IX_GP_TCQDto_GP_ThongTinDtoId",
                table: "GP_TCQDto",
                column: "GP_ThongTinDtoId");

            migrationBuilder.CreateIndex(
                name: "IX_GP_TCQDto_TCQ_ThongTinDtoId",
                table: "GP_TCQDto",
                column: "TCQ_ThongTinDtoId");

            migrationBuilder.CreateIndex(
                name: "IX_GP_ThongTinDto_congtrinhId",
                table: "GP_ThongTinDto",
                column: "congtrinhId");

            migrationBuilder.CreateIndex(
                name: "IX_GP_ThongTinDto_GP_ThongTinDtoId",
                table: "GP_ThongTinDto",
                column: "GP_ThongTinDtoId");

            migrationBuilder.CreateIndex(
                name: "IX_GP_ThongTinDto_loaiGPId",
                table: "GP_ThongTinDto",
                column: "loaiGPId");

            migrationBuilder.CreateIndex(
                name: "IX_GP_ThongTinDto_tangchuanuocId",
                table: "GP_ThongTinDto",
                column: "tangchuanuocId");

            migrationBuilder.CreateIndex(
                name: "IX_GP_ThongTinDto_tochuc_canhanId",
                table: "GP_ThongTinDto",
                column: "tochuc_canhanId");

            migrationBuilder.CreateIndex(
                name: "IX_GP_ThongTinDtoTCQ_ThongTinDto_tiencqId",
                table: "GP_ThongTinDtoTCQ_ThongTinDto",
                column: "tiencqId");

            migrationBuilder.CreateIndex(
                name: "IX_TCQ_ThongTinDto_qd_bosungId",
                table: "TCQ_ThongTinDto",
                column: "qd_bosungId");

            migrationBuilder.AddForeignKey(
                name: "FK_LuuLuongTheoMucDich_CT_ThongTinDto_congtrinhId",
                table: "LuuLuongTheoMucDich",
                column: "congtrinhId",
                principalTable: "CT_ThongTinDto",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LuuLuongTheoMucDich_CT_ThongTin_CT_ThongTinId",
                table: "LuuLuongTheoMucDich",
                column: "CT_ThongTinId",
                principalTable: "CT_ThongTin",
                principalColumn: "Id");
        }
    }
}
