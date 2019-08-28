using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _04_Fiap.Web.AspNet.Migrations
{
    public partial class Churros : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "T_VEICULO",
                columns: table => new
                {
                    cd_codigo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Peso = table.Column<float>(nullable: false),
                    Modelo = table.Column<string>(maxLength: 100, nullable: false),
                    DataFabricacao = table.Column<DateTime>(nullable: false),
                    Combustivel = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_VEICULO", x => x.cd_codigo);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "T_VEICULO");
        }
    }
}
