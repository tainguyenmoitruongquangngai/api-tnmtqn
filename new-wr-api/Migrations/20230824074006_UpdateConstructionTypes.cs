using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace new_wr_api.Migrations
{
    /// <inheritdoc />
    public partial class UpdateConstructionTypes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ParentId",
                table: "ConstructionTypes");

            migrationBuilder.AddColumn<string>(
                name: "Parent",
                table: "ConstructionTypes",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Parent",
                table: "ConstructionTypes");

            migrationBuilder.AddColumn<int>(
                name: "ParentId",
                table: "ConstructionTypes",
                type: "int",
                nullable: true);
        }
    }
}
