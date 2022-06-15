using Microsoft.EntityFrameworkCore.Migrations;

namespace SwapBooksApp.Migrations
{
    public partial class drugaMigracija : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AutorskoDjelo_AspNetUsers_korisnikId",
                table: "AutorskoDjelo");

            migrationBuilder.DropForeignKey(
                name: "FK_Knjiga_AspNetUsers_KorisnikId",
                table: "Knjiga");

            migrationBuilder.DropForeignKey(
                name: "FK_Notifikacija_AspNetUsers_korisnikId",
                table: "Notifikacija");

            migrationBuilder.DropForeignKey(
                name: "FK_Racun_AspNetUsers_korisnikId",
                table: "Racun");

            migrationBuilder.DropForeignKey(
                name: "FK_Recenzija_AspNetUsers_korisnikId",
                table: "Recenzija");

            migrationBuilder.DropIndex(
                name: "IX_Recenzija_korisnikId",
                table: "Recenzija");

            migrationBuilder.DropIndex(
                name: "IX_Racun_korisnikId",
                table: "Racun");

            migrationBuilder.DropIndex(
                name: "IX_Notifikacija_korisnikId",
                table: "Notifikacija");

            migrationBuilder.DropIndex(
                name: "IX_Knjiga_KorisnikId",
                table: "Knjiga");

            migrationBuilder.DropIndex(
                name: "IX_AutorskoDjelo_korisnikId",
                table: "AutorskoDjelo");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Ime",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Prezime",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "korisnikId",
                table: "Recenzija",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "korisnikId",
                table: "Racun",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "korisnikId",
                table: "Notifikacija",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "KorisnikId",
                table: "Knjiga",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "korisnikId",
                table: "AutorskoDjelo",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "korisnikId",
                table: "Recenzija",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "korisnikId",
                table: "Racun",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "korisnikId",
                table: "Notifikacija",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "KorisnikId",
                table: "Knjiga",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "korisnikId",
                table: "AutorskoDjelo",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Ime",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Prezime",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Recenzija_korisnikId",
                table: "Recenzija",
                column: "korisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_Racun_korisnikId",
                table: "Racun",
                column: "korisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_Notifikacija_korisnikId",
                table: "Notifikacija",
                column: "korisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_Knjiga_KorisnikId",
                table: "Knjiga",
                column: "KorisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_AutorskoDjelo_korisnikId",
                table: "AutorskoDjelo",
                column: "korisnikId");

            migrationBuilder.AddForeignKey(
                name: "FK_AutorskoDjelo_AspNetUsers_korisnikId",
                table: "AutorskoDjelo",
                column: "korisnikId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Knjiga_AspNetUsers_KorisnikId",
                table: "Knjiga",
                column: "KorisnikId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Notifikacija_AspNetUsers_korisnikId",
                table: "Notifikacija",
                column: "korisnikId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Racun_AspNetUsers_korisnikId",
                table: "Racun",
                column: "korisnikId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Recenzija_AspNetUsers_korisnikId",
                table: "Recenzija",
                column: "korisnikId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
