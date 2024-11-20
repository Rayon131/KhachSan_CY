using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppData.Migrations
{
    /// <inheritdoc />
    public partial class ks02 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "MaDichVuKhachDung",
                table: "HoaDonChiTiets",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HoaDon",
                table: "HoaDonChiTiets",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MaDatPhong",
                table: "HoaDonChiTiets",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HoaDon",
                table: "HoaDonChiTiets");

            migrationBuilder.DropColumn(
                name: "MaDatPhong",
                table: "HoaDonChiTiets");

            migrationBuilder.AlterColumn<int>(
                name: "MaDichVuKhachDung",
                table: "HoaDonChiTiets",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
