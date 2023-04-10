using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PrinterManagementAppLibrary.Migrations
{
    public partial class ModifyModelClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PrinterName",
                table: "Printers",
                newName: "SerialNo");

            migrationBuilder.AddColumn<string>(
                name: "Department",
                table: "Printers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "IP",
                table: "Printers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Printers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MachineNo",
                table: "Printers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Manufacturer",
                table: "Printers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "Printers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Printers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Department",
                table: "Printers");

            migrationBuilder.DropColumn(
                name: "IP",
                table: "Printers");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "Printers");

            migrationBuilder.DropColumn(
                name: "MachineNo",
                table: "Printers");

            migrationBuilder.DropColumn(
                name: "Manufacturer",
                table: "Printers");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "Printers");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Printers");

            migrationBuilder.RenameColumn(
                name: "SerialNo",
                table: "Printers",
                newName: "PrinterName");
        }
    }
}
