using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace new_wr_api.Migrations
{
    /// <inheritdoc />
    public partial class BieuMauSoMuoiBays : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TongCTPheDuyetTCQiaPhuongKyBaoCao",
                table: "BieuMauSoMuoiBay",
                newName: "TongCTPheDuyetTCQDiaPhuongKyBaoCao");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TongCTPheDuyetTCQDiaPhuongKyBaoCao",
                table: "BieuMauSoMuoiBay",
                newName: "TongCTPheDuyetTCQiaPhuongKyBaoCao");
        }
    }
}
