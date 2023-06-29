using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace new_wr_api.Data
{
    public class DatabaseContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
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
        public DbSet<Constructions>? Constructions { get; set; }
        public DbSet<Licenses>? Licenses { get; set; }
        public DbSet<ConstructionType>? ConstructionType { get; set; }
        public DbSet<Permission>? Permission { get; set; }
        public DbSet<Dashboard>? Dashboard { get; set; }
        #endregion
    }
}
