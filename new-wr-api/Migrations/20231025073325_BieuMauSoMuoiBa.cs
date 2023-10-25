using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace new_wr_api.Migrations
{
    /// <inheritdoc />
    public partial class BieuMauSoMuoiBa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BieuMauSoMuoiBa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ViTriQuanTrac = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BOD5LonNhat = table.Column<double>(type: "float", nullable: true),
                    BOD5NhoNhat = table.Column<double>(type: "float", nullable: true),
                    CODLonNhat = table.Column<double>(type: "float", nullable: true),
                    CODNhoNhat = table.Column<double>(type: "float", nullable: true),
                    DOLonNhat = table.Column<double>(type: "float", nullable: true),
                    DONhoNhat = table.Column<double>(type: "float", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BieuMauSoMuoiBa", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BieuMauSoMuoiBa");
        }
    }
}
