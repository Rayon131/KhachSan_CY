using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppData.Migrations
{
    /// <inheritdoc />
    public partial class Bookstá : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TrangThai",
                table: "Phongs");

            migrationBuilder.DropColumn(
                name: "MaLoaiPhong",
                table: "PhongChiTiets");

            migrationBuilder.AddColumn<int>(
                name: "LoaiPhongMaLoaiPhong",
                table: "Phongs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MaLoaiPhong",
                table: "Phongs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "TrangThai",
                table: "PhongChiTiets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Phongs_LoaiPhongMaLoaiPhong",
                table: "Phongs",
                column: "LoaiPhongMaLoaiPhong");

            migrationBuilder.AddForeignKey(
                name: "FK_Phongs_LoaiPhongs_LoaiPhongMaLoaiPhong",
                table: "Phongs",
                column: "LoaiPhongMaLoaiPhong",
                principalTable: "LoaiPhongs",
                principalColumn: "MaLoaiPhong");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Phongs_LoaiPhongs_LoaiPhongMaLoaiPhong",
                table: "Phongs");

            migrationBuilder.DropIndex(
                name: "IX_Phongs_LoaiPhongMaLoaiPhong",
                table: "Phongs");

            migrationBuilder.DropColumn(
                name: "LoaiPhongMaLoaiPhong",
                table: "Phongs");

            migrationBuilder.DropColumn(
                name: "MaLoaiPhong",
                table: "Phongs");

            migrationBuilder.DropColumn(
                name: "TrangThai",
                table: "PhongChiTiets");

            migrationBuilder.AddColumn<string>(
                name: "TrangThai",
                table: "Phongs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "MaLoaiPhong",
                table: "PhongChiTiets",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
