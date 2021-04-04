using Microsoft.EntityFrameworkCore.Migrations;

namespace MebelMarket.Migrations
{
    public partial class Orders : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Furnitures",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Furnitures",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Furnitures",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Furnitures",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Furnitures",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Furnitures",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Furnitures",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.InsertData(
                table: "Furnitures",
                columns: new[] { "Id", "Description", "ForOffice", "IsFeatured", "IsNew", "Name", "Price", "TypeId" },
                values: new object[,]
                {
                    { 1, null, false, false, false, "Диван", 111m, 1 },
                    { 2, null, false, false, false, "Табуреты", 222m, 1 },
                    { 3, null, false, false, false, "Мойки", 333m, 1 },
                    { 4, null, false, false, false, "Столешницы", 444m, 1 },
                    { 5, null, false, false, false, "Кресла", 555m, 1 },
                    { 6, null, false, false, false, "Кресла-качалки", 666m, 1 },
                    { 7, null, false, false, false, "Пуфы", 777m, 1 }
                });
        }
    }
}
