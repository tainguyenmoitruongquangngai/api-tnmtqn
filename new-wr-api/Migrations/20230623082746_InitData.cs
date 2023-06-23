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
            migrationBuilder.AlterColumn<bool>(
                name: "IsDefault",
                table: "AspNetRoles",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Constructions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeOfConstructionId = table.Column<int>(type: "int", nullable: true),
                    ProvinceId = table.Column<int>(type: "int", nullable: true),
                    DistrictId = table.Column<int>(type: "int", nullable: true),
                    CommuneId = table.Column<int>(type: "int", nullable: true),
                    RiverId = table.Column<int>(type: "int", nullable: true),
                    BasinId = table.Column<int>(type: "int", nullable: true),
                    LicenseId = table.Column<int>(type: "int", nullable: true),
                    AquiferId = table.Column<int>(type: "int", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConstructionName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConstructionCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConstructionLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    X = table.Column<double>(type: "float", nullable: true),
                    Y = table.Column<double>(type: "float", nullable: true),
                    Lat = table.Column<double>(type: "float", nullable: true),
                    Lng = table.Column<double>(type: "float", nullable: true),
                    StartDate = table.Column<int>(type: "int", nullable: true),
                    ExploitedWS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MiningMode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MiningMethod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MiningPurpose = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DischargeMethod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DischargeMode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DischargeWS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DischargeFlow = table.Column<double>(type: "float", nullable: true),
                    MaximumDischargeFlow = table.Column<double>(type: "float", nullable: true),
                    MiningMaxFlow = table.Column<double>(type: "float", nullable: true),
                    MaximumFlow = table.Column<double>(type: "float", nullable: true),
                    MinimumFlow = table.Column<double>(type: "float", nullable: true),
                    MaximumWasteWaterFlow = table.Column<double>(type: "float", nullable: true),
                    Power = table.Column<double>(type: "float", nullable: true),
                    PumpCapacity = table.Column<double>(type: "float", nullable: true),
                    OverflowFlow = table.Column<double>(type: "float", nullable: true),
                    RiseWL = table.Column<double>(type: "float", nullable: true),
                    DeadWL = table.Column<double>(type: "float", nullable: true),
                    PreFlootMaxWL = table.Column<double>(type: "float", nullable: true),
                    FlootWL = table.Column<double>(type: "float", nullable: true),
                    UpstreamWL = table.Column<double>(type: "float", nullable: true),
                    DownstreamWL = table.Column<double>(type: "float", nullable: true),
                    DeadCapacity = table.Column<double>(type: "float", nullable: true),
                    UsefulCapacity = table.Column<double>(type: "float", nullable: true),
                    TotalCapacity = table.Column<double>(type: "float", nullable: true),
                    DamHeight = table.Column<double>(type: "float", nullable: true),
                    DamWidth = table.Column<double>(type: "float", nullable: true),
                    DrainElevation = table.Column<double>(type: "float", nullable: true),
                    DrainLength = table.Column<double>(type: "float", nullable: true),
                    DrainDiameter = table.Column<double>(type: "float", nullable: true),
                    DrainSize = table.Column<double>(type: "float", nullable: true),
                    PumpNumber = table.Column<double>(type: "float", nullable: true),
                    PumpDesignFlow = table.Column<double>(type: "float", nullable: true),
                    PumpMaxFlow = table.Column<double>(type: "float", nullable: true),
                    SuctionTankWL = table.Column<double>(type: "float", nullable: true),
                    WaterSupplyFlow = table.Column<double>(type: "float", nullable: true),
                    MiningDuration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DrillingDuration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DrillingPurpose = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExplorationPurposes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DrillingScale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConstructionTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DesignFloodLevel = table.Column<double>(type: "float", nullable: true),
                    CheckFloodWL = table.Column<double>(type: "float", nullable: true),
                    NumberMiningWells = table.Column<double>(type: "float", nullable: true),
                    AmountWaterExploited = table.Column<double>(type: "float", nullable: true),
                    NumberMonitoringWells = table.Column<double>(type: "float", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WellNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MonitoringWellWL = table.Column<double>(type: "float", nullable: true),
                    WellWL = table.Column<double>(type: "float", nullable: true),
                    WaterDepthFrom = table.Column<double>(type: "float", nullable: true),
                    WaterDepthTo = table.Column<double>(type: "float", nullable: true),
                    LowWL = table.Column<double>(type: "float", nullable: true),
                    StaticWL = table.Column<double>(type: "float", nullable: true),
                    DynamicWL = table.Column<double>(type: "float", nullable: true),
                    VolumeOfExplorationItems = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WaterExtractionFlowDesign = table.Column<double>(type: "float", nullable: true),
                    WaterExtractionFlowReality = table.Column<double>(type: "float", nullable: true),
                    ConstructionDetailLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RealityWateringArea = table.Column<double>(type: "float", nullable: true),
                    WateringAreaDesigned = table.Column<double>(type: "float", nullable: true),
                    GuaranteedFlow = table.Column<double>(type: "float", nullable: true),
                    Hmax = table.Column<double>(type: "float", nullable: true),
                    Hmin = table.Column<double>(type: "float", nullable: true),
                    Htt = table.Column<double>(type: "float", nullable: true),
                    RealityFlow = table.Column<double>(type: "float", nullable: true),
                    FlowDesigned = table.Column<double>(type: "float", nullable: true),
                    FlowAvgForYears = table.Column<double>(type: "float", nullable: true),
                    RainAvgForYears = table.Column<double>(type: "float", nullable: true),
                    BasinArea = table.Column<double>(type: "float", nullable: true),
                    AverageDischargeFlow = table.Column<double>(type: "float", nullable: true),
                    SmallPlanningArea = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GuaranteedPower = table.Column<double>(type: "float", nullable: true),
                    ConstructionLevel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KqKf = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DamElevation = table.Column<double>(type: "float", nullable: true),
                    AveragePumpTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaximumPumpTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MinimumPumpTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaximumDischargeFlowPre = table.Column<double>(type: "float", nullable: true),
                    CapacityPre = table.Column<double>(type: "float", nullable: true),
                    DownstreamWLPre = table.Column<double>(type: "float", nullable: true),
                    UpstreamWLPre = table.Column<double>(type: "float", nullable: true),
                    MinimumFlowPre = table.Column<double>(type: "float", nullable: true),
                    MaximumFlowPre = table.Column<double>(type: "float", nullable: true),
                    TimePre = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    IsDisconnect = table.Column<bool>(type: "bit", nullable: true),
                    IsError = table.Column<bool>(type: "bit", nullable: true),
                    Change = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Constructions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ConstructionType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PortalId = table.Column<int>(type: "int", nullable: true),
                    ParentId = table.Column<int>(type: "int", nullable: true),
                    TypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeSlug = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsWebPublic = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConstructionType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Licenses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LicenseName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LicenseNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SignDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IssueDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ExpireDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Duration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LicenseHolderName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LicenseHolderAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LicensingAuthorities = table.Column<int>(type: "int", nullable: true),
                    LicenseFile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RelatedDocumentFile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LicenseRequestFile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsRevoked = table.Column<bool>(type: "bit", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    ThietBiQuanTracMucNuoc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThietBiQuanTracMua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThietBiQuanTracLuuLuong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThietBiQuanTracDongChayToiThieu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThietBiQuanTracDinhKy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuanTracMuaMua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuanTracMuaKho = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Licenses", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Constructions");

            migrationBuilder.DropTable(
                name: "ConstructionType");

            migrationBuilder.DropTable(
                name: "Licenses");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDefault",
                table: "AspNetRoles",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");
        }
    }
}
