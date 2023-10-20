using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace new_wr_api.Data
{
    public class DatabaseContext : IdentityDbContext<AspNetUsers, AspNetRoles, string>
    {
        private readonly IConfiguration configuration;
        public DatabaseContext(DbContextOptions options, IConfiguration configuration) : base(options)
        {
            this.configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
        }
        //
        #region DbSet

        //For Authoright -- assign permission folow dashboard
        public DbSet<Permissions>? Permissions { get; set; }
        public DbSet<Dashboards>? Dashboards { get; set; }
        public DbSet<UserDashboards>? UserDashboards { get; set; }
        public DbSet<RoleDashboards>? RoleDashboards { get; set; }
        public DbSet<Functions>? Functions { get; set; }

        //Other database

        public DbSet<CT_HangMuc>? CT_HangMuc { get; set; }
        public DbSet<CT_Loai>? CT_Loai { get; set; }
        public DbSet<CT_ThongTin>? CT_ThongTin { get; set; }
        public DbSet<CT_ThongSo>? CT_ThongSo { get; set; }
        public DbSet<DonViHC>? DonViHC { get; set; }
        public DbSet<GP_Loai>? GP_Loai { get; set; }
        public DbSet<GP_TCQ>? GP_TCQ { get; set; }
        public DbSet<GP_ThongTin>? GP_ThongTin { get; set; }
        public DbSet<GS_DuLieu>? GS_DuLieu { get; set; }
        public DbSet<GS_TaiKhoanTruyen>? GS_TaiKhoanTruyen { get; set; }
        public DbSet<TangChuaNuoc>? TangChuaNuoc { get; set; }
        public DbSet<LuuVucSong>? LuuVucSong { get; set; }
        public DbSet<Song>? Song { get; set; }
        public DbSet<TCQ_ThongTin>? TCQ_ThongTin { get; set; }
        public DbSet<TieuVungLuuVuc>? TieuVungLuuVuc { get; set; }
        public DbSet<TLN_NuocDuoiDat_SoLuong>? TLN_NuocDuoiDat_SoLuong { get; set; }
        public DbSet<TLN_NuocDuoiDat_TongLuong>? TLN_NuocDuoiDat_TongLuong { get; set; }
        public DbSet<TLN_NuocDuoiDat_ChatLuong>? TLN_NuocDuoiDat_ChatLuong { get; set; }
        public DbSet<TLN_NuocMat_ChatLuong>? TLN_NuocMat_ChatLuong { get; set; }
        public DbSet<TLN_NuocMat_SoLuong>? TLN_NuocMat_SoLuong { get; set; }
        public DbSet<TLN_NuocMat_TongLuong>? TLN_NuocMat_TongLuong { get; set; }
        public DbSet<TLN_NuocMua_TongLuong>? TLN_NuocMua_TongLuong { get; set; }
        public DbSet<ToChuc_CaNhan>? ToChuc_CaNhan { get; set; }
        public DbSet<Tram_LoaiTram>? Tram_LoaiTram { get; set; }
        public DbSet<Tram_ThongTin>? Tram_ThongTin { get; set; }


        public DbSet<BieuMauSoMot>? BieuMauSoMot { get; set; }
        public DbSet<BieuMauSoHai>? BieuMauSoHai { get; set; }
        public DbSet<BieuMauSoBa>? BieuMauSoBa { get; set; }
        public DbSet<BieuMauSoBon>? BieuMauSoBon { get; set; }
        public DbSet<BieuMauSoNam>? BieuMauSoNam { get; set; }
        public DbSet<BieuMauSoSau>? BieuMauSoSau { get; set; }
        public DbSet<BieuMauSoBay>? BieuMauSoBay { get; set; }
        public DbSet<BieuMauSoTam>? BieuMauSoTam { get; set; }
        public DbSet<BieuMauSoChin>? BieuMauSoChin { get; set; }
        public DbSet<BieuMauSoMuoi>? BieuMauSoMuoi { get; set; }
        public DbSet<BieuMauSoMuoiMot>? BieuMauSoMuoiMot { get; set; }
        public DbSet<BieuMauSoMuoiHai>? BieuMauSoMuoiHai { get; set; }
        public DbSet<BieuMauSoMuoiNam>? BieuMauSoMuoiNam { get; set; }
        public DbSet<BieuMauSoMuoiSau>? BieuMauSoMuoiSau { get; set; }
        public DbSet<BieuMauSoMuoiBay>? BieuMauSoMuoiBay { get; set; }
        public DbSet<BieuMauSoMuoiTam>? BieuMauSoMuoiTam { get; set; }
        public DbSet<BieuMauSoMuoiChin>? BieuMauSoMuoiChin { get; set; }


        //MoreDatabase

        //GS
        public DbSet<TramBomSinhHoat>? TramBomSinhHoat { get; set; }
        public DbSet<TramBomSanXuat>? TramBomSanXuat { get; set; }
        public DbSet<ToaDoCongTrinh>? ToaDoCongTrinh { get; set; }
        public DbSet<ThongTinCongTrinh>? ThongTinCongTrinh { get; set; }
        public DbSet<ThongSoVanHanhThucTe>? ThongSoVanHanhThucTe { get; set; }
        public DbSet<ThongSoKyThuatCongTrinh>? ThongSoKyThuatCongTrinh { get; set; }
        public DbSet<CheDoKhaiThacCongTrinh>? CheDoKhaiThacCongTrinh { get; set; }
        public DbSet<ThoiGianVanHanhCongTrinh>? ThoiGianVanHanhCongTrinh { get; set; }
        public DbSet<PhanCapCongTrinhCong>? PhanCapCongTrinhCong { get; set; }

        //TLN
        //TLN > NDD
        public DbSet<SoLuongNDD>? SoLuongNDD { get; set; }
        public DbSet<ThongTinVeCacChiTieuPhanTichCLN>? ThongTinVeCacChiTieuPhanTichCLN { get; set; }
        public DbSet<ThongTinVeChatLuongNuoc>? ThongTinVeChatLuongNuoc { get; set; }
        public DbSet<ThongTinVeHoatDongCuaCongTrinh>? ThongTinVeHoatDongCuaCongTrinh { get; set; }
        public DbSet<ThongTinVeMucNuocTinh>? ThongTinVeMucNuocTinh { get; set; }
        public DbSet<ThongTinVeTruLuongNuoc>? ThongTinVeTruLuongNuoc { get; set; }
        public DbSet<TLN_CongTrinh>? TLN_CongTrinh { get; set; }
        public DbSet<TLN_TangChuaNuoc>? TLN_TangChuaNuoc { get; set; }
        public DbSet<TongLuongNuocMan>? TongLuongNuocMan { get; set; }

        //TLN > NMat
        public DbSet<Ao_Ho_Dam_Pha>? Ao_Ho_Dam_Pha { get; set; }
        public DbSet<CLNMatTheoWQI>? CLNMatTheoWQI { get; set; }
        public DbSet<DacTrungSongSuoi>? DacTrungSongSuoi { get; set; }
        public DbSet<Song_Suoi_KenhRach>? Song_Suoi_KenhRach { get; set; }
        public DbSet<TLN_LuuVucSong>? TLN_LuuVucSong { get; set; }
        public DbSet<TongLuongDongChay>? TongLuongDongChay { get; set; }

        //TLN > NMua
        public DbSet<LoaiTramQuanTracLuongMua>? LoaiTramQuanTracLuongMua { get; set; }
        public DbSet<PhuongPhapTinhMua>? PhuongPhapTinhMua { get; set; }
        public DbSet<SoLieuMua>? SoLieuMua { get; set; }
        public DbSet<TongLuongMua>? TongLuongMua { get; set; }
        public DbSet<TramQuanTracLuongMua>? TramQuanTracLuongMua { get; set; }
        public DbSet<TrangThaiQuanTrac>? TrangThaiQuanTrac { get; set; }


        #endregion
    }
}
