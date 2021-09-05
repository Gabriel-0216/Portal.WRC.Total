using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Portal.WRC.Total.com.Migrations
{
    public partial class ScriptInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Equipes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    eqp_nome_curto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    eqp_nome_completo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    eqp_url_site = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    eqp_url_email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    eqp_nome_chefe_equipe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    eqp_pais_origem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    eqp_data_insercao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    eqp_data_atualizacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Equipes");
        }
    }
}
