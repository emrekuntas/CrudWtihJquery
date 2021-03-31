using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class Mymigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Fiyat",
                table: "Products",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "Adet",
                table: "Products",
                newName: "Piece");

            migrationBuilder.RenameColumn(
                name: "Aciklama",
                table: "Products",
                newName: "Description");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Products",
                newName: "Fiyat");

            migrationBuilder.RenameColumn(
                name: "Piece",
                table: "Products",
                newName: "Adet");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Products",
                newName: "Aciklama");
        }
    }
}
