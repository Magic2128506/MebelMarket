using Microsoft.EntityFrameworkCore.Migrations;

namespace MebelMarket.Migrations
{
    public partial class FurnitureColors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Color1",
                table: "Furnitures",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Color10",
                table: "Furnitures",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Color11",
                table: "Furnitures",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Color12",
                table: "Furnitures",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Color13",
                table: "Furnitures",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Color14",
                table: "Furnitures",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Color15",
                table: "Furnitures",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Color2",
                table: "Furnitures",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Color3",
                table: "Furnitures",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Color4",
                table: "Furnitures",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Color5",
                table: "Furnitures",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Color6",
                table: "Furnitures",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Color7",
                table: "Furnitures",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Color8",
                table: "Furnitures",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Color9",
                table: "Furnitures",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Color1",
                table: "Furnitures");

            migrationBuilder.DropColumn(
                name: "Color10",
                table: "Furnitures");

            migrationBuilder.DropColumn(
                name: "Color11",
                table: "Furnitures");

            migrationBuilder.DropColumn(
                name: "Color12",
                table: "Furnitures");

            migrationBuilder.DropColumn(
                name: "Color13",
                table: "Furnitures");

            migrationBuilder.DropColumn(
                name: "Color14",
                table: "Furnitures");

            migrationBuilder.DropColumn(
                name: "Color15",
                table: "Furnitures");

            migrationBuilder.DropColumn(
                name: "Color2",
                table: "Furnitures");

            migrationBuilder.DropColumn(
                name: "Color3",
                table: "Furnitures");

            migrationBuilder.DropColumn(
                name: "Color4",
                table: "Furnitures");

            migrationBuilder.DropColumn(
                name: "Color5",
                table: "Furnitures");

            migrationBuilder.DropColumn(
                name: "Color6",
                table: "Furnitures");

            migrationBuilder.DropColumn(
                name: "Color7",
                table: "Furnitures");

            migrationBuilder.DropColumn(
                name: "Color8",
                table: "Furnitures");

            migrationBuilder.DropColumn(
                name: "Color9",
                table: "Furnitures");
        }
    }
}
