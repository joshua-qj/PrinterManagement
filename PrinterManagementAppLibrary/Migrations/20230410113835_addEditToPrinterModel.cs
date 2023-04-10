using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PrinterManagementAppLibrary.Migrations
{
    public partial class addEditToPrinterModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Editing",
                table: "Printers",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Editing",
                table: "Printers");
        }
    }
}
