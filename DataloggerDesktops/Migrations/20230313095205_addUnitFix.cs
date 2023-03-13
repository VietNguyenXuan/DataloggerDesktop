using Microsoft.EntityFrameworkCore.Migrations;

namespace DataloggerDesktops.Migrations
{
    public partial class addUnitFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Unit",
                table: "ParametterSettings");

            migrationBuilder.AddColumn<int>(
                name: "UnitId",
                table: "ParametterSettings",
                type: "INTEGER",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UnitId",
                table: "ParametterSettings");

            migrationBuilder.AddColumn<string>(
                name: "Unit",
                table: "ParametterSettings",
                type: "TEXT",
                nullable: true);
        }
    }
}
