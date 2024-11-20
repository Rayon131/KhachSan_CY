using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppData.Migrations
{
    /// <inheritdoc />
    public partial class B : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "MaPhong",
                table: "PhongChiTiets");

            migrationBuilder.DropColumn(
                name: "MaDatPhong",
                table: "KhachHangs");

            migrationBuilder.DropColumn(
                name: "MaTaiKhoan",
                table: "KhachHangs");

            migrationBuilder.DropColumn(
                name: "HoaDon",
                table: "HoaDonChiTiets");

            migrationBuilder.DropColumn(
                name: "MaDatPhong",
                table: "HoaDonChiTiets");

            migrationBuilder.DropColumn(
                name: "MaPhongChiTiet",
                table: "Gias");

            migrationBuilder.DropColumn(
                name: "MaDatPhong",
                table: "DichVuKhachDungs");

            migrationBuilder.DropColumn(
                name: "MaPhongChiTiet",
                table: "DatPhongs");

            migrationBuilder.AlterColumn<int>(
                name: "MaNhanVien",
                table: "HoaDons",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "MaKhachHang",
                table: "HoaDons",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "MaDichVuKhachDung",
                table: "HoaDonChiTiets",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "MaDichVu",
                table: "DichVuKhachDungs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LoaiPhongMaLoaiPhong",
                table: "PhongChiTiets",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MaPhong",
                table: "PhongChiTiets",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.AlterColumn<int>(
                name: "MaNhanVien",
                table: "HoaDons",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MaKhachHang",
                table: "HoaDons",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MaDatPhong",
                table: "HoaDonChiTiets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MaPhongChiTiet",
                table: "Gias",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MaDichVu",
                table: "DichVuKhachDungs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MaDatPhong",
                table: "DichVuKhachDungs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MaPhongChiTiet",
                table: "DatPhongs",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
    }
}
