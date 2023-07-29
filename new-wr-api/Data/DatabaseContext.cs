﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using new_wr_api.Data;

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
        public DbSet<ConstructionTypes>? ConstructionTypes { get; set; }
        public DbSet<Constructions>? Constructions { get; set; }
        public DbSet<Licenses>? Licenses { get; set; }
        public DbSet<ConstructionLicense>? ConstructionLicense { get; set; }
        public DbSet<Business>? Business { get; set; }
        public DbSet<LicenseFees>? LicenseFees { get; set; }
        #endregion
    }
}
