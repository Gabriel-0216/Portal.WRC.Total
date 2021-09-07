using Microsoft.EntityFrameworkCore.Migrations;

namespace Portal.WRC.Total.com.Migrations.RallyContextoMigrations
{
    public partial class Script : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "cld_quantidade_dias",
                table: "Rally");

            migrationBuilder.RenameColumn(
                name: "cld_data_rally",
                table: "Rally",
                newName: "cld_data_inicio_rally");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "cld_data_inicio_rally",
                table: "Rally",
                newName: "cld_data_rally");

            migrationBuilder.AddColumn<int>(
                name: "cld_quantidade_dias",
                table: "Rally",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
