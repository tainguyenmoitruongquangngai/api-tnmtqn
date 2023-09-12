using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace new_wr_api.Migrations
{
    /// <inheritdoc />
    public partial class UpdateConstruction : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ConstructionDetails");

            migrationBuilder.DropColumn(
                name: "AmountWaterExploited",
                table: "Constructions");

            migrationBuilder.DropColumn(
                name: "AverageDischargeFlow",
                table: "Constructions");

            migrationBuilder.DropColumn(
                name: "AveragePumpTime",
                table: "Constructions");

            migrationBuilder.DropColumn(
                name: "BasinArea",
                table: "Constructions");

            migrationBuilder.DropColumn(
                name: "CheckFloodWL",
                table: "Constructions");

            migrationBuilder.DropColumn(
                name: "ConstructionDetailLocation",
                table: "Constructions");

            migrationBuilder.DropColumn(
                name: "ConstructionLevel",
                table: "Constructions");

            migrationBuilder.DropColumn(
                name: "DamElevation",
                table: "Constructions");

            migrationBuilder.DropColumn(
                name: "DamHeight",
                table: "Constructions");

            migrationBuilder.DropColumn(
                name: "DamWidth",
                table: "Constructions");

            migrationBuilder.DropColumn(
                name: "DeadCapacity",
                table: "Constructions");

            migrationBuilder.DropColumn(
                name: "DeadWL",
                table: "Constructions");

            migrationBuilder.DropColumn(
                name: "DesignFloodLevel",
                table: "Constructions");

            migrationBuilder.DropColumn(
                name: "DrainDiameter",
                table: "Constructions");

            migrationBuilder.DropColumn(
                name: "DrainElevation",
                table: "Constructions");

            migrationBuilder.DropColumn(
                name: "DrainLength",
                table: "Constructions");

            migrationBuilder.DropColumn(
                name: "DrainSize",
                table: "Constructions");

            migrationBuilder.DropColumn(
                name: "DynamicWL",
                table: "Constructions");

            migrationBuilder.DropColumn(
                name: "ExploitMethod",
                table: "Constructions");

            migrationBuilder.DropColumn(
                name: "FlowAvgForYears",
                table: "Constructions");

            migrationBuilder.DropColumn(
                name: "FlowDesigned",
                table: "Constructions");

            migrationBuilder.DropColumn(
                name: "GuaranteedFlow",
                table: "Constructions");

            migrationBuilder.DropColumn(
                name: "GuaranteedPower",
                table: "Constructions");

            migrationBuilder.DropColumn(
                name: "Hmax",
                table: "Constructions");

            migrationBuilder.DropColumn(
                name: "Hmin",
                table: "Constructions");

            migrationBuilder.DropColumn(
                name: "Htt",
                table: "Constructions");

            migrationBuilder.DropColumn(
                name: "KqKf",
                table: "Constructions");

            migrationBuilder.DropColumn(
                name: "LowWL",
                table: "Constructions");

            migrationBuilder.DropColumn(
                name: "MaximumFlow",
                table: "Constructions");

            migrationBuilder.DropColumn(
                name: "MaximumPumpTime",
                table: "Constructions");

            migrationBuilder.DropColumn(
                name: "MaximumWasteWaterFlow",
                table: "Constructions");

            migrationBuilder.DropColumn(
                name: "MinimumFlow",
                table: "Constructions");

            migrationBuilder.DropColumn(
                name: "MonitoringWellWL",
                table: "Constructions");

            migrationBuilder.DropColumn(
                name: "Power",
                table: "Constructions");

            migrationBuilder.DropColumn(
                name: "PumpNumber",
                table: "Constructions");

            migrationBuilder.DropColumn(
                name: "RainAvgForYears",
                table: "Constructions");

            migrationBuilder.DropColumn(
                name: "RealityFlow",
                table: "Constructions");

            migrationBuilder.DropColumn(
                name: "RealityWateringArea",
                table: "Constructions");

            migrationBuilder.DropColumn(
                name: "RiseWL",
                table: "Constructions");

            migrationBuilder.DropColumn(
                name: "StaticWL",
                table: "Constructions");

            migrationBuilder.DropColumn(
                name: "TotalCapacity",
                table: "Constructions");

            migrationBuilder.DropColumn(
                name: "UsefulCapacity",
                table: "Constructions");

            migrationBuilder.DropColumn(
                name: "WaterDepthFrom",
                table: "Constructions");

            migrationBuilder.DropColumn(
                name: "WaterDepthTo",
                table: "Constructions");

            migrationBuilder.DropColumn(
                name: "WaterSupplyFlow",
                table: "Constructions");

            migrationBuilder.DropColumn(
                name: "WateringAreaDesigned",
                table: "Constructions");

            migrationBuilder.DropColumn(
                name: "WellWL",
                table: "Constructions");

            migrationBuilder.RenameColumn(
                name: "MinimumPumpTime",
                table: "Constructions",
                newName: "WasteDischargeLocation");

            migrationBuilder.CreateTable(
                name: "ConstructionItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConstructionId = table.Column<int>(type: "int", nullable: false),
                    AquiferId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    X = table.Column<double>(type: "float", nullable: true),
                    Y = table.Column<double>(type: "float", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConstructionItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ConstructionSpecifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConstructionId = table.Column<int>(type: "int", nullable: false),
                    ConstructionItemId = table.Column<int>(type: "int", nullable: true),
                    ConstructionLevel = table.Column<double>(type: "float", nullable: true),
                    BasinArea = table.Column<double>(type: "float", nullable: true),
                    RainAvgForYears = table.Column<double>(type: "float", nullable: true),
                    FlowAvgForYears = table.Column<double>(type: "float", nullable: true),
                    Power = table.Column<double>(type: "float", nullable: true),
                    GuaranteedPower = table.Column<double>(type: "float", nullable: true),
                    DamHeight = table.Column<double>(type: "float", nullable: true),
                    DamWidth = table.Column<double>(type: "float", nullable: true),
                    DamElevation = table.Column<double>(type: "float", nullable: true),
                    MaximumFlow = table.Column<double>(type: "float", nullable: true),
                    MinimumFlow = table.Column<double>(type: "float", nullable: true),
                    GuaranteedFlow = table.Column<double>(type: "float", nullable: true),
                    Hmax = table.Column<double>(type: "float", nullable: false),
                    Hmin = table.Column<double>(type: "float", nullable: true),
                    Htt = table.Column<double>(type: "float", nullable: true),
                    DeadWL = table.Column<double>(type: "float", nullable: true),
                    RiseWL = table.Column<double>(type: "float", nullable: true),
                    DesignFloodLevel = table.Column<double>(type: "float", nullable: true),
                    CheckFloodWL = table.Column<double>(type: "float", nullable: true),
                    TotalCapacity = table.Column<double>(type: "float", nullable: true),
                    DeadCapacity = table.Column<double>(type: "float", nullable: true),
                    UsefulCapacity = table.Column<double>(type: "float", nullable: true),
                    DrainElevation = table.Column<double>(type: "float", nullable: true),
                    DrainLength = table.Column<double>(type: "float", nullable: true),
                    DrainDiameter = table.Column<double>(type: "float", nullable: true),
                    DrainSize = table.Column<double>(type: "float", nullable: true),
                    PumpNumber = table.Column<double>(type: "float", nullable: true),
                    FlowDesigned = table.Column<double>(type: "float", nullable: true),
                    RealityFlow = table.Column<double>(type: "float", nullable: true),
                    WateringAreaDesigned = table.Column<double>(type: "float", nullable: true),
                    RealityWateringArea = table.Column<double>(type: "float", nullable: true),
                    AveragePumpTime = table.Column<double>(type: "float", nullable: true),
                    MinimumPumpTime = table.Column<double>(type: "float", nullable: true),
                    MaximumPumpTime = table.Column<double>(type: "float", nullable: true),
                    WaterDepthFrom = table.Column<double>(type: "float", nullable: true),
                    WaterDepthTo = table.Column<double>(type: "float", nullable: true),
                    WaterSupplyFlow = table.Column<double>(type: "float", nullable: true),
                    WellWL = table.Column<double>(type: "float", nullable: true),
                    MonitoringWellWL = table.Column<double>(type: "float", nullable: true),
                    ExploitMethod = table.Column<double>(type: "float", nullable: true),
                    StaticWL = table.Column<double>(type: "float", nullable: true),
                    DynamicWL = table.Column<double>(type: "float", nullable: true),
                    ExploitAquifer = table.Column<double>(type: "float", nullable: true),
                    LowWL = table.Column<double>(type: "float", nullable: true),
                    AmountWaterExploited = table.Column<double>(type: "float", nullable: true),
                    DepthFilterTubeFrom = table.Column<double>(type: "float", nullable: true),
                    DepthFilterTubeTo = table.Column<double>(type: "float", nullable: true),
                    ExploitMaxFlow = table.Column<double>(type: "float", nullable: true),
                    ExploitMode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PumpCapacity = table.Column<double>(type: "float", nullable: true),
                    AverageDischargeFlow = table.Column<double>(type: "float", nullable: true),
                    MaximumWasteWaterFlow = table.Column<double>(type: "float", nullable: true),
                    KqKf = table.Column<double>(type: "float", nullable: true),
                    DischargeWS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DischargeMethod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DischargeMode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConstructionSpecifications", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ConstructionItems");

            migrationBuilder.DropTable(
                name: "ConstructionSpecifications");

            migrationBuilder.RenameColumn(
                name: "WasteDischargeLocation",
                table: "Constructions",
                newName: "MinimumPumpTime");

            migrationBuilder.AddColumn<double>(
                name: "AmountWaterExploited",
                table: "Constructions",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "AverageDischargeFlow",
                table: "Constructions",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AveragePumpTime",
                table: "Constructions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "BasinArea",
                table: "Constructions",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "CheckFloodWL",
                table: "Constructions",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConstructionDetailLocation",
                table: "Constructions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConstructionLevel",
                table: "Constructions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "DamElevation",
                table: "Constructions",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "DamHeight",
                table: "Constructions",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "DamWidth",
                table: "Constructions",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "DeadCapacity",
                table: "Constructions",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "DeadWL",
                table: "Constructions",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "DesignFloodLevel",
                table: "Constructions",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "DrainDiameter",
                table: "Constructions",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "DrainElevation",
                table: "Constructions",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "DrainLength",
                table: "Constructions",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "DrainSize",
                table: "Constructions",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "DynamicWL",
                table: "Constructions",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExploitMethod",
                table: "Constructions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "FlowAvgForYears",
                table: "Constructions",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "FlowDesigned",
                table: "Constructions",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "GuaranteedFlow",
                table: "Constructions",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "GuaranteedPower",
                table: "Constructions",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Hmax",
                table: "Constructions",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Hmin",
                table: "Constructions",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Htt",
                table: "Constructions",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "KqKf",
                table: "Constructions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "LowWL",
                table: "Constructions",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "MaximumFlow",
                table: "Constructions",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MaximumPumpTime",
                table: "Constructions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "MaximumWasteWaterFlow",
                table: "Constructions",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "MinimumFlow",
                table: "Constructions",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "MonitoringWellWL",
                table: "Constructions",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Power",
                table: "Constructions",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "PumpNumber",
                table: "Constructions",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "RainAvgForYears",
                table: "Constructions",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "RealityFlow",
                table: "Constructions",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "RealityWateringArea",
                table: "Constructions",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "RiseWL",
                table: "Constructions",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "StaticWL",
                table: "Constructions",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "TotalCapacity",
                table: "Constructions",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "UsefulCapacity",
                table: "Constructions",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "WaterDepthFrom",
                table: "Constructions",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "WaterDepthTo",
                table: "Constructions",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "WaterSupplyFlow",
                table: "Constructions",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "WateringAreaDesigned",
                table: "Constructions",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "WellWL",
                table: "Constructions",
                type: "float",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ConstructionDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AmountWaterExploited = table.Column<double>(type: "float", nullable: true),
                    AquiferId = table.Column<int>(type: "int", nullable: true),
                    AverageDischargeFlow = table.Column<double>(type: "float", nullable: true),
                    ConstructionId = table.Column<int>(type: "int", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepthFilterTubeFrom = table.Column<double>(type: "float", nullable: true),
                    DepthFilterTubeTo = table.Column<double>(type: "float", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DischargeMethod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DischargeMode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DischargeWS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DynamicWL = table.Column<double>(type: "float", nullable: true),
                    ExploitMaxFlow = table.Column<double>(type: "float", nullable: true),
                    ExploitMode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    KqKf = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LowWL = table.Column<double>(type: "float", nullable: true),
                    MaximumWasteWaterFlow = table.Column<double>(type: "float", nullable: true),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PumpCapacity = table.Column<double>(type: "float", nullable: true),
                    StaticWL = table.Column<double>(type: "float", nullable: true),
                    WaterDepthFrom = table.Column<double>(type: "float", nullable: true),
                    WaterDepthTo = table.Column<double>(type: "float", nullable: true),
                    WaterSupplyFlow = table.Column<double>(type: "float", nullable: true),
                    X = table.Column<double>(type: "float", nullable: true),
                    Y = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConstructionDetails", x => x.Id);
                });
        }
    }
}
