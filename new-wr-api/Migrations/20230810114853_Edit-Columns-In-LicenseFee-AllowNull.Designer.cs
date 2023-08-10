﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using new_wr_api.Data;

#nullable disable

namespace new_wr_api.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20230810114853_Edit-Columns-In-LicenseFee-AllowNull")]
    partial class EditColumnsInLicenseFeeAllowNull
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("new_wr_api.Data.AspNetRoles", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsDefault")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("new_wr_api.Data.AspNetUsers", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTime?>("ModifiedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordSalt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("new_wr_api.Data.Business", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AuthorityPerson")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Director")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fax")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdentifierCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LegalRepresentative")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Business");
                });

            modelBuilder.Entity("new_wr_api.Data.ConstructionLicense", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ConstructionId")
                        .HasColumnType("int");

                    b.Property<int>("LicenseId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ConstructionLicense");
                });

            modelBuilder.Entity("new_wr_api.Data.ConstructionTypes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ParentId")
                        .HasColumnType("int");

                    b.Property<string>("TypeName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TypeSlug")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ConstructionTypes");
                });

            modelBuilder.Entity("new_wr_api.Data.Constructions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double?>("AmountWaterExploited")
                        .HasColumnType("float");

                    b.Property<int?>("AquiferId")
                        .HasColumnType("int");

                    b.Property<double?>("AverageDischargeFlow")
                        .HasColumnType("float");

                    b.Property<string>("AveragePumpTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("BasinArea")
                        .HasColumnType("float");

                    b.Property<int?>("BasinId")
                        .HasColumnType("int");

                    b.Property<double?>("CapacityPre")
                        .HasColumnType("float");

                    b.Property<string>("Change")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("CheckFloodWL")
                        .HasColumnType("float");

                    b.Property<int?>("CommuneId")
                        .HasColumnType("int");

                    b.Property<string>("ConstructionCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConstructionDetailLocation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConstructionLevel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConstructionLocation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConstructionName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConstructionTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("DamElevation")
                        .HasColumnType("float");

                    b.Property<double?>("DamHeight")
                        .HasColumnType("float");

                    b.Property<double?>("DamWidth")
                        .HasColumnType("float");

                    b.Property<double?>("DeadCapacity")
                        .HasColumnType("float");

                    b.Property<double?>("DeadWL")
                        .HasColumnType("float");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("DesignFloodLevel")
                        .HasColumnType("float");

                    b.Property<double?>("DischargeFlow")
                        .HasColumnType("float");

                    b.Property<string>("DischargeMethod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DischargeMode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DischargeWS")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DistrictId")
                        .HasColumnType("int");

                    b.Property<double?>("DownstreamWL")
                        .HasColumnType("float");

                    b.Property<double?>("DownstreamWLPre")
                        .HasColumnType("float");

                    b.Property<double?>("DrainDiameter")
                        .HasColumnType("float");

                    b.Property<double?>("DrainElevation")
                        .HasColumnType("float");

                    b.Property<double?>("DrainLength")
                        .HasColumnType("float");

                    b.Property<double?>("DrainSize")
                        .HasColumnType("float");

                    b.Property<string>("DrillingDuration")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DrillingPurpose")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DrillingScale")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("DynamicWL")
                        .HasColumnType("float");

                    b.Property<string>("ExploitedWS")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExplorationPurposes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("FlootWL")
                        .HasColumnType("float");

                    b.Property<double?>("FlowAvgForYears")
                        .HasColumnType("float");

                    b.Property<double?>("FlowDesigned")
                        .HasColumnType("float");

                    b.Property<double?>("GuaranteedFlow")
                        .HasColumnType("float");

                    b.Property<double?>("GuaranteedPower")
                        .HasColumnType("float");

                    b.Property<double?>("Hmax")
                        .HasColumnType("float");

                    b.Property<double?>("Hmin")
                        .HasColumnType("float");

                    b.Property<double?>("Htt")
                        .HasColumnType("float");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsDisconnect")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsError")
                        .HasColumnType("bit");

                    b.Property<string>("KqKf")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Lat")
                        .HasColumnType("float");

                    b.Property<double?>("Lng")
                        .HasColumnType("float");

                    b.Property<double?>("LowWL")
                        .HasColumnType("float");

                    b.Property<double?>("MaximumDischargeFlow")
                        .HasColumnType("float");

                    b.Property<double?>("MaximumDischargeFlowPre")
                        .HasColumnType("float");

                    b.Property<double?>("MaximumFlow")
                        .HasColumnType("float");

                    b.Property<double?>("MaximumFlowPre")
                        .HasColumnType("float");

                    b.Property<string>("MaximumPumpTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("MaximumWasteWaterFlow")
                        .HasColumnType("float");

                    b.Property<double?>("MinimumFlow")
                        .HasColumnType("float");

                    b.Property<double?>("MinimumFlowPre")
                        .HasColumnType("float");

                    b.Property<string>("MinimumPumpTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiningDuration")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("MiningMaxFlow")
                        .HasColumnType("float");

                    b.Property<string>("MiningMethod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiningMode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiningPurpose")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("MonitoringWellWL")
                        .HasColumnType("float");

                    b.Property<double?>("NumberMiningWells")
                        .HasColumnType("float");

                    b.Property<double?>("NumberMonitoringWells")
                        .HasColumnType("float");

                    b.Property<double?>("OverflowFlow")
                        .HasColumnType("float");

                    b.Property<double?>("Power")
                        .HasColumnType("float");

                    b.Property<double?>("PreFlootMaxWL")
                        .HasColumnType("float");

                    b.Property<int?>("ProvinceId")
                        .HasColumnType("int");

                    b.Property<double?>("PumpCapacity")
                        .HasColumnType("float");

                    b.Property<double?>("PumpDesignFlow")
                        .HasColumnType("float");

                    b.Property<double?>("PumpMaxFlow")
                        .HasColumnType("float");

                    b.Property<double?>("PumpNumber")
                        .HasColumnType("float");

                    b.Property<double?>("RainAvgForYears")
                        .HasColumnType("float");

                    b.Property<double?>("RealityFlow")
                        .HasColumnType("float");

                    b.Property<double?>("RealityWateringArea")
                        .HasColumnType("float");

                    b.Property<double?>("RiseWL")
                        .HasColumnType("float");

                    b.Property<int?>("RiverId")
                        .HasColumnType("int");

                    b.Property<string>("SmallPlanningArea")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StartDate")
                        .HasColumnType("int");

                    b.Property<double?>("StaticWL")
                        .HasColumnType("float");

                    b.Property<double?>("SuctionTankWL")
                        .HasColumnType("float");

                    b.Property<DateTime?>("TimePre")
                        .HasColumnType("datetime2");

                    b.Property<double?>("TotalCapacity")
                        .HasColumnType("float");

                    b.Property<int?>("TypeOfConstructionId")
                        .HasColumnType("int");

                    b.Property<double?>("UpstreamWL")
                        .HasColumnType("float");

                    b.Property<double?>("UpstreamWLPre")
                        .HasColumnType("float");

                    b.Property<double?>("UsefulCapacity")
                        .HasColumnType("float");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VolumeOfExplorationItems")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("WaterDepthFrom")
                        .HasColumnType("float");

                    b.Property<double?>("WaterDepthTo")
                        .HasColumnType("float");

                    b.Property<double?>("WaterExtractionFlowDesign")
                        .HasColumnType("float");

                    b.Property<double?>("WaterExtractionFlowReality")
                        .HasColumnType("float");

                    b.Property<double?>("WaterSupplyFlow")
                        .HasColumnType("float");

                    b.Property<double?>("WateringAreaDesigned")
                        .HasColumnType("float");

                    b.Property<string>("WellNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("WellWL")
                        .HasColumnType("float");

                    b.Property<double?>("X")
                        .HasColumnType("float");

                    b.Property<double?>("Y")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Constructions");
                });

            modelBuilder.Entity("new_wr_api.Data.Dashboards", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Path")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("PermitAccess")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Dashboards");
                });

            modelBuilder.Entity("new_wr_api.Data.Functions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PermitCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PermitName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Functions");
                });

            modelBuilder.Entity("new_wr_api.Data.LicenseFees", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ChildrenId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FilePDF")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LicenseFeeNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LicensingAuthorities")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("SignDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("TotalMoney")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("LicenseFees");
                });

            modelBuilder.Entity("new_wr_api.Data.Licenses", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BusinessId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Duration")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ExpireDate")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsRevoked")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("IssueDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LicenseFile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LicenseName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LicenseNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LicenseRequestFile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("LicensingAuthorities")
                        .HasColumnType("int");

                    b.Property<int>("LicensingTypeId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ParentId")
                        .HasColumnType("int");

                    b.Property<string>("RelatedDocumentFile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("SignDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Licenses");
                });

            modelBuilder.Entity("new_wr_api.Data.Permissions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("DashboardId")
                        .HasColumnType("int");

                    b.Property<string>("FunctionCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("FunctionId")
                        .HasColumnType("int");

                    b.Property<string>("FunctionName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Permissions");
                });

            modelBuilder.Entity("new_wr_api.Data.RoleDashboards", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("DashboardId")
                        .HasColumnType("int");

                    b.Property<string>("FileControl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("PermitAccess")
                        .HasColumnType("bit");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("RoleDashboards");
                });

            modelBuilder.Entity("new_wr_api.Data.UserDashboards", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("DashboardId")
                        .HasColumnType("int");

                    b.Property<string>("FileControl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("PermitAccess")
                        .HasColumnType("bit");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UserDashboards");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("new_wr_api.Data.AspNetRoles", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("new_wr_api.Data.AspNetUsers", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("new_wr_api.Data.AspNetUsers", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("new_wr_api.Data.AspNetRoles", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("new_wr_api.Data.AspNetUsers", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("new_wr_api.Data.AspNetUsers", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
