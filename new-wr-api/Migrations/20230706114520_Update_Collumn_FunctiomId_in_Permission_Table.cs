using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace new_wr_api.Migrations
{
    /// <inheritdoc />
    public partial class Update_Collumn_FunctiomId_in_Permission_Table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PermitName",
                table: "Permissions",
                newName: "FunctionName");

            migrationBuilder.RenameColumn(
                name: "PermitId",
                table: "Permissions",
                newName: "FunctionId");

            migrationBuilder.RenameColumn(
                name: "PermitCode",
                table: "Permissions",
                newName: "FunctionCode");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FunctionName",
                table: "Permissions",
                newName: "PermitName");

            migrationBuilder.RenameColumn(
                name: "FunctionId",
                table: "Permissions",
                newName: "PermitId");

            migrationBuilder.RenameColumn(
                name: "FunctionCode",
                table: "Permissions",
                newName: "PermitCode");
        }
    }
}
