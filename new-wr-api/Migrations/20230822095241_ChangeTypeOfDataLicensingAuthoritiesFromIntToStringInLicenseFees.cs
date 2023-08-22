using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace new_wr_api.Migrations
{
    /// <inheritdoc />
    public partial class ChangeTypeOfDataLicensingAuthoritiesFromIntToStringInLicenseFees : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LicensingAuthorities",
                table: "LicenseFees",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "LicensingAuthorities",
                table: "LicenseFees",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
