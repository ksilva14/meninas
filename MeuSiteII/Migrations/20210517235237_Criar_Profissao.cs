using Microsoft.EntityFrameworkCore.Migrations;

namespace MeuSiteII.Migrations
{
    public partial class Criar_Profissao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Profissao",
                columns: table => new
                {
                    ProfissaoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profissao", x => x.ProfissaoId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Profissao");
        }
    }
}
