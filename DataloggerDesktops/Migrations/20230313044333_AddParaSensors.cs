using Microsoft.EntityFrameworkCore.Migrations;

namespace DataloggerDesktops.Migrations
{
    public partial class AddParaSensors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Action",
                table: "ParametterSettings",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Action",
                table: "ParametterSettings",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "INTEGER",
                oldNullable: true);
        }
    }
}
