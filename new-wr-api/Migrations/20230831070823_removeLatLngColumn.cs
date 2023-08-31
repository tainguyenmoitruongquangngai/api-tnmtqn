using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace new_wr_api.Migrations
{
    /// <inheritdoc />
    public partial class removeLatLngColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Lat",
                table: "Constructions");

            migrationBuilder.DropColumn(
                name: "Lng",
                table: "Constructions");

            migrationBuilder.DropColumn(
                name: "Lat",
                table: "ConstructionDetails");

            migrationBuilder.DropColumn(
                name: "Lng",
                table: "ConstructionDetails");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Lat",
                table: "Constructions",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Lng",
                table: "Constructions",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Lat",
                table: "ConstructionDetails",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Lng",
                table: "ConstructionDetails",
                type: "float",
                nullable: true);
        }
    }
}
