using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace new_wr_api.Migrations
{
    /// <inheritdoc />
    public partial class Remove_column_TangChuaNuocKT_in_CT_ThongSo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TangChuaNuocKT",
                table: "CT_ThongSo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "TangChuaNuocKT",
                table: "CT_ThongSo",
                type: "float",
                nullable: true);
        }
    }
}
