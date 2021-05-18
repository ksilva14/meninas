using Microsoft.EntityFrameworkCore.Migrations;

namespace MeuSiteII.Migrations
{
    public partial class Produtos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Profissao",
                table: "Profissao");

            migrationBuilder.RenameTable(
                name: "Profissao",
                newName: "Profissoes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Profissoes",
                table: "Profissoes",
                column: "ProfissaoId");

            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    ProdutoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: true),
                    Descricao = table.Column<string>(type: "TEXT", nullable: true),
                    QuantidadeEstoque = table.Column<int>(type: "INTEGER", nullable: false),
                    UrlImagem = table.Column<string>(type: "TEXT", nullable: true),
                    Preco = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.ProdutoId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produtos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Profissoes",
                table: "Profissoes");

            migrationBuilder.RenameTable(
                name: "Profissoes",
                newName: "Profissao");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Profissao",
                table: "Profissao",
                column: "ProfissaoId");
        }
    }
}
