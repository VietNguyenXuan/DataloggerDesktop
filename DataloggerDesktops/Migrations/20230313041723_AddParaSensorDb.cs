using Microsoft.EntityFrameworkCore.Migrations;

namespace DataloggerDesktops.Migrations
{
    public partial class AddParaSensorDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ParametterLogs_ParametterSensor_ParametterSensorId",
                table: "ParametterLogs");

            migrationBuilder.DropForeignKey(
                name: "FK_ParametterSensor_Devices_DeviceId",
                table: "ParametterSensor");

            migrationBuilder.DropForeignKey(
                name: "FK_ParametterSetting_Sensors_SensorId",
                table: "ParametterSetting");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ParametterSetting",
                table: "ParametterSetting");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ParametterSensor",
                table: "ParametterSensor");

            migrationBuilder.RenameTable(
                name: "ParametterSetting",
                newName: "ParametterSettings");

            migrationBuilder.RenameTable(
                name: "ParametterSensor",
                newName: "ParametterSensors");

            migrationBuilder.RenameIndex(
                name: "IX_ParametterSetting_SensorId",
                table: "ParametterSettings",
                newName: "IX_ParametterSettings_SensorId");

            migrationBuilder.RenameIndex(
                name: "IX_ParametterSensor_DeviceId",
                table: "ParametterSensors",
                newName: "IX_ParametterSensors_DeviceId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ParametterSettings",
                table: "ParametterSettings",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_ParametterSettings_Sensors_SensorId",
                table: "ParametterSettings",
                column: "SensorId",
                principalTable: "Sensors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ParametterLogs_ParametterSensors_ParametterSensorId",
                table: "ParametterLogs");

            migrationBuilder.DropForeignKey(
                name: "FK_ParametterSensors_Devices_DeviceId",
                table: "ParametterSensors");

            migrationBuilder.DropForeignKey(
                name: "FK_ParametterSettings_Sensors_SensorId",
                table: "ParametterSettings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ParametterSettings",
                table: "ParametterSettings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ParametterSensors",
                table: "ParametterSensors");

            migrationBuilder.RenameTable(
                name: "ParametterSettings",
                newName: "ParametterSetting");

            migrationBuilder.RenameTable(
                name: "ParametterSensors",
                newName: "ParametterSensor");

            migrationBuilder.RenameIndex(
                name: "IX_ParametterSettings_SensorId",
                table: "ParametterSetting",
                newName: "IX_ParametterSetting_SensorId");

            migrationBuilder.RenameIndex(
                name: "IX_ParametterSensors_DeviceId",
                table: "ParametterSensor",
                newName: "IX_ParametterSensor_DeviceId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ParametterSetting",
                table: "ParametterSetting",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ParametterSensor",
                table: "ParametterSensor",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_ParametterSetting_Sensors_SensorId",
                table: "ParametterSetting",
                column: "SensorId",
                principalTable: "Sensors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
