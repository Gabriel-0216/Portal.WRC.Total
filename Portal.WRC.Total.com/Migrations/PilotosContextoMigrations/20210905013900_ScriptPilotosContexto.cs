using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Portal.WRC.Total.com.Migrations.PilotosContextoMigrations
{
    public partial class ScriptPilotosContexto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Piloto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    plt_nome_curto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    plt_nome_completo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    plt_data_nascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    plt_data_insercao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    plt_data_atualizacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    plt_pais_nascimento = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Piloto", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Piloto");
        }
    }
}
