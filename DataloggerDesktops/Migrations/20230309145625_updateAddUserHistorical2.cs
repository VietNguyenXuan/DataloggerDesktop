using Microsoft.EntityFrameworkCore.Migrations;

namespace DataloggerDesktops.Migrations
{
    public partial class updateAddUserHistorical2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UserCurrents",
                table: "UserCurrents");

            migrationBuilder.RenameTable(
                name: "UserCurrents",
                newName: "UserHistoricals");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserHistoricals",
                table: "UserHistoricals",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UserHistoricals",
                table: "UserHistoricals");

            migrationBuilder.RenameTable(
                name: "UserHistoricals",
                newName: "UserCurrents");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserCurrents",
                table: "UserCurrents",
                column: "Id");
        }
    }
}
