using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace new_wr_api.Migrations
{
    /// <inheritdoc />
    public partial class CreateTableConstructionDetailsAnsLocations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ConstructionDetails",
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
                    Lat = table.Column<double>(type: "float", nullable: true),
                    Lng = table.Column<double>(type: "float", nullable: true),
                    WaterSupplyFlow = table.Column<double>(type: "float", nullable: true),
                    WaterDepthFrom = table.Column<double>(type: "float", nullable: true),
                    WaterDepthTo = table.Column<double>(type: "float", nullable: true),
                    DepthFilterTubeFrom = table.Column<double>(type: "float", nullable: true),
                    DepthFilterTubeTo = table.Column<double>(type: "float", nullable: true),
                    StaticWL = table.Column<double>(type: "float", nullable: true),
                    DynamicWL = table.Column<double>(type: "float", nullable: true),
                    MiningMaxFlow = table.Column<double>(type: "float", nullable: true),
                    MiningMode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AmountWaterExploited = table.Column<double>(type: "float", nullable: true),
                    PumpCapacity = table.Column<double>(type: "float", nullable: true),
                    MaximumWasteWaterFlow = table.Column<double>(type: "float", nullable: true),
                    AverageDischargeFlow = table.Column<double>(type: "float", nullable: true),
                    KqKf = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DischargeWS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DischargeMethod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DischargeMode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LowWL = table.Column<double>(type: "float", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConstructionDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CityId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DistrictName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DistrictId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommuneName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommuneId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommuneLevel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedByUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedByUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ConstructionDetails");

            migrationBuilder.DropTable(
                name: "Locations");
        }
    }
}
