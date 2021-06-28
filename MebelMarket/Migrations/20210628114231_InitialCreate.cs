using Microsoft.EntityFrameworkCore.Migrations;

namespace MebelMarket.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FurnitureCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FurnitureCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "FurnitureTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
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
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    TypeId = table.Column<int>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsNew = table.Column<bool>(nullable: false),
                    IsFeatured = table.Column<bool>(nullable: false),
                    ForOffice = table.Column<bool>(nullable: false),
                    Width = table.Column<string>(nullable: true),
                    Height = table.Column<string>(nullable: true),
                    Length = table.Column<string>(nullable: true),
                    Upholstery = table.Column<string>(nullable: true),
                    Filler = table.Column<string>(nullable: true),
                    BodyMaterial = table.Column<string>(nullable: true),
                    FacadeMaterial = table.Column<string>(nullable: true),
                    DiscountValue = table.Column<int>(nullable: true),
                    Color1 = table.Column<bool>(nullable: false),
                    Color2 = table.Column<bool>(nullable: false),
                    Color3 = table.Column<bool>(nullable: false),
                    Color4 = table.Column<bool>(nullable: false),
                    Color5 = table.Column<bool>(nullable: false),
                    Color6 = table.Column<bool>(nullable: false),
                    Color7 = table.Column<bool>(nullable: false),
                    Color8 = table.Column<bool>(nullable: false),
                    Color9 = table.Column<bool>(nullable: false),
                    Color10 = table.Column<bool>(nullable: false),
                    Color11 = table.Column<bool>(nullable: false),
                    Color12 = table.Column<bool>(nullable: false),
                    Color13 = table.Column<bool>(nullable: false),
                    Color14 = table.Column<bool>(nullable: false),
                    Color15 = table.Column<bool>(nullable: false)
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
                values: new object[] { 1, "Мягкая мебель" });

            migrationBuilder.InsertData(
                table: "FurnitureCategories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Гостиная" });

            migrationBuilder.InsertData(
                table: "FurnitureCategories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Кухня" });

            migrationBuilder.InsertData(
                table: "FurnitureCategories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 4, "Спальня" });

            migrationBuilder.InsertData(
                table: "FurnitureCategories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 5, "Шкафы" });

            migrationBuilder.InsertData(
                table: "FurnitureCategories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 6, "Детская мебель" });

            migrationBuilder.InsertData(
                table: "FurnitureCategories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 7, "Прихожая" });

            migrationBuilder.InsertData(
                table: "FurnitureCategories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 8, "Офис" });

            migrationBuilder.InsertData(
                table: "FurnitureCategories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 9, "Сад и дача" });

            migrationBuilder.InsertData(
                table: "FurnitureTypes",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[] { 1, 1, "Диваны прямые" });

            migrationBuilder.InsertData(
                table: "FurnitureTypes",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[] { 30, 4, "Тумбы" });

            migrationBuilder.InsertData(
                table: "FurnitureTypes",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[] { 31, 4, "Зеркала" });

            migrationBuilder.InsertData(
                table: "FurnitureTypes",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[] { 32, 5, "Шкафы купе" });

            migrationBuilder.InsertData(
                table: "FurnitureTypes",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[] { 33, 5, "Шкафы распашные" });

            migrationBuilder.InsertData(
                table: "FurnitureTypes",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[] { 34, 5, "Стеллажи" });

            migrationBuilder.InsertData(
                table: "FurnitureTypes",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[] { 35, 6, "Детские кровати" });

            migrationBuilder.InsertData(
                table: "FurnitureTypes",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[] { 36, 6, "Стулья для детской" });

            migrationBuilder.InsertData(
                table: "FurnitureTypes",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[] { 37, 6, "Детские комплексы" });

            migrationBuilder.InsertData(
                table: "FurnitureTypes",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[] { 38, 7, "Тумбы для обуви" });

            migrationBuilder.InsertData(
                table: "FurnitureTypes",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[] { 39, 7, "Вешалки" });

            migrationBuilder.InsertData(
                table: "FurnitureTypes",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[] { 40, 7, "Пуфы" });

            migrationBuilder.InsertData(
                table: "FurnitureTypes",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[] { 41, 7, "Скамьи" });

            migrationBuilder.InsertData(
                table: "FurnitureTypes",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[] { 42, 7, "Прихожие" });

            migrationBuilder.InsertData(
                table: "FurnitureTypes",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[] { 43, 8, "Компьютерные столы" });

            migrationBuilder.InsertData(
                table: "FurnitureTypes",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[] { 44, 8, "Офисные кресла" });

            migrationBuilder.InsertData(
                table: "FurnitureTypes",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[] { 45, 8, "Письменные столы" });

            migrationBuilder.InsertData(
                table: "FurnitureTypes",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[] { 46, 8, "Полки" });

            migrationBuilder.InsertData(
                table: "FurnitureTypes",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[] { 47, 8, "Офисные тумбы" });

            migrationBuilder.InsertData(
                table: "FurnitureTypes",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[] { 48, 8, "Офисные стулья" });

            migrationBuilder.InsertData(
                table: "FurnitureTypes",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[] { 49, 9, "Раскладушки" });

            migrationBuilder.InsertData(
                table: "FurnitureTypes",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[] { 50, 9, "Шезлонги и лежаки" });

            migrationBuilder.InsertData(
                table: "FurnitureTypes",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[] { 51, 9, "Садовые скамейки" });

            migrationBuilder.InsertData(
                table: "FurnitureTypes",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[] { 52, 9, "Этажерки" });

            migrationBuilder.InsertData(
                table: "FurnitureTypes",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[] { 29, 4, "Комоды" });

            migrationBuilder.InsertData(
                table: "FurnitureTypes",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[] { 28, 4, "Туалетные столики" });

            migrationBuilder.InsertData(
                table: "FurnitureTypes",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[] { 27, 4, "Банкетки и пуфы" });

            migrationBuilder.InsertData(
                table: "FurnitureTypes",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[] { 26, 4, "Матрасы" });

            migrationBuilder.InsertData(
                table: "FurnitureTypes",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[] { 2, 1, "Диваны угловые" });

            migrationBuilder.InsertData(
                table: "FurnitureTypes",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[] { 3, 1, "Диваны для офиса" });

            migrationBuilder.InsertData(
                table: "FurnitureTypes",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[] { 4, 1, "Диваны детские" });

            migrationBuilder.InsertData(
                table: "FurnitureTypes",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[] { 5, 1, "Кресла" });

            migrationBuilder.InsertData(
                table: "FurnitureTypes",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[] { 6, 1, "Кресла-качалки" });

            migrationBuilder.InsertData(
                table: "FurnitureTypes",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[] { 7, 1, "Кресла-мешки" });

            migrationBuilder.InsertData(
                table: "FurnitureTypes",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[] { 8, 1, "Пуфы" });

            migrationBuilder.InsertData(
                table: "FurnitureTypes",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[] { 9, 1, "Банкетки" });

            migrationBuilder.InsertData(
                table: "FurnitureTypes",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[] { 10, 2, "Стенки" });

            migrationBuilder.InsertData(
                table: "FurnitureTypes",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[] { 11, 2, "Журнальные столики" });

            migrationBuilder.InsertData(
                table: "FurnitureTypes",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[] { 12, 2, "Тумбы под ТВ" });

            migrationBuilder.InsertData(
                table: "FurnitureTypes",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[] { 53, 9, "Мебель из ротанга" });

            migrationBuilder.InsertData(
                table: "FurnitureTypes",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[] { 13, 3, "Кухонные гарнитуры" });

            migrationBuilder.InsertData(
                table: "FurnitureTypes",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[] { 15, 3, "Кухонные столы" });

            migrationBuilder.InsertData(
                table: "FurnitureTypes",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[] { 16, 3, "Кухонные стулья" });

            migrationBuilder.InsertData(
                table: "FurnitureTypes",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[] { 17, 3, "Барные стулья" });

            migrationBuilder.InsertData(
                table: "FurnitureTypes",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[] { 18, 3, "Табуреты" });

            migrationBuilder.InsertData(
                table: "FurnitureTypes",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[] { 19, 3, "Мойки" });

            migrationBuilder.InsertData(
                table: "FurnitureTypes",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[] { 20, 3, "Столешницы" });

            migrationBuilder.InsertData(
                table: "FurnitureTypes",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[] { 21, 3, "Стеновые панели" });

            migrationBuilder.InsertData(
                table: "FurnitureTypes",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[] { 22, 3, "Комплектующие" });

            migrationBuilder.InsertData(
                table: "FurnitureTypes",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[] { 23, 4, "Спальные гарнитуры" });

            migrationBuilder.InsertData(
                table: "FurnitureTypes",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[] { 24, 4, "Кровати" });

            migrationBuilder.InsertData(
                table: "FurnitureTypes",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[] { 25, 4, "Кроватные основания" });

            migrationBuilder.InsertData(
                table: "FurnitureTypes",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[] { 14, 3, "Кухонные уголки" });

            migrationBuilder.InsertData(
                table: "FurnitureTypes",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[] { 54, 9, "Прочая мебель" });

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
                name: "Orders");

            migrationBuilder.DropTable(
                name: "FurnitureTypes");

            migrationBuilder.DropTable(
                name: "FurnitureCategories");
        }
    }
}
