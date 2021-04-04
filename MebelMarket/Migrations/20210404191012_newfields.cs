using Microsoft.EntityFrameworkCore.Migrations;

namespace MebelMarket.Migrations
{
    public partial class newfields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BodyMaterial",
                table: "Furnitures",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DiscountValue",
                table: "Furnitures",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "FacadeMaterial",
                table: "Furnitures",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Filler",
                table: "Furnitures",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Height",
                table: "Furnitures",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Length",
                table: "Furnitures",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Upholstery",
                table: "Furnitures",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Width",
                table: "Furnitures",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BodyMaterial",
                table: "Furnitures");

            migrationBuilder.DropColumn(
                name: "DiscountValue",
                table: "Furnitures");

            migrationBuilder.DropColumn(
                name: "FacadeMaterial",
                table: "Furnitures");

            migrationBuilder.DropColumn(
                name: "Filler",
                table: "Furnitures");

            migrationBuilder.DropColumn(
                name: "Height",
                table: "Furnitures");

            migrationBuilder.DropColumn(
                name: "Length",
                table: "Furnitures");

            migrationBuilder.DropColumn(
                name: "Upholstery",
                table: "Furnitures");

            migrationBuilder.DropColumn(
                name: "Width",
                table: "Furnitures");
        }
    }
}
