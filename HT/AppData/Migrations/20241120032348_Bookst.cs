using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppData.Migrations
{
    /// <inheritdoc />
    public partial class Bookst : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MaDatPhong",
                table: "KhachHangs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MaTaiKhoan",
                table: "KhachHangs",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MaDatPhong",
                table: "KhachHangs");

            migrationBuilder.DropColumn(
                name: "MaTaiKhoan",
                table: "KhachHangs");
        }
    }
}
