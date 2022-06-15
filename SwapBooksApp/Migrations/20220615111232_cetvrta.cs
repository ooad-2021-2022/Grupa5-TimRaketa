using Microsoft.EntityFrameworkCore.Migrations;

namespace SwapBooksApp.Migrations
{
    public partial class cetvrta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "KorisnikId",
                table: "Knjiga",
                newName: "korisnikId");

            migrationBuilder.AlterColumn<string>(
                name: "korisnikId",
                table: "Recenzija",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "korisnikId",
                table: "Razmjena",
                type: "nvarchar(450)",
                nullable: true);

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
                name: "korisnikId",
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
                name: "IX_Razmjena_korisnikId",
                table: "Razmjena",
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
                name: "IX_Knjiga_korisnikId",
                table: "Knjiga",
                column: "korisnikId");

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
                name: "FK_Knjiga_AspNetUsers_korisnikId",
                table: "Knjiga",
                column: "korisnikId",
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
                name: "FK_Razmjena_AspNetUsers_korisnikId",
                table: "Razmjena",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AutorskoDjelo_AspNetUsers_korisnikId",
                table: "AutorskoDjelo");

            migrationBuilder.DropForeignKey(
                name: "FK_Knjiga_AspNetUsers_korisnikId",
                table: "Knjiga");

            migrationBuilder.DropForeignKey(
                name: "FK_Notifikacija_AspNetUsers_korisnikId",
                table: "Notifikacija");

            migrationBuilder.DropForeignKey(
                name: "FK_Racun_AspNetUsers_korisnikId",
                table: "Racun");

            migrationBuilder.DropForeignKey(
                name: "FK_Razmjena_AspNetUsers_korisnikId",
                table: "Razmjena");

            migrationBuilder.DropForeignKey(
                name: "FK_Recenzija_AspNetUsers_korisnikId",
                table: "Recenzija");

            migrationBuilder.DropIndex(
                name: "IX_Recenzija_korisnikId",
                table: "Recenzija");

            migrationBuilder.DropIndex(
                name: "IX_Razmjena_korisnikId",
                table: "Razmjena");

            migrationBuilder.DropIndex(
                name: "IX_Racun_korisnikId",
                table: "Racun");

            migrationBuilder.DropIndex(
                name: "IX_Notifikacija_korisnikId",
                table: "Notifikacija");

            migrationBuilder.DropIndex(
                name: "IX_Knjiga_korisnikId",
                table: "Knjiga");

            migrationBuilder.DropIndex(
                name: "IX_AutorskoDjelo_korisnikId",
                table: "AutorskoDjelo");

            migrationBuilder.DropColumn(
                name: "korisnikId",
                table: "Razmjena");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Ime",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Prezime",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "korisnikId",
                table: "Knjiga",
                newName: "KorisnikId");

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
    }
}
