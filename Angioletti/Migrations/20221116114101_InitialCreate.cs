using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Angioletti.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Audio",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Titolo = table.Column<string>(type: "TEXT", nullable: false),
                    Album = table.Column<string>(type: "TEXT", nullable: false),
                    Artista = table.Column<string>(type: "TEXT", nullable: false),
                    Publicazione = table.Column<int>(type: "INTEGER", nullable: false),
                    Genere = table.Column<string>(type: "TEXT", nullable: false),
                    Durata = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Audio", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Audio");
        }
    }
}
