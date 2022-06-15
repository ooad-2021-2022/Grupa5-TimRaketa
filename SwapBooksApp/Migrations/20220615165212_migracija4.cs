using Microsoft.EntityFrameworkCore.Migrations;

namespace SwapBooksApp.Migrations
{
    public partial class migracija4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Autor",
                table: "AutorskoDjelo",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Cijena",
                table: "AutorskoDjelo",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Autor",
                table: "AutorskoDjelo");

            migrationBuilder.DropColumn(
                name: "Cijena",
                table: "AutorskoDjelo");
        }
    }
}
