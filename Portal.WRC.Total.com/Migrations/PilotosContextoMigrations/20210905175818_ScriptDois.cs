using Microsoft.EntityFrameworkCore.Migrations;

namespace Portal.WRC.Total.com.Migrations.PilotosContextoMigrations
{
    public partial class ScriptDois : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "plt_nome_co_piloto",
                table: "Piloto",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "plt_nome_equipe",
                table: "Piloto",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "plt_qtde_titulos_wrc",
                table: "Piloto",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "plt_qtde_vitorias_wrc",
                table: "Piloto",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "plt_nome_co_piloto",
                table: "Piloto");

            migrationBuilder.DropColumn(
                name: "plt_nome_equipe",
                table: "Piloto");

            migrationBuilder.DropColumn(
                name: "plt_qtde_titulos_wrc",
                table: "Piloto");

            migrationBuilder.DropColumn(
                name: "plt_qtde_vitorias_wrc",
                table: "Piloto");
        }
    }
}
