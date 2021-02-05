using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Dotz.Infra.Data.Migrations
{
    public partial class AtualizacaoTabelas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClienteMovimentacao_Cliente_CodigoCliente",
                table: "ClienteMovimentacao");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ClienteMovimentacao",
                table: "ClienteMovimentacao");

            migrationBuilder.DropColumn(
                name: "Valor",
                table: "ClienteMovimentacao");

            migrationBuilder.RenameTable(
                name: "ClienteMovimentacao",
                newName: "clienteMovimentacao");

            migrationBuilder.RenameIndex(
                name: "IX_ClienteMovimentacao_CodigoCliente",
                table: "clienteMovimentacao",
                newName: "IX_clienteMovimentacao_CodigoCliente");

            migrationBuilder.AddColumn<int>(
                name: "QtdePontosUtilizados",
                table: "clienteMovimentacao",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_clienteMovimentacao",
                table: "clienteMovimentacao",
                column: "Codigo");

            migrationBuilder.CreateTable(
                name: "ClientePedido",
                columns: table => new
                {
                    Codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CodigoCliente = table.Column<int>(type: "int", nullable: false),
                    CodigoClienteResgate = table.Column<int>(type: "int", nullable: false),
                    CodigoClienteEndereco = table.Column<int>(type: "int", nullable: false),
                    EstatusEntrega = table.Column<int>(type: "int", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DataExclusao = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientePedido", x => x.Codigo);
                    table.ForeignKey(
                        name: "FK_ClientePedido_Cliente_CodigoCliente",
                        column: x => x.CodigoCliente,
                        principalTable: "Cliente",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientePedido_ClienteEndereco_CodigoClienteEndereco",
                        column: x => x.CodigoClienteEndereco,
                        principalTable: "ClienteEndereco",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientePedido_ClienteResgate_CodigoClienteResgate",
                        column: x => x.CodigoClienteResgate,
                        principalTable: "ClienteResgate",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProdutoParceiro",
                columns: table => new
                {
                    Codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CodigoParceiro = table.Column<int>(type: "int", nullable: false),
                    CodigoProduto = table.Column<int>(type: "int", nullable: false),
                    QtdePontosNecessarios = table.Column<int>(type: "int", nullable: false),
                    QtdeEmEstoqueDisponivel = table.Column<int>(type: "int", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DataExclusao = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdutoParceiro", x => x.Codigo);
                    table.ForeignKey(
                        name: "FK_ProdutoParceiro_Parceiro_CodigoParceiro",
                        column: x => x.CodigoParceiro,
                        principalTable: "Parceiro",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProdutoParceiro_Produto_CodigoProduto",
                        column: x => x.CodigoProduto,
                        principalTable: "Produto",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClientePedido_CodigoCliente",
                table: "ClientePedido",
                column: "CodigoCliente");

            migrationBuilder.CreateIndex(
                name: "IX_ClientePedido_CodigoClienteEndereco",
                table: "ClientePedido",
                column: "CodigoClienteEndereco");

            migrationBuilder.CreateIndex(
                name: "IX_ClientePedido_CodigoClienteResgate",
                table: "ClientePedido",
                column: "CodigoClienteResgate");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoParceiro_CodigoParceiro",
                table: "ProdutoParceiro",
                column: "CodigoParceiro");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoParceiro_CodigoProduto",
                table: "ProdutoParceiro",
                column: "CodigoProduto");

            migrationBuilder.AddForeignKey(
                name: "FK_clienteMovimentacao_Cliente_CodigoCliente",
                table: "clienteMovimentacao",
                column: "CodigoCliente",
                principalTable: "Cliente",
                principalColumn: "Codigo",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_clienteMovimentacao_Cliente_CodigoCliente",
                table: "clienteMovimentacao");

            migrationBuilder.DropTable(
                name: "ClientePedido");

            migrationBuilder.DropTable(
                name: "ProdutoParceiro");

            migrationBuilder.DropPrimaryKey(
                name: "PK_clienteMovimentacao",
                table: "clienteMovimentacao");

            migrationBuilder.DropColumn(
                name: "QtdePontosUtilizados",
                table: "clienteMovimentacao");

            migrationBuilder.RenameTable(
                name: "clienteMovimentacao",
                newName: "ClienteMovimentacao");

            migrationBuilder.RenameIndex(
                name: "IX_clienteMovimentacao_CodigoCliente",
                table: "ClienteMovimentacao",
                newName: "IX_ClienteMovimentacao_CodigoCliente");

            migrationBuilder.AddColumn<decimal>(
                name: "Valor",
                table: "ClienteMovimentacao",
                type: "decimal(65,30)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ClienteMovimentacao",
                table: "ClienteMovimentacao",
                column: "Codigo");

            migrationBuilder.AddForeignKey(
                name: "FK_ClienteMovimentacao_Cliente_CodigoCliente",
                table: "ClienteMovimentacao",
                column: "CodigoCliente",
                principalTable: "Cliente",
                principalColumn: "Codigo",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
