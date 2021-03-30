using Microsoft.EntityFrameworkCore.Migrations;

namespace MebelMarket.Migrations
{
    public partial class Start : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FurnitureTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Category = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FurnitureTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Furnitures",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    TypeId = table.Column<int>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsNew = table.Column<bool>(nullable: false),
                    IsFeatured = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Furnitures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Furnitures_FurnitureTypes_TypeId",
                        column: x => x.TypeId,
                        principalTable: "FurnitureTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "FurnitureTypes",
                columns: new[] { "Id", "Category", "Name" },
                values: new object[,]
                {
                    { 8, "Мягкая мебель", "Пуфы" },
                    { 21, "Кухня", "Столешницы" },
                    { 20, "Кухня", "Мойки" },
                    { 19, "Кухня", "Табуреты" },
                    { 18, "Кухня", "Барные стулья" },
                    { 17, "Кухня", "Кухонные стулья" },
                    { 16, "Кухня", "Кухонные столы" },
                    { 15, "Кухня", "Кухонные уголки" },
                    { 14, "Кухня", "Кухонные гарнитуры" },
                    { 13, "Гостинная", "Тумбы под ТВ" },
                    { 12, "Гостинная", "Журнальные столики" },
                    { 11, "Гостинная", "Стенки" },
                    { 10, "Мягкая мебель", "Банкетки" },
                    { 22, "Кухня", "Стеновые панели" },
                    { 23, "Кухня", "Комплектующие" },
                    { 6, "Мягкая мебель", "Кресла-качалки" },
                    { 5, "Мягкая мебель", "Кресла" },
                    { 4, "Мягкая мебель", "Диваны детские" },
                    { 3, "Мягкая мебель", "Диваны для офиса" },
                    { 2, "Мягкая мебель", "Диваны угловые" },
                    { 1, "Мягкая мебель", "Диваны прямые" },
                    { 7, "Мягкая мебель", "Кресла-мешки" }
                });

            migrationBuilder.InsertData(
                table: "Furnitures",
                columns: new[] { "Id", "Description", "IsFeatured", "IsNew", "Name", "Price", "TypeId" },
                values: new object[,]
                {
                    { 7, null, false, false, "Пуфы", 777m, null },
                    { 6, null, false, false, "Кресла-качалки", 666m, null },
                    { 5, null, false, false, "Кресла", 555m, null },
                    { 4, null, false, false, "Столешницы", 444m, null },
                    { 3, null, false, false, "Мойки", 333m, null },
                    { 2, null, false, false, "Табуреты", 222m, null },
                    { 1, null, false, false, "Диван", 111m, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Furnitures_TypeId",
                table: "Furnitures",
                column: "TypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Furnitures");

            migrationBuilder.DropTable(
                name: "FurnitureTypes");
        }
    }
}
