using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataloggerDesktops.Migrations
{
    public partial class AddSensorDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ParametterLogs_ParametterSensors_ParametterSensorId",
                table: "ParametterLogs");

            migrationBuilder.DropForeignKey(
                name: "FK_ParametterSensors_Devices_DeviceId",
                table: "ParametterSensors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ParametterSensors",
                table: "ParametterSensors");

            migrationBuilder.RenameTable(
                name: "ParametterSensors",
                newName: "ParametterSensor");

            migrationBuilder.RenameIndex(
                name: "IX_ParametterSensors_DeviceId",
                table: "ParametterSensor",
                newName: "IX_ParametterSensor_DeviceId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ParametterSensor",
                table: "ParametterSensor",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Sensors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    DateCreate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sensors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ParametterSetting",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    StatusName = table.Column<string>(type: "TEXT", nullable: true),
                    Action = table.Column<string>(type: "TEXT", nullable: true),
                    Condition = table.Column<string>(type: "TEXT", nullable: true),
                    Threshold = table.Column<string>(type: "TEXT", nullable: true),
                    Item = table.Column<string>(type: "TEXT", nullable: true),
                    DateCreate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    SensorId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParametterSetting", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ParametterSetting_Sensors_SensorId",
                        column: x => x.SensorId,
                        principalTable: "Sensors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ParametterSetting_SensorId",
                table: "ParametterSetting",
                column: "SensorId");

            migrationBuilder.AddForeignKey(
                name: "FK_ParametterLogs_ParametterSensor_ParametterSensorId",
                table: "ParametterLogs",
                column: "ParametterSensorId",
                principalTable: "ParametterSensor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ParametterSensor_Devices_DeviceId",
                table: "ParametterSensor",
                column: "DeviceId",
                principalTable: "Devices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ParametterLogs_ParametterSensor_ParametterSensorId",
                table: "ParametterLogs");

            migrationBuilder.DropForeignKey(
                name: "FK_ParametterSensor_Devices_DeviceId",
                table: "ParametterSensor");

            migrationBuilder.DropTable(
                name: "ParametterSetting");

            migrationBuilder.DropTable(
                name: "Sensors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ParametterSensor",
                table: "ParametterSensor");

            migrationBuilder.RenameTable(
                name: "ParametterSensor",
                newName: "ParametterSensors");

            migrationBuilder.RenameIndex(
                name: "IX_ParametterSensor_DeviceId",
                table: "ParametterSensors",
                newName: "IX_ParametterSensors_DeviceId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ParametterSensors",
                table: "ParametterSensors",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ParametterLogs_ParametterSensors_ParametterSensorId",
                table: "ParametterLogs",
                column: "ParametterSensorId",
                principalTable: "ParametterSensors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ParametterSensors_Devices_DeviceId",
                table: "ParametterSensors",
                column: "DeviceId",
                principalTable: "Devices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
