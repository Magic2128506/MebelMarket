using Microsoft.EntityFrameworkCore.Migrations;

namespace MebelMarket.Migrations
{
    public partial class start : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FurnitureCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FurnitureCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FurnitureTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    CategoryId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FurnitureTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FurnitureTypes_FurnitureCategories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "FurnitureCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                    IsFeatured = table.Column<bool>(nullable: false),
                    ForOffice = table.Column<bool>(nullable: false)
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
                table: "FurnitureCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Мягкая мебель" },
                    { 2, "Гостиная" },
                    { 3, "Кухня" },
                    { 4, "Спальня" },
                    { 5, "Шкафы" },
                    { 6, "Детская мебель" },
                    { 7, "Прихожая" },
                    { 8, "Офис" },
                    { 9, "Сад и дача" }
                });

            migrationBuilder.InsertData(
                table: "FurnitureTypes",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Диваны прямые" },
                    { 30, 4, "Тумбы" },
                    { 31, 4, "Зеркала" },
                    { 32, 5, "Шкафы купе" },
                    { 33, 5, "Шкафы распашные" },
                    { 34, 5, "Стеллажи" },
                    { 35, 6, "Детские кровати" },
                    { 36, 6, "Стулья для детской" },
                    { 37, 6, "Детские комплексы" },
                    { 38, 7, "Тумбы для обуви" },
                    { 39, 7, "Вешалки" },
                    { 40, 7, "Пуфы" },
                    { 41, 7, "Скамьи" },
                    { 42, 7, "Прихожие" },
                    { 43, 8, "Компьютерные столы" },
                    { 44, 8, "Офисные кресла" },
                    { 45, 8, "Письменные столы" },
                    { 46, 8, "Полки" },
                    { 47, 8, "Офисные тумбы" },
                    { 48, 8, "Офисные стулья" },
                    { 49, 9, "Раскладушки" },
                    { 50, 9, "Шезлонги и лежаки" },
                    { 51, 9, "Садовые скамейки" },
                    { 52, 9, "Этажерки" },
                    { 29, 4, "Комоды" },
                    { 28, 4, "Туалетные столики" },
                    { 27, 4, "Банкетки и пуфы" },
                    { 26, 4, "Матрасы" },
                    { 2, 1, "Диваны угловые" },
                    { 3, 1, "Диваны для офиса" },
                    { 4, 1, "Диваны детские" },
                    { 5, 1, "Кресла" },
                    { 6, 1, "Кресла-качалки" },
                    { 7, 1, "Кресла-мешки" },
                    { 8, 1, "Пуфы" },
                    { 9, 1, "Банкетки" },
                    { 10, 2, "Стенки" },
                    { 11, 2, "Журнальные столики" },
                    { 12, 2, "Тумбы под ТВ" },
                    { 53, 9, "Мебель из ротанга" },
                    { 13, 3, "Кухонные гарнитуры" },
                    { 15, 3, "Кухонные столы" },
                    { 16, 3, "Кухонные стулья" },
                    { 17, 3, "Барные стулья" },
                    { 18, 3, "Табуреты" },
                    { 19, 3, "Мойки" },
                    { 20, 3, "Столешницы" },
                    { 21, 3, "Стеновые панели" },
                    { 22, 3, "Комплектующие" },
                    { 23, 4, "Спальные гарнитуры" },
                    { 24, 4, "Кровати" },
                    { 25, 4, "Кроватные основания" },
                    { 14, 3, "Кухонные уголки" },
                    { 54, 9, "Прочая мебель" }
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Furnitures_TypeId",
                table: "Furnitures",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_FurnitureTypes_CategoryId",
                table: "FurnitureTypes",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Furnitures");

            migrationBuilder.DropTable(
                name: "FurnitureTypes");

            migrationBuilder.DropTable(
                name: "FurnitureCategories");
        }
    }
}
