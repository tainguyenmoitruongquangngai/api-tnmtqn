using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace new_wr_api.Migrations
{
    /// <inheritdoc />
    public partial class AddRalationSHipGS : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "MaThongSoVanHanhThucTe",
                table: "ThongSoKyThuatCongTrinh",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MaThongTinCongTrinh",
                table: "ThoiGianVanHanhCongTrinh",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TramBomSinhHoat_MaThongTinCongTrinh",
                table: "TramBomSinhHoat",
                column: "MaThongTinCongTrinh",
                unique: true,
                filter: "[MaThongTinCongTrinh] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_TramBomSanXuat_MaThongTinCongTrinh",
                table: "TramBomSanXuat",
                column: "MaThongTinCongTrinh",
                unique: true,
                filter: "[MaThongTinCongTrinh] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ToaDoCongTrinh_MaThongTinCongTrinh",
                table: "ToaDoCongTrinh",
                column: "MaThongTinCongTrinh",
                unique: true,
                filter: "[MaThongTinCongTrinh] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ThongSoVanHanhThucTe_MaThongTinCongTrinh",
                table: "ThongSoVanHanhThucTe",
                column: "MaThongTinCongTrinh");

            migrationBuilder.CreateIndex(
                name: "IX_ThongSoKyThuatCongTrinh_MaThongSoVanHanhThucTe",
                table: "ThongSoKyThuatCongTrinh",
                column: "MaThongSoVanHanhThucTe",
                unique: true,
                filter: "[MaThongSoVanHanhThucTe] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ThongSoKyThuatCongTrinh_MaThongTinCongTrinhTramBom",
                table: "ThongSoKyThuatCongTrinh",
                column: "MaThongTinCongTrinhTramBom",
                unique: true,
                filter: "[MaThongTinCongTrinhTramBom] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ThoiGianVanHanhCongTrinh_MaThongTinCongTrinh",
                table: "ThoiGianVanHanhCongTrinh",
                column: "MaThongTinCongTrinh",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PhanCapCongTrinhCong_MaThongTinCongTrinh",
                table: "PhanCapCongTrinhCong",
                column: "MaThongTinCongTrinh",
                unique: true,
                filter: "[MaThongTinCongTrinh] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CheDoKhaiThacCongTrinh_MaThongTinCongTrinh",
                table: "CheDoKhaiThacCongTrinh",
                column: "MaThongTinCongTrinh",
                unique: true,
                filter: "[MaThongTinCongTrinh] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_CheDoKhaiThacCongTrinh_ThongTinCongTrinh_MaThongTinCongTrinh",
                table: "CheDoKhaiThacCongTrinh",
                column: "MaThongTinCongTrinh",
                principalTable: "ThongTinCongTrinh",
                principalColumn: "MaThongTinCongTrinh");

            migrationBuilder.AddForeignKey(
                name: "FK_PhanCapCongTrinhCong_ThongTinCongTrinh_MaThongTinCongTrinh",
                table: "PhanCapCongTrinhCong",
                column: "MaThongTinCongTrinh",
                principalTable: "ThongTinCongTrinh",
                principalColumn: "MaThongTinCongTrinh");

            migrationBuilder.AddForeignKey(
                name: "FK_ThoiGianVanHanhCongTrinh_ThongTinCongTrinh_MaThongTinCongTrinh",
                table: "ThoiGianVanHanhCongTrinh",
                column: "MaThongTinCongTrinh",
                principalTable: "ThongTinCongTrinh",
                principalColumn: "MaThongTinCongTrinh",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ThongSoKyThuatCongTrinh_ThongSoVanHanhThucTe_MaThongSoVanHanhThucTe",
                table: "ThongSoKyThuatCongTrinh",
                column: "MaThongSoVanHanhThucTe",
                principalTable: "ThongSoVanHanhThucTe",
                principalColumn: "MaThongSoVanHanhThucTe");

            migrationBuilder.AddForeignKey(
                name: "FK_ThongSoKyThuatCongTrinh_ThongTinCongTrinh_MaThongTinCongTrinhTramBom",
                table: "ThongSoKyThuatCongTrinh",
                column: "MaThongTinCongTrinhTramBom",
                principalTable: "ThongTinCongTrinh",
                principalColumn: "MaThongTinCongTrinh");

            migrationBuilder.AddForeignKey(
                name: "FK_ThongSoVanHanhThucTe_ThongTinCongTrinh_MaThongTinCongTrinh",
                table: "ThongSoVanHanhThucTe",
                column: "MaThongTinCongTrinh",
                principalTable: "ThongTinCongTrinh",
                principalColumn: "MaThongTinCongTrinh");

            migrationBuilder.AddForeignKey(
                name: "FK_ToaDoCongTrinh_ThongTinCongTrinh_MaThongTinCongTrinh",
                table: "ToaDoCongTrinh",
                column: "MaThongTinCongTrinh",
                principalTable: "ThongTinCongTrinh",
                principalColumn: "MaThongTinCongTrinh");

            migrationBuilder.AddForeignKey(
                name: "FK_TramBomSanXuat_ThongTinCongTrinh_MaThongTinCongTrinh",
                table: "TramBomSanXuat",
                column: "MaThongTinCongTrinh",
                principalTable: "ThongTinCongTrinh",
                principalColumn: "MaThongTinCongTrinh");

            migrationBuilder.AddForeignKey(
                name: "FK_TramBomSinhHoat_ThongTinCongTrinh_MaThongTinCongTrinh",
                table: "TramBomSinhHoat",
                column: "MaThongTinCongTrinh",
                principalTable: "ThongTinCongTrinh",
                principalColumn: "MaThongTinCongTrinh");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CheDoKhaiThacCongTrinh_ThongTinCongTrinh_MaThongTinCongTrinh",
                table: "CheDoKhaiThacCongTrinh");

            migrationBuilder.DropForeignKey(
                name: "FK_PhanCapCongTrinhCong_ThongTinCongTrinh_MaThongTinCongTrinh",
                table: "PhanCapCongTrinhCong");

            migrationBuilder.DropForeignKey(
                name: "FK_ThoiGianVanHanhCongTrinh_ThongTinCongTrinh_MaThongTinCongTrinh",
                table: "ThoiGianVanHanhCongTrinh");

            migrationBuilder.DropForeignKey(
                name: "FK_ThongSoKyThuatCongTrinh_ThongSoVanHanhThucTe_MaThongSoVanHanhThucTe",
                table: "ThongSoKyThuatCongTrinh");

            migrationBuilder.DropForeignKey(
                name: "FK_ThongSoKyThuatCongTrinh_ThongTinCongTrinh_MaThongTinCongTrinhTramBom",
                table: "ThongSoKyThuatCongTrinh");

            migrationBuilder.DropForeignKey(
                name: "FK_ThongSoVanHanhThucTe_ThongTinCongTrinh_MaThongTinCongTrinh",
                table: "ThongSoVanHanhThucTe");

            migrationBuilder.DropForeignKey(
                name: "FK_ToaDoCongTrinh_ThongTinCongTrinh_MaThongTinCongTrinh",
                table: "ToaDoCongTrinh");

            migrationBuilder.DropForeignKey(
                name: "FK_TramBomSanXuat_ThongTinCongTrinh_MaThongTinCongTrinh",
                table: "TramBomSanXuat");

            migrationBuilder.DropForeignKey(
                name: "FK_TramBomSinhHoat_ThongTinCongTrinh_MaThongTinCongTrinh",
                table: "TramBomSinhHoat");

            migrationBuilder.DropIndex(
                name: "IX_TramBomSinhHoat_MaThongTinCongTrinh",
                table: "TramBomSinhHoat");

            migrationBuilder.DropIndex(
                name: "IX_TramBomSanXuat_MaThongTinCongTrinh",
                table: "TramBomSanXuat");

            migrationBuilder.DropIndex(
                name: "IX_ToaDoCongTrinh_MaThongTinCongTrinh",
                table: "ToaDoCongTrinh");

            migrationBuilder.DropIndex(
                name: "IX_ThongSoVanHanhThucTe_MaThongTinCongTrinh",
                table: "ThongSoVanHanhThucTe");

            migrationBuilder.DropIndex(
                name: "IX_ThongSoKyThuatCongTrinh_MaThongSoVanHanhThucTe",
                table: "ThongSoKyThuatCongTrinh");

            migrationBuilder.DropIndex(
                name: "IX_ThongSoKyThuatCongTrinh_MaThongTinCongTrinhTramBom",
                table: "ThongSoKyThuatCongTrinh");

            migrationBuilder.DropIndex(
                name: "IX_ThoiGianVanHanhCongTrinh_MaThongTinCongTrinh",
                table: "ThoiGianVanHanhCongTrinh");

            migrationBuilder.DropIndex(
                name: "IX_PhanCapCongTrinhCong_MaThongTinCongTrinh",
                table: "PhanCapCongTrinhCong");

            migrationBuilder.DropIndex(
                name: "IX_CheDoKhaiThacCongTrinh_MaThongTinCongTrinh",
                table: "CheDoKhaiThacCongTrinh");

            migrationBuilder.DropColumn(
                name: "MaThongTinCongTrinh",
                table: "ThoiGianVanHanhCongTrinh");

            migrationBuilder.AlterColumn<string>(
                name: "MaThongSoVanHanhThucTe",
                table: "ThongSoKyThuatCongTrinh",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}
