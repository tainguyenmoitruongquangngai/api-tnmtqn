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
        public DbSet<CT_Loai>? CT_Loai { get; set; }
        public DbSet<CT_ThongTin>? CT_ThongTin { get; set; }
        public DbSet<CT_HangMuc>? CT_HangMuc { get; set; }
        public DbSet<CT_ThongSo>? CT_ThongSo { get; set; }

        public DbSet<DonViHC>? DonViHC { get; set; }

        public DbSet<GP_Loai>? GP_Loai { get; set; }
        public DbSet<GP_ThongTin>? GP_ThongTin { get; set; }

        #endregion
    }
}
