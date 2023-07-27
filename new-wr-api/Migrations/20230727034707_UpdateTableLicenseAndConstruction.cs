using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace new_wr_api.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTableLicenseAndConstruction : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LicenseId",
                table: "Constructions");

            migrationBuilder.AddColumn<int>(
                name: "BusinessId",
                table: "Licenses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LicensingTypeId",
                table: "Licenses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ParentId",
                table: "Licenses",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BusinessId",
                table: "Licenses");

            migrationBuilder.DropColumn(
                name: "LicensingTypeId",
                table: "Licenses");

            migrationBuilder.DropColumn(
                name: "ParentId",
                table: "Licenses");

            migrationBuilder.AddColumn<int>(
                name: "LicenseId",
                table: "Constructions",
                type: "int",
                nullable: true);
        }
    }
}
