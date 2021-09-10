using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAQsede.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: false),
                    CPF = table.Column<int>(type: "int", nullable: false),
                    DataNascimento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CEP = table.Column<int>(type: "int", nullable: false),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Endereco = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefone = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Entregadores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CPF = table.Column<int>(type: "int", nullable: false),
                    DataNascimento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CEP = table.Column<int>(type: "int", nullable: false),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefone = table.Column<int>(type: "int", nullable: false),
                    CNH = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entregadores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Estabelecimentos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CNPJ = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CEP = table.Column<int>(type: "int", nullable: false),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefone = table.Column<int>(type: "int", nullable: false),
                    Endereco = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estabelecimentos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Entregadores");

            migrationBuilder.DropTable(
                name: "Estabelecimentos");
        }
    }
}
