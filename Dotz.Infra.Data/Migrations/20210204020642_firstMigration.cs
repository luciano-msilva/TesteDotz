using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Dotz.Infra.Data.Migrations
{
    public partial class firstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NomeCompleto = table.Column<string>(type: "longtext", nullable: true),
                    Email = table.Column<string>(type: "longtext", nullable: true),
                    Documento = table.Column<string>(type: "longtext", nullable: true),
                    TelefoneResidencial = table.Column<string>(type: "longtext", nullable: true),
                    TelefoneComercial = table.Column<string>(type: "longtext", nullable: true),
                    Celular = table.Column<string>(type: "longtext", nullable: true),
                    DataCadastro = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DataExclusao = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Codigo);
                });

            migrationBuilder.CreateTable(
                name: "Parceiro",
                columns: table => new
                {
                    Codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RazaoSocial = table.Column<string>(type: "longtext", nullable: true),
                    NomeFantasia = table.Column<string>(type: "longtext", nullable: true),
                    CNPJ = table.Column<string>(type: "longtext", nullable: true),
                    DataCadastro = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DataExclusao = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parceiro", x => x.Codigo);
                });

            migrationBuilder.CreateTable(
                name: "Produto",
                columns: table => new
                {
                    Codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(type: "longtext", nullable: true),
                    ECategoriaProduto = table.Column<int>(type: "int", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DataExclusao = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto", x => x.Codigo);
                });

            migrationBuilder.CreateTable(
                name: "ClienteEndereco",
                columns: table => new
                {
                    Codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CodigoCliente = table.Column<int>(type: "int", nullable: false),
                    Endereco = table.Column<string>(type: "longtext", nullable: true),
                    Numero = table.Column<string>(type: "longtext", nullable: true),
                    Bairro = table.Column<string>(type: "longtext", nullable: true),
                    Estado = table.Column<string>(type: "longtext", nullable: true),
                    Cidade = table.Column<string>(type: "longtext", nullable: true),
                    Cep = table.Column<string>(type: "longtext", nullable: true),
                    EnderecoPrincipal = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DataExclusao = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClienteEndereco", x => x.Codigo);
                    table.ForeignKey(
                        name: "FK_ClienteEndereco_Cliente_CodigoCliente",
                        column: x => x.CodigoCliente,
                        principalTable: "Cliente",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClienteMovimentacao",
                columns: table => new
                {
                    Codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CodigoCliente = table.Column<int>(type: "int", nullable: false),
                    TipoMovimentacao = table.Column<int>(type: "int", nullable: false),
                    Valor = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DataExclusao = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClienteMovimentacao", x => x.Codigo);
                    table.ForeignKey(
                        name: "FK_ClienteMovimentacao_Cliente_CodigoCliente",
                        column: x => x.CodigoCliente,
                        principalTable: "Cliente",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClienteResgate",
                columns: table => new
                {
                    Codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CodigoCliente = table.Column<int>(type: "int", nullable: false),
                    CodigoProduto = table.Column<int>(type: "int", nullable: false),
                    CodigoParceiro = table.Column<int>(type: "int", nullable: false),
                    QtdeProduto = table.Column<int>(type: "int", nullable: false),
                    QtdePontosUtilizados = table.Column<int>(type: "int", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DataExclusao = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClienteResgate", x => x.Codigo);
                    table.ForeignKey(
                        name: "FK_ClienteResgate_Cliente_CodigoCliente",
                        column: x => x.CodigoCliente,
                        principalTable: "Cliente",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClienteResgate_Parceiro_CodigoParceiro",
                        column: x => x.CodigoParceiro,
                        principalTable: "Parceiro",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClienteResgate_Produto_CodigoProduto",
                        column: x => x.CodigoProduto,
                        principalTable: "Produto",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClienteEndereco_CodigoCliente",
                table: "ClienteEndereco",
                column: "CodigoCliente");

            migrationBuilder.CreateIndex(
                name: "IX_ClienteMovimentacao_CodigoCliente",
                table: "ClienteMovimentacao",
                column: "CodigoCliente");

            migrationBuilder.CreateIndex(
                name: "IX_ClienteResgate_CodigoCliente",
                table: "ClienteResgate",
                column: "CodigoCliente");

            migrationBuilder.CreateIndex(
                name: "IX_ClienteResgate_CodigoParceiro",
                table: "ClienteResgate",
                column: "CodigoParceiro");

            migrationBuilder.CreateIndex(
                name: "IX_ClienteResgate_CodigoProduto",
                table: "ClienteResgate",
                column: "CodigoProduto");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClienteEndereco");

            migrationBuilder.DropTable(
                name: "ClienteMovimentacao");

            migrationBuilder.DropTable(
                name: "ClienteResgate");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Parceiro");

            migrationBuilder.DropTable(
                name: "Produto");
        }
    }
}
