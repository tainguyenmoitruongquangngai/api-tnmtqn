using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace new_wr_api.Migrations
{
    /// <inheritdoc />
    public partial class Update_CT_ThongTin_MucDichhKT_to_MucDichKT : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MucDichhKT",
                table: "CT_ThongTin",
                newName: "MucDichKT");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MucDichKT",
                table: "CT_ThongTin",
                newName: "MucDichhKT");
        }
    }
}
