using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Portal.WRC.Total.com.Migrations.NoticiasContextoMigrations
{
    public partial class ScriptNoticias : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Noticia",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ntc_titulo_noticia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ntc_curta_descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ntc_texto_noticia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ntc_pais_rally = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ntc_data_insercao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ntc_data_atualizacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Noticia", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Noticia");
        }
    }
}
