using Microsoft.EntityFrameworkCore.Migrations;

namespace renatodavis.app.infra.Migrations
{
    public partial class grpProduto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Clientes_ClienteId",
                table: "Produtos");

            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_GrupoProduto_GrupoProdutoId",
                table: "Produtos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GrupoProduto",
                table: "GrupoProduto");

            migrationBuilder.RenameTable(
                name: "GrupoProduto",
                newName: "GrupoProdutos");

            migrationBuilder.AlterColumn<int>(
                name: "GrupoProdutoId",
                table: "Produtos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ClienteId",
                table: "Produtos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GrupoProdutos",
                table: "GrupoProdutos",
                column: "GrupoProdutoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Clientes_ClienteId",
                table: "Produtos",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "ClienteId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_GrupoProdutos_GrupoProdutoId",
                table: "Produtos",
                column: "GrupoProdutoId",
                principalTable: "GrupoProdutos",
                principalColumn: "GrupoProdutoId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Clientes_ClienteId",
                table: "Produtos");

            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_GrupoProdutos_GrupoProdutoId",
                table: "Produtos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GrupoProdutos",
                table: "GrupoProdutos");

            migrationBuilder.RenameTable(
                name: "GrupoProdutos",
                newName: "GrupoProduto");

            migrationBuilder.AlterColumn<int>(
                name: "GrupoProdutoId",
                table: "Produtos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ClienteId",
                table: "Produtos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_GrupoProduto",
                table: "GrupoProduto",
                column: "GrupoProdutoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Clientes_ClienteId",
                table: "Produtos",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "ClienteId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_GrupoProduto_GrupoProdutoId",
                table: "Produtos",
                column: "GrupoProdutoId",
                principalTable: "GrupoProduto",
                principalColumn: "GrupoProdutoId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
