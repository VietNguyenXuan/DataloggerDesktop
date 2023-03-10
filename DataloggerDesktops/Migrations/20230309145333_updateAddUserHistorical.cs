using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataloggerDesktops.Migrations
{
    public partial class updateAddUserHistorical : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Passwords",
                table: "UserCurrents");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateLogIn",
                table: "UserCurrents",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateLogIn",
                table: "UserCurrents");

            migrationBuilder.AddColumn<string>(
                name: "Passwords",
                table: "UserCurrents",
                type: "TEXT",
                nullable: true);
        }
    }
}
