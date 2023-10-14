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

        public DbSet<BieuMauSoHai>? BieuMauSoHai { get; set; }

        public DbSet<BieuMauSoBa>? BieuMauSoBa { get; set; }
        public DbSet<BieuMauSoBon>? BieuMauSoBon { get; set; }
        public DbSet<BieuMauSoNam>? BieuMauSoNam { get; set; }


        #endregion
    }
}
