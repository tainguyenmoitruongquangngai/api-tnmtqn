using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace new_wr_api.Migrations
{
    /// <inheritdoc />
    public partial class Update_DuongKichCong_to_DuongKinhCong_in_CT_ThongSO : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DuongKichCong",
                table: "CT_ThongSo",
                newName: "DuongKinhCong");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DuongKinhCong",
                table: "CT_ThongSo",
                newName: "DuongKichCong");
        }
    }
}
