using Microsoft.EntityFrameworkCore.Migrations;

namespace DataloggerDesktops.Migrations
{
    public partial class addUnit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Unit",
                table: "ParametterSettings",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Unit",
                table: "ParametterSettings");
        }
    }
}
