using Microsoft.EntityFrameworkCore.Migrations;

namespace MeuSite.Migrations
{
    public partial class Criar_Profissao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Profissoes",
                columns: table => new
                {
                    ProfissaoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profissoes", x => x.ProfissaoId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Profissoes");
        }
    }
}
