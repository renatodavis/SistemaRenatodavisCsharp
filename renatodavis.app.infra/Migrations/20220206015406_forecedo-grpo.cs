using Microsoft.EntityFrameworkCore.Migrations;

namespace renatodavis.app.infra.Migrations
{
    public partial class forecedogrpo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GrupoProdutoId",
                table: "Produtos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "GrupoProduto",
                columns: table => new
                {
                    GrupoProdutoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrupoProduto", x => x.GrupoProdutoId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_GrupoProdutoId",
                table: "Produtos",
                column: "GrupoProdutoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_GrupoProduto_GrupoProdutoId",
                table: "Produtos",
                column: "GrupoProdutoId",
                principalTable: "GrupoProduto",
                principalColumn: "GrupoProdutoId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_GrupoProduto_GrupoProdutoId",
                table: "Produtos");

            migrationBuilder.DropTable(
                name: "GrupoProduto");

            migrationBuilder.DropIndex(
                name: "IX_Produtos_GrupoProdutoId",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "GrupoProdutoId",
                table: "Produtos");
        }
    }
}
