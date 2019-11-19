using Microsoft.EntityFrameworkCore.Migrations;

namespace ControlWork.Migrations
{
    public partial class UpdateFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "ClientLatitude",
                table: "Orders",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "ClientLongitude",
                table: "Orders",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "DestinationLatitude",
                table: "Orders",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "DestinationLongitude",
                table: "Orders",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClientLatitude",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ClientLongitude",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "DestinationLatitude",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "DestinationLongitude",
                table: "Orders");
        }
    }
}
