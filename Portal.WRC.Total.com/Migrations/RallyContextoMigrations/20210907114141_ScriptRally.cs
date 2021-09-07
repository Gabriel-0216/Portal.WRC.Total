using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Portal.WRC.Total.com.Migrations.RallyContextoMigrations
{
    public partial class ScriptRally : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Rally",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cld_nome_curto_rally = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cld_nome_completo_rally = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cld_pais_rally = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cld_cidade_rally = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cld_quantidade_dias = table.Column<int>(type: "int", nullable: false),
                    cld_data_insercao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    cld_data_atualizacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    cld_data_rally = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rally", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rally");
        }
    }
}
