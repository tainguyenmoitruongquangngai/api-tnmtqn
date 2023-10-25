using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace new_wr_api.Migrations
{
    /// <inheritdoc />
    public partial class BieuMauSoMuoiBon : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BieuMauSoMuoiBon",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ViTriQuanTrac = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PHlonNhat = table.Column<double>(type: "float", nullable: true),
                    PHNhoNhat = table.Column<double>(type: "float", nullable: true),
                    DoCungLonNhat = table.Column<double>(type: "float", nullable: true),
                    DoCungNhoNhat = table.Column<double>(type: "float", nullable: true),
                    AmoniLonNhat = table.Column<double>(type: "float", nullable: true),
                    AmoniNhoNhat = table.Column<double>(type: "float", nullable: true),
                    NitratLonNhat = table.Column<double>(type: "float", nullable: true),
                    NitratNhoNhat = table.Column<double>(type: "float", nullable: true),
                    SulfatLonNhat = table.Column<double>(type: "float", nullable: true),
                    SulfatNhoNhat = table.Column<double>(type: "float", nullable: true),
                    AsenLonNhat = table.Column<double>(type: "float", nullable: true),
                    AsenNhoNhat = table.Column<double>(type: "float", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BieuMauSoMuoiBon", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BieuMauSoMuoiBon");
        }
    }
}
