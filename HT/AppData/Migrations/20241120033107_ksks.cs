using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppData.Migrations
{
    /// <inheritdoc />
    public partial class ksks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TrangThai",
                table: "PhongChiTiets");

            migrationBuilder.AddColumn<int>(
                name: "LoaiPhongMaLoaiPhong",
                table: "PhongChiTiets",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MaPhongChiTiet",
                table: "DatPhongs",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PhongChiTiets_LoaiPhongMaLoaiPhong",
                table: "PhongChiTiets",
                column: "LoaiPhongMaLoaiPhong");

            migrationBuilder.AddForeignKey(
                name: "FK_PhongChiTiets_LoaiPhongs_LoaiPhongMaLoaiPhong",
                table: "PhongChiTiets",
                column: "LoaiPhongMaLoaiPhong",
                principalTable: "LoaiPhongs",
                principalColumn: "MaLoaiPhong");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PhongChiTiets_LoaiPhongs_LoaiPhongMaLoaiPhong",
                table: "PhongChiTiets");

            migrationBuilder.DropIndex(
                name: "IX_PhongChiTiets_LoaiPhongMaLoaiPhong",
                table: "PhongChiTiets");

            migrationBuilder.DropColumn(
                name: "LoaiPhongMaLoaiPhong",
                table: "PhongChiTiets");

            migrationBuilder.DropColumn(
                name: "MaPhongChiTiet",
                table: "DatPhongs");

            migrationBuilder.AddColumn<string>(
                name: "TrangThai",
                table: "PhongChiTiets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
