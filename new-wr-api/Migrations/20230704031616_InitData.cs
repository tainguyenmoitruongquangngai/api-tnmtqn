using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace new_wr_api.Migrations
{
    /// <inheritdoc />
    public partial class InitData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
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
                    PasswordSalt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
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
                name: "Constructions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeOfConstructionId = table.Column<int>(type: "int", nullable: false),
                    ProvinceId = table.Column<int>(type: "int", nullable: false),
                    DistrictId = table.Column<int>(type: "int", nullable: false),
                    CommuneId = table.Column<int>(type: "int", nullable: false),
                    RiverId = table.Column<int>(type: "int", nullable: false),
                    BasinId = table.Column<int>(type: "int", nullable: false),
                    LicenseId = table.Column<int>(type: "int", nullable: false),
                    AquiferId = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConstructionName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConstructionCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConstructionLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    X = table.Column<double>(type: "float", nullable: false),
                    Y = table.Column<double>(type: "float", nullable: false),
                    Lat = table.Column<double>(type: "float", nullable: false),
                    Lng = table.Column<double>(type: "float", nullable: false),
                    StartDate = table.Column<int>(type: "int", nullable: false),
                    ExploitedWS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MiningMode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MiningMethod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MiningPurpose = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DischargeMethod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DischargeMode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DischargeWS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DischargeFlow = table.Column<double>(type: "float", nullable: false),
                    MaximumDischargeFlow = table.Column<double>(type: "float", nullable: false),
                    MiningMaxFlow = table.Column<double>(type: "float", nullable: false),
                    MaximumFlow = table.Column<double>(type: "float", nullable: false),
                    MinimumFlow = table.Column<double>(type: "float", nullable: false),
                    MaximumWasteWaterFlow = table.Column<double>(type: "float", nullable: false),
                    Power = table.Column<double>(type: "float", nullable: false),
                    PumpCapacity = table.Column<double>(type: "float", nullable: false),
                    OverflowFlow = table.Column<double>(type: "float", nullable: false),
                    RiseWL = table.Column<double>(type: "float", nullable: false),
                    DeadWL = table.Column<double>(type: "float", nullable: false),
                    PreFlootMaxWL = table.Column<double>(type: "float", nullable: false),
                    FlootWL = table.Column<double>(type: "float", nullable: false),
                    UpstreamWL = table.Column<double>(type: "float", nullable: false),
                    DownstreamWL = table.Column<double>(type: "float", nullable: false),
                    DeadCapacity = table.Column<double>(type: "float", nullable: false),
                    UsefulCapacity = table.Column<double>(type: "float", nullable: false),
                    TotalCapacity = table.Column<double>(type: "float", nullable: false),
                    DamHeight = table.Column<double>(type: "float", nullable: false),
                    DamWidth = table.Column<double>(type: "float", nullable: false),
                    DrainElevation = table.Column<double>(type: "float", nullable: false),
                    DrainLength = table.Column<double>(type: "float", nullable: false),
                    DrainDiameter = table.Column<double>(type: "float", nullable: false),
                    DrainSize = table.Column<double>(type: "float", nullable: false),
                    PumpNumber = table.Column<double>(type: "float", nullable: false),
                    PumpDesignFlow = table.Column<double>(type: "float", nullable: false),
                    PumpMaxFlow = table.Column<double>(type: "float", nullable: false),
                    SuctionTankWL = table.Column<double>(type: "float", nullable: false),
                    WaterSupplyFlow = table.Column<double>(type: "float", nullable: false),
                    MiningDuration = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DrillingDuration = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DrillingPurpose = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExplorationPurposes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DrillingScale = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConstructionTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DesignFloodLevel = table.Column<double>(type: "float", nullable: false),
                    CheckFloodWL = table.Column<double>(type: "float", nullable: false),
                    NumberMiningWells = table.Column<double>(type: "float", nullable: false),
                    AmountWaterExploited = table.Column<double>(type: "float", nullable: false),
                    NumberMonitoringWells = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WellNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MonitoringWellWL = table.Column<double>(type: "float", nullable: false),
                    WellWL = table.Column<double>(type: "float", nullable: false),
                    WaterDepthFrom = table.Column<double>(type: "float", nullable: false),
                    WaterDepthTo = table.Column<double>(type: "float", nullable: false),
                    LowWL = table.Column<double>(type: "float", nullable: false),
                    StaticWL = table.Column<double>(type: "float", nullable: false),
                    DynamicWL = table.Column<double>(type: "float", nullable: false),
                    VolumeOfExplorationItems = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WaterExtractionFlowDesign = table.Column<double>(type: "float", nullable: false),
                    WaterExtractionFlowReality = table.Column<double>(type: "float", nullable: false),
                    ConstructionDetailLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RealityWateringArea = table.Column<double>(type: "float", nullable: false),
                    WateringAreaDesigned = table.Column<double>(type: "float", nullable: false),
                    GuaranteedFlow = table.Column<double>(type: "float", nullable: false),
                    Hmax = table.Column<double>(type: "float", nullable: false),
                    Hmin = table.Column<double>(type: "float", nullable: false),
                    Htt = table.Column<double>(type: "float", nullable: false),
                    RealityFlow = table.Column<double>(type: "float", nullable: false),
                    FlowDesigned = table.Column<double>(type: "float", nullable: false),
                    FlowAvgForYears = table.Column<double>(type: "float", nullable: false),
                    RainAvgForYears = table.Column<double>(type: "float", nullable: false),
                    BasinArea = table.Column<double>(type: "float", nullable: false),
                    AverageDischargeFlow = table.Column<double>(type: "float", nullable: false),
                    SmallPlanningArea = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GuaranteedPower = table.Column<double>(type: "float", nullable: false),
                    ConstructionLevel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KqKf = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DamElevation = table.Column<double>(type: "float", nullable: false),
                    AveragePumpTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaximumPumpTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MinimumPumpTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaximumDischargeFlowPre = table.Column<double>(type: "float", nullable: false),
                    CapacityPre = table.Column<double>(type: "float", nullable: false),
                    DownstreamWLPre = table.Column<double>(type: "float", nullable: false),
                    UpstreamWLPre = table.Column<double>(type: "float", nullable: false),
                    MinimumFlowPre = table.Column<double>(type: "float", nullable: false),
                    MaximumFlowPre = table.Column<double>(type: "float", nullable: false),
                    TimePre = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDisconnect = table.Column<bool>(type: "bit", nullable: false),
                    IsError = table.Column<bool>(type: "bit", nullable: false),
                    Change = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Constructions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ConstructionTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentId = table.Column<int>(type: "int", nullable: false),
                    TypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TypeSlug = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConstructionTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Dashboards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dashboards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LicenseConstructions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConstructionId = table.Column<int>(type: "int", nullable: false),
                    LicenseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LicenseConstructions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Licenses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LicenseName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LicenseNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SignDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IssueDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ExpireDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Duration = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LicensingAuthorities = table.Column<int>(type: "int", nullable: false),
                    LicenseFile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RelatedDocumentFile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LicenseRequestFile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsRevoked = table.Column<bool>(type: "bit", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Licenses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Permissions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DashboardId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PermitName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PermitCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permissions", x => x.Id);
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
                name: "Constructions");

            migrationBuilder.DropTable(
                name: "ConstructionTypes");

            migrationBuilder.DropTable(
                name: "Dashboards");

            migrationBuilder.DropTable(
                name: "LicenseConstructions");

            migrationBuilder.DropTable(
                name: "Licenses");

            migrationBuilder.DropTable(
                name: "Permissions");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
