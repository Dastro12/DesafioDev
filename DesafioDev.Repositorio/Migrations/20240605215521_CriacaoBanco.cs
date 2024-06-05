using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DesafioDev.Repositorio.Migrations
{
    public partial class CriacaoBanco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cidade",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    estado = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_cidade", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Pessoa",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: true),
                    tipo_pessoa = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    cpf_cnpj = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: true),
                    cep = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: true),
                    endereco = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    numero = table.Column<int>(type: "int", nullable: false),
                    complemento = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    bairro = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    data_nascimento_fundacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    data_cadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    celular = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    sit_cadastral = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    cidade_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_pessoa", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cidade");

            migrationBuilder.DropTable(
                name: "Pessoa");
        }
    }
}
